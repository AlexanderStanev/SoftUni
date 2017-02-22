using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {//[ ]{1}([a-zA-Z0-9]+[.]*-*\w+@+[A-Za-z]+[-a-zA-Z]*\.{1}[a-zA-Z]+[.A-Za-z]*[-A-Za-z]*)[,.]


            var input = Console.ReadLine().Trim();
            var pattern = @"[ ]{1}([A-Za-z0-9]+\.{0,1}-{0,1}[A-Za-z0-9]+@+[A-Za-z]+[-a-zA-Z]*\.{1}[a-zA-Z]+[.A-Za-z]*[-A-Za-z]*)[,.]";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[1]);
            }
        }
    }
}
