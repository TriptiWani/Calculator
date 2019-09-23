using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace calculator.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ArrayCalcController : ControllerBase
    {
        // GET api/arraycalc
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/arraycalc
        [HttpGet]
        public ActionResult<IEnumerable<string>> Reverse()
        {
            return new string[] { "Rvalue1", "Rvalue2" };
        }

        // GET api/arraycalc/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }        
    }
}
