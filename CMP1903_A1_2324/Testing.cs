using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324 {
  /// <summary>
  /// Used for tesing the Die and Game classes work as intended.
  /// </summary>
  internal class Testing {
    /// <summary>
    /// Tests the Die class by rolling a die many times. <br/>
    /// Checks that each roll is between 1 and 6
    /// </summary>
    /// <param name="rolls">
    /// How many rolls to test the Die class with.
    /// </param>
    public void TestDie(int rolls) {
      Console.WriteLine($"Testing die with {rolls} roll(s)...");

      Die die = new Die();
      for (int i = 0; i < 32767; i++) {
        int roll = die.Roll();
        Debug.Assert(1 <= roll && roll <= 6, "Die roll out of expected range!"); // Roll between 1 and 6
      }
    }

    /// <summary>
    /// Tests the Game class by running the game with many rolls. <br/>
    /// Checks the real sum against the expected sum. <br/>
    /// Checks that the correct number of rolls occur.
    /// </summary>
    /// <param name="rolls">
    /// How many rolls to test the Game class with.
    /// </param>
    public void TestGame(int rolls) {
      Console.WriteLine($"Testing game with {rolls} roll(s)...");

      Game game = new Game(rolls);
      int result = game.Play();

      int expectedSum = 0;
      foreach (Die die in game.Dice) {
        expectedSum += die.Value;
      }

      Debug.Assert(expectedSum == result, "Result of game is not as expected!");
      Debug.Assert(rolls == game.RollsCompleted, "Result of game is not as expected!");
    }
  }
}
