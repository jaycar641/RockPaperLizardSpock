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


            switch (UserInput)
            {
                case "rock":
                    UserInput = "rock";
                    break;
                case "paper":
                    UserInput = "paper";
                    break;
                case "scissors":
                    UserInput = "scissors";
                    break;
                case "lizards":
                    UserInput = "lizard";
                    break;
                case "spock":
                    UserInput = "spock";
                    break;

                default:
                    {
                        Console.WriteLine("Please Choose an Option");
                        GetGestures();
                        break;
                    }

            }

            return UserInput;

        }

     

    }
}
