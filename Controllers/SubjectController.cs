using Microsoft.AspNetCore.Mvc;
using Online_Exam_Gladiator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Exam_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : Controller
    {
        public AppDbContext _context { get; }

        public SubjectController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Subject>> Get()
        {
            return Ok(_context.Subjects.ToList());
        }
        [HttpGet("{id}")]
        public ActionResult<Subject> Get(int? id)
        {
            
            if (id == null)
            {
                return BadRequest();
            }
            var data = _context.Subjects.Where(emp => emp.Subject_Id == id).FirstOrDefault();
            return Ok(data);
            
        }

    }
}
