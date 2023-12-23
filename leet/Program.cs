using System;
using System.Collections.Generic;
using System.Linq;

public class Program {
  public static void Main() {
    for(int i = 0; i < 200; i++) {
      Console.WriteLine(FizzBuzz(i));
    }
  }

  private static string FizzBuzz(int i) {
    return (i % 3, i % 5) switch {
      (0, 0) => "FizzBuzz",
      (0, _) => "Fizz",
      (_, 0) => "Buzz",
      (_, _) => i.ToString()
    };
  }
}
