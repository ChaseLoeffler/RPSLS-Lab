﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class HumanPlayer : Player
    {
        public HumanPlayer(string name) : base(name)
        {
        }

        public override void ChooseGesture()
        {
            Console.WriteLine("Choose a gesture either:\nRock,Paper,Scissors,Lizard,or Spock");
            chosenGesture = Console.ReadLine();

        }
    }
}