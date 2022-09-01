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
    public class UserLoginController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UserLoginController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("UserLogin")]

        public IActionResult Post(userlogin data)
        {
            var res = _context.Users.Where(i => i.Email == data.Email && i.Password == data.Password).FirstOrDefault();
            if (res != null)
            {
                return Ok("Success");
            }
            return Ok("Failure");
        }
    }
}
