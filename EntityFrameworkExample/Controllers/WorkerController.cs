using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MigrationCodeFirst.Models;

namespace EntityFrameworkExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkerController : ControllerBase
    {
        private readonly SqlContext _sqlContext;
        public WorkerController(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
        }

        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(200, Type = typeof(String))]

        public async Task<IActionResult> get(CancellationToken cancellationToken)
        {
            return Ok("Hej");
        }
    }
}
