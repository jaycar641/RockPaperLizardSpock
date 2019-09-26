using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestureGame
{
    class Gameplay
    {
        int score;
        bool GameOver;
        Player FirstPlayer;
        Player SecondPlayer;

        
        public void Start ()
        {
            PlayerSelector();


            while (!GameOver)
            {
                CheckResults();
                //console.Writeline WINNER won this round
            }
        }

        public Player PlayerSelector()
        {
            return;
        }

        public void CheckResults(string player1result, string player2restult) //Checks results of round and returns gameover, and calls increase score
        {
            switch()


                //return winner
        }

        public void IncreaseScore()
        {

        }
    }
}
