using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTennis1
{
    public class Game
    {
        public Player1 Player1 { get; set; }
        public Player2 Player2 { get; set; }

        public Game(IPlayer player1, IPlayer player2)
        {
            Player1 = player1;
            Player2 = player2;
            GameEnd = false;
        }

        public bool GameEnd { get; set; }
      
        public IPlayer Winner { get; private set; }
 
        public string Score()
        {
            if (Player1.Points == Player2.Points && Player1.Points >= 3)
            {
                return "deuce";
            }
            else if (Player1.Points > Player2.Points && Player1.Points >= 3 && Player2.Points >= 3)
            {
                return "advantage player 1";
            }
            else if (Player2.Points > Player1.Points && Player2.Points >= 3 && Player2.Points >= 3)
            {
                return "advantage player 2";
            }
            else
            {
                return string.Format("{0} - {1}", Player1.Points.ToTennisScore(), Player2.Points.ToTennisScore());
            }

        }
        public void Point(IPlayer player)
        {
            player.Score;
            Update();
        }

        private void Update()
        {
           
        }
    }
}
