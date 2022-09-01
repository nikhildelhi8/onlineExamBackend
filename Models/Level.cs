using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Exam_Gladiator.Models
{
    public class Level
    {
        [Key]
        public int Level_Id { get; set; }
        public int Level_No { get; set; }
    }
}
