using System;
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

            CheckAlphabet alph = new CheckAlphabet();
            alph.checkvowelornot('s');
        }
    }
}
