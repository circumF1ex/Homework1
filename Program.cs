using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {

            drobes Drobe1 = new drobes(5);
            drobes Drobe2 = new drobes(5);

            drobes Drobe3 = Drobe1 + Drobe2;
            Console.WriteLine(Drobe3.ToDecimal());

        }
    }
}
