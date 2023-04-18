using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
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
                string pc = "The Computer";
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
            Console.WriteLine($"{playerOne.name} choose {playerOne.chosenGesture}");
            Console.WriteLine($"{playerTwo.name} choose {playerTwo.chosenGesture}");
            if (playerOne.chosenGesture == "Rock" && playerTwo.chosenGesture == "Rock")
            {
                Console.WriteLine($"Rock hangs out with Rock.\n{playerOne.name} and {playerTwo.name} tied");
                Console.WriteLine();

            }
            else if (playerOne.chosenGesture == "Paper" && playerTwo.chosenGesture == "Paper")
            {
                Console.WriteLine($"Paper stacks on Paper.\n{playerOne.name} and {playerTwo.name} tied");
                Console.WriteLine();

            }
            else if (playerOne.chosenGesture == "Scissors" && playerTwo.chosenGesture == "Scissors")
            {
                Console.WriteLine($"Scissors does not wish to harm Scissors .\n{playerOne.name} and {playerTwo.name} tied");
                Console.WriteLine();

            }
            else if (playerOne.chosenGesture == "Lizard" && playerTwo.chosenGesture == "Lizard")
            {
                Console.WriteLine($"Lizard loves his fellow Lizard.\n{playerOne.name} and {playerTwo.name} tied");
                Console.WriteLine();

            }
            else if (playerOne.chosenGesture == "Spock" && playerTwo.chosenGesture == "Spock")
            {
                Console.WriteLine($"Spock contemplates seeing himself.\n{playerOne.name} and {playerTwo.name} tied");
                Console.WriteLine();

            }
            else if (playerOne.chosenGesture == "Rock" && playerTwo.chosenGesture == "Paper")
            {
                Console.WriteLine($"Paper engulfs Rock.\n{playerTwo.name} Wins!");
                Console.WriteLine();
                ++playerTwo.score;

            }
            else if (playerOne.chosenGesture == "Rock" && playerTwo.chosenGesture == "Scissors")
            {
                Console.WriteLine($"Rock destorys Scissors.\n{playerOne.name} Wins!");
                Console.WriteLine();
                ++playerOne.score;

            }
            else if (playerOne.chosenGesture == "Rock" && playerTwo.chosenGesture == "Lizard")
            {
                Console.WriteLine($"Rock smashes Lizard.\n{playerOne.name} Wins!");
                Console.WriteLine();
                ++playerOne.score;

            }
            else if (playerOne.chosenGesture == "Rock" && playerTwo.chosenGesture == "Spock")
            {
                Console.WriteLine($"Spock atomizes Rock.\n{playerTwo.name} Wins!");
                Console.WriteLine();
                ++playerTwo.score;

            }
            else if (playerOne.chosenGesture == "Paper" && playerTwo.chosenGesture == "Rock")
            {
                Console.WriteLine($"Paper engulfs Rock.\n{playerOne.name} Wins!");
                Console.WriteLine();
                ++playerOne.score;

            }
            else if (playerOne.chosenGesture == "Paper" && playerTwo.chosenGesture == "Scissors")
            {
                Console.WriteLine($"Scissors slices Paper.\n{playerTwo.name} Wins!");
                Console.WriteLine();
                ++playerTwo.score;

            }
            else if (playerOne.chosenGesture == "Paper" && playerTwo.chosenGesture == "Lizard")
            {
                Console.WriteLine($"Lizard Swallows Paper.\n{playerTwo.name} Wins!");
                Console.WriteLine();
                ++playerTwo.score;

            }
            else if (playerOne.chosenGesture == "Paper" && playerTwo.chosenGesture == "Spock")
            {
                Console.WriteLine($"Paper proves Spock commited tax fraud.\n{playerOne.name} Wins!");
                Console.WriteLine();
                ++playerOne.score;

            }
            else if (playerOne.chosenGesture == "scissors" && playerTwo.chosenGesture == "Rock")
            {
                Console.WriteLine($"Rock destorys Scissors.\n{playerTwo.name} Wins!");
                Console.WriteLine();
                ++playerTwo.score;

            }
            else if (playerOne.chosenGesture == "Scissors" && playerTwo.chosenGesture == "Paper")
            {
                Console.WriteLine($"Scissors slices Paper.\n{playerOne.name} Wins!");
                Console.WriteLine();
                ++playerOne.score;

            }
            else if (playerOne.chosenGesture == "Scissors" && playerTwo.chosenGesture == "Lizard")
            {
                Console.WriteLine($"Scissors behead Lizard.\n{playerOne.name} Wins!");
                Console.WriteLine();
                ++playerOne.score;

            }
            else if (playerOne.chosenGesture == "Scissors" && playerTwo.chosenGesture == "Spock")
            {
                Console.WriteLine($"Spock shows Scissors that it is a inferior blade.\n{playerTwo.name} Wins!");
                Console.WriteLine();
                ++playerTwo.score;

            }
            else if (playerOne.chosenGesture == "Lizard" && playerTwo.chosenGesture == "Rock")
            {
                Console.WriteLine($"Rock Smashes Lizard.\n{playerTwo.name} Wins!");
                Console.WriteLine();
                ++playerTwo.score;

            }
            else if (playerOne.chosenGesture == "Lizard" && playerTwo.chosenGesture == "Paper")
            {
                Console.WriteLine($"Lizard swallows Paper.\n{playerOne.name} Wins!");
                Console.WriteLine();
                ++playerOne.score;

            }
            else if (playerOne.chosenGesture == "Lizard" && playerTwo.chosenGesture == "Scissors")
            {
                Console.WriteLine($"Scissors behead Lizard.\n{playerTwo.name} Wins!"); 
                Console.WriteLine();
                ++playerTwo.score;

            }
            else if (playerOne.chosenGesture == "Lizard" && playerTwo.chosenGesture == "Spock")
            {
                Console.WriteLine($"Lizard poisons Spock .\n{playerOne.name} Wins!");
                Console.WriteLine();
                ++playerOne.score;

            }
            else if (playerOne.chosenGesture == "Spock" && playerTwo.chosenGesture == "Rock")
            {
                Console.WriteLine($"Spock atomizes Rock.\n{playerOne.name} Wins!");
                Console.WriteLine();
                ++playerOne.score;

            }
            else if (playerOne.chosenGesture == "Spock" && playerTwo.chosenGesture == "Paper")
            {
                Console.WriteLine($"Paper proves Spock commited tax fraud.\n{playerTwo.name} Wins!");
                Console.WriteLine();
                ++playerTwo.score;

            }
            else if (playerOne.chosenGesture == "Spock" && playerTwo.chosenGesture == "Scissors")
            {
                Console.WriteLine($"Spock shows Scissors that it is a inferior blade.\n{playerOne.name} Wins!");
                Console.WriteLine();
                ++playerOne.score;

            }
            else if (playerOne.chosenGesture == "Spock" && playerTwo.chosenGesture == "Lizard")
            {
                Console.WriteLine($"Lizard poisons Spock .\n{playerTwo.name} Wins!");
                Console.WriteLine();
                ++playerTwo.score;

            }
        }

        public void DisplayGameWinner()
        {
            if (playerOne.score == 2)
            {
                Console.WriteLine($"{playerOne.name} Wins the game!");
            }
            else if (playerTwo.score == 2)
            {
                Console.WriteLine($"{playerTwo.name} Wins the game!");
            }
        }

        public void RunGame()
        {
            WelcomeMessage();

            int numOfPlayers = ChooseNumberOfHumanPlayers();

            CreatePlayerObjects(numOfPlayers);

            while (playerOne.score < 2 && playerTwo.score < 2)
            {
                playerOne.ChooseGesture();
                playerTwo.ChooseGesture();
                CompareGestures();
            }
            if (playerOne.score == 2 || playerTwo.score == 2)
            {
                DisplayGameWinner();
            }

        }
    }
}
