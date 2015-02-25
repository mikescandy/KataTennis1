using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTennis1
{
    public class Player
    {
        public int PlayerNumber { get; set; }
        public Player(int number)
        {
            Points=0;
            PlayerNumber=number;
        }
        public int Points { get; set; }
        public void Score()
        {
            Points++;
        }
       
    }
}
