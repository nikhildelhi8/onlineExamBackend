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
    public class forgot_PasswordController : ControllerBase
    {
        private readonly AppDbContext _context;

        public forgot_PasswordController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("{email}")]

        
        public ActionResult<forgotPasswordView> Get(string email)
        {
            if(email==null)
            {
                return BadRequest();
            }
            var data = _context.forgotPassword.FromSqlInterpolated($"dbo.forgotPassword @email={email}");

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
