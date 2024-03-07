using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324 {
  /// <summary>
  /// Mimics a six sided die.
  /// </summary>
  internal class Die {
    /// <summary>
    /// Random number generator for the Die.
    /// </summary>
    private static readonly Random _random = new Random(); // readonly rather than const as Randoms constructor uses the a time based 
                                                           // value as the seed and const fields are set at build time.
    /// <summary>
    /// Stores the current value of the Die.
    /// </summary>
    public int Value = 0;

    /// <summary>
    /// Rolls the Die.
    /// </summary>
    /// <returns>
    /// Result of the roll.
    /// </returns>
    public int Roll() {
      Value = (_random.Next() % 6) + 1;
      return Value;
    }
  }
}
