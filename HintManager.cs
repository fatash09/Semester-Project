public class HintManager
{
    public bool HintUsed { get; private set; }

    public string GetHint(Puzzle puzzle)
    {
        HintUsed = true;
        return puzzle.Hint;
    }

    public void ResetHint()
    {
        HintUsed = false;
    }
}
