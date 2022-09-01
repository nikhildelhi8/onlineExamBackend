using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Exam_Gladiator.Models
{
    public class Test
    {
        [Key]
        public int Test_Id { get; set; }
        public int Subject_Id { get; set; }

        public int Test_Level { get; set; }
        public int Marks { get; set; }
    }
}
