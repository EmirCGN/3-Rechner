using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("  _______                    _____                          _      \r\n |__   __|                  |  __ \\                        (_)     \r\n    | |_ __ ___ _   _  ___  | |__) | __ __ _  ___ _ __ ___  _  ___ \r\n    | | '__/ _ \\ | | |/ _ \\ |  ___/ '__/ _` |/ _ \\ '_ ` _ \\| |/ _ \\\r\n    | | | |  __/ |_| |  __/ | |   | | | (_| |  __/ | | | | | |  __/\r\n    |_|_|  \\___|\\__,_|\\___| |_|   |_|  \\__,_|\\___|_| |_| |_|_|\\___|\r\n                                                                   \r\n                                                                   ");

        Console.WriteLine("Wie viele Jahre Arbeiten Sie schon hier?");
        string jahre_str = Console.ReadLine();
        int jahre = Convert.ToInt32(jahre_str);

        if(jahre <= 3)
        {
            Console.WriteLine("Sie erhalten noch keine Prämie, da Sie weniger als drei Jahren arbeiten!");
        }
        else if(jahre >= 4 && jahre <= 10)
        {
            Console.WriteLine("Sie erhalten pro Jahr 150 EURO als Treueprämie!");
        }
        else if (jahre >= 10)
        {
            Console.WriteLine("Sie Erhalten zusätzlich zu den 150 EURO noch 10 EURO pro Jahr aufgeschlagen!");
        }
    }
}