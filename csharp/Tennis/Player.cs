namespace Tennis
{
    public class Player
    {
        private string name;
        public int Score { get; private set; }

        public Player(string name)
        {
            this.name = name;
            Score = 0;
        }

        public void WonPoint()
        {
            Score++;
        }

    }
}
