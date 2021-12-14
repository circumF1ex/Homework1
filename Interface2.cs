using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface ISelectDrobeAction
    {
        public static string AT { get; set; }

        public static string SAT(int value)
        {
            if (value != 1)
            {
                Program.Printer("Выбирите действие:" + "\n1. MATH" + "\n2. ToDecimal\n");
            }

            else
            {
                Program.Printer("Выбирите действие:" + "\n1. MATH\n");
            }

            AT = Console.ReadLine();
            return AT;
        }
    }
}
