using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace VotingCore.Models
{
    public class SignUpUserModel
    {

        [Required(ErrorMessage = "Please enter your first name")]
        [Display(Name = "First name")]
        [RegularExpression(@"[A-Za-z]+$", ErrorMessage = "Please Enter Name in alphabets only")]

        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your last name")]
        [Display(Name = "Last name")]
        [RegularExpression(@"[A-Za-z]+$", ErrorMessage = "Please Enter Name alphabets only")]

        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your email")]
        [Display(Name = "Email address")]
        [EmailAddress(ErrorMessage = "Please enter a valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a strong password")]
        [Compare("ConfirmPassword", ErrorMessage = "Password does not match")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please confirm your password")]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        [Required]
        [RegularExpression(@"[A-Z]{5}[0-9]{4}[A-Z]{1}", ErrorMessage = "Please Enter valid Pan number")]

        public string Pan_Number { get; set; }

    }
}
