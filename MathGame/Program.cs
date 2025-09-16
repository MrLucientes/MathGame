using Spectre.Console;

var menuChoices = new string[6] { "Sumar", "Restar", "Multiplicar", "Dividir", "Historico","Exit" };

string? respuesta;
bool respuestaCorrecta;
bool exit = false;
int numberOne = 0;
int numberTwo = 0;
int resultado = 0;

List<string> historial = new List<string>();

do
{
    var choice = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
            .Title("What do you want to do next?")
            .AddChoices(menuChoices));


    switch (choice)
    {
        case "Sumar":
            Console.WriteLine("Elige un numero que quieras sumar");

            respuesta = Console.ReadLine();
            respuestaCorrecta = int.TryParse(respuesta, out numberOne);
            if (respuestaCorrecta)
            {
                Console.WriteLine("Ahora el segundo numero que quieres sumar");
                respuesta = Console.ReadLine();
                respuestaCorrecta = int.TryParse(respuesta, out numberTwo);
                if (respuestaCorrecta)
                {
                    resultado = numberOne + numberTwo;
                }
            }
            historial.Add($"{choice} = {resultado}");
            Console.WriteLine("La suma de {0} y {1} es {2}", numberOne, numberTwo, resultado);

            break;

        case "Restar":
            Console.WriteLine("Elige un numero que quieras restar");

            respuesta = Console.ReadLine();
            respuestaCorrecta = int.TryParse(respuesta, out numberOne);
            if (respuestaCorrecta)
            {
                Console.WriteLine("Ahora el segundo numero que quieres emplear");
                respuesta = Console.ReadLine();
                respuestaCorrecta = int.TryParse(respuesta, out numberTwo);
                if (respuestaCorrecta)
                {
                    resultado = numberOne - numberTwo;
                }
            }
            historial.Add($"{choice} = {resultado}");
            Console.WriteLine("La resta de {0} y {1} es {2}", numberOne, numberTwo, resultado);
            break;

        case "Dividir":
            bool cero = false;
            do
            {
                Console.WriteLine("Elige un dividendo");

                respuesta = Console.ReadLine();
                respuestaCorrecta = int.TryParse(respuesta, out numberOne);
                if (respuestaCorrecta)
                {
                    Console.WriteLine("Ahora el divivisor pero solo uno cuyo resto sea 0, y este entre 0 y 100");
                    respuesta = Console.ReadLine();
                    respuestaCorrecta = int.TryParse(respuesta, out numberTwo);
                    if (respuestaCorrecta)
                    {
                        if (numberOne % numberTwo == 0 && numberTwo < 100 && numberOne > 0)
                        {
                            resultado = numberOne / numberTwo;
                            cero = true;
                        }
                        else
                            Console.WriteLine("Error!!!!!");
                    }
                }
            } while (!cero);
            historial.Add($"{choice} = {resultado}");
            Console.WriteLine("La division de {0} y {1} es {2}", numberOne, numberTwo, resultado);
            break;

        case "Multiplicar":
            Console.WriteLine("Elige un numero que quieras multiplicar");

            respuesta = Console.ReadLine();
            respuestaCorrecta = int.TryParse(respuesta, out numberOne);
            if (respuestaCorrecta)
            {
                Console.WriteLine("Ahora el segundo numero que quieres emplear");
                respuesta = Console.ReadLine();
                respuestaCorrecta = int.TryParse(respuesta, out numberTwo);
                if (respuestaCorrecta)
                {
                    resultado = numberOne * numberTwo;
                }
            }
            historial.Add($"{choice} = {resultado}");
            Console.WriteLine("La multiplicación de {0} y {1} es {2}", numberOne, numberTwo, resultado);
            break;

        case "Historico":

            foreach (string juego in historial)
            {
                int i = 1;
                Console.WriteLine($"Juego {i} : " + juego);
                i++;
            }

            break;

        case "Exit":
            exit = true;
            break;

    }
} while (!exit);



