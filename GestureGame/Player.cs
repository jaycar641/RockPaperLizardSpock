using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestureGame
{
    abstract class Player
    {
        public int score;
        public string name;


        public abstract string GetGestures();
      

        public abstract void Start();

        
        
    }
}
