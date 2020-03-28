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

        public TennisGame2(string p1Name, string p2Name)
        {
            this.p1Name = p1Name;
            this.p2Name = p2Name;
        }

        public string GetScore()
        {
            var score = "";
            if (p1Score == p2Score && p1Score < 3)
            {
                if (p1Score == 0)
                    score = "Love";
                if (p1Score == 1)
                    score = "Fifteen";
                if (p1Score == 2)
                    score = "Thirty";
                score += "-All";
            }
            if (p1Score == p2Score && p1Score > 2)
                score = "Deuce";

            if (p1Score > 0 && p2Score == 0)
            {
                if (p1Score == 1)
                    p1Result = "Fifteen";
                if (p1Score == 2)
                    p1Result = "Thirty";
                if (p1Score == 3)
                    p1Result = "Forty";

                p2Result = "Love";
                score = p1Result + "-" + p2Result;
            }
            if (p2Score > 0 && p1Score == 0)
            {
                if (p2Score == 1)
                    p2Result = "Fifteen";
                if (p2Score == 2)
                    p2Result = "Thirty";
                if (p2Score == 3)
                    p2Result = "Forty";

                p1Result = "Love";
                score = p1Result + "-" + p2Result;
            }

            if (p1Score > p2Score && p1Score < 4)
            {
                if (p1Score == 2)
                    p1Result = "Thirty";
                if (p1Score == 3)
                    p1Result = "Forty";
                if (p2Score == 1)
                    p2Result = "Fifteen";
                if (p2Score == 2)
                    p2Result = "Thirty";
                score = p1Result + "-" + p2Result;
            }
            if (p2Score > p1Score && p2Score < 4)
            {
                if (p2Score == 2)
                    p2Result = "Thirty";
                if (p2Score == 3)
                    p2Result = "Forty";
                if (p1Score == 1)
                    p1Result = "Fifteen";
                if (p1Score == 2)
                    p1Result = "Thirty";
                score = p1Result + "-" + p2Result;
            }

            if (p1Score > p2Score && p2Score >= 3)
            {
                score = "Advantage player1";
            }

            if (p2Score > p1Score && p1Score >= 3)
            {
                score = "Advantage player2";
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

