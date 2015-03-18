using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTennis1
{
     public interface IPlayer
    {
        int Points { get; set; }
        void Score();
    }

    public abstract class Player:IPlayer
    {
         
        public Player()
        {
            Points = 0;
           
        }
        public int Points { get; set; }
        public void Score()
        {
            Points++;
        }

    }

    public sealed class Player1 : Player
    {

    }

    public sealed class Player2 : Player
    {

    }
}
