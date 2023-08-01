using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11
{
    class Program
    {
        static void Main()
        {
            int[] numbers = new int[] { 1, 3, 5, 7, 11, 13, 17 };

            Console.WriteLine("Квадраты чисел");
            Console.WriteLine();
            Console.WriteLine("Дан ряд чисел:");

            for (int a = 0; a < numbers.Length; a++)
            {
                Console.Write(numbers[a] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Квадраты этих чисел:");

            for (int a = 0; a < numbers.Length; a++)
            {
                Console.Write(numbers[a] * numbers[a] + " ");
            }
        }
    }
}
