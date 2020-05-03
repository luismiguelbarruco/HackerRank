using System;

namespace left_rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            //var input = new int[] {1, 2, 3, 4, 5};
            var input = new int[] { 33, 47, 70, 37, 8, 53, 13, 93, 71, 72, 51, 100, 60, 87, 97 };
            var result = rotLeft(input, 13);

            Console.WriteLine(string.Join(" ", result));
        }

        static int[] rotLeft(int[] a, int d) 
        {
            int[] arr = new int[a.Length];
            for(var i = a.Length - 1; i >= 0; i--)
            {
                var newIndex = (i - d);
                if(newIndex < 0)
                    newIndex += a.Length;

                arr[newIndex] = a[i];
            }

            return arr;
        }
    }
}
