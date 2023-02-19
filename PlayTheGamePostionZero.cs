using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderGame
{
    internal class PlayTheGamePostionZero
    {
        public void Play()
        {
           
            Random random = new Random();


            int position = 10;
            for (int i = 0; i < position; i++)
            {

                Console.WriteLine("You rolled a ");

                int option = random.Next(1, 4);


                switch (option)
                {
                    case 1: // No Play
                        Console.WriteLine("No Play. You stay in the same position.");
                        break;
                    case 2: // Ladder

                        Console.WriteLine("You climbed a ladder! You moved ahead by  positions.");
                        break;
                    case 3: // Snake

                        Console.WriteLine("You encountered a snake! You moved back by  positions.");
                        break;
                }
            }
               
               

            
        }
    }
}

