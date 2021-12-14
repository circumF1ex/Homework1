using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable CS1717 // Назначение выполнено для той же переменной

namespace Homework1
{
    class drobes
    {
        public static int Celoe;
        public static int Znamenat;
        public static int Chislit;
        public static char Act;
        public drobes(int Celoe) { drobes.Celoe = Celoe; }
        public void Deconstruct1(int Celoe) { drobes.Celoe = Celoe;  }
        public drobes(int Znamenat, int Chislit) { drobes.Znamenat = Znamenat; drobes.Chislit = Chislit; }
        public void Deconstruct2(int Znamenat, int Chislit) { drobes.Znamenat = Znamenat; drobes.Chislit = Chislit; }
        public drobes(int Celoe, int Znamenat, int Chislit) { drobes.Celoe = Celoe; drobes.Znamenat = Znamenat; drobes.Chislit = Chislit; }
        public void Deconstruct3(int Celoe, int Znamenat, int Chislit) { drobes.Celoe = Celoe; drobes.Znamenat = Znamenat; drobes.Chislit = Chislit; }

        public drobes(char Act) { Act = Act; }
        public void DeconstructAct(int Celoe) { drobes.Act = Act; }

        //public static void Math(out int Celoe, out int Znamenat, out int Chislit, out char Act)
        //{
            
        //}
    }
}
