using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */

        //Methods
        public List<Die> dice = new List<Die>();
        public int total { get; private set; }

        private int testingIterations, currentIteration;
        private char choice = ' ';


        private bool Condition()
        {
            if (testingIterations == 0)
                return choice != 'n';
            else 
                return testingIterations > currentIteration;
        }

        public Game(int testingIterations = 0) 
        {
            this.testingIterations = testingIterations;
        }

        public void Play()
        {
            currentIteration = 0;

            while (Condition()) 
            {
                if (testingIterations == 0)
                {
                    Console.Write("Would you like to roll? (y/n): ");
                    choice = Console.ReadLine()[0];
                }
                else
                {
                    choice = 'y';
                }

                if (choice == 'y')
                {
                    Die die = new Die();
                    die.Roll();
                    
                    if (testingIterations == 0)
                        Console.WriteLine($"Rolled a {die.value}");

                    dice.Add(die);
                }
                else if (choice != 'n')
                {
                    Console.WriteLine("Invalid input please try again.");
                }

                currentIteration++;
            }

            total = 0;
            foreach (Die die in dice)
                total += die.value;

            Console.WriteLine($"The total of the {dice.Count()} roll(s) is {total}");
        }
    }
}
