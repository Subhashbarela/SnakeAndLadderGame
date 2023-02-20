using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderGame
{
    internal class CheckWhoWinTheGame
    {
        public void Winner()
        {
            int playerPosition = 0;
            int previousPosition = 0;
            Random random = new Random();
            int Player = random.Next(2);
            while (playerPosition < 100)
            {
                if (Player == 0)
                {
                    int diceRoll = random.Next(1, 7);
                    Console.WriteLine("You rolled a " + diceRoll);
                    int option = random.Next(1, 4);
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("No Play. You stay in the same position.");

                            break;
                        case 2:
                            previousPosition = playerPosition;
                            playerPosition += diceRoll;
                            Console.WriteLine("You climbed a ladder! You moved ahead by " + diceRoll + " positions.");

                            break;
                        case 3:
                            playerPosition -= diceRoll;
                            Console.WriteLine("You encountered a snake! You moved back by " + diceRoll + " positions.");

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
                        Console.WriteLine("Congratulations!...... Player1 won the game!");
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
                else
                {
                    int diceRoll = random.Next(1, 7);
                    Console.WriteLine("You rolled a " + diceRoll);
                    int option = random.Next(1, 4);
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("No Play. You stay in the same position.");

                            break;
                        case 2:
                            previousPosition = playerPosition;
                            playerPosition += diceRoll;
                            Console.WriteLine("You climbed a ladder! You moved ahead by " + diceRoll + " positions.");

                            break;
                        case 3:
                            playerPosition -= diceRoll;
                            Console.WriteLine("You encountered a snake! You moved back by " + diceRoll + " positions.");

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
                        Console.WriteLine("Congratulations!...... Player2 won the game!");
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
            }
        }
    }
}

