using Spectre.Console;

var menuChoices = new string[4] { "Sumar", "Restar", "Multiplicar", "Dividir" };

string? respuesta;
bool respuestaCorrecta;
int numberOne = 0;
int numberTwo = 0;
int resultado = 0;

List<string> historial = new List<string>();

/*You need to create a Math game containing the 4 basic operations


The divisions should result on INTEGERS ONLY and dividends should go from 0 to 100. Example: Your app shouldn't present the division 7/2 to the user, since it doesn't result in an integer.

You should record previous games in a List and there should be an option in the menu for the user to visualize a history of previous games.


You don't need to record results on a database. Once the program is closed the results will be deleted.*/


var choice = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
        .Title("What do you want to do next?")
        .AddChoices(menuChoices));

/*if (choice == "Sumar")
{
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
            resultado = Sumar(numberOne, numberTwo);
        }
    }

    Console.WriteLine("La suma de {0} y {1} es {2}", numberOne,numberTwo,resultado);

}
*/
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
                resultado = Sumar(numberOne, numberTwo);
            }
        }

        Console.WriteLine("La suma de {0} y {1} es {2}", numberOne, numberTwo, resultado);

        break;

    case "Restar":
        Console.WriteLine("Te esperas iyoPuta");
        break;
    
}




int Sumar(int uno, int dos)
{
    int resultado = uno + dos;
    return resultado;
}

