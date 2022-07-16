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
            introQuote();
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
                    Start();
                }
                
   
                CheckResults(PlayerOneChoice, PlayerTwoChoice);
                DisplayScore(FirstPlayer, SecondPlayer);
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

            
        string player1Gesture = PlayerOneGesture;   
        string player2Gesture = PlayerTwoGesture;
            if(player1Gesture == player2Gesture) {
                Console.WriteLine("Player 1 has " + player1Gesture + " and Player 2 has " + player2Gesture);
                Console.WriteLine("Its a tie");
                Console.ReadLine();
                return;
            }
            switch(player1Gesture) 
            {

                case "rock":
                 if(player2Gesture == "lizard" || player2Gesture == "scissor")   
                 {
                     Console.WriteLine("Player 2 has " + player2Gesture + " Player One Wins this round");
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
                if(player2Gesture == "rock" || player2Gesture == "spock")   {
                 Console.WriteLine("Player 2 has " + player2Gesture + " Player One Wins this round");
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
                if(player2Gesture == "lizard" || player2Gesture == "paper")  { 
                     Console.WriteLine("Player 2 has " + player2Gesture + " Player One Wins this round");
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
                if(player2Gesture == "spock" || player2Gesture == "paper")   {
                     Console.WriteLine("Player 2 has " + player2Gesture + " Player One Wins this round");
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
                if(player2Gesture == "rock" || player2Gesture == "scissor")   {
                     Console.WriteLine("Player 2 has " + player2Gesture + " Player One Wins this round");
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
                  CheckResults(player1Gesture, player2Gesture);               
                break;
            }

           
        }

        public void DisplayScore(Player FirstPlayer, Player SecondPlayer) 
        {
            Console.WriteLine("Player 1 has " + FirstPlayer.score + " and Player 2 has " + SecondPlayer.score);
        

        }

        
        public void CheckWinner()
        {

            if (FirstPlayer.score == 2)
            {
                Console.WriteLine("Player 1 Wins!");
                Console.Read();
                GameOver = true;
            }


            if (SecondPlayer.score == 2)
            {
                Console.WriteLine("Player 2 Wins!");
                Console.Read();
                GameOver = true;

            }

        }

        public void introQuote() {

            Console.WriteLine("Welcome to Rock Paper Scissor Lizard Spock.  The rules are simple:");
            Console.ReadLine();
            Console.WriteLine("Rock crushes Scissors, Scissors cuts Paper \n Paper covers Rock, Rock crushes Lizard \n Lizard poisons Spock, Spock smashes Scissors \n Scissors decapitates Lizard, Lizard eats Paper, \n Paper disproves Spock, Spock vaporizes Rock");
            Console.ReadLine();
        }

     }
}
