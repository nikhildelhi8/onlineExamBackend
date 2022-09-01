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
    public class AdminController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AdminController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("LoginAdmin")]

        // for login we are using post method
        public IActionResult Post(Admin admin)
        {
            var data = _context.Admins.Where(res => res.Email == admin.Email && res.Password == admin.Password).FirstOrDefault();
            if(data!=null)
            {
                return Ok("Success");
            }
            return Ok("Failure");
        }
    }
}
