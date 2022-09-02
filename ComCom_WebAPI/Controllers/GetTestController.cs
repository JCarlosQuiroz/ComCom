using ComCom_WebAPI.Models;
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
        public async Task<ActionResult<List<closure_closures>>> Get()
        {
           var getData = await ctx.closure_closures.Select(x => new { x.id_closure, x.date, x.due_balance, x.payable_balance,x.current_balance, x.total_balance}).ToListAsync();
            return Ok(getData);
        }

    }
}
