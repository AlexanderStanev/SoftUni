using System;
using System.Linq;

namespace SquaresMatrix
{
    internal class SquaresMatrix
    {
        private static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var rows = input[0];
            var cols = input[1];

            var matrix = new string[rows][];
            for (var i = 0; i < rows; i++)
            {
                var currentRow = Console.ReadLine()
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                matrix[i] = new string[cols];

                for (var j = 0; j < cols; j++)
                    matrix[i][j] = currentRow[j];
            }

            var equalMatrixCount = 0;
            for (var i = 0; i < rows - 1; i++)
            for (var j = 0; j < cols - 1; j++)
            {
                var topLeftIndex = matrix[i][j];
                var topRightIndex = matrix[i][j + 1];
                var botLeftIndex = matrix[i + 1][j];
                var botRightndex = matrix[i + 1][j + 1];

                if (topLeftIndex == topRightIndex && topLeftIndex == botLeftIndex
                    && topLeftIndex == botRightndex)
                    equalMatrixCount++;
            }

            Console.WriteLine(equalMatrixCount);
        }
    }
}