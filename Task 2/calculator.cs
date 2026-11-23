namespace Task_2;


class Calculator
{
    // Method 1: Void method
    public void PrintWelcome()
    {
        Console.WriteLine("Welcome to the Calculator");
    }

    // Method 2: Addition
    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    // Method 3: Multiplication with optional parameter
    public int Multiply(int num1, int num2 = 1)
    {
        return num1 * num2;
    }
}
