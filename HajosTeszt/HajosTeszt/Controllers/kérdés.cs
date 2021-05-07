using HajosTeszt.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HajosTeszt.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class kérdés : ControllerBase
    {
        [HttpGet]
        [Route("questions/count")]
        public int M1()
        {
            HajostesztContext context = new HajostesztContext();
            int questionNumvber = context.Questions.Count();
            return questionNumvber;

        }

        [HttpGet]
        [Route("questions/{sorszám}")]
        public ActionResult M2(int sorszám)
        {
            HajostesztContext context = new HajostesztContext();
            var kérdés = (from i in context.Questions
                          where i.QuestionId == sorszám
                          select i).FirstOrDefault();
            if (kérdés == null) return BadRequest("nincs ilyen kérdés");

            return new JsonResult(kérdés);

        }
    }
}
