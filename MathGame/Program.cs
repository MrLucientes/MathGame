using Microsoft.VisualBasic;
using Spectre.Console;

internal class Program
{
    public static void Main(string[] args)
    {
        var menuChoices = new string[6] { "Sumar", "Restar", "Multiplicar", "Dividir", "Historico", "Exit" };
        var initialDate = DateTime.UtcNow;
        List<string> historial = new List<string>();

        string name = GetName();
        Menu(name);

        void Menu(string name)
        {
            bool exit = false;
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"Hello {name.ToUpper()}. It's {initialDate}. This is your math's game. That's great that you're working on improving yourself\n");
            do
            {
                var choice = AnsiConsole.Prompt(
                        new SelectionPrompt<string>()
                        .Title("¿Que reto te gustaría jugar? Elige entre las siguientes opciones:")
                                .AddChoices(menuChoices));

                switch (choice)
                {
                    case "Sumar":
                        AdditionGame("Addition selected");
                        break;

                    case "Restar":
                        SubtractionGame("Subtraction selected");
                        break;

                    case "Dividir":
                        DivisionGame("Division selected");
                        break;

                    case "Multiplicar":
                        MultiplicationGame("Multiplication selected");
                        break;

                    case "Historico":
                        int i = 1;
                        int gameScore = 0;
                        int totalScore = 0;
                        foreach (string juego in historial)
                        {
                            Console.WriteLine($"Juego {i} : " + juego);
                            i++;
                            int.TryParse(juego.Split(" ")[6], out gameScore);
                            totalScore += gameScore;
                        }
                        Console.WriteLine($"Has conseguido un total de {totalScore} puntos");
                        break;

                    case "Exit":
                        exit = true;
                        var finalDate = DateTime.UtcNow;
                        var time = finalDate - initialDate;
                        Console.WriteLine($"Has entrado a las {initialDate} y salido a las {finalDate}, estando un total de {time.TotalMinutes:F2}");
                        break;
                }
            } while (!exit);
        }

        //-----------------------------------
        void DivisionGame(string message)
        {
            Console.WriteLine(message);
            var score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);
                Random random = new Random();

                /*var divisionNumbers = Helpers.GetDivisionNumbers();
                var firstNumber = divisionNumbers[0];
                var secondNumber = divisionNumbers[1];*/
                int firstNumber = random.Next(1, 9);
                int secondNumber = random.Next(1, 9);

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
            addHistorial(score, message.Split(" ")[0]);
        }

        void MultiplicationGame(string message)
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

            addHistorial(score, message.Split(" ")[0]);
        }

        void SubtractionGame(string message)
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
            addHistorial(score, message.Split(" ")[0]);
        }

        void AdditionGame(string message)
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
            addHistorial(score, message.Split(" ")[0]);
        }

        string GetName()
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
        void addHistorial(int score, string game)
        {
            historial.Add($"La puntuacion en {game} fue de {score}");
        }
    }
}
