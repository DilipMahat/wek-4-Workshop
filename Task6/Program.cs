using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter marks: ");
        string marksInput = Console.ReadLine();

        Console.Write("Enter total marks: ");
        string totalInput = Console.ReadLine();

        if (int.TryParse(marksInput, out int marks) &&
            int.TryParse(totalInput, out int total))
        {
            if (total <= 0)
            {
                Console.WriteLine("Total marks must be greater than zero.");
                return;
            }

            // Breakpoint 1
            double percentage = (double)marks / total * 100;

            // Breakpoint 2
            Console.WriteLine("Percentage: " + percentage + "%");
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}