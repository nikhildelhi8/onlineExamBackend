using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Online_Exam_Gladiator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Exam_Gladiator.Models
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public AppDbContext _context { get; }

        public UserController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]

        public ActionResult<IEnumerable<User>> Get()
        {
            return Ok(_context.Users.ToList());
        }
        [HttpGet("GetUser/{id}")]

        public ActionResult<User> getuser(int id)
        {
            var data = _context.Users.Where(use => use.User_Id == id).FirstOrDefault();
            if (data == null)
                return NotFound();
            else
                return Ok(data);
        }
        [HttpGet("{email}")]
        public ActionResult<User> Get(string email)
        {
            var data = _context.Users.Where(use => use.Email == email).FirstOrDefault();
            if (data == null)
                return NotFound();
            else
                return Ok(data);
        }
        [HttpPost]
        public ActionResult Post(User newuse)
        {

            _context.Users.Add(newuse);
         
            _context.SaveChanges();
            return Ok();

        }

         [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var data = _context.Users.FirstOrDefault(use => use.User_Id == id);
            if (data == null)
                return NotFound();
            else
            {
                _context.Users.Remove(data);
                _context.SaveChanges();
                return Ok();
            }
        }

        [HttpPut("{id}")]
        
       public ActionResult<User> Put(int? Id, User newData)
        {
            var data = _context.Users.Where(r => r.User_Id == Id).FirstOrDefault();

            if (data == null)
            {
                return NotFound();
            }
            else
            {

                data.Firstname = newData.Firstname;
                data.Lastname = newData.Lastname;
                data.City = newData.City;
                data.State = newData.State;
                data.Mobile = newData.Mobile;
                data.Email = newData.Email;
                data.Password = newData.Password;
                data.Qualification = newData.Qualification;
                data.Year_of_completion = newData.Year_of_completion;
                data.Dob = newData.Dob;
                data.Confirm_password = newData.Confirm_password;
                _context.SaveChanges();
                return Ok(data);
            }
        }

    }
}
