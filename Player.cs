using System;
using System.Collections.Generic;

namespace dartScoreboard
{
    class Player
    {
        private string playerName;
        private int currentScore;
        List<int> scoreList = new List<int>();
        public Player(string name, int startScore)
        {
            playerName = name;
            currentScore = startScore;
        }

        /// <summary>
        /// Updates currentScore by substracting latestScore from currentScore
        /// Appends latestScore to scoreList for statistic generation 
        /// /// </summary>
        /// <param name="latestScore">latestScore by player</param> 
        /// <returns>Updated currentScore</returns>
        public int SubstractScore(int latestScore) {
            currentScore =- latestScore;
            scoreList.Add(latestScore);
            return currentScore;               

        }

        /// <summary>
        /// Checks if player has checked out bust with latestScore
        /// </summary>
        /// <param name="latestScore">latestScore by player</param>
        /// <returns>Boolean that describes whether or not the player has checked out.</returns>
        public Boolean CheckedOut(int latestScore)
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