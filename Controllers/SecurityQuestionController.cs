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
    public class SecurityQuestionController : ControllerBase
    {
        private AppDbContext _context;

        public SecurityQuestionController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Security_Question>> Get()
        {
            return Ok(_context.Security_Questions.ToList());
        }

    }
}
