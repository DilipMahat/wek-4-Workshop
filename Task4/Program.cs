class Program
{
    static void Main(string[] args)
    {
        // Default constructor
        Player player1 = new Player();

        // Parameterized constructor
        Player player2 = new Player("Dilip", 10, 100);

        Console.WriteLine("\nPlayer 1:");
        Console.WriteLine(player1.playerName);
        Console.WriteLine(player1.level);
        Console.WriteLine(player1.health);

        Console.WriteLine("\nPlayer 2:");
        Console.WriteLine(player2.playerName);
        Console.WriteLine(player2.level);
        Console.WriteLine(player2.health);
    }
}