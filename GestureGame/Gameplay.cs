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
            Console.WriteLine("Welcome to Rock Paper Scissor Lizard Spock.  The rules are simple:");
            Console.WriteLine("\n");
            Console.WriteLine("Rock crushes Scissors \n Scissors cuts Paper \n Paper covers Rock \n Rock crushes Lizard \n Lizard poisons Spock \n Spock smashes Scissors \n Scissors decapitates Lizard \n Lizard eats Paper \n Paper disproves Spock \n Spock vaporizes Rock");
            Console.WriteLine("\n");
            PlayerSelector();


            while (GameOver == false)
            {
                string displaylist = " ";
                foreach(string item in Gestures)
                {

                    displaylist += " " + item;
                }

                Console.WriteLine(FirstPlayer.name + " Please Select an option " + displaylist);

                string PlayerOneChoice = FirstPlayer.GetGestures();
                string PlayerTwoChoice = SecondPlayer.GetGestures();
               

                CheckResults(PlayerOneChoice, PlayerTwoChoice);


              
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
            string PlayerOneGesture = player1result;
            string PlayerTwoGesture = player2restult;

            if (player1result == player2restult)
            {
                Console.WriteLine("Tie");
            }

            else if (player1result == "rock" && player2restult == "scissors" || player2restult == "lizards")
            {
                Console.WriteLine(player2restult);
                Console.ReadLine();
                Console.WriteLine("Player One Wins this round");
                FirstPlayer.score += 1;
            }


            else if (player1result == "scissors" && player2restult == "lizards" || player2restult == "paper")
            {
                Console.WriteLine(player2restult);
                Console.ReadLine();
                Console.WriteLine("Player One Wins this round");
                FirstPlayer.score += 1;
            }

            else if (player1result == "paper" && player2restult == "spock" || player2restult == "rock")
            {
                Console.WriteLine(player2restult);
                Console.ReadLine();
                Console.WriteLine("Player One Wins this round");
                FirstPlayer.score += 1;
            }


            else if (player1result == "spock" && player2restult == "rock" || player2restult == "scissors")
            {
                Console.WriteLine(player2restult);
                Console.ReadLine();
                Console.WriteLine("Player One Wins this round");
                FirstPlayer.score += 1;
            }


            else if (player1result == "lizard" && player2restult == "spock" || player2restult == "paper")
            {
                Console.WriteLine(player2restult);
                Console.ReadLine();
                Console.WriteLine("Player One Wins this round");
                FirstPlayer.score += 1;
            }

            else
            {
                Console.WriteLine(player2restult);
                Console.ReadLine();
                Console.WriteLine("Player Two Wins this round");
                SecondPlayer.score += 1;

            }

          


        }


      
    }
}
