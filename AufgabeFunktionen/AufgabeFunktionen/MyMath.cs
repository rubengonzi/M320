using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AufgabeFunktionen
{
    internal class MyMath
    {
        public int calc_ggt(int a, int b)
        {
            int z;
            while (b != 0)
            {
                z = a % b;
                a = b;
                b = z;
            }
            return a;
        }

        public int calc_kgv(int a, int b)
        {
            return a * b / calc_ggt(a, b);
        }

        public int readInt()
        {
            int input = 0;

            do
            {
                Console.Write("Geben Sie eine positive Zahl ein");
                input = Console.Read();
            } while (input >= 0);
            return input;
        }

        public string showResult(string type, int a, int b, int result)
        {
            return "ggT von";
        }
    }
}
