using System;



class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Bitte geben Sie Ihre Körpergröße ein:");
        double Größe = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Bitte geben Sie Ihr aktuelles Gewicht ein:");
        double Gewicht = Convert.ToDouble(Console.ReadLine());

        double bmi = Gewicht / (Größe*Größe);

        if (bmi < 18.5)
        {
            Console.WriteLine("Sie sind Untergewichtig");
        }
        else if(bmi >= 18.5 && bmi <= 24.9)
        {
            Console.WriteLine("Sie haben ein Normalgewicht");
        }
        else 
        {
            Console.WriteLine("Sie sind Übergewichtig");
        }
    }
}