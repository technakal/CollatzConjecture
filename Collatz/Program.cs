using System;

namespace Collatz
{
  class Program
  {
    static void Main(string[] args)
    {
      bool keepRunning = true;

      Console.WriteLine("*******************************************");
      Console.WriteLine();
      Console.WriteLine("Let's play with the Collatz Conjecture!");
      Console.WriteLine();
      Console.WriteLine("*******************************************");
      Console.WriteLine("It's a kind of math game where we determine how many steps it takes for any number to reach one, given the following rules:");
      Console.WriteLine("1. If a number is even, we divide the number by two.");
      Console.WriteLine("2. If a number is odd, we multiply the number by three and add one.");
      Console.WriteLine("*******************************************");

      while (keepRunning)
      {
        Console.WriteLine("Go ahead and enter a whole number and we'll see how long it takes to get to one.");
        Console.WriteLine("You can enter \"q\" to quit.");

        string input = Console.ReadLine();
        if (input.ToLower() == "q")
        {
          keepRunning = false;
          Console.WriteLine("Thanks for stopping by.");
          break;
        } 
        else
        {
          try
          {
            double value = Convert.ToDouble(input);
            Console.WriteLine(CalculateSteps(value));
            continue;
          }
          catch (FormatException)
          {
            Console.WriteLine("Invalid entry! You didn't enter a number in the right format.");
            continue;
          }
        }
      }
    }

    private static double CalculateSteps(double value)
    {
      if(value == 0)
      {
        return 0;
      }
      return CalculateSteps(value, 0);
    }

    private static double CalculateSteps(double value, double steps)
    {
      if(value == 1)
      {
        return steps;
      }
      if(value % 2 == 0)
      {
        return CalculateSteps(value / 2, steps+=1);
      }
      if(value % 2 != 0)
      {
        return CalculateSteps(value * 3 + 1, steps += 1);
      }
      return steps;
    }
  }
}
