using System;

namespace Tennis
{
    public abstract class GameState
    {
        protected readonly int player1Score;
        private readonly int player2Score;

        public static GameState GetGameState(int player1Score, int player2Score)
        {
            if (player1Score == player2Score)
            {
                return new EqualScoreState(player1Score, player2Score);
            }

            return null;
        }

        protected GameState(int player1Score, int player2Score)
        {
            this.player1Score = player1Score;
            this.player2Score = player2Score;
        }

        public abstract string GetScore();
    }

    class EqualScoreState : GameState
    {
        public override string GetScore()
        {
            switch (player1Score)
            {
                case 0:
                    return "Love-All";
                case 1:
                    return "Fifteen-All";
                case 2:
                    return "Thirty-All";
                default:
                    return "Deuce";
            }
        }

        public EqualScoreState(int player1Score, int player2Score) : base(player1Score, player2Score)
        {
        }
    }
}
