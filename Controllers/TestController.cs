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
    public class TestController : ControllerBase
    {
        private AppDbContext _context { get; }

        public TestController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]

        public ActionResult<IEnumerable<Test>> Get()
        {
            var data = _context.Test_Lists.ToList();
            return Ok(data);
        }



        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Test>> Get(int? id)
        {
            if(id==null)
            {
                return BadRequest();
            }
            var data = _context.Test_Lists.Where(data => data.Subject_Id == id).ToList();
            return Ok(data);
        }

        [HttpGet]
        [Route("tid/{tid}")]
        public ActionResult<Test> GetWithTid(int? tid)
        {
            if (tid == null)
            {
                return BadRequest();
            }
            var data = _context.Test_Lists.Where(data => data.Test_Id == tid).FirstOrDefault();
            return Ok(data);
        }

        [HttpPost]

        public ActionResult<Test> Post(Test newdata)
        {       _context.Test_Lists.Add(newdata);
                _context.SaveChanges();
                return Ok(newdata);
         
        }

    }
}
