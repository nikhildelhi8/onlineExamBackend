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
    public class SearchUserController : ControllerBase
    {
        private AppDbContext _context;

        public SearchUserController(AppDbContext context)
        {
            _context = context;

        }

        [HttpGet("GetBySubject/{subject_id}")]
        public ActionResult<IEnumerable<SearchUser>> GetBySubject(int? subject_id)
        {
            var data=_context.SearchUsers.FromSqlInterpolated($"dbo.SearchBySubject @id={subject_id}");

            if(data==null)
            {
                return NotFound();
            }
            else
            {
                return Ok(data);
            }
        }

        [HttpGet("GetByState/{state}")]
        public ActionResult<IEnumerable<SearchUser>> GetByState(string state)
        {
            var data = _context.SearchUsers.FromSqlInterpolated($"dbo.SearchByState @state={state}");

            if (data == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(data);
            }
        }
        [HttpGet("GetByLevel/{level}")]
        public ActionResult<IEnumerable<SearchUser>> GetByLevel(int level)
        {
            var data = _context.SearchUsers.FromSqlInterpolated($"dbo.SearchBylevel @level={level}");

            if (data == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(data);
            }
        }
        [HttpGet("GetByMarks/{lower}/{upper}")]
        public ActionResult<IEnumerable<SearchUser>> GetByMarks(int? lower, int? upper)
        {
            var data = _context.SearchUsers.FromSqlInterpolated($"dbo.SearchByMarks @lower={lower}, @upper={upper}");

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
