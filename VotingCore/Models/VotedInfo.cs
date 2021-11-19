using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VotingCore.Models
{
    public class VotedInfo
    {
        public int Id { get; set; }
        public int CandidateId { get; set; }

        public string VoterEmailId { get; set; }

        public string CandidateName { get; set; }
        public string CandidateNumber { get; set; }



    }
}
