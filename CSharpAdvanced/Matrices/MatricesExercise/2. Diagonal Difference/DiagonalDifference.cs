using System;
using System.Linq;

namespace DiagonalDifference
{
    internal class DiagonalDifference
    {
        private static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());

            var matrix = new int[size][];

            for (var i = 0; i < size; i++)
            {
                var currentRow = Console.ReadLine();
                var elements = currentRow.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                    .ToArray();

                matrix[i] = new int[size];
                for (var j = 0; j < size; j++)
                    matrix[i][j] = elements[j];
            }

            var primaryDiagonalSum = 0;
            var secondaryDiagonalSum = 0;

            for (var i = 0; i < size; i++)
                primaryDiagonalSum += matrix[i][i];

            for (var i = 0; i < size; i++)
                secondaryDiagonalSum += matrix[i][size - i - 1];

            Console.WriteLine(Math.Abs(primaryDiagonalSum - secondaryDiagonalSum));
        }
    }
}