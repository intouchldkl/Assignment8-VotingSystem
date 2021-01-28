using System;

namespace Assignment8_VotingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Vote[] votes = new Vote[1000000];

            
            

            Console.WriteLine(Vote.getTotalVotes());

            castVotes(votes);
            Console.WriteLine(GetWinner(votes));

            
        }

        static void castVotes(Vote[] votes)
        {
            string name;
            
            int input = -1 ;
            int i = 0;
            
            while (input != 0)
            {
                Console.WriteLine("Hello What's your name?");
                name = Console.ReadLine();
                Console.WriteLine("Which party are you voting for?");
                Console.WriteLine("1:Democrats  2:Communists  3:Facists  Press 0 to exit");
                string Voteinput = Console.ReadLine();

                input = Convert.ToInt32(Voteinput);

                if (input == 1)
                {
                    votes[i] = new Vote(name,"Democrats");
                    i = i + 1;
                }
                else if (input == 2)
                {
                    votes[i] = new Vote(name, "Communists");
                    i = i + 1;
                }
                else if (input == 3)
                {
                    votes[i] = new Vote(name, "Facists");
                    i = i + 1;
                }
                else if(input == 0)
                {
                    Console.WriteLine("Voting ended.");
                }

                else
                {
                    Console.WriteLine("Your input is ineligible");
                }



            }

        }
        static int[] CountVotes(Vote[] votes)
        {
            int[] partyVotes = new int[3];

            
            for (int i = 0; i < votes.Length; i++)
            {
                if (votes[i] != null && votes[i].getPartyName() == "Democrats" )
                {
                    partyVotes[0] = partyVotes[0] + 1;
                }
                else if (votes[i] != null && votes[i].getPartyName() == "Communists")
                {
                    partyVotes[1] = partyVotes[1] + 1;
                }
                else if (votes[i] != null && votes[i].getPartyName() == "Facists")
                {
                    partyVotes[2] = partyVotes[2] + 1;
                }

            }
            return partyVotes;
            
          
        }

        static string GetMostVotedParty(Vote[] votes)
        {
            String MostVotes = "No one";
            int DemocratsVotes = CountVotes(votes)[0];
            int CommunistsVotes = CountVotes(votes)[1];
            int FacistsVotes = CountVotes(votes)[2];
            if ( DemocratsVotes > CommunistsVotes && DemocratsVotes > FacistsVotes   )
            {
                MostVotes = "Democrats";
            }
            else if (CommunistsVotes > DemocratsVotes && CommunistsVotes > FacistsVotes)
            {
                MostVotes = "Communists";
            }
            else if (FacistsVotes > DemocratsVotes && FacistsVotes > CommunistsVotes)
            {
                MostVotes = "Facists";
            }
            return MostVotes;
        }
        static string GetWinner(Vote[] votes)
        {
            int Fiftypercent = Vote.getTotalVotes() / 2;
            String candidateWinner = GetMostVotedParty(votes);
            int MostVotes = 0;
            string Winner = " ";
            if (candidateWinner == "Democrats")
            {
                MostVotes = CountVotes(votes)[0];
               
            }
            else if (candidateWinner == "Communists")
            {
                MostVotes = CountVotes(votes)[1];

            }
            else if (candidateWinner == "Facists")
            {
                MostVotes = CountVotes(votes)[2];

            }

            if(MostVotes > Fiftypercent)
            {
                Winner = candidateWinner;
            }
            else
            {
                return " No party has enough votes to win";
            }
            return Winner;



        }
    }
}
