using Microsoft.VisualBasic;
using Spectre.Console;

internal class Program
{
    public static void Main(string[] args)
    {
        var menuChoices = new string[6] { "Sumar", "Restar", "Multiplicar", "Dividir", "Historico", "Exit" };

        string? respuesta;
        bool respuestaCorrecta;
        bool exit = false;
        int numberOne = 0;
        int numberTwo = 0;
        int resultado = 0;
        var initialDate = DateTime.UtcNow;
        List<string> historial = new List<string>();



        string name = GetName();

        do
            Menu(name);
        while (!exit);

        void Menu(string name)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"Hello {name.ToUpper()}. It's {initialDate}. This is your math's game. That's great that you're working on improving yourself\n");

            var choice = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                    .Title("What game would you like to play today? Choose from the options below:")
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
                    foreach (string juego in historial)
                    {

                        Console.WriteLine($"Juego {i} : " + juego);
                        i++;
                    }

                    break;

                case "Exit":
                    exit = true;
                    var finalDate = DateTime.UtcNow;
                    var time = finalDate - initialDate;
                    Console.WriteLine($"Has entrado a las {initialDate} y salido a las {finalDate}, estando un total de {time.TotalMinutes:F2}");
                    break;

            }
        }

        //-----------------------------------
        static void DivisionGame(string message)
        {
            Console.WriteLine(message);
        }

        static void MultiplicationGame(string message)
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

                if (int.Parse(result) == firstNumber * secondNumber)
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
        }

        static void SubtractionGame(string message)
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

                if (int.Parse(result) == firstNumber - secondNumber)
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
        }

        static void AdditionGame(string message)
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

                if (int.Parse(result) == firstNumber + secondNumber)
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
        }

        string GetName()
        {
            Console.WriteLine("Please type your name");
            var name = Console.ReadLine();
            return name;
        }
    }
}
