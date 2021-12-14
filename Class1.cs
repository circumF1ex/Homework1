using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class drobes
    {
        //Поля класса
        public int Znamenat;
        public int Chislit;
        //Конструкторы
        public drobes(int Chislit) { this.Chislit = Chislit; this.Znamenat = 1; }

        public drobes(int Chislit, int Znamenat ) {  this.Chislit = Chislit; this.Znamenat = Znamenat; }

        public drobes(int value, int Chislit, int Znamenat) { this.Chislit = value * Znamenat + Chislit; this.Znamenat = Znamenat; }
        //Методы: НОК и ТоDecimal
        public static void NOC(drobes Drobe1, drobes Drobe2)
        {
            int Maximum = Math.Max(Drobe1.Znamenat, Drobe2.Znamenat);
            int MaxStat = Maximum;
            int Minimum = Math.Min(Drobe1.Znamenat, Drobe2.Znamenat);

            if (Drobe1.Znamenat == Drobe2.Znamenat) { }
            else 
            { 
                while (Maximum % Minimum != 0)
                {
                    Maximum += MaxStat;
                }
                int multiply = Maximum / Minimum;

                if (Drobe1.Znamenat > Drobe2.Znamenat)
                {
                    Drobe1.Znamenat = Drobe1.Znamenat * multiply;
                    Drobe1.Chislit = Drobe1.Chislit * multiply;
                }
                else
                {
                    Drobe2.Znamenat = Drobe2.Znamenat * multiply;
                    Drobe2.Chislit = Drobe2.Chislit * multiply;
                }
            }
        }
        public double ToDecimal()
        {
            return (double)Chislit / Znamenat;
        }
        //операторы
        public static drobes operator +(drobes Drobe1, drobes Drobe2)
        {
            NOC(Drobe1, Drobe2);
            return new drobes(
                Drobe1.Chislit + Drobe2.Chislit,
                Drobe2.Znamenat + Drobe2.Znamenat
                );
        }
        public static drobes operator -(drobes Drobe1, drobes Drobe2)
        {
            NOC(Drobe1, Drobe2);
            return new drobes(
                Drobe1.Chislit - Drobe2.Chislit,
                Drobe2.Znamenat - Drobe2.Znamenat
                );
        }
        public static drobes operator /(drobes Drobe1, drobes Drobe2)
        {
            return new drobes(
                Drobe1.Chislit * Drobe2.Znamenat,
                Drobe2.Znamenat * Drobe2.Chislit
                );
        }
        public static drobes operator *(drobes Drobe1, drobes Drobe2)
        {
            return new drobes(
                Drobe1.Chislit * Drobe2.Chislit,
                Drobe2.Znamenat * Drobe2.Znamenat
                );
        }
    }
}
