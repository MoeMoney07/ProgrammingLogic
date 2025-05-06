using System;

class Book
{
    private string title;
    private string author;

    // 
    public Book()
    {
        title = "Unknown Title";
        author = "Unknown Author";
    }

    // 
    public Book(string title)
    {
        this.title = title;
        author = "Unknown Author";
    }

    // 
    public Book(string title, string author)
    {
        this.title = title;
        this.author = author;
    }

    public string GetTitle()
    {
        return title;
    }

    public void SetTitle(string newTitle)
    {
        title = newTitle;
    }

    public string GetAuthor()
    {
        return author;
    }

    public void SetAuthor(string newAuthor)
    {
        author = newAuthor;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Problem 1:
        Book book1 = new Book();
        Console.WriteLine("Book 1 Title: " + book1.GetTitle());  // Output: Unknown Title
        book1.SetTitle("C# Fundamentals");
        Console.WriteLine("Book 1 Updated Title: " + book1.GetTitle());  // Output: C# Fundamentals

        // Problem 2: 
        Book book2 = new Book("Advanced C#");
        Console.WriteLine("Book 2 Title: " + book2.GetTitle());  // Output: Advanced C#

        // Problem 3: 
        Book book3 = new Book("Advanced C#", "John Doe");
        Console.WriteLine("Book 3 Title: " + book3.GetTitle());  // Output: Advanced C#
        Console.WriteLine("Book 3 Author: " + book3.GetAuthor());  // Output: John Doe

        // Problem 4: 
        Book book4 = new Book();
        book4.SetTitle("Mastering C#");
        book4.SetAuthor("Jane Smith");
        Console.WriteLine("Book 4 Title: " + book4.GetTitle());  // Output: Mastering C#
        Console.WriteLine("Book 4 Author: " + book4.GetAuthor());  // Output: Jane Smith
    }
}
