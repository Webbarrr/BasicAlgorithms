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
            //// 1. Write a C# Sharp program to compute the sum of the two given integer values. If the two values are the same, then return triple their sum.
            //Console.WriteLine(Ex1(1, 2));
            //Console.WriteLine(Ex1(2, 2));

            //// 2. Write a C# Sharp program to get the absolute difference between n and 51. If n is greater than 51 return triple the absolute difference.
            //Console.WriteLine(Ex2(53));
            //Console.WriteLine(Ex2(30));
            //Console.WriteLine(Ex2(51));

            //// 3. Write a C# Sharp program to check two given integers, and return true if one of them is 30 or if their sum is 30. 
            //Console.WriteLine(Ex3(30, 0));
            //Console.WriteLine(Ex3(25, 5));
            //Console.WriteLine(Ex3(20, 30));
            //Console.WriteLine(Ex3(20, 25));

            //// 4. Write a C# Sharp program to check a given integer and return true if it is within 10 of 100 or 200.
            //Console.WriteLine(Ex4(103));
            //Console.WriteLine(Ex4(90));
            //Console.WriteLine(Ex4(89));

            // 5. Write a C# Sharp program to create a new string where 'if' is added to the front of a given string. If the string already begins with 'if', return the string unchanged.
            Console.WriteLine(Ex5("if else"));
            Console.WriteLine(Ex5("else"));


            Console.ReadLine();
        }

        private static int Ex1(int n1, int n2)
        {
            return n1 == n2? (n1 + n2) * 3: n1 + n2;
        }
        private static int Ex2(int n)
        {
            int i = 51;
            return n > i ? (n - i) * 3 : i - n;
        }
        private static bool Ex3(int n1, int n2)
        {
            return (n1 == 30 || n2 == 30) || n1 + n2 == 30 ? true : false;
        }
        private static bool Ex4(int n)
        {
            int range = 10;
            return Math.Abs(n - 100) <= range || Math.Abs(n - 200) <= range ? true : false;
        }
        private static string Ex5(string yourString)
        {
            return yourString.ToLower().StartsWith("if") ? yourString : "if " + yourString;
        }
    }
}
