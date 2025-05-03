using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Player player = new Player(name);
        List<Puzzle> puzzles = new List<Puzzle>
        {
            new Puzzle("I speak without a mouth and hear without ears. What am I?", "echo", "It's a sound."),
            new Puzzle("I have keys but no locks. What am I?", "piano", "It makes music."),
            new Puzzle("What disappears as soon as you say its name?", "silence", "You break it when you speak.")
        };

        GameEngine engine = new GameEngine(player, puzzles);
        Leaderboard leaderboard = new Leaderboard();

        engine.StartGame();
        leaderboard.Update(player);
        leaderboard.Display();
    }
}
