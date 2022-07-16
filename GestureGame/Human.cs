using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestureGame
{
    class Human : Player
    {
        public int score;
        public string name;
        public void Player() {
            Start();
        }

        public override void Start()
        {
            Console.WriteLine("Enter your Player Name");
            string UserInput = Console.ReadLine();
            this.name = UserInput;
            Console.WriteLine("Thank you " + this.name);
            
        }

        public override string GetGestures(string playerName)
        {
        Console.WriteLine(playerName + " Please Select an option Rock, Paper, Scissor, Lizard, Spock");
          string UserInput = Console.ReadLine();
            string GestureChoice = "";

            switch (UserInput)
            {
                case "rock":
                    GestureChoice = "rock";
                    break;
                case "paper":
                    GestureChoice = "paper";
                    break;
                case "scissors":
                    GestureChoice = "scissors";
                    break;
                case "lizard":
                    GestureChoice = "lizard";
                    break;
                case "spock":
                    GestureChoice = "spock";
                    break;

                default:
                     GestureChoice = null;
                        break;
                    


            }

            return GestureChoice;

        }

     

    }
}
