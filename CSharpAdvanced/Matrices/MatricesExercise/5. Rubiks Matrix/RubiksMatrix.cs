using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksMatrix
{
    class RubiksMatrix
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var rows = dimensions[0];
            var cols = dimensions[1];

            var matrix = new int[rows][];

            var numbers = 1;
            for (var i = 0; i < rows; i++)
            {
                matrix[i] = new int[cols];
                for (var j = 0; j < cols; j++)
                {
                    matrix[i][j] = numbers;
                    numbers++;
                }
            }

            var commandsCount = int.Parse(Console.ReadLine());
            for (var i = 0; i < commandsCount; i++)
            {
                var comandTokens = Console.ReadLine()
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                var firstElement = int.Parse(comandTokens[0]);
                var direction = comandTokens[1];
                var movesCount = int.Parse(comandTokens[2]);

                switch (direction)
                {
                    case "up":

                        ColMove(matrix, firstElement, movesCount);
                        break;

                    case "down":

                        ColMove(matrix, firstElement, rows- movesCount % rows);
                        break;

                    case "left":

                        RowMove(matrix, firstElement, movesCount);
                        break;

                    case "right":
                        RowMove(matrix, firstElement, cols - movesCount % cols);
                        break;
                }
            }

            var element = 1;
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    if (matrix[i][j] == element)
                    {
                        Console.WriteLine("No swap required");
                    }
                    else
                    {
                        for (int k = 0; k < matrix.Length; k++)
                        {
                            for (int l = 0; l < matrix[0].Length; l++)
                            {
                                if (matrix[k][l] == element)
                                {
                                    var currentElement = matrix[i][j];
                                    matrix[i][j] = element;
                                    matrix[k][l] = currentElement;
                                    Console.WriteLine($"Swap ({i}, {j}) with ({k}, {l})");
                                }
                            }
                        }
                    }

                    element++;
                }
            }
        }

        private static void RowMove(int[][] matrix, int firstElement, int movesCount)
        {
            var temp = new int[matrix[0].Length];
            for (int i = 0; i < matrix[0].Length; i++)
            {
                temp[i] = matrix[firstElement][(i + movesCount) % matrix[0].Length];
            }

            matrix[firstElement] = temp;
        }

        private static void ColMove(int[][] matrix, int firstElement, int movesCount)
        {
            var temp = new int[matrix.Length];
            for (int j = 0; j < matrix.Length; j++)
            {
                temp[j] = matrix[(j + movesCount) % matrix.Length][firstElement];
            }

            for (int j = 0; j < matrix.Length; j++)
            {
                matrix[j][firstElement] = temp[j];
            }
        }
    }
}
