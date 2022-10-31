using ComCom_WebAPI.Models;
using ComCom_WebAPI.Models.DataValeAmigo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace ComCom_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetTestController : ControllerBase
    {

        private readonly ValeAmigo ctx;


        public GetTestController (ValeAmigo ctx)
        {
            this.ctx = ctx;
        }

        [HttpGet("closures")]
        public async Task<ActionResult<IQueryable>> GetClosures()
        {
           var _getData = await(
            from c in ctx.Set<closure_closures>()
            select new {
                idClosure = c.id_closure,
                idUser = c.id_user,
                Status = c.status,
                Date = c.date,
                dueBalance = c.due_balance,
            }).ToListAsync();
            return Ok(_getData);
        }

    }
}
