using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_copy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте! Для передвижения по полю используйте клавиши W,A,S и D\nW-движение вверх, S-вниз, A-влево, D-вправо.\nДля выхода нажмите E.");
            for (int i = 0; ;)
            {
                i++;
                string letter = Console.ReadLine();
                foreach (char way in letter)
                {
                    if (way == 'W' || way == 'w')
                    {
                        Console.WriteLine("Вверх");
                    }
                    else if (way == 'S' || way == 's')
                    {
                        Console.WriteLine("Вниз");
                    }
                    else if (way == 'A' || way == 'a')
                    {
                        Console.WriteLine("Влево");
                    }
                    else if (way == 'D' || way == 'd')
                    {
                        Console.WriteLine("Вправо");
                    }
                    else if (way == 'E' || way == 'e')
                    {
                        Console.WriteLine("Вы завершили");
                        break;
                    }


                }

               
            }

                             
        }
          

    }
}
