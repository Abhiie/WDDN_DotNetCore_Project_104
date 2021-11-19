using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace VotingCore.Models
{
    public class Candidate
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Please enter Candidate Name")]
        [Display(Name = "CandidateName")]
        [RegularExpression(@"[A-Za-z]+$", ErrorMessage = "Please Enter Name in alphabets only")]
        public string CandidateName { get; set; }

        [Required(ErrorMessage = "Please enter Candidat Number")]
        [Display(Name = "CandidateNumber")]
        [RegularExpression(@"[0-9]+$", ErrorMessage = "Please Enter Valid Number")]

        public string CandidateNumber { get; set; }

       
        [Required(ErrorMessage = "Please enter your email")]
        [Display(Name = "Emailaddress")]
        [EmailAddress(ErrorMessage = "Please enter a valid email")]
        public string CandidateEmailAddress { get; set; }
        
        [Required(ErrorMessage = "Please enter Position ")]
        [Display(Name = "Position")]
        [RegularExpression(@"[A-Za-z]+$", ErrorMessage = "Please Enter in alphabets only")]

        public string Position { get; set; }
        
      


    }
}
