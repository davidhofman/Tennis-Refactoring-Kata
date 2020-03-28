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
            string scoreName;
            if ((p2Score < 4 && p1Score < 4) && (p2Score + p1Score < 6))
            {
                string[] scoreNames = { "Love", "Fifteen", "Thirty", "Forty" };
                scoreName = scoreNames[p2Score];
                return (p2Score == p1Score) ? scoreName + "-All" : scoreName + "-" + scoreNames[p1Score];
            }
            else
            {
                if (p2Score == p1Score)
                    return "Deuce";
                scoreName = p2Score > p1Score ? p1Name : p2Name;
                return ((p2Score - p1Score) * (p2Score - p1Score) == 1) ? "Advantage " + scoreName : "Win for " + scoreName;
            }
        }

        public void WonPoint(string playerName)
        {
            if (playerName == "player1")
                this.p2Score += 1;
            else
                this.p1Score += 1;
        }

    }
}

