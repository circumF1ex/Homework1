using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Drob d1 = new Drob(1, 2);
            Drob d2 = new Drob(2, 3);
            Drob d3 = d1 * d2;
            Console.WriteLine(d3.ToDouble());


            Console.WriteLine("Hello World!");

            drobes Drobe1 = new drobes(10, 5);
            Drobe1.Deconstruct2(drobes.Znamenat, drobes.Chislit);

            drobes Act1 = new drobes('+');
            Act1.DeconstructAct(drobes.Act);

            drobes Drobe2 = new drobes(10, 3);
            Drobe1.Deconstruct2(drobes.Znamenat, drobes.Chislit);

        }
    }
}
