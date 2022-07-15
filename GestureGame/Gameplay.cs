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
            Console.ReadLine();
            Console.WriteLine("Rock crushes Scissors \n Scissors cuts Paper \n Paper covers Rock \n Rock crushes Lizard \n Lizard poisons Spock \n Spock smashes Scissors \n Scissors decapitates Lizard \n Lizard eats Paper \n Paper disproves Spock \n Spock vaporizes Rock");
            Console.WriteLine("\n");
            Console.ReadLine();
            PlayerSelector();
            
            
            while (GameOver == false)
            {
                string PlayerTwoChoice = "";
            string PlayerOneChoice = "";
                try {
                PlayerTwoChoice = SecondPlayer.GetGestures(SecondPlayer.name);
                PlayerOneChoice = FirstPlayer.GetGestures(FirstPlayer.name);

                }
                catch(NullReferenceException e) {
                    Console.WriteLine("Not a correct option");
                }
                
   
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
                    this.SecondPlayer = new Human();
                    break;
                case "Computer vs Player":
                        Console.WriteLine("One Player Game");
                    this.FirstPlayer = new Human();
                    this.SecondPlayer = new Computer();
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

            
            
        string player2Gesture = PlayerTwoGesture;
            switch(PlayerOneGesture) 
            {

                case "rock":
                 if(PlayerTwoGesture == "lizard" || PlayerTwoGesture == "scissor")   
                 {
                     Console.WriteLine("Player One Wins this round");
                     Console.ReadLine();
                        FirstPlayer.score += 1; 
                 }
                    else {
                        Console.WriteLine("Player Two has " + player2Gesture + " Player 2 " + "Wins this round");
                                             Console.ReadLine();
                     SecondPlayer.score +=1;
                    }
                break;
                case "paper":
                if(PlayerTwoGesture == "rock" || PlayerTwoGesture == "spock")   {
                 Console.WriteLine("Player One Wins this round");
                                         Console.ReadLine();
                        FirstPlayer.score += 1;
                    }
                    else {
                        Console.WriteLine("Player Two has " + player2Gesture + " Player 2" + " Wins this round");
                                             Console.ReadLine();
                     SecondPlayer.score +=1;
                    }
                break;
                case "scissor":
                if(PlayerTwoGesture == "lizard" || PlayerTwoGesture == "paper")  { 
                     Console.WriteLine("Player One Wins this round");
                                         Console.ReadLine();
                        FirstPlayer.score += 1;
                    }
                    else {
                        Console.WriteLine("Player Two has " + player2Gesture + " Player 2 " + "Wins this round");
                                             Console.ReadLine();
                     SecondPlayer.score +=1;
                    }
                break;
                case "lizard":
                if(PlayerTwoGesture == "spock" || PlayerTwoGesture == "paper")   {
                     Console.WriteLine("Player One Wins this round");
                                         Console.ReadLine();
                        FirstPlayer.score += 1;
                    }
                    else {
                        Console.WriteLine("Player Two has " + player2Gesture + " Player 2 " + "Wins this round");
                                             Console.ReadLine();
                     SecondPlayer.score +=1;
                    }
                break;
                    case "spock":
                if(PlayerTwoGesture == "rock" || PlayerTwoGesture == "scissor")   {
                     Console.WriteLine("Player One Wins this round");
                                         Console.ReadLine();
                        FirstPlayer.score += 1;
                    }
                    else {
                        Console.WriteLine("Player Two has " + player2Gesture + " Player 2 " + "Wins this round");
                                             Console.ReadLine();
                     SecondPlayer.score +=1;
                    }
                break;
                default:
                                 Console.WriteLine("Its a tie");
                                 Console.ReadLine();
                break;
            }

           
        }

        public void DisplayScore() 
        {
            Console.WriteLine(FirstPlayer.name + " has " + FirstPlayer.score + " and " + SecondPlayer.name + " has " + SecondPlayer.score);
        

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
