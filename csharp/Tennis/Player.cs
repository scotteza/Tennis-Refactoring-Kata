namespace Tennis
{
    public class Player
    {
        public string Name { get; }
        // TODO: make this a score object
        public int Score { get; private set; }

        public Player(string name)
        {
            Name = name;
            Score = 0;
        }

        public void WonPoint()
        {
            Score++;
        }

    }
}
