using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1 = 43.6F; // явное преобразование типов
            char num2;
            num2 = (char)num1;

            int num3 = 29; // явное преобразование типов
            short num4;
            num4 = (short)num3;

            double num5 = 204.4689; // явное преобразование типов
            long num6;
            num6 = (long)num5;

            byte num7 = 76; // неявное преобразование типов
            int num8 = num7;

            float num9 = 21.45F; //  неявное преобразование типов
            double num10 = num9;

            uint num11 = num2;  //  неявное преобразование типов

            double num12 = 2.46; //boxing
            object x = num12;

            double y = (double)x; //unboxing


        }
        
        
    }
}
