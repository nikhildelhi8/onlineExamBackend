using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Exam_Gladiator.Models
{
    public class Security_Question
    {
        [Key]
        public int Security_Id { get; set; }
        public string Question_Statement { get; set; }
    }
}
