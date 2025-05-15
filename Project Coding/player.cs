public class Player
{
    public string Name { get; set; }
    public int Score { get; private set; }

    public Player(string name)
    {
        Name = name;
        Score = 0;
    }

    public void UpdateScore(int points)
    {
        Score += points;
    }
}
