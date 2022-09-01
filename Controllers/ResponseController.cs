using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Online_Exam_Gladiator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Exam_Gladiator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResponseController : ControllerBase
    {
        private AppDbContext _context;

        public ResponseController(AppDbContext context)
        {
            _context = context;
        }


        [HttpGet]

        public ActionResult<IEnumerable<Response>> Get()
        {
            return _context.Responses.ToList();
        }

        [HttpPost]
        public ActionResult<Response> Post(Response newdata)
        {
            _context.Responses.Add(newdata);
            _context.SaveChanges();
            return Ok(newdata);
        }
    }
}
