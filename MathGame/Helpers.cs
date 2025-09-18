using MathGame.Models;

namespace MathGame
{
    internal class Helpers
    {
        internal static List<Game> games = new List<Game>()
        {
            /*new Game { Date = DateTime.Now.AddDays(1), Type = GameType.Addition, Score = 5 },
            new Game { Date = DateTime.Now.AddDays(2), Type = GameType.Multiplication, Score = 4 },
            new Game { Date = DateTime.Now.AddDays(3), Type = GameType.Division, Score = 4 },
            new Game { Date = DateTime.Now.AddDays(4), Type = GameType.Subtraction, Score = 3 },
            new Game { Date = DateTime.Now.AddDays(5), Type = GameType.Addition, Score = 1 },
            new Game { Date = DateTime.Now.AddDays(6), Type = GameType.Multiplication, Score = 2 },
            new Game { Date = DateTime.Now.AddDays(7), Type = GameType.Division, Score = 3 },
            new Game { Date = DateTime.Now.AddDays(8), Type = GameType.Subtraction, Score = 4 },
            new Game { Date = DateTime.Now.AddDays(9), Type = GameType.Addition, Score = 4 },
            new Game { Date = DateTime.Now.AddDays(10), Type = GameType.Multiplication, Score = 1 },
            new Game { Date = DateTime.Now.AddDays(11), Type = GameType.Subtraction, Score = 0 },
            new Game { Date = DateTime.Now.AddDays(12), Type = GameType.Division, Score = 2 },
            new Game { Date = DateTime.Now.AddDays(13), Type = GameType.Subtraction, Score = 5 },*/
        };
        internal static int[] GetDivisionNumbers()
        {
            var random = new Random();
            int firstNumber, secondNumber;

            do
            {
                firstNumber = random.Next(1, 99);
                secondNumber = random.Next(1, 99);
            } while (firstNumber % secondNumber != 0);

            return new int[] { firstNumber, secondNumber };


        }
        internal string GetName()
        {
            string? name;
            do
            {
                Console.WriteLine("Please type your name");
                name = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(name));
            return name;
        }
        internal void AddToHistory(int gameScore, GameType gameType)
        {
            games.Add(new Game
            {
                Date = DateTime.UtcNow,
                Score = gameScore,
                Type = gameType,

            });
        }

        internal void PrintGames()
        {
            var gamesToPrint = games.Where(x => x.Type == GameType.Division);

            Console.Clear();
            Console.WriteLine("Games History");
            Console.WriteLine("---------------------------");
            foreach (var game in gamesToPrint)
            {
                Console.WriteLine($"{game.Date} - {game.Type} : {game.Score} pts");
            }
            Console.WriteLine("---------------------------\n");
            Console.WriteLine("Press any key to return to Main Menu");
            Console.ReadLine();
        }
        internal void Salida(DateTime initialDate)
        {

            var finalDate = DateTime.UtcNow;
            var time = finalDate - initialDate;
            Console.WriteLine($"Has entrado a las {initialDate} y salido a las {finalDate}, estando un total de {time.TotalMinutes:F2}");
            Environment.Exit(0);
        }

        internal static string? ValidateResults(string? result)
        {
            while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
            {
                Console.WriteLine($"Your answer needs to be a Integer. Try Again!");
                result = Console.ReadLine();
            }

            return result;
        }
    }
}