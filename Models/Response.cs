using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Exam_Gladiator.Models
{
    public class Response
    {
        [Key]
        public int Response_Id { get; set; }

        public int User_Id { get; set; }
        public int Test_Id { get; set; }
        public int Question_Id { get; set; }
        public string User_Response { get; set; }
        public bool Correct_Wrong { get; set; }

    }
}
