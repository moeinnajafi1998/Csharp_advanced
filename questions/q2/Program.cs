using System;

class Program
{
    static void Main()
    {
        // 1. Multidimensional Arrays
        // Example: 2D Array (Matrix)

        // Declare a 2D array with 3 rows and 4 columns
        int[,] matrix2D = new int[3, 4];

        // Initialize the array with values
        int[,] matrix2DInit = {
            { 1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 }
        };

        // Accessing an element in the array
        int value2D = matrix2DInit[1, 2]; // This will be 7 (2nd row, 3rd column)
        Console.WriteLine("2D Array value: " + value2D);

        // Example: 3D Array

        // Declare a 3D array with dimensions 2x3x4
        int[,,] threeDArray = new int[2, 3, 4];

        // Initialize a 3D array
        int[,,] threeDArrayInit = {
            {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 }
            },
            {
                { 13, 14, 15, 16 },
                { 17, 18, 19, 20 },
                { 21, 22, 23, 24 }
            }
        };

        // Accessing an element in the array
        int value3D = threeDArrayInit[1, 2, 3]; // This will be 24 (2nd matrix, 3rd row, 4th column)
        Console.WriteLine("3D Array value: " + value3D);

        // 2. Jagged Arrays
        // Example: Jagged Array

        // Declare a jagged array with 3 arrays (rows)
        int[][] jaggedArray = new int[3][];

        // Initialize each row individually
        jaggedArray[0] = new int[] { 1, 2 };
        jaggedArray[1] = new int[] { 3, 4, 5 };
        jaggedArray[2] = new int[] { 6, 7, 8, 9 };

        // Accessing an element in the jagged array
        int valueJagged = jaggedArray[1][2]; // This will be 5 (2nd row, 3rd element)
        Console.WriteLine("Jagged Array value: " + valueJagged);
    }
}
