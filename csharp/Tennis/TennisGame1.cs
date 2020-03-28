using System.Collections.Generic;

namespace Tennis
{
    class TennisGame1 : ITennisGame
    {
        private int player1Score = 0;
        private int player2Score = 0;
        private string player1Name;
        private string player2Name;

        private Dictionary<int,string> scoreNames = new Dictionary<int, string>() {
            { 0, "Love" },
            { 1, "Fifteen" },
            { 2, "Thirty" },
            { 3, "Forty" }};

        public TennisGame1(string player1Name, string player2Name)
        {
            this.player1Name = player1Name;
            this.player2Name = player2Name;
        }

        public void WonPoint(string playerName)
        {
            if (playerName == player1Name) player1Score ++;
            if (playerName == player2Name) player2Score++;
        }
        public string GetScore()
        {
            if (player1Score == player2Score) return GetEqualScore();
            else if (player1Score >= 4 || player2Score >= 4) return GetAdvantageScore();
            else return GetDefaultScore();
        }

        private string GetEqualScore()
        {
            return (player1Score >= 3) ? "Deuce" : scoreNames[player1Score] + "-All";

        }

        private string GetAdvantageScore()
        {
            int difference = player1Score - player2Score;
            if (difference == 1) return "Advantage " + player1Name;
            else if (difference == -1) return "Advantage " + player2Name;
            else if (difference >= 2) return "Win for " + player1Name;
            else return "Win for " + player2Name;
        }

        private string GetDefaultScore()
        {
            return scoreNames[player1Score] + "-" + scoreNames[player2Score];
        }
    }
}

