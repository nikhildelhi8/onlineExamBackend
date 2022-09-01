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
    public class UserReportController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UserReportController(AppDbContext context)
        {
            _context = context;
        }


        [HttpGet("{id}")]

        public ActionResult<IEnumerable<User_ReportView>> Get(int? id)
        {
            var data = _context.user_report.FromSqlInterpolated($"dbo.user_report @id={id}");

            if(data==null)
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
