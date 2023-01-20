using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class Methods
    {
        internal static void FillArray(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"arr[{i}]=");
                arr[i] = int.Parse(Console.ReadLine());
            }

        }

        internal static void PrintArray(int[] arr)
        {
            Console.Write("Array elements: ");
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
        }
    }
}
