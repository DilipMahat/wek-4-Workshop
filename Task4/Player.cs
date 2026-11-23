namespace Task4;



class Player
{
    public string playerName;
    public int level;
    public int health;

    // Default constructor
    public Player()
    {
        Console.WriteLine("Default constructor has been called");
    }

    // Parameterized constructor
    public Player(string name, int playerLevel, int playerHealth)
    {
        playerName = name;
        level = playerLevel;
        health = playerHealth;
    }
}
