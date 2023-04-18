using System;
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
            Console.WriteLine($"{this.name}, please choose a gesture either:\nRock,Paper,Scissors,Lizard,or Spock.\n(note:first letter of the gesture must be capitilized)");
            chosenGesture = Console.ReadLine();

        }
    }
}
