namespace MathGame.Models
{
    internal class Game
    {
        /*private int _score;
        public int Score
        {
            get { return _score; }
            set { _score = value; }
        }*/
        public DateTime Date { get; set; }
        public int Score { get; set; }

        public GameType? Type { set; get; }
    }

    internal enum GameType
    {
        Addition,
        Subtraction,
        Division,
        Multiplication,
        Historico,
        Exit
    }

}
