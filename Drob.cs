using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    public class Drob
    {
        int chislitel;
        int znamenatel;
        public Drob(int chislitel, int znamenatel)
        {
            this.chislitel = chislitel;
            this.znamenatel = znamenatel;
        }

        public double ToDouble()
        {
            return (double)chislitel / znamenatel;
        }

        public static Drob operator * (Drob drob1, Drob drob2)
        {
            return new Drob(
                drob1.chislitel * drob2.chislitel,
                drob1.znamenatel * drob2.znamenatel
           );
        }
    }
}
