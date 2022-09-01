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
    public class QuestionController : ControllerBase
    {
        private AppDbContext _context { get; }

        public QuestionController(AppDbContext context)
        {
            _context = context;
        }


        // get all questions

        [HttpGet]

        public ActionResult<IEnumerable<Question>> Get()
        {
            return _context.Questions.ToList();
        }
        [HttpDelete("{id}")]
        public ActionResult Delete(int? id)
        {
            var data = _context.Questions.Where(data => data.Question_Id == id).FirstOrDefault();
            if(data==null)
            {
                return BadRequest();
            }
            else
            {
                _context.Questions.Remove(data);
                _context.SaveChanges();
                return Ok();
            }
        }

        [HttpPut("{subject_id}/{test_id}")]

        public ActionResult<Question> Put(int? subject_id, int? test_id, Question newdata)
        {
            var data = _context.Questions.Where(res => res.Subject_Id == subject_id && res.Test_Id == test_id).FirstOrDefault();
            if(data==null)
            {
                return BadRequest();
            }
            else
            {
                data.Question_Statement = newdata.Question_Statement;
                data.Option_1 = newdata.Option_1;
                data.Option_2 = newdata.Option_2;
                data.Option_3 = newdata.Option_3;
                data.Option_4 = newdata.Option_4;
                data.Question_marks = newdata.Question_marks;
                _context.SaveChanges();
                return Ok(data);
            }
        }


        [HttpPost]

        // post data in questions after scanning from excel
        public ActionResult<IEnumerable<Question>> Post(Question newTest)
        {
            _context.Questions.Add(newTest);
            _context.SaveChanges();
            return Ok(newTest);
        }

        [HttpGet("{id}")]

        // get questions based on test_Id
        public ActionResult<IEnumerable<Question>> Get(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var data = _context.Questions.Where(data => data.Test_Id == id).ToList();
            return Ok(data);
        }
  


    }
}

        


