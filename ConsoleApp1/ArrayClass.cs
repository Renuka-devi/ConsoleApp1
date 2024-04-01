using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ArrayClass
    {
        public static void findVowel() {
            //Search vowels from a given character array
            string[] characters = { "a", "v", "i", "s" };
            string[] vowels = { };
            int index = 0;
            foreach (string i in characters)
            {
                switch (i)
                {
                    case "a":
                        if (i == "a")
                        {
                            vowels[index] = i;
                            index++;
                        }
                        break;
                    case "i":
                        if (i == "i")
                        {
                            vowels[index] = i;
                            index++;
                        }
                        break;
                    case "e":
                        if (i == "e")
                        {
                            vowels[index] = i;
                            index++;
                        }
                        break;
                    case "o":
                        if (i == "o")
                        {
                            vowels[index] = i;
                            index++;
                        }
                        break;
                    case "u":
                        if (i == "u")
                        {
                            vowels[index] = i;
                            index++;
                        }
                        break;
                    default:
                        break;
                }
            }
            foreach (string vowel in vowels)
            {
                Console.WriteLine(vowel);
            }
        }
    }
}
