using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestureGame
{
    class Computer:Player
    {
        public override void Start()
        {
            Console.WriteLine("Enter the Computer's Name");
            string UserInput = Console.ReadLine();

            if (UserInput == "")
            {
                UserInput = "Maya";
                this.name = UserInput;
                Console.WriteLine("The Computer's Name will be Maya");

            }

            else
            {
                this.name = UserInput;
                Console.WriteLine("The Computer's Name will be " + UserInput);

            }

            //  GetGestures();

        }

        public override string GetGestures()
        {
            Random ComputerChoice = new Random();
            int NumberDecision = ComputerChoice.Next(0, 5);
            string GestureDecision;

            switch(NumberDecision)
            {
                case 0:
                    GestureDecision = "rock";
                    break;
                case 1:
                    GestureDecision = "paper";
                    break;
                case 2:
                    GestureDecision = "scissors";
                    break;
                case 3:
                    GestureDecision = "lizard";
                    break;
                case 4:
                    GestureDecision = "spock";
                    break;

                default:
                    {
                        GestureDecision = "rock";
                        break;
                    }

            }


            return GestureDecision;

        }


    }
}
