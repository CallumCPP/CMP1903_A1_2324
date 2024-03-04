using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Create a Game object and call its methods.
             * Create a Testing object to verify the output and operation of the other classes.
             */

            Game game = new Game();
            game.Play();

            Console.Write("Thanks for playing. Press any key to continue or press t for testing.");
            var key = Console.ReadKey();

            Console.WriteLine();
               
            if (key.KeyChar == 't')
            {
                Testing testing = new Testing();
                testing.TestDie(1000);
                testing.TestGame(1000);
            }

            Console.Write("Testing completed. Press any key to continue.");
            Console.ReadKey();
        }
    }
}
