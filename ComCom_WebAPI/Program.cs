using ComCom_WebAPI.Models;
using ComCom_WebAPI.Models.DataMS;
using ComCom_WebAPI.Models.DataPG;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Web;
using Newtonsoft.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

var configuration = builder.Configuration;

// Add services to the container.
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddMicrosoftIdentityWebApi(builder.Configuration.GetSection("AzureAd"))
        .EnableTokenAcquisitionToCallDownstreamApi()
            .AddMicrosoftGraph(builder.Configuration.GetSection("MicrosoftGraph"))
            .AddInMemoryTokenCaches();


builder.Services.AddDbContext<radius_db>(options =>
         options.UseMySql("server=localhost;database=database_radius;username=root;password=Temporal9713@", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.24-mariadb")));

builder.Services.AddDbContext<ValeAmigo>(options =>
         options.UseMySql("server=localhost;database=valeamigo;username=root;password=", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.24-mariadb")));

builder.Services.AddDbContext<databasecomCom>(options =>
         options.UseNpgsql(builder.Configuration.GetConnectionString("ServicesDataPostgresql")));

builder.Services.AddControllersWithViews().AddNewtonsoftJson(options =>
                 options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore).AddNewtonsoftJson(options =>
                 options.SerializerSettings.ContractResolver = new DefaultContractResolver());

builder.Services.AddCors(options =>
{
    var FrontEndURL = configuration.GetValue<string>("FrontEnd_URL");

    options.AddDefaultPolicy(builder =>
    {
        builder.WithOrigins(FrontEndURL).AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin();
    });
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
