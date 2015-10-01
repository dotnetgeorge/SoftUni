namespace MinesweeperApp
{
    public class Leaderboard
    {
        private string name;
        private int points;

        public Leaderboard()
        {
        }

        public Leaderboard(string name, int points)
        {
            this.Player = name;
            this.Points = points;
        }

        public string Player
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Points
        {
            get
            {
                return points;
            }

            set
            {
                points = value;
            }
        }
    }
}
