using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderGame
{
    internal class CheckTotalDieADisc
    {
        public void CheckRollDie()
        {
            int playerPosition = 0;
            int previousPosition = 0;
            int DicsOfSnake = 0;
            int dicsOfLadder = 0;
            int Empty = 0;
            Random random = new Random();
            while (playerPosition < 100)
            {
                int diceRoll = random.Next(1, 7);
                Console.WriteLine("You rolled a " + diceRoll);
                int option = random.Next(1, 4);
                switch (option)
                {
                    case 1:
                        Console.WriteLine("No Play. You stay in the same position.");
                        Empty += 1;
                        break;
                    case 2:
                        previousPosition = playerPosition;
                        playerPosition += diceRoll;
                        Console.WriteLine("You climbed a ladder! You moved ahead by " + diceRoll + " positions.");
                        dicsOfLadder += 1;
                        break;
                    case 3:
                        playerPosition -= diceRoll;
                        Console.WriteLine("You encountered a snake! You moved back by " + diceRoll + " positions.");
                        DicsOfSnake += 1;
                        break;
                }
                if (playerPosition < 0)
                {
                    Console.WriteLine("Oops, you went below 0. Starting over at position 0.");
                    playerPosition = 0;
                }
                else if (playerPosition > 100)
                {
                    Console.WriteLine("You went above 100. You stay at previous position.");
                    playerPosition = previousPosition;
                }
                else if (playerPosition == 100)
                {
                    Console.WriteLine("Congratulations! You won the game!");
                    break;
                }
                else
                {
                    Console.WriteLine("Your current position is " + playerPosition);
                }
                if (playerPosition + diceRoll > 100)
                {
                    Console.WriteLine("You cannot move forward as it would lead to a position greater than 100.");
                }
            }
            Console.WriteLine("........................................Result.............................");
            Console.WriteLine(" Number  of empty die  :" + Empty);
            Console.WriteLine(" Number of  ladder die : " + dicsOfLadder);
            Console.WriteLine(" Number of snake die  :  " + DicsOfSnake);
            Console.WriteLine(" Total time of Die Disc ............. : " + (DicsOfSnake + Empty + dicsOfLadder));
            Console.ReadKey();
        }
    }
}
