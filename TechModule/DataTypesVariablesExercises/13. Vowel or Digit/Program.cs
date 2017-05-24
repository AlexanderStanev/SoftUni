using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse((Console.ReadLine()));

                switch (symbol)
                {
                case 'a':
                    Console.WriteLine("vowel");
                    break;
                case 'e':
                    Console.WriteLine("vowel");
                    break;
                case 'i':
                    Console.WriteLine("vowel");
                    break;
                case 'o':
                    Console.WriteLine("vowel");
                    break;
                case 'u':
                    Console.WriteLine("vowel");
                    break;
                default:
                    {
                        if (char.IsDigit(symbol))
                        {
                            Console.WriteLine("digit");
                        }
                        else
                        {
                            Console.WriteLine("other");
                        }
                    }

                    break;



            }
        }
    }
}
