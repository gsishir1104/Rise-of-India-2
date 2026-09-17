using System;
using RiseOfIndia2;

class Program
{
    static void Main()
    {
        PlayerData player = new PlayerData("Arjun");

        player.AddScore(10);

        Console.WriteLine("Player: " + player.PlayerName);
        Console.WriteLine("Score: " + player.Score);
    }
}