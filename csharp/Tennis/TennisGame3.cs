using System;

namespace Tennis
{
    public class TennisGame3 : ITennisGame
    {
        private int p1Score;
        private int p2Score;
        private string p1Name;
        private string p2Name;

        public TennisGame3(string player1Name, string player2Name)
        {
            this.p1Name = player1Name;
            this.p2Name = player2Name;
        }

        public string GetScore()
        {
            return ((p2Score < 4 && p1Score < 4) && (p2Score + p1Score < 6)) ? GetScoreFirstPhase() : GetScoreSecondPhase();
        }

        public void WonPoint(string playerName)
        {
            if (playerName == p1Name) p1Score ++;
            else p2Score ++;
        }

        private string GetScoreFirstPhase()
        {
            string[] scoreNames = { "Love", "Fifteen", "Thirty", "Forty" };
            string p1ScoreName = scoreNames[p1Score];
            return (p2Score == p1Score) ? p1ScoreName + "-All" : p1ScoreName + "-" + scoreNames[p2Score];
        }

        private string GetScoreSecondPhase()
        {
            if (p2Score == p1Score) return "Deuce";
            string leadingPlayer = p1Score > p2Score ? p1Name : p2Name;
            return (Math.Abs(p1Score - p2Score) == 1) ? "Advantage " + leadingPlayer : "Win for " + leadingPlayer;
        }

    }
}

