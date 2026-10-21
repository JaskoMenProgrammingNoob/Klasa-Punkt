using System.Runtime.CompilerServices;
using System;
public class Program
{
    

    public static void Main(string[] args)
    {
        Punkt punkt = new Punkt();
        Punkt pomocniczy_punkt;
        pomocniczy_punkt = punkt.PobierzWspolrzedne();
        Console.WriteLine("Przed ustawieniem wartości: ");
        Console.WriteLine("Współrzędna x = " + pomocniczy_punkt.x);
        Console.WriteLine("Współrzędna y = " + pomocniczy_punkt.y);
        punkt.UstawWspolrzedne(1,2);
        pomocniczy_punkt = punkt.PobierzWspolrzedne();
        Console.WriteLine();
        Console.WriteLine("Po ustawieniem wartości: ");
        Console.WriteLine("Współrzędna x = " + pomocniczy_punkt.x);
        Console.WriteLine("Współrzędna y = " + pomocniczy_punkt.y);
    }

}
