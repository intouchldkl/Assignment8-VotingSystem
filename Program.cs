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
            

        }

        static void castVotes(Vote[] votes)
        {
            string name;
            
            int input = 0;
            int i = 0;
            Console.WriteLine("Hello What's your name?");
            name = Console.ReadLine();
            Console.WriteLine("Which party are you voting for?");
            Console.WriteLine("1:Democrats  2:Communists  3:Facists  Press 0 to exit");
            input = Console.Read();
            while (input != 0)
            {
               
                if(input == 1)
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
                else
                {
                    Console.WriteLine("Your input is ineligible");
                }



            }

        }
    }
}
