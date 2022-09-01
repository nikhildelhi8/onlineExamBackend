using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Exam_Gladiator.Models
{
    public class Question
    {
        [Key]
        public int Question_Id { get; set; }
        public int Question_No { get; set; }
        public int Subject_Id { get; set; }

        public int Test_Id { get; set; }
        public int Question_marks { get; set; }

        [MaxLength(200)]
        public string Question_Statement { get; set; }
        public string Option_1 { get; set; }
        public string Option_2 { get; set; }
        public string Option_3 { get; set; }
        public string Option_4 { get; set; }
        public string Correct_Answer { get; set; }

        
    }
}
