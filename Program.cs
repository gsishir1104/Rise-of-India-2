using System;
using RiseOfIndia2;

class Program
{
    static void Main()
    {
        PlayerData player = new PlayerData("Arjun");

        Artifact artifact = new Artifact(
            "Ashoka Pillar",
            "A historical pillar from the Mauryan period.",
            250,
            20
        );

        player.AddScore(artifact.Points);
        artifact.Interact();

        Console.WriteLine("Player: " + player.PlayerName);
        Console.WriteLine("Artifact: " + artifact.Name);
        Console.WriteLine("Description: " + artifact.Description);
        Console.WriteLine("Historical Year: " + artifact.HistoricalYear);
        Console.WriteLine("Score: " + player.Score);
    }
}