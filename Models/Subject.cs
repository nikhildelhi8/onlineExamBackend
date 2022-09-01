using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Exam_Gladiator.Models
{
    public class Subject
    {
        [Key]
        public int Subject_Id { get; set; }
        public string Subject_Name { get; set; }
        public string Image_Path { get; set; }
    }
}
