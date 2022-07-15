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

        public Player() {

        

        }
        public abstract string GetGestures(string playerName);
      

        public abstract void Start();

        
        
    }
}
