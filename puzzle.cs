public class Puzzle
{
    public string Question { get; }
    public string Answer { get; }
    public string Hint { get; }

    public Puzzle(string question, string answer, string hint)
    {
        Question = question;
        Answer = answer.ToLower();
        Hint = hint;
    }

    public bool CheckAnswer(string userInput)
    {
        return userInput.ToLower() == Answer;
    }
}
