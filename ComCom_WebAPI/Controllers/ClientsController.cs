
using ComCom_WebAPI.Models.DataMS;
using ComCom_WebAPI.Models.DataPG;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ComCom_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {

        private readonly radius_db ctx;
        public ClientsController(radius_db ctx)
        {
            this.ctx = ctx;
        }

        [HttpGet("nas")]
        public async Task<ActionResult<List<nas>>> Get()
        {
            return await ctx.Nas.ToListAsync();
        }

    }
    
}
