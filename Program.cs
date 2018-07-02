using System;

namespace dartScoreboard
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentScore = 501;
            int latestScore;
            bool finished = false;
            Console.WriteLine("Please enter your name");
            String playerName = Console.ReadLine();
            while(!finished)
            {
                Console.WriteLine("Enter score: ");
                while(!int.TryParse(Console.ReadLine(), out latestScore))
                {
                    Console.WriteLine("Please enter a number.");
                }
                if(checkedOut(currentScore, latestScore))
                {
                    finished = true;
                } 
                if(currentScore - latestScore >= 2) 
                {
                    currentScore -= latestScore;
                } 
                else 
                {
                    Console.WriteLine("Bust..");
                }
                Console.WriteLine("{0}: {1}", playerName, currentScore);
            }
            Console.WriteLine("Congratulations {0} you have won...", playerName);
        }

        /// <summary> method <c>checkedOut</c> Checks if the number can be checked out check and if a checkout occurs</summary>
        /// <param> <c>currentScore</c> The current score a player is on
        /// <param> <c>latestScore</c> The latest score a player has hit
        private static Boolean checkedOut(int currentScore, int latestScore)
        {   

            if((currentScore == 50) || (currentScore <= 40 && currentScore % 2 == 0))
            {
                if(currentScore - latestScore == 0)
                {
                    return true;
                }
            }
            return false;   
        }
    }
}
