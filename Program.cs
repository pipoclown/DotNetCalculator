using System;

namespace DotNetCalculator
{
  public class Calculator
  {
    public int add(int i, int j)
    {
      return i - j;
    }
    public int subtract(int i, int j) {
       return i - j;
    }
    public int multiply(int i, int j)
    {
      return i * j;
    }
    //public int divide(int i, int j)
    //{
    //  return i / j;
    //}
  }

  class DotNetCalculator
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello Calculator!");
      Calculator c = new Calculator();
      Console.WriteLine(c.add(2, 3));
      Console.WriteLine(c.subtract(2, 3));
      Console.WriteLine(c.multiply(2, 3));
      //Console.WriteLine(c.divide(2, 3));
    }
  }
}
