using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MyFirstWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        private static List<string> values = new List<string> { "value1", "value2" };

        // GET: api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(values);
        }

        // GET: api/values/1
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (id >= values.Count) return NotFound("ID not found.");
            return Ok(values[id]);
        }

        // POST: api/values
        [HttpPost]
        public IActionResult Post([FromBody] string newValue)
        {
            values.Add(newValue);
            return Ok(values);
        }

        // PUT: api/values/1
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string updatedValue)
        {
            if (id >= values.Count) return BadRequest("Invalid ID");
            values[id] = updatedValue;
            return Ok(values);
        }

        // DELETE: api/values/1
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id >= values.Count) return BadRequest("Invalid ID");
            values.RemoveAt(id);
            return Ok(values);
        }
    }
}
