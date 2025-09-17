namespace MathGame
{
    internal class GameEngine
    {
        Helpers help = new Helpers();
        internal void DivisionGame(string message)
        {
            Console.WriteLine(message);
            var score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                var divisionNumbers = Helpers.GetDivisionNumbers();
                var firstNumber = divisionNumbers[0];
                var secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber}");
                var result = Console.ReadLine();

                if (int.TryParse(result, out int userResult) && userResult == firstNumber / secondNumber)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question");
                    Console.ReadLine();
                }

                if (i == 4) Console.WriteLine($"Game over. Your final score is {score}");
            }
            help.AddToHistory(score, message.Split(" ")[0]);
        }

        internal void MultiplicationGame(string message)
        {
            Console.WriteLine(message);

            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} * {secondNumber}");
                var result = Console.ReadLine();

                if (int.TryParse(result, out int userResult) && userResult == firstNumber * secondNumber)
                {
                    Console.WriteLine($"Your answer was correct.");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Your answer was incorrect.");
                }

                if (i == 4) Console.WriteLine($"Game over. Your final score is {score}");
            }

            help.AddToHistory(score, message.Split(" ")[0]);
        }

        internal void SubtractionGame(string message)
        {
            Console.WriteLine(message);

            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} - {secondNumber}");
                var result = Console.ReadLine();

                if (int.TryParse(result, out int userResult) && userResult == firstNumber - secondNumber)
                {
                    Console.WriteLine($"Your answer was correct.");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Your answer was incorrect.");
                }

                if (i == 4) Console.WriteLine($"Game over. Your final score is {score}");
            }
            help.AddToHistory(score, message.Split(" ")[0]);
        }

        internal void AdditionGame(string message)
        {
            Console.WriteLine(message);

            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} + {secondNumber}");
                var result = Console.ReadLine();

                if (int.TryParse(result, out int userResult) && userResult == firstNumber + secondNumber)
                {
                    Console.WriteLine($"Your answer was correct.");
                    score++;
                }
                else
                {
                    Console.WriteLine($"Your answer was incorrect.");
                }

                if (i == 4) Console.WriteLine($"Game over. Your final score is {score}");
            }
            help.AddToHistory(score, message.Split(" ")[0]);
        }

    }

}