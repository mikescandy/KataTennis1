using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTennis1
{
    public class Game
    {
        public Game()
        {
            Player1 = new Player(1);
            Player2 = new Player(2);
            GameEnd = false;
        }
        public bool GameEnd { get; set; }
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }
        public Player Winner { get; private set; }
        private int activePlayer = 1;
        public Player ActivePlayer { get { return activePlayer == 1 ? Player1 : Player2; } }
        public void NextPlayer()
        {
            activePlayer = (activePlayer++) % 2;
        }
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
        public void Point(int playerN)
        {
            if (playerN == 1)
                Player1.Score();
            else Player2.Score();
            Update();
        }

        private void Update()
        {
            if (Player1.Points >= 4 && Player1.Points - Player2.Points >= 2)
            {
                GameEnd = true;
                Winner = Player1;
            }
            else if (Player2.Points >= 4 && Player2.Points - Player1.Points >= 2)
            {
                GameEnd = true;
                Winner = Player2;
            }
        }

    }
}
