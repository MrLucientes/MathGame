namespace MathGame
{
    internal class Helpers
    {
        internal static List<string> games = new List<string>();
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
            bool correct = false;
            string? name;
            do
            {

                Console.WriteLine("Please type your name");
                name = Console.ReadLine();
                if (name != "")
                {
                    correct = true;
                }
            } while (!correct);
            return name;
        }
        internal void AddToHistory(int gameScore, string gameType)
        {
            games.Add($"{DateTime.Now} - {gameType}: {gameScore} pts");
        }

        internal void PrintGames()
        {
            Console.Clear();
            Console.WriteLine("Games History");
            Console.WriteLine("---------------------------");
            foreach (var game in games)
            {
                Console.WriteLine(game);
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
    }
}