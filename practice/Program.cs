using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[][] matrix = new int[4][];
        matrix[0] = new int[] { 1, 3, 5, 7, 9, 11, 13, 15 };
        matrix[1] = new int[] { 2, 4, 6 };
        matrix[2] = new int[] { 8, 10, 12, 14, 16 };
        matrix[3] = new int[] { 18, 20, 22 };

        int row = 0;
        while (row < 4)
        {
            int column = 0;
            while (column < matrix[row].Length)
            {
                if (row % 2 == 0 && column % 3 == 0)
                {
                    Console.Write("{0} ", matrix[row][column]);
                }
                column++;
            }
            Console.WriteLine();
            row += 2;
        }

        int index = 0;
        while (index < matrix[1].Length)
        {
            matrix[1][index] = matrix[0][index + 2] - matrix[0][index];
            index += 2;
        }

        index = 0;
        while (index < matrix[3].Length - 1) // to avoid out of range exception
        {
            matrix[3][index] = matrix[2][index] + matrix[2][index + 1];
            index++;
        }

        row = 1;
        while (row < 4)
        {
            int column = 0;
            while (column < matrix[row].Length)
            {
                if (row % 2 != 0 && column % 2 == 0)
                {
                    Console.Write("{0} ", matrix[row][column]);
                }
                column += 2;
            }
            Console.WriteLine();
            row += 2;
        }
    }
}
