using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте! Для передвижения по полю используйте клавиши W,A,S и D\nW-движение вверх, S-вниз, A-влево, D-вправо.\nДля выхода нажмите E.");

            for (int i = 0; ;)
            {
                i++;
                char letter;
                letter = Convert.ToChar(Console.ReadLine()); //на этом месте при повторном вводе у меня выдает ошибку, как ее исправить так и не нашла
                int num;
                num = (int)letter;

                if (num == 87 | num == 119)
                {
                    Console.WriteLine("Вверх");
                }
                else if (num == 83 | num == 115)
                {
                    Console.WriteLine("Вниз");
                }
                else if (num == 65 | num == 97)
                {
                    Console.WriteLine("Влево");
                }
                else if (num == 68 | num == 100)
                {
                    Console.WriteLine("Вправо");
                }
                else if (num == 69 | num == 101)
                {
                    break;                    
                }

                Console.Read();



                               


            }
            
            

            
            
            
        }
    }
}
