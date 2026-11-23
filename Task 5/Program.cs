using System;

enum DayType
{
    Weekday,
    Weekend
}

record Book(string title, string author, double price);

class Program
{
    static void Main(string[] args)
    {
        // Enum
        Console.Write("Enter a day: ");
        string day = Console.ReadLine();

        DayType type;

        if (day.Equals("Friday", StringComparison.OrdinalIgnoreCase) ||
            day.Equals("Saturday", StringComparison.OrdinalIgnoreCase))
        {
            type = DayType.Weekend;
        }
        else
        {
            type = DayType.Weekday;
        }

        Console.WriteLine("It is: " + type);


        // Record
        Book book1 = new Book("C# Basics", "John", 500);

        // Using with expression
        Book book2 = book1 with
        {
            title = "Advanced C#",
            price = 800
        };

        // Display first object
        Console.WriteLine("\nFirst Book:");
        Console.WriteLine(book1);

        // Deconstruct second object
        var (title, author, price) = book2;

        Console.WriteLine("\nSecond Book:");
        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: " + price);
    }
}