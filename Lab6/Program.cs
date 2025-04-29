using System;

class Car
{
    public string model;
    public string color;
    public int year;

    // Example method to display car details
    public void Display()
    {
        Console.WriteLine("Car Details:");
        Console.WriteLine("Model: " + model);
        Console.WriteLine("Color: " + color);
        Console.WriteLine("Year: " + year);
    }

    // Problem 1: Method with No Parameters
    public void Start()
    {
        Console.WriteLine("The car is starting.");
    }

    // Problem 2: Method with Parameters
    public void Drive(int miles)
    {
        Console.WriteLine($"The car drove {miles} miles.");
    }

    // Problem 3: Method with a Return Value
    public string GetDescription()
    {
        return $"{year} {color} {model}";
    }

    // Problem 4: Method that Updates a Field
    public void Repaint(string newColor)
    {
        color = newColor;
        Console.WriteLine($"The car has been repainted to {color}.");
    }
}

class Program
{
    static void Main()
    {
        // Creating a Car object and assigning values to its properties
        Car myCar = new Car();
        myCar.model = "Civic";
        myCar.color = "Black";
        myCar.year = 2020;

        // Display car details
        myCar.Display(); 

        // Problem 1: Start the car
        myCar.Start(); 

        // Problem 2: Drive the car
        myCar.Drive(50); 

        // Problem 3: Get car description
        string description = myCar.GetDescription();
        Console.WriteLine("Car Description: " + description); 

        // Problem 4: Repaint the car
        myCar.Repaint("Red"); 
    }
}
