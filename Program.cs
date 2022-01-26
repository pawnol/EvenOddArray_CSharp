/*
 * Even Odd Array
 * Pawelski
 * 1/25/2022
 * Read over the code and run the program a few times to determine what
 * the program does. Once you know what the program does and how it works,
 * answer the questions on the activity sheet.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int evenCount = 0, oddCount = 0;
            int[] number = { 5, 2, 9, 3, 7, 1, 10, 11, 15, 12, 14 };
            for(int i = 0; i < number.Length; i++)
            {
                if (number[i] % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }
            Console.WriteLine("The array has " + evenCount + " even numbers.");
            Console.WriteLine("The array has " + oddCount + " even numbers.");
        }
    }
}
