using System;
using System.Linq;

namespace MatrixPalindromes
{
    internal class MatrixPalindromes
    {
        private static void Main(string[] args)
        {
            var alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var col = input[0];
            var row = input[1];

            for (var j = 0; j < col; j++)
            {
                for (var i = 0; i < row; i++)
                    Console.Write(alphabet[j].ToString() + alphabet[j + i] + alphabet[j] + ' ');

                Console.WriteLine();
            }
        }
    }
}