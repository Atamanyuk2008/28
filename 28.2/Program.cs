using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[9];
            Random(mas);
            int even = Even(mas);
            int odd = Odd(mas);

            Comparison(mas);
            Console.ReadKey();
        }
        static void Random(int[] mas)
        {
            Random rand = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rand.Next(1, 100);
                Console.Write($"{mas[i]} \t");
            }
        }
        static int Even(int[] mas)
        {
            int even = 0;
            foreach (int element in mas)
            {
                if (element % 2 == 0)
                {
                    even++;
                }
            }
            return even;
        }
        static int Odd(int[] mas)
        {
            int odd = 0;
            foreach (int element in mas)
            {
                if (element % 2 != 0)
                {
                    odd++;
                }
            }
            return odd;
        }
        static void Comparison(int[] mas)
        {
            int even = Even(mas);
            int odd = Odd(mas);
            if (even > odd)
            {
                Console.WriteLine("Чётных чисел больше");
            }
            else if (even < odd)
            {
                Console.WriteLine("Нечётных чисел больше");
            }
        }
    }
}
