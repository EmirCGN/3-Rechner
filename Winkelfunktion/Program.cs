using System;



class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Winkelfunktion-Rechner");
        Console.WriteLine("Welche der folgenden Winkelfunktionen wollen Sie berechnen?");
        Thread.Sleep(2000);

        Console.WriteLine("1. Cosinus \n2. Sinus \n3. Tangens");
        string menu = Console.ReadLine();

        Console.WriteLine("Bitte geben Sie den Winkelgrad ein");
        string auswahl_str = Console.ReadLine();
        double auswahl = Convert.ToDouble(auswahl_str);

        if (menu == "Cosinus")
        {
            double erg = Math.Cos(auswahl);
            Console.WriteLine("Ihr Ergebnis ist: {0}", erg);
        }
        else if (menu == "Sinus")
        {
             double erg = Math.Sin(auswahl);
            Console.WriteLine("Ihr Ergebnis ist: {0}", erg);
        }
         else if (menu == "Tangens")
        {
             double erg = Math.Tan(auswahl);
            Console.WriteLine("Ihr Ergebnis ist: {0}", erg);
        }
    }
}