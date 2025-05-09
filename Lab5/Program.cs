﻿using System;

class Program
{
    static void Main()
    {
        // Problem 1: 
        string[] seasons = { "Spring", "Summer", "Fall", "Winter" };
        foreach (string season in seasons)
        {
            Console.WriteLine($"Season: {season}");
        }

        Console.WriteLine(); // 

        // Problem 2: 
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        Console.Write("Enter a number (1–7): ");
        if (int.TryParse(Console.ReadLine(), out int dayNumber) && dayNumber >= 1 && dayNumber <= 7)
        {
            Console.WriteLine($"That day is: {days[dayNumber - 1]}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
        }

        Console.WriteLine(); // 

        // Problem 3: Favorite Books and Authors
        string[] books = { "The Hobbit", "Charlotte’s Web", "1984" };
        string[] authors = { "J.R.R. Tolkien", "E.B. White", "George Orwell" };
        for (int i = 0; i < books.Length; i++)
        {
            Console.WriteLine($"Book {i + 1}: {books[i]} by {authors[i]}");
        }

        Console.WriteLine(); // 

        // Problem 4: 
        int[] temperatures = { 65, 72, 78, 70, 68 };
        Array.Sort(temperatures);
        Console.Write("Sorted Temperatures: ");
        foreach (int temp in temperatures)
        {
            Console.Write($"{temp} ");
        }
        Console.WriteLine();
        Console.WriteLine($"Highest Temperature: {temperatures[^1]}");
        Console.WriteLine($"Lowest Temperature: {temperatures[0]}");

        Console.WriteLine(); // 

        // Problem 5:
        int[] countdown = { 5, 4, 3, 2, 1 };
        Array.Reverse(countdown);
        Console.Write("Countdown: ");
        for (int i = 0; i < countdown.Length; i++)
        {
            Console.Write($"{countdown[i]} ");
        }

        Console.WriteLine(); //
    }
}
