using System.Collections.Generic;

namespace Tennis
{
    public class TennisGame2 : ITennisGame
    {
        private int p1Score;
        private int p2Score;

        private string p1Result = "";
        private string p2Result = "";
        private string p1Name;
        private string p2Name;
        private Dictionary<int, string> scoreNames = new Dictionary<int, string>() {
            { 0, "Love" },
            { 1, "Fifteen" },
            { 2, "Thirty" },
            { 3, "Forty" }};

        public TennisGame2(string p1Name, string p2Name)
        {
            this.p1Name = p1Name;
            this.p2Name = p2Name;
        }

        public string GetScore()
        {
            var score = "";
            if (p1Score == p2Score) return (p1Score < 3) ? scoreNames[p1Score] + "-All" : "Deuce";
            if (p1Score < 4) p1Result = scoreNames[p1Score];
            if (p2Score < 4) p2Result = scoreNames[p2Score];
            score = p1Result + "-" + p2Result;

            if (p1Score > 3 || p2Score > 3)
            {
                if (p1Score > p2Score) score = "Advantage player1";
                else score = "Advantage player2";
            }

            if (p1Score >= 4 && p2Score >= 0 && (p1Score - p2Score) >= 2)
            {
                score = "Win for player1";
            }
            if (p2Score >= 4 && p1Score >= 0 && (p2Score - p1Score) >= 2)
            {
                score = "Win for player2";
            }
            return score;
        }

        public void WonPoint(string player)
        {
            if(player == p1Name) p1Score++;
            if(player == p2Name) p2Score++;
        }

    }
}

