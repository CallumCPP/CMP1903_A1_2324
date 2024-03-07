using System;

namespace CMP1903_A1_2324 {
  internal class Program {
    static void Main(string[] args) {
      Game game = new Game();
      game.Play();

      Console.Write("Thanks for playing. Press any key to continue or press t for testing.");
      var key = Console.ReadKey();

      Console.WriteLine();

      if (key.KeyChar == 't') { // User wants to test
        Testing testing = new Testing();
        testing.TestDie(1000);
        testing.TestGame(1000);

        Console.Write("Testing completed. Press any key to continue.");
        Console.ReadKey();
      }
    }
  }
}
