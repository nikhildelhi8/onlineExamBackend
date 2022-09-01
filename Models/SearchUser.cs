using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Exam_Gladiator.Models
{
    public class SearchUser
    {
        [Key]
        public int Report_Id { get; set; }
        [Required]
        [StringLength(25)]
        public string Firstname { get; set; }

        [Required]
        [StringLength(25)]
        public string Lastname { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(25)]
        public string Email { get; set; }

        [Required]
        [StringLength(13)]
        public string Mobile { get; set; }

        [Required]
        [StringLength(20)]
        public string City { get; set; }

        [Required]
        [DataType(DataType.Date, ErrorMessage = "Date should be in DD/MM/YYYY")]
        public string Dob { get; set; }

        [Required]
        [StringLength(20)]
        public string State { get; set; }

        [Required]
        public string Qualification { get; set; }

        [Required]
        public string Year_of_completion { get; set; }

        public int Marks { get; set; }

        public string Subject_Name { get; set; }

        public int Total_Score { get; set; }
        public int Test_Level { get; set; }
        public string Pass_Fail { get; set; }

        public int Subject_Id { get; set; }

        

    }
}
