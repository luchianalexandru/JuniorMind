using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Library;

namespace WebAppPassword.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet("{length}/{upper}/{number}/{symbols}/{similar}/{ambiguous}")]
        public string Get(int length, int upper, int number, int symbols, bool similar, bool ambiguous)
        {
            var options = new PasswordOptions
            {
                Length = length,
                UpperCase = upper,
                Numbers = number,
                Symbols = symbols,
                Similar = similar,
                Ambiguous = ambiguous,
            };

            var passwordGenerator = new PasswordGenerator();
            var result = passwordGenerator.GeneratePass(options);
            return result;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
