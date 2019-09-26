using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Math.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MathController : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult> ExecuteAddition([FromBody] decimal value1, [FromBody] decimal value2)
        {
            await Task.Delay(100);

            return CreatedAtAction("ExecuteAddition", new { result = 1 }, null);
        }

        [HttpPost]
        public async Task<ActionResult> ExecuteSubtraction([FromBody] decimal value1, [FromBody] decimal value2)
        {
            await Task.Delay(100);

            return CreatedAtAction("ExecuteSubtraction", new { result = 1 }, null);
        }

        [HttpPost]
        public async Task<ActionResult> ExecuteMultiplication([FromBody] decimal value1, [FromBody] decimal value2)
        {
            await Task.Delay(100);

            return CreatedAtAction("ExecuteMultiplication", new { result = 1 }, null);
        }

        [HttpPost]
        public async Task<ActionResult> ExecuteDivision([FromBody] decimal value1, [FromBody] decimal value2)
        {
            await Task.Delay(100);

            return CreatedAtAction("ExecuteDivision", new { result = 1 }, null);
        }
    }
}
