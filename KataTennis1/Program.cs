using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTennis1
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();
            while(!game.GameEnd)
            {
                Console.WriteLine("Who scores?");
                int player;
                var input = Console.ReadLine();
                while(!int.TryParse(input,out player))
                {
                    input = Console.ReadLine();
                }
                game.Point(player);
                if (!game.GameEnd)
                {
                    Console.WriteLine(game.Score());
                }
            }
            Console.WriteLine("The winner is player {0}", game.Winner.PlayerNumber);
            Console.ReadLine();
        }
    }
}
