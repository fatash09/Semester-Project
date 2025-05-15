using System;
using System.Collections.Generic;

public class GameEngine
{
    private Player player;
    private List<Puzzle> puzzles;
    private HintManager hintManager;

    public GameEngine(Player player, List<Puzzle> puzzles)
    {
        this.player = player;
        this.puzzles = puzzles;
        this.hintManager = new HintManager();
    }

    public void StartGame()
    {
        Console.WriteLine($"Welcome {player.Name}! Let’s begin the adventure.\n");

        foreach (var puzzle in puzzles)
        {
            PlayPuzzle(puzzle);
        }

        Console.WriteLine("\n🎉 Game Over! Thanks for playing.");
    }

    private void PlayPuzzle(Puzzle puzzle)
    {
        Console.WriteLine($"Puzzle: {puzzle.Question}");
        Console.Write("Need a hint? (yes/no): ");
        string choice = Console.ReadLine().ToLower();

        if (choice == "yes")
        {
            Console.WriteLine("Hint: " + hintManager.GetHint(puzzle));
        }

        Console.Write("Enter your answer: ");
        string userAnswer = Console.ReadLine();

        if (puzzle.CheckAnswer(userAnswer))
        {
            int points = hintManager.HintUsed ? 5 : 10;
            player.UpdateScore(points);
            Console.WriteLine($"✅ Correct! You earned {points} points.\n");
        }
        else
        {
            Console.WriteLine("❌ Incorrect.\n");
        }

        hintManager.ResetHint();
    }
}
