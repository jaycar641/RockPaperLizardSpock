using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestureGame
{
    class Gameplay
    {
        bool GameOver = false;
        Player FirstPlayer;
        Player SecondPlayer;
        List<string> Gestures = new List<string> { "rock" , "paper", "scissors", "lizard", "spock" };
        
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
                Console.WriteLine(SecondPlayer.name + " Please Select an option " + displaylist);
                string PlayerTwoChoice = SecondPlayer.GetGestures();

                CheckResults(PlayerOneChoice, PlayerTwoChoice);
                DisplayScore();
                CheckWinner();
            }

        }

        public void PlayerSelector()
        {
            Console.WriteLine("Choose Game Mode:  Player vs Player, Computer vs Player");
            String UserInput = Console.ReadLine();
            
            switch (UserInput)
            {
                case "Player vs Player":
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

                default:
                    {
                        Console.WriteLine("Please enter a correct value");
                        PlayerSelector();
                        break;
                        
                    }

            }
            

        }

        public void CheckResults(string PlayerOneGesture, string PlayerTwoGesture) 
        {
            bool result1 = ValidPrompt(PlayerOneGesture);
            bool result2 = ValidPrompt(PlayerTwoGesture);
            Console.WriteLine("\n");

            if (result1 != true)
            {
                Console.WriteLine("Player One pick a Gesture!");
               PlayerOneGesture = FirstPlayer.GetGestures();
            }

            if (result2 != true)
            {
                Console.WriteLine("Player Two pick a Gesture!");
                PlayerTwoGesture = SecondPlayer.GetGestures();

            }


            if (PlayerOneGesture == PlayerTwoGesture)
                {
                Console.WriteLine(FirstPlayer.name + " chooses " + PlayerOneGesture);
                Console.WriteLine(SecondPlayer.name + " chooses " + PlayerTwoGesture);
                Console.WriteLine("Tie");
                }

                else if (PlayerOneGesture == "rock" ) 
                {
                    if (PlayerTwoGesture == "lizard" || PlayerTwoGesture == "scissors")
                    {
                        Console.WriteLine(FirstPlayer.name + " chooses " + PlayerOneGesture);
                        Console.WriteLine(SecondPlayer.name + " chooses " + PlayerTwoGesture);
                        Console.ReadLine();
                        Console.WriteLine("Player One Wins this round");
                        FirstPlayer.score += 1;
                    }
                    else
                    {
                        Console.WriteLine(FirstPlayer.name + " chooses " + PlayerOneGesture);
                        Console.WriteLine(SecondPlayer.name + " chooses " + PlayerTwoGesture);
                        Console.ReadLine();
                        Console.WriteLine("Player Two Wins this round");
                        SecondPlayer.score += 1;
                    }
                }


                else if (PlayerOneGesture == "scissors")
                {
                    if (PlayerTwoGesture == "paper" || PlayerTwoGesture == "lizard")
                    {
                        Console.WriteLine(FirstPlayer.name + " chooses " + PlayerOneGesture);
                        Console.WriteLine(SecondPlayer.name + " chooses " + PlayerTwoGesture);
                        Console.ReadLine();
                        Console.WriteLine("Player One Wins this round");
                        FirstPlayer.score += 1;
                    }

                    else
                    {
                        Console.WriteLine(FirstPlayer.name + " chooses " + PlayerOneGesture);
                        Console.WriteLine(SecondPlayer.name + " chooses " + PlayerTwoGesture);
                        Console.ReadLine();
                        Console.WriteLine("Player Two Wins this round");
                        SecondPlayer.score += 1;
                    }
                }

                else if (PlayerOneGesture == "paper") 
                {
                    if (PlayerTwoGesture == "rock" || PlayerTwoGesture == "spock")
                    {
                        Console.WriteLine(FirstPlayer.name + " chooses " + PlayerOneGesture);
                        Console.WriteLine(SecondPlayer.name + " chooses " + PlayerTwoGesture);
                        Console.ReadLine();
                        Console.WriteLine("Player One Wins this round");
                        FirstPlayer.score += 1;
                    }

                    else
                    {
                        Console.WriteLine(FirstPlayer.name + " chooses " + PlayerOneGesture);
                        Console.WriteLine(SecondPlayer.name + " chooses " + PlayerTwoGesture);
                        Console.ReadLine();
                        Console.WriteLine("Player Two Wins this round");
                        SecondPlayer.score += 1;
                    }
                }


                else if (PlayerOneGesture == "spock")
                {
                    if (PlayerTwoGesture == "rock" || PlayerTwoGesture == "scissors")
                    {
                        Console.WriteLine(FirstPlayer.name + " chooses " + PlayerOneGesture);
                        Console.WriteLine(SecondPlayer.name + " chooses " + PlayerTwoGesture);
                        Console.ReadLine();
                        Console.WriteLine("Player One Wins this round");
                        FirstPlayer.score += 1;
                    }

                    else
                    {
                        Console.WriteLine(FirstPlayer.name + " chooses " + PlayerOneGesture);
                        Console.WriteLine(SecondPlayer.name + " chooses " + PlayerTwoGesture);
                        Console.ReadLine();
                        Console.WriteLine("Player Two Wins this round");
                        SecondPlayer.score += 1;
                    }
                }


                else if (PlayerOneGesture == "lizard" )
                {
                    if (PlayerTwoGesture == "spock" || PlayerTwoGesture == "paper")
                    {
                        Console.WriteLine(FirstPlayer.name + " chooses " + PlayerOneGesture);
                        Console.WriteLine(SecondPlayer.name + " chooses " + PlayerTwoGesture);
                        Console.ReadLine();
                        Console.WriteLine("Player One Wins this round");
                        FirstPlayer.score += 1;
                    }

                    else
                    {
                        Console.WriteLine(FirstPlayer.name + " chooses " + PlayerOneGesture);
                        Console.WriteLine(SecondPlayer.name + " chooses " + PlayerTwoGesture);
                        Console.ReadLine();
                        Console.WriteLine("Player Two Wins this round");
                        SecondPlayer.score += 1;
                    }
                }


            PlayerOneGesture = null;
            PlayerTwoGesture = null;


        }

        public void DisplayScore() 
        {
            Console.WriteLine(FirstPlayer.name + " has " + FirstPlayer.score + " and " + SecondPlayer.name + " has " + SecondPlayer.score);
        

        }

        public bool ValidPrompt(string Gesture)
        {
            bool prompt = false;
            foreach (string test in Gestures)
            {

                if (Gesture == test)
                {
                     prompt = true;
                }

              

            }

            return prompt;

        }

        public void CheckWinner()
        {

            if (FirstPlayer.score == 2)
            {
                Console.WriteLine(FirstPlayer.name + " Wins!");
                Console.Read();
                GameOver = true;
            }


            if (SecondPlayer.score == 2)
            {
                Console.WriteLine(SecondPlayer.name + " Wins!");
                Console.Read();
                GameOver = true;

            }

        }

     }
}
