using System;

namespace HD
{
  class Program
  {
    static void Main()
    {
      var tuple = MyExampleTuple();
      Console.WriteLine(tuple.Item1);

      (string name, int number, double value) = tuple;
      Console.WriteLine(number);
      Console.WriteLine(value);

      Console.ReadKey();
    }

    static (string, int, double) MyExampleTuple()
    {
      return ("Wow", 42, .001);
    }
  }
}
