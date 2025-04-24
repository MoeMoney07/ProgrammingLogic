using System;

class Program
{
    static void Main(string[] args)
    {
        // Part 1: Variable Declarations
        int myInt = 25;
        double myDouble = 3.14;
        float myFloat = 2.71f;
        char myChar = 'A';
        bool myBool = true;
        string myString = "Hello, World!";

        Console.WriteLine("int: " + myInt);
        Console.WriteLine("double: " + myDouble);
        Console.WriteLine("float: " + myFloat);
        Console.WriteLine("char: " + myChar);
        Console.WriteLine("bool: " + myBool);
        Console.WriteLine("string: " + myString);

        // Part 2: Type Casting
        double castDouble = 9.78;
        int castToInt = (int)castDouble;

        Console.WriteLine("Original double: " + castDouble);
        Console.WriteLine("Cast to int: " + castToInt);

        int intValue = 123;
        string intToString = Convert.ToString(intValue);
        bool boolValue = false;
        string boolToString = Convert.ToString(boolValue);

        Console.WriteLine("int to string: " + intToString);
        Console.WriteLine("bool to string: " + boolToString);

        // Part 3: User Input and Type Conversion
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Hello, " + name + "! You are " + age + " years old.");

        // Part 4: Arithmetic Operators
        int num1 = 20;
        int num2 = 5;

        Console.WriteLine("Addition (num1 + 10): " + (num1 + 10));
        Console.WriteLine("Subtraction (num2 - 2): " + (num2 - 2));
        Console.WriteLine("Multiplication (num1 * 3): " + (num1 * 3));
        Console.WriteLine("Division (num1 / 2): " + (num1 / 2));
        Console.WriteLine("Modulus (num2 % 2): " + (num2 % 2));

        // Part 5: Floating Point Precision
        float floatPrecision = 1.123456789f;
        double doublePrecision = 1.123456789;

        Console.WriteLine("Float value: " + floatPrecision);
        Console.WriteLine("Double value: " + doublePrecision);

        // Part 6: Increment and Decrement
        int counter = 10;
        counter++;
        Console.WriteLine("After increment: " + counter);
        counter--;
        Console.WriteLine("After decrement: " + counter);
    }
}
