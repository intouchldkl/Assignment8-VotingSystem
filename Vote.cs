using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment8_VotingSystem
{
    class Vote
    {
        private string VoterName;
        private string PartyName;
        private DateTime TimeVoted;
        private static int TotalVotes;

        public Vote(string VoterName,string PartyName)
        {
            this.VoterName = VoterName;
            this.PartyName = PartyName;
            TimeVoted = DateTime.Now;
            TotalVotes = TotalVotes + 1;

        }

        public string getPartyName()
        {
            return PartyName;
        }

        public static int getTotalVotes()
        {
            return TotalVotes;
        }
    }
}
