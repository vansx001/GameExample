using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameExample
{
    class Turn
    {
        Player player;

        public Turn(Player player)
        {
            this.player = player;
        }
        public void TakeTurn()
        {
            player.addOneToScore();
            player.addOneToScore();
            Console.WriteLine("Your turn is over {0}. Your score is {1}.", player.getName(),player.getScore());
            Console.ReadLine();
        }
    }
}

