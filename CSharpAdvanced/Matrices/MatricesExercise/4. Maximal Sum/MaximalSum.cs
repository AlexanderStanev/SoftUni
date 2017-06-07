using System;
using System.Linq;

namespace MaximalSum
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var rows = input[0];
            var cols = input[1];

            var matrix = new int[rows][];
            for (var i = 0; i < rows; i++)
            {
                var currentRow = Console.ReadLine()
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                matrix[i] = new int[cols];

                for (var j = 0; j < cols; j++)
                    matrix[i][j] = currentRow[j];
            }

            //---------------------------------------------------------//

            var maxSum = int.MinValue;
            var bestRowIndex = 0;
            var bestColIndex = 0;

            for (var i = 0; i < rows - 2; i++)
            for (var j = 0; j < cols - 2; j++)
            {
                var topLeftIndex = matrix[i][j];
                var topMiddleIndex = matrix[i][j + 1];
                var topRightIndex = matrix[i][j + 2];

                var middleLeftIndex = matrix[i + 1][j];
                var middleMiddleIndex = matrix[i + 1][j + 1];
                var middleRightIndex = matrix[i + 1][j + 2];

                var botLeftIndex = matrix[i + 2][j];
                var botMiddleIndex = matrix[i + 2][j + 1];
                var botRightndex = matrix[i + 2][j + 2];

                var sum = topLeftIndex + topMiddleIndex
                          + topRightIndex + middleLeftIndex
                          + middleMiddleIndex + middleRightIndex
                          + botLeftIndex + botMiddleIndex + botRightndex;

                if (sum > maxSum)
                {
                    maxSum = sum;
                    bestRowIndex = i;
                    bestColIndex = j;
                }
            }

            Console.WriteLine($"Sum = {maxSum}");

            for (var i = 0; i < 3; i++)
            {
                for (var j = 0; j < 3; j++)
                    Console.Write(matrix[bestRowIndex + i][bestColIndex + j] + " ");

                Console.WriteLine();
            }
        }
    }
}