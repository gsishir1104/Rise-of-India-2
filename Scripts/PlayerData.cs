namespace RiseOfIndia2
{
    public class PlayerData
    {
        public string PlayerName;
        public int Score;

        public PlayerData(string playerName)
        {
            PlayerName = playerName;
            Score = 0;
        }

        public void AddScore(int points)
        {
            Score += points;
        }
    }
}