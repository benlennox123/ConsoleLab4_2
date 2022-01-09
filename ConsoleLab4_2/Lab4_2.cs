using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int count1 = 0;
            int count2 = 0;
            Console.WriteLine("Введите последовательность чисел. Чтобы прекратить введите 0");
            do
            {
                N = Convert.ToInt32(Console.ReadLine());
                int D = N % 2;
                if (N != 0)
                {
                    if (D == 1)
                    {
                        count1++;
                    }
                    else
                    {
                        count2++;
                    }
                }
            }
            while (N != 0);
            if (count1==count2)
            {
                Console.WriteLine("Количество нечётных чисел {0} равно количеству чётных чисел {1}", count1, count2);
            }
            else
            {
                if (count1 > count2)
                {
                    Console.WriteLine("Нечётных чисел {0} больше, чем чётных чисел {1}", count1, count2);
                }
                else
                {
                    Console.WriteLine("Чётных чисел {0} больше, чем нечётных чисел {1}", count2, count1);
                }
            }
 





            /*
            Console.WriteLine("Введите число");
            Console.Write("N = ");
            int N = Convert.ToInt32(Console.ReadLine());
            int N2 = 0;
            if (N > 0)
            {
                for (int i = 1; i <= N; i++)
                {

                    N2 = N2 + (2 * i - 1);
                    Console.WriteLine(N2);
                }
            }
            else
            {
                Console.WriteLine("Введённое число должно быть >0");
            }
            */
            Console.Write("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
