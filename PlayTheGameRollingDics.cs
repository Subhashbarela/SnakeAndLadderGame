using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderGame
{
    internal class PlayTheGameRollingDics
    {
        public void RollDics()
        {
            int playerPosition = 0;
            int previousPosition = 0;
            Random random = new Random();

            while (playerPosition < 10)
            {
                int diceRoll = random.Next(1, 7);
                Console.WriteLine("You rolled a " + diceRoll);

                int option = random.Next(1, 4);


                switch (option)
                {
                    case 1: // No Play
                        Console.WriteLine("No Play. You stay in the same position.");
                        break;
                    case 2: // Ladder
                        previousPosition = playerPosition;
                        playerPosition += diceRoll;
                        Console.WriteLine("You climbed a ladder! You moved ahead by " + diceRoll + " positions.");
                        break;
                    case 3: // Snake
                        playerPosition -= diceRoll;
                        Console.WriteLine("You encountered a snake! You moved back by " + diceRoll + " positions.");
                        break;
                }
               
            }
        }
    }
}
