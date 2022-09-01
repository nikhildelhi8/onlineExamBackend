using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online_Exam_Gladiator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Exam_Gladiator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchQuestionController : ControllerBase
    {
        private AppDbContext _context;

        public SearchQuestionController(AppDbContext context)
        {
            _context = context;

        }
        [HttpGet("{subject_id}/{test_level}")]
        public ActionResult<IEnumerable<SearchQuestion>> GetBySubject(int? subject_id,int? test_level)
        {
            var data = _context.SearchQuestions.FromSqlInterpolated($"dbo.SearchQuestions @sub_id={subject_id}, @test_level={test_level}");

            if (data == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(data);
            }
        }
    }
}
