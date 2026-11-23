class Program
{
    static void Main(string[] args)
    {
        // Creating object
        ParameterDemo demo = new ParameterDemo();

        // 1. Calling ref method
        int number = 20;

        demo.Increase(ref number);

        Console.WriteLine("Increased Number: " + number);


        // 2. Calling out method
        string fullname;

        demo.GetFullName(out fullname);

        Console.WriteLine("Full Name: " + fullname);


        // 3. Calling params method
        int result = demo.SumAll(10, 20, 30, 40, 50);

        Console.WriteLine("Total Sum: " + result);
    }
}