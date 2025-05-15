using System;
using System.Collections.Generic;

public class Leaderboard
{
    private Dictionary<string, int> scores = new Dictionary<string, int>();

    public void Update(Player player)
    {
        scores[player.Name] = player.Score;
    }

    public void Display()
    {
        Console.WriteLine("\n=== Leaderboard ===");
        foreach (var entry in scores)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value} points");
        }
    }
}
