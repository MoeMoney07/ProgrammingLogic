using System;

class Program
{
  static void Main(string[] args)
  {
    // Problem 1: 
    Console.WriteLine("Problem 1:");
    for (int i = 1; i <= 10; i++)
    {
      Console.WriteLine(i);
    }

    Console.WriteLine(); // Spacer

    // Problem 2:
    Console.WriteLine("Problem 2:");
    for (int i = 1; i <= 20; i++)
    {
      if (i % 2 == 0)
      {
        Console.WriteLine(i);
      }
    }

    Console.WriteLine(); // Spacer

    // Problem 3: 
    Console.WriteLine("Problem 3:");
    int countdown = 5;
    while (countdown >= 1)
    {
      Console.WriteLine(countdown);
      countdown--;
    }

    Console.WriteLine(); // Spacer

    // Problem 4: 
    Console.WriteLine("Problem 4:");
    int number;
    do
    {
      Console.Write("Enter a number greater than 100: ");
      number = Convert.ToInt32(Console.ReadLine());
    } while (number <= 100);

    Console.WriteLine(); // Spacer

    // Problem 5: 
    Console.WriteLine("Problem 5:");
    int multiple = 10;
    while (multiple <= 1000)
    {
      Console.WriteLine(multiple);
      multiple += 10;
    }

    Console.WriteLine(); // Spacer

    // Problem 6:
    Console.WriteLine("Problem 6:");
    for (int i = 1; i <= 10; i++)
    {
      for (int j = 1; j <= i; j++)
      {
        Console.Write("*");
      }
      Console.WriteLine();
    }
  }
}
