using System;

namespace _2D_Array
{
    class Program
    {
        static int sunGlass(int[][] arr, int i, int j)
        {
            return arr[i][j] + arr[i][j + 1] + arr[i][j + 2] +
                arr[i + 1][j + 1] + 
                arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
        }

        static int hourglassSum(int[][] arr) 
        {
            var total = int.MinValue;
            for(var i = 0; i < 4; i++)
            {
                for(var j = 0; j < 4; j++)
                {
                    var result = sunGlass(arr, i, j);
                    if(result > total)
                        total = result;
                }   
            }

            return total;
        }

        static void Main(string[] args)
        {
            int[][] mat = new int[][]
            {
                new int[] { 1, 1, 1, 0, 0, 0 },
                new int[] { 0, 1, 0, 0, 0, 0 },
                new int[] { 1, 1, 1, 0, 0, 0 },
                new int[] { 0, 0, 2, 4, 4, 0 },
                new int[] { 0, 0, 0, 2, 0, 0 },
                new int[] { 0, 0, 1, 2, 4, 0 }
            };

            hourglassSum(mat);
        }
    }
}
