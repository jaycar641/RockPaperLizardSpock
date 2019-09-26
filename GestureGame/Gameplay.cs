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
        List<string> Gestures = new List<string> { "Rock" , "Paper", "Scissors", "Lizard", "Spock" };

        public void gameplay()
        {


        }
        public void Start ()
        {
            PlayerSelector();


            while (GameOver == false)
            {
                string displaylist = " ";
                foreach(string item in Gestures)
                {

                    displaylist += " " + item;
                }
                Console.WriteLine(FirstPlayer.name + " Please Select an option " + displaylist);

                Console.ReadLine();
                
                //CheckResults();
                //console.Writeline WINNER won this round
            }
        }

        public void PlayerSelector()
        {
            Console.WriteLine("Choose Game Mode:  Player vs Player, Computer vs Player");
            String UserInput = Console.ReadLine();
            
            switch (UserInput)
            {
                case "Player vs Player": //Commit after this is done.
                        Console.WriteLine("Two Player Game");
                    this.FirstPlayer = new Human();
                    FirstPlayer.Start();
                    this.SecondPlayer = new Human();
                    SecondPlayer.Start();
                    break;
                case "Computer vs Player":
                        Console.WriteLine("One Player Game");
                    this.FirstPlayer = new Human();
                    FirstPlayer.Start();
                    this.SecondPlayer = new Computer();
                    SecondPlayer.Start();
                    break;

            }

        }

        public void CheckResults(string player1result, string player2restult) //Checks results of round and returns gameover, and calls increase score
        {
          //  switch()


                //return winner
        }
       
         
            public void IncreaseScore()
        {

        }
    }
}
