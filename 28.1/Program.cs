using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                int[] mas = new int[14];

                InPut("Введите элементы массива: ", mas);
                int evenCount = CountEvenElements(mas);
                Console.WriteLine($"Количество чётных элементов: {evenCount}");
                Console.ReadKey();
            }

            static void InPut(string message, int[] mas)
            {
                for (int x = 0; x < mas.Length; x++)
                {
                    Console.Write(message);
                    mas[x] = Convert.ToInt32(Console.ReadLine());
                }
            }
            static int CountEvenElements(int[] mas)
            {
                int count = 0;
                foreach (int element in mas)
                {
                    if (element % 2 == 0)
                    {
                        count++;
                    }
                }
                return count;
            }
    }
}
