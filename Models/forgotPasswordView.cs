using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Exam_Gladiator.Models
{
    public class forgotPasswordView
    {
        [Key]
        public int User_Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Confirm_Password { get; set; }

       
        public int Security_Id { get; set; }
        public string Question_Statement { get; set; }
        public string Security_Answer { get; set; }

    }
}
