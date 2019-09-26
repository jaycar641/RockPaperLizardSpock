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

        public override void GetGestures()
        {
            
        }

    }
}
