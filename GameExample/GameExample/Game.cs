﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameExample
{
    class Game
    {
        Player playerOne;
        Player playerTwo;
        int round;
        int numberOfRounds;

        public Game()
        {
            this.playerOne = new Player("Anderew");
            this.playerTwo = new Player("Mike");
            this.numberOfRounds = 7;
            this.round = 1;
        }
        public void RunGame()
        {
            Console.WriteLine("Welcome to my awesome and totally fair game!");
            while(this.round < this.numberOfRounds)
            {
                Console.WriteLine("Welcome to Turn {0}.", this.round);
                Console.WriteLine("It's your turn {0}.", this.playerOne.getName());
                Turn playerOneturn = new Turn(this.playerOne);
                playerOneturn.TakeTurn();
                Console.WriteLine("Great job {0}!", this.playerOne.getName());
                Console.WriteLine("It's your turn {0}!", this.playerTwo.getName());
                Turn playerTwoTurn = new Turn(this.playerTwo);
                playerTwoTurn.TakeTurn();
                Console.WriteLine("Good Job {0}!", this.playerTwo.getName());
                this.round++;
            }
        }
    }
}
