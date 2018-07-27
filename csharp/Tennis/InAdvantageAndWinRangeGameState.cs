namespace Tennis
{
    internal class InAdvantageAndWinRangeGameState : GameState
    {
        public InAdvantageAndWinRangeGameState(Player player1, Player player2) : base(player1, player2)
        {
        }

        public override string GetScore()
        {
            var minusResult = player1.Score - player2.Score;
            if (minusResult == 1)
            {
                return "Advantage player1";
            }
            else if (minusResult == -1)
            {
                return "Advantage player2";
            }
            else if (minusResult >= 2)
            {
                return "Win for player1";
            }
            else
            {
                return "Win for player2";
            }
        }
    }
}