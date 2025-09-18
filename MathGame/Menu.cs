using Spectre.Console;

namespace MathGame
{
    internal class Menu
    {
        GameEngine engine = new GameEngine();
        Helpers help = new Helpers();
        bool fin = false;
        internal void showMenu(string name)
        {
            while (!fin)
            {
                var menuChoices = new string[6] { "Sumar", "Restar", "Multiplicar", "Dividir", "Historico", "Exit" };
                var initialDate = DateTime.UtcNow;

                Console.Clear();
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine($"Hello {name.ToUpper()}. It's {initialDate}. This is your math's game. That's great that you're working on improving yourself\n");

                var choice = AnsiConsole.Prompt(
                        new SelectionPrompt<string>()
                        .Title("¿Que reto te gustaría jugar? Elige entre las siguientes opciones:")
                        .AddChoices(menuChoices));

                switch (choice)
                {
                    case "Sumar":
                        engine.AdditionGame("Addition selected");
                        break;

                    case "Restar":
                        engine.SubtractionGame("Subtraction selected");
                        break;

                    case "Dividir":
                        engine.DivisionGame("Division selected");
                        break;

                    case "Multiplicar":
                        engine.MultiplicationGame("Multiplication selected");
                        break;

                    case "Historico":
                        help.PrintGames();
                        break;

                    case "Exit":
                        help.Salida(initialDate);
                        break;
                }
            }
        }
    }
}