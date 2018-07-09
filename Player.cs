using System;

namespace dartScoreboard
{
    class Player
    {
        private string playerName;
        private int playerScore;
        public Player(string name, int score)
        {
            playerName = name;
            playerScore = score;
        }

        public int SubstractScore(int latestScore) => playerScore - latestScore;

        public Boolean checkedOut(int latestScore)
        {   

            if((playerScore == 50) || (playerScore <= 40 && playerScore % 2 == 0))
            {
                if(playerScore - latestScore == 0)
                {
                    return true;
                }
            }
            return false;   
        }
    }
}