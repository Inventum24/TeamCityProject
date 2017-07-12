using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TeamCityProject.Controllers
{
    [Produces("application/json")]
    [Route("api/Values")]
    public class ValuesController : Controller
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "val1", "val2", "val3" };
        }
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "val1";
        }
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }
        [HttpPut]
        public void Put(int id, [FromBody] string value)
        {
            
        }
        [HttpDelete("{id}")]
        public void Delete( int id)
        {

        }
    }
}