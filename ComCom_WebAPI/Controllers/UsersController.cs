
using ComCom_WebAPI.Models.DataPG;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ComCom_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly databasecomCom ctx;
        public UsersController(databasecomCom ctx)
        {
            this.ctx = ctx;
        }

        [HttpGet("client")]
        public async Task<ActionResult<IQueryable>> GetClients()
        {
            var _clientes = await (
                from c in ctx.Set<client>()
                select new {
                    idCliente = c.id,
                    NombreUsuario = c.username,
                    FechaInstalacion = c.installation_date,
                    FechaContrato = c.contract_date,
                    ArchivoContrato = c.contract_file,
                    Direccion = c.street,
                    NumInterior = c.indoor_number,
                    NumExterior = c.outdoor_number,
                    Colonia = c.colony_fraction,
                    Tipo = c.type,
                    PrecioInstalacion = c.installation_price,
                    ServicioDebInstalacion = c.debited_service_installation,
                    EstatusMonitoreo = c.monitoring_status,
                    Revision = c.need_review,

                }).ToListAsync();
                return Ok(_clientes);
        }

        // public async Task<ActionResult<List<auth_user>>> Get()
        // {
        //   var Users = await ctx.auth_user.Select(e => new
        //   {
        //       IdUsuario = e.id,
        //       NombredeUsuario = e.username,
        //       Nombre = e.first_name,
        //       Apellido = e.last_name,
        //       CorreoElectronico = e.email,
        //       UsuarioActivo = e.is_active,
        //       AltadeUsuario = e.date_joined,
        //   }).OrderBy(x => x.Nombre).ToListAsync();
        //     return Ok(Users);
        // }


        [HttpGet("OxxoCode")]
        public async Task<ActionResult<IQueryable>> getOxxo()
        {
            var _oxxo_code = await (
                from c in ctx.Set<oxxo_code>()
                select new {
                    id = c.id,
                    code = c.code,
                    created_date = c.created_date,
                    begin_date = c.begin_date,
                    end_date = c.end_date,
                    amount = c.amount,
                    fk_client_id = c.fk_client_id,
                }).ToListAsync();
                return Ok(_oxxo_code);
        }

        [HttpGet("ServiceStatus")]
        public async Task<ActionResult<IQueryable>> getServiceStatus()
        {
            var _service_status = await (
                from c in ctx.Set<service_status>()
                select new {
                    id = c.id,
                    key = c.key,
                    value = c.value,
                    isactive = c.is_active,
                }).ToListAsync();
                return Ok(_service_status);
        }


        [HttpGet("depositcredit")]
        public async Task<ActionResult<List<deposit_credit>>> GetCredit()
        {
            return await ctx.deposit_credit.Take(20).ToListAsync();
        }

    }
}
