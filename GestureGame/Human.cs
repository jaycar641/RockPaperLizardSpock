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
                case "Rock":
                    UserInput = "Rock";
                    break;
                case "Paper":
                    UserInput = "Paper";
                    break;
                case "Scissors":
                    UserInput = "Scissors";
                    break;
                case "Lizards":
                    UserInput = "Lizard";
                    break;
                case "Spock":
                    UserInput = "Spock";
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
