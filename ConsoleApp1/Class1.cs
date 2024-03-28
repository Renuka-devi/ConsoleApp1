using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CheckAlphabet
    {
         public static void checkvowelornot(char x)
        {
             switch(x)
            {
                case 'a':
                    if(x == 'a')
                    {
                        Console.WriteLine(x + " is Vowel");
                    }
                    break;
                case 'e':
                    if (x == 'e')
                    {
                        Console.WriteLine(x + " is Vowel");
                    }
                    break;
                case 'i':
                    if (x == 'i')
                    {
                        Console.WriteLine(x + " is Vowel");
                    }
                    break;
                case 'o':
                    if (x == 'o')
                    {
                        Console.WriteLine(x + " is Vowel");
                    }
                    break;
                case 'u':
                    if (x == 'u')
                    {
                        Console.WriteLine(x + " is Vowel");
                    }
                    break;
                default:
                    Console.WriteLine(x + " is not Vowel");
                    break;
            }
        }
    }
}
