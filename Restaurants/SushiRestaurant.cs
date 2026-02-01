using System;

namespace CSharpDummy1.Restaurants;

public class SushiRestaurant1
{
  private static int customerCounts = 0;

  public SushiRestaurant1()
  {
    Console.WriteLine("One customer entered the restaurant!");
    customerCounts++;
    IncreaseCustomerCount();
  }

  public void PrintCustomerCounts()
  {
    Console.WriteLine("Customer Counts: " + customerCounts);
  }

  public void IncreaseCustomerCount()
  {
    customerCounts++;
  }
}