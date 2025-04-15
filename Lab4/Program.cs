namespace Lab4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}
for (int i = 1; i <= 20; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}
int i = 5;
while (i >= 1)
{
    Console.WriteLine(i);
    i--;
}
int number;
do
{
    Console.Write("Enter a number greater than 100: ");
    number = Convert.ToInt32(Console.ReadLine());
} while (number <= 100);
int i = 10;
while (i <= 1000)
{
    Console.WriteLine(i);
    i += 10;
}
for (int i = 1; i <= 10; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
