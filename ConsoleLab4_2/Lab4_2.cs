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
                int D = Math.Abs(N);
                if (N != 0)
                {
                    if (D != N)
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
                Console.WriteLine("Количество отрицательных чисел {0} равно количеству положительных чисел {1}", count1, count2);
            }
            else
            {
                if (count1 > count2)
                {
                    Console.WriteLine("Отрицательных чисел {0} больше, чем положительных чисел {1}", count1, count2);
                }
                else
                {
                    Console.WriteLine("Положительных чисел {0} больше, чем отрицательных чисел {1}", count2, count1);
                }
            }
            Console.Write("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
