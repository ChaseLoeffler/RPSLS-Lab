using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Game
    {
        //Member Variabes (HAS A)
        public Player playerOne;
        public Player playerTwo;

        //Constructor
        public Game()
        {

        }

        //Member Methods (CAN DO)
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to RPSLS! Here are the rules:\nThe game is Best of 3 rounds. Ties do not count towards your score.\nYou will be prompeted to chose how many players(either 1 or 2. A single player will face the computer.) and a gesture.\nThe gestures consist of Rock, Paper, Scissors, Lizard, Or Spock.");
            Console.WriteLine("The gestures will be compared and between them a winner chosen.\nRock wins against Scissors and Lizard.\nPaper wins against Rock and Spock.\nScissors wins against Paper and Lizard\nLizard wins against Paper and Spock\nSpock wins against Scissors and Rock");
            Console.WriteLine("Have fun!");
        }

        public int ChooseNumberOfHumanPlayers()
        {
            Console.WriteLine("How many Players would you like 1 or 2?");
            string userInput = Console.ReadLine();
            int playerNum = Convert.ToInt32(userInput);
            return playerNum;
        }

        public void CreatePlayerObjects(int numberOfHumanPlayers)
        {
            if (numberOfHumanPlayers == 1)
            {
                Console.WriteLine("What is your name?");
                string name = Console.ReadLine();
                string pc = "Computer";
                playerOne = new HumanPlayer(name);
                playerTwo = new ComputerPlayer(pc);
            }
            else if (numberOfHumanPlayers == 2)
            {
                Console.WriteLine("What is player one's name?");
                string nameOne = Console.ReadLine();
                Console.WriteLine("What is Player two's name?");
                string nameTwo = Console.ReadLine();
                playerOne = new HumanPlayer(nameOne);
                playerTwo = new HumanPlayer(nameTwo);

            }

        }

        public void CompareGestures()
        {

        }

        public void DisplayGameWinner()
        {

        }

        public void RunGame()
        {
            WelcomeMessage();
        }
    }
}
