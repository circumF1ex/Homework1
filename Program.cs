using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {

            drobes Drobe1 = new drobes(5, 10); //0.5
            drobes Drobe2 = new drobes(5, 20); //0.25

            drobes Drobe3 = Drobe1 + Drobe2; //0.75
            Console.WriteLine(Drobe3.ToDecimal());

            Console.ReadLine();
            Console.Clear();

            Drobe1 = new drobes(5, 8, 10); //5.8
            Drobe2 = new drobes(7, 10); //0.7

            Drobe3 = Drobe1 + Drobe2; //6.5
            Console.WriteLine(Drobe3.ToDecimal());

            Console.ReadLine();
            Console.Clear();

            drobes Drobe4 = new(100); //10
            drobes FinalResult = (Drobe1 + Drobe2) / Drobe3 * Drobe4 - Drobe2;
            Console.WriteLine(FinalResult.ToDecimal()); //99.3
        }
    }
}