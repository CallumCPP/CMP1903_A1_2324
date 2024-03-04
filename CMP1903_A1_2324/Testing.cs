using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */

        //Method
        public void TestDie(int rolls)
        {
            Console.WriteLine($"Testing die with {rolls} roll(s)...");

            Die die = new Die();
            for (int i = 0; i < 32767; i++)
            {
                die.Roll();
                Debug.Assert(die.value <= 6 && die.value >= 1, "Die result out of expected range!");
            }
        }

        public void TestGame(int rolls)
        {
            Console.WriteLine($"Testing game with {rolls} roll(s)...");

            Game game = new Game(rolls);
            game.Play();

            int sum = 0;
            foreach (Die die in game.dice) 
                sum += die.value;

            Debug.Assert(sum == game.total, "Result of game is not as expected!");
        }
    }
}
