using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Exam_Gladiator.Models
{
    public class Report
    {
        [Key]
        public int Report_Id { get; set; }
        public int User_Id { get; set; }
        public int Test_Id { get; set; }
        public int Subject_Id { get; set; }
        public int Total_Score { get; set; }
        public int Test_Level { get; set; }
        public string Pass_Fail { get; set; }
    }
}
