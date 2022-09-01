using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Exam_Gladiator.Models
{
    public class User
    {
        [Key]
        public int User_Id { get; set; }

      
        [Required(ErrorMessage = "Enter First Name")]
        [StringLength(25)]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Enter Last Name")]
        [StringLength(25)]
        public  string Lastname { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(25)]
        public  string Email { get; set; }

        [Required(ErrorMessage = "Mobile number is required")]
        [StringLength(13)]
        public  string Mobile { get; set; }

        [Required(ErrorMessage = "City name is required")]
        [StringLength(20)]
        public  string City { get; set; }

        [Required]
        [DataType(DataType.Date, ErrorMessage = "Date should be in DD/MM/YYYY")]
        public string Dob { get; set; }

        [Required(ErrorMessage = "state name is required")]
        [StringLength(20)]
        public string State { get; set; }

        [Required(ErrorMessage = "qualification level is required")]
        public  string Qualification { get; set; }

        [Required(ErrorMessage = "year of completion is required")]
        public  string Year_of_completion { get; set; }

        [Required(ErrorMessage = "password is required")]
        [StringLength(50)]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Password and confirm password does not match")]
        [StringLength(50)]
        public  string Confirm_password { get; set; }


        public int Security_Id { get; set; }

        public string Security_Answer { get; set; }

    }
}
