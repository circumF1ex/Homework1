using System;
#pragma warning disable CS1717 // Назначение выполнено для той же переменной
/* 
  
   Получить из дроби число в десятичном виде

   Математические операции

   Получить знак дроби

   Перед изменением числителя и знаменателя генерировать соответствующее событие и вызывать метод,
   в первый аргумент которого передается экземпляр класса дроби, а во второй присваиваемое значение.
   Вызываемый метод событием не должен находится в созданном Вами классе.

   Обратившись по индексу получить числитель и знаменатель

 */
namespace ConsoleApp1
{
    interface ISelectDrobeType
    {
        public static string DT { get; set; }
        public static string SDT()
        {
            Console.WriteLine("Тип вводимой дроби:" + "\n1. Десятичная" + "\n2. Правильная" + "\n3. Неправильная" + "\n");
            DT = Console.ReadLine();
            return DT;
        }
    }

    interface ISelectDrobeAction
    {
        public static string AT { get; set; }

        public static string SAT(int value)
        {
            if (value != 1)
            {
                Console.WriteLine("Выбирите действие:" + "\n1. MATH" + "\n2. ToDecimal\n");
            }
            
            else
            {
                Console.WriteLine("Выбирите действие:" + "\n1. MATH\n");
            }

            AT = Console.ReadLine();
            return AT;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Drobes.DrobeInpt();
            Drobes.ActInpt(Drobes.caseselected);
        }
    }

    class Drobes : ISelectDrobeType, ISelectDrobeAction
    {
        public static double DecimalDrobe = 0;
        public static int Celoe = 0;
        public static int Chislit = 0;
        public static int Znamenat = 0;
        public static int multiply = 0;

        public static int caseselected = 0;


       /* public Drobes(double DecimalDrobe) { DecimalDrobe = DecimalDrobe; }

        public Drobes(int Celoe, int Chislit, int Znamenat ) { Celoe = Celoe;  Chislit = Chislit; Znamenat = Znamenat; }
        public Drobes(int Chislit, int Znamenat) { Chislit = Chislit; Znamenat = Znamenat; }
       */

        public static void DrobeInpt() //Ввод дроби
        {
            ISelectDrobeType.SDT();

            switch (ISelectDrobeType.DT)
            {
                case "1":
                    caseselected = 1;
                    Console.WriteLine("Введите десятичную дробь");
                    DecimalDrobe = Math.Round(Double.Parse(Console.ReadLine()),1);
                    //Drobes DD = new (DecimalDrobe);
                    
                    Console.WriteLine(DecimalDrobe);
                    Convertor(caseselected);
                    break;

                case "2":
                    caseselected = 2;
                    Console.WriteLine("Введите правильную дробь");
                    Console.Write("Введите целую часть:");
                    Celoe = int.Parse(Console.ReadLine());
                    Console.Write("Введите числитель:");
                    Chislit = int.Parse(Console.ReadLine());
                    Console.Write("Введите знаменатель:");
                    Znamenat = int.Parse(Console.ReadLine());
                    //Drobes RD = new(Celoe, Chislit, Znamenat);

                    Console.WriteLine($"{Celoe} {Znamenat}/{Chislit}");
                    
                    break;

                case "3":
                    caseselected = 3;
                    Console.Write("Введите числитель:");
                    Chislit = int.Parse(Console.ReadLine());
                    Console.Write("Введите знаменатель:");
                    Znamenat = int.Parse(Console.ReadLine());
                    
                    //Drobes WD = new(Chislit, Znamenat);

                    Console.WriteLine($"{Znamenat}/{Chislit}");
                    break;

                default:
                    break;
            }
        } 
        public static void ActInpt(int value) //Ввод действия над дробью
        {
            ISelectDrobeAction.SAT(caseselected);

            switch (ISelectDrobeAction.AT)
            {
                case "1":
                    Console.Write("Введите математическое действие: ");
                    char MathAct = char.Parse(Console.ReadLine());
                    Convertor(caseselected);
                    MathActs(Chislit, Znamenat, MathAct);
                    break;
                case "2":
                    Console.Clear();
                    ToDecimal(caseselected);
                    break;
            }
        }

        public static void MathActs(int value3, int value4, char value5) //Сделать НОД!?
        {

            int ChislitM = value3;
            int ZnamenatM = value4;

            Console.Clear();

            DrobeInpt();
            Convertor(caseselected);
            NOC(ChislitM, Chislit);

            if (ChislitM > Chislit)
            {
                Chislit = Chislit * multiply;
                Znamenat = Znamenat * multiply;
            }
            else
            {
                ChislitM = ChislitM * multiply;
                ZnamenatM = ZnamenatM * multiply;
            }

            switch (value5)
            {
                case '+':
                    Console.WriteLine($"Результат сложения: {(ZnamenatM + Znamenat)/multiply}/{(Math.Max(ChislitM, Chislit))/multiply}");
                    break;
                case '-':
                    Console.WriteLine($"Результат сложения: {(ZnamenatM - Znamenat)/multiply}/{(Math.Max(ChislitM, Chislit))/multiply}");
                    break;
                case '*':
                    Console.WriteLine($"Результат умножения: {(ZnamenatM * Znamenat)/multiply}/{(ChislitM * Chislit) / multiply}");
                    break;
                case '/':
                    Console.WriteLine($"Результат деления: {(ZnamenatM * Chislit)/multiply}/{(ChislitM * Znamenat)/multiply}");
                    break;
                default:
                    break;
            }
        }
        public static int NOC(int value, int value2) //Нахождение НОК
        {
            int Maximus = Math.Max(value, value2);
            int Minimus = Math.Min(value, value2);

            while (Maximus % Minimus != 0)
            {
                Maximus += Math.Max(value, value2);
            }

            multiply = Maximus / Minimus;
            return multiply;
        }

        public static void Convertor(int caseselected) //Конвертор - конвертирует вводимые дроби в неправильные для дальнейших математических вычислений
        {
            switch (caseselected)
            {
                case 1:
                    Celoe = (int)DecimalDrobe;
                    Chislit = 10;
                    Znamenat = (int)((DecimalDrobe - Celoe) * Chislit + Celoe * Chislit);
                    break;
                case 2:
                    Znamenat = Celoe * Chislit + Znamenat;
                    break;
                default:
                    break;
            }
        }
        public static void ToDecimal(int value)
        {
            switch(caseselected)
            {
                case 2:
                    DecimalDrobe = (Convert.ToDouble(Celoe) * Convert.ToDouble(Chislit) + Convert.ToDouble(Znamenat)) / Convert.ToDouble(Chislit);
                    Console.WriteLine($"{Celoe} {Znamenat}/{Chislit} виде десятичной дроби: {DecimalDrobe}");
                    break;
                case 3:
                    DecimalDrobe = Convert.ToDouble(Znamenat) / Convert.ToDouble(Chislit);
                    Console.WriteLine($"{Znamenat}/{Chislit} виде десятичной дроби: {DecimalDrobe}");
                    break;

            }
                

        }
    }
}
