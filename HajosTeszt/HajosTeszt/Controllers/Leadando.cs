using HajosTeszt.LeadandoModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HajosTeszt.Controllers
{
    [Route("api/felhasznalok")]
    [ApiController]
    public class Leadando : ControllerBase
    {
        // GET: api/<Leadando>
        [HttpGet]
        public IEnumerable<U945x9> Get()
        {
            SzamhaloContext context = new SzamhaloContext();
            return context.U945x9s.ToList();
        }

        // GET api/<Leadando>/5
        [HttpGet("{id}")]
        public U945x9 Get(int id)
        {
            SzamhaloContext context = new SzamhaloContext();
            var keresetfelhasznaló = (from x in context.U945x9s
                                where x.NévSk == id
                                select x).FirstOrDefault();
            return keresetfelhasznaló;
        }

        // POST api/<Leadando>
        [HttpPost]
        public void Post([FromBody] U945x9 újVicc)
        {
            SzamhaloContext context = new SzamhaloContext();
            context.U945x9s.Add(újVicc);
            context.SaveChanges();
        }

        // PUT api/<Leadando>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            SzamhaloContext context = new SzamhaloContext();
            var törlendőFelhasznaló = (from x in context.U945x9s
                                where x.NévSk == id
                                select x).FirstOrDefault();
            context.Remove(törlendőFelhasznaló);
            context.SaveChanges();
        }
    }
}
