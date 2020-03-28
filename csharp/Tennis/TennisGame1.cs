namespace Tennis
{
    class TennisGame1 : ITennisGame
    {
        private int player1Score = 0;
        private int player2Score = 0;
        private string player1Name;
        private string player2Name;

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

        private string GetEqualScore()
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
            var tempScore = 0;
            string score = "";
            for (var i = 1; i < 3; i++)
            {
                if (i == 1) tempScore = player1Score;
                else { score += "-"; tempScore = player2Score; }
                switch (tempScore)
                {
                    case 0:
                        score += "Love";
                        break;
                    case 1:
                        score += "Fifteen";
                        break;
                    case 2:
                        score += "Thirty";
                        break;
                    case 3:
                        score += "Forty";
                        break;
                }
            }
            return score;
        }

        public string GetScore()
        {
            if (player1Score == player2Score) return GetEqualScore();
            else if (player1Score >= 4 || player2Score >= 4) return GetAdvantageScore();
            else return GetDefaultScore();
        }
    }
}

