using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms
{
    class Program
    {
        static void Main()
        {
            // 1. Write a C# Sharp program to compute the sum of the two given integer values. If the two values are the same, then return triple their sum.
            Console.WriteLine(Ex1(1, 2));
            Console.WriteLine(Ex1(2, 2));


            Console.ReadLine();
        }

        private static int Ex1(int n1, int n2)
        {
            return n1 == n2? (n1 + n2) * 3: n1 + n2;
        }
    }
}
