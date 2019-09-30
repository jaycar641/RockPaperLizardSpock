using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestureGame
{
    class Human : Player
    {
      
        public override void Start()
        {
            Console.WriteLine("Enter your Player Name");
            string UserInput = Console.ReadLine();
            this.name = UserInput;
            
        }

        public override string GetGestures()
        {
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
                    {
                        Console.WriteLine("Not a correct option");
                        break;
                    }


            }

            return GestureChoice;

        }

     

    }
}
