using System;

namespace CSharpDummy1.Drinks;

public class Americano
{
  public void Drink()
  {
    Console.WriteLine("You are drinking Americano");
  }
}

public class Espresso
{
  public void Drink()
  {
    Console.WriteLine("You are drinking Espresso");
  }
}

public static class StaticAmericano
{
  public static void DrinkStatic()
  {
    Console.WriteLine("You are drinking STATIC Americano");
  }
}