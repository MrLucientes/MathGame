using Microsoft.VisualBasic;
using Spectre.Console;
using MathGame;

internal class Program
{
    public static void Main(string[] args)
    {
        Menu menu = new Menu();
        Helpers help = new Helpers();

        string name = help.GetName();
        menu.showMenu(name);
    }
}
