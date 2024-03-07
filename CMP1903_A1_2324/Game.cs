using System;
using System.Collections.Generic;
using System.Linq;

namespace CMP1903_A1_2324 {
  /// <summary>
  /// A game in which you roll dice and the sum of those rolls is outputted.
  /// </summary>
  internal class Game {
    /// <summary>
    /// List of dice in the game.
    /// </summary>
    public List<Die> Dice = new List<Die>();

    /// <summary>
    /// Number of rolls completed in the most recent game.
    /// </summary>
    public int RollsCompleted = 0;

    /// <summary>
    /// Number of testing iterations to complete.
    /// </summary>
    private int _testingIterations = 0;

    /// <summary>
    /// Current testing iteration.
    /// </summary>
    private int _currentIteration = 0;

    /// <summary>
    /// Users current choice (y/n).
    /// </summary>
    private char _choice = ' ';

    /// <summary>
    /// Constructor for Game class.
    /// </summary>
    /// <param name="testingIterations">
    /// How many iterations to test the Game and Die class. <br/>
    /// 0 (default) for no testing.
    /// </param>
    public Game(int testingIterations = 0) {
      this._testingIterations = testingIterations;
    }

    /// <summary>
    /// Main function to play the game.
    /// </summary>
    /// <returns>
    /// Result of the game.
    /// </returns>
    public int Play() {
      RollsCompleted = 0;
      _currentIteration = 0;

      while (Condition()) {
        if (_testingIterations == 0) {
          Console.Write("Would you like to roll? (y/n): ");
          _choice = Console.ReadLine()[0];
        } else { // Testing enabled
          _choice = 'y';
        }

        if (_choice == 'y') {
          Die die = new Die();
          die.Roll();
          RollsCompleted++;

          if (_testingIterations == 0) { // Not testing
            Console.WriteLine($"Rolled a {die.Value}");
          }

          Dice.Add(die);
        } else if (_choice != 'n') {
          Console.WriteLine("Invalid input please try again.");
        }

        _currentIteration++;
      }

      int total = 0;
      foreach (Die die in Dice) {
        total += die.Value;
      }

      Console.WriteLine($"The total of the {Dice.Count()} roll(s) is {total}");

      return total;
    }

    /// <summary>
    /// Used to determine correct condition for the main game loop.
    /// </summary>
    /// <returns>
    /// Whether or not to continue the game.
    /// </returns>
    private bool Condition() {
      if (_testingIterations == 0) {
        return _choice != 'n';
      } else {
        return _testingIterations > _currentIteration;
      }
    }
  }
}
