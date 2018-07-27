namespace Tennis
{
    public class Player
    {
        private string name;
        private int points;

        public Player(string name)
        {
            this.name = name;
        }

        public void WonPoint()
        {
            points++;
        }
    }
}
