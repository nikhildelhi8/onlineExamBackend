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
    public class ReportController : ControllerBase
    {
        public ReportController(AppDbContext context)
        {
            _context = context;
        }

        private AppDbContext _context { get; }


        [HttpGet]

        public ActionResult<IEnumerable<Report>> Get()
        {
            return Ok(_context.Reports.ToList());
            
        }

        [HttpPost]

        public ActionResult<Report> Post(Report newdata)
        {
            _context.Reports.Add(newdata);
            _context.SaveChanges();
            return Ok(newdata);
        }

        [HttpGet("{user_id}/{test_id}")]

        public ActionResult<IEnumerable<Report>> Get(int? user_id, int? test_id)
        {
            if(user_id==null&& test_id == null)
            {
                return BadRequest();
            }
            else
            {
                var data = _context.Reports.Where(rev => rev.User_Id == user_id && rev.Test_Id==test_id).FirstOrDefault();
                return Ok(data);
            }

        }

        [HttpGet("getbyid/{id}")]

        public ActionResult<IEnumerable<Report>> Getbyid(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            else
            {
                var data = _context.Reports.Where(rev => rev.User_Id == id).ToList();
                return Ok(data);
            }

        }


    }
}
