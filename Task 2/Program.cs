class Program
{
    static void Main(string[] args)
    {
        // Creating Calculator object
        Calculator calculator = new Calculator();

        // Calling welcome method
        calculator.PrintWelcome();

        // Calling Add method
        int sum = calculator.Add(10, 20);

        Console.WriteLine("Addition: " + sum);

        // Calling Multiply with two arguments
        int result1 = calculator.Multiply(5, 3);

        Console.WriteLine("Multiplication: " + result1);

        // Calling Multiply with one argument
        int result2 = calculator.Multiply(5);

        Console.WriteLine("Multiplication with default value: " + result2);
    }
}