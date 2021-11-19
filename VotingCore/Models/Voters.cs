using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace VotingCore.Models
{
    public class Voters
    {
        public int id { get; set; }
        [Required]
        [StringLength(210)]
        public string Fname { get; set; }
        [Required]
        public string Lname { get; set; }
        [Required]
        public string PanNumber { get; set; }
        [Required]
        public string EmailId { get; set; }
        [Required]
        public decimal Contact_number { get; set; }
        
        public string isVoted { get; set; }
    }
}
