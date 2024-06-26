﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            var a = 10;
            var b = "TEST0";
            var c = 10.10;
            Console.WriteLine("{0} type: {1}", a, a.GetType());
            Console.WriteLine("{0} type: {1}", b, b.GetType());
            Console.WriteLine("{0} type: {1}", c, c.GetType());

            //Task 2

            // reading numbers from console
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());

            //checking which one is greater
            var flag = 0;
            if (num1 > num2)
            {
                flag = 1;
            }
            if (flag == 1)
            {
                if (num1 > num3)
                {
                    Console.WriteLine(num1);
                }
            }
            else if (num2 > num3)
            {
                Console.WriteLine(num2);
            }
            else
            {
                Console.WriteLine(num3);
            }

            // Task 3

            Console.WriteLine("Enter a character");
            char newchar = char.ToLower(Console.ReadLine()[0]);
            CheckAlphabet.checkvowelornot(newchar);

            // Task 4
            Console.WriteLine("sum of the first n natural numbers");

            Console.WriteLine("Enter the n value");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            if (n != 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    sum = sum + i;
                }
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine(0);
            }

            //Task 5

            Console.WriteLine("number is prime or not");
            int num = Convert.ToInt32(Console.ReadLine());
            int j = 2;
            while (j <= num - 1)
            {
                if (num % j == 0)
                {
                    Console.WriteLine("The Given Number is not Prime");
                    break;
                }
                j++;
            }
            if (num == j)
            {
                Console.WriteLine("The Given Number is an Prime Number");
            }

            //Task6
            Console.WriteLine("Multiplication of given number");
            int newnum = Convert.ToInt32(Console.ReadLine());
            int k = 1;
            do
            {
                Console.WriteLine(k * newnum);
                k++;

            } while (k <= newnum);

            //Task 7

            Console.WriteLine("string to upper case");
            Console.WriteLine("Enter a name");
            var name = Convert.ToString(Console.ReadLine());
            Program.stringToUpper(ref name);

            //Task 8
            Console.WriteLine("sum of digits");
            Console.WriteLine("Enter the number");
            int z = Convert.ToInt32(Console.ReadLine());
            Program obj = new Program();
            Console.WriteLine(obj.sumofdigits(ref z));
        }

        static void stringToUpper(ref string name)
        {
            Console.WriteLine(name.ToUpper());
        }

        public int sumofdigits(ref int digit)
        {
            int sumofdigit = 0;
            double length = Math.Floor(Math.Log10(digit) + 1);
            for(int m= 1; m <= length; m++)
            {
                int reminder = digit % 10;
                sumofdigit = sumofdigit + reminder;
                digit = digit / 10;
            }
            return sumofdigit;
        }

        // Find vowels from an array
       ArrayClass.findVowel();
        
    }
}
