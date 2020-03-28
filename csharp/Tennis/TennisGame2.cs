using System.Collections.Generic;
using System;

namespace Tennis
{
    public class TennisGame2 : ITennisGame
    {
        private int p1Score;
        private int p2Score;
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
            if (p1Score == p2Score) return (p1Score < 3) ? scoreNames[p1Score] + "-All" : "Deuce";
            if (p1Score < 4 && p2Score < 4) return scoreNames[p1Score] + "-" + scoreNames[p2Score];
            if (Math.Abs(p1Score - p2Score) == 1) return (p1Score > p2Score) ? "Advantage " + p1Name : "Advantage " + p2Name;
            return (p1Score > p2Score) ? "Win for " + p1Name : "Win for " + p2Name;
        }

        public void WonPoint(string player)
        {
            if(player == p1Name) p1Score++;
            if(player == p2Name) p2Score++;
        }
    }
}

