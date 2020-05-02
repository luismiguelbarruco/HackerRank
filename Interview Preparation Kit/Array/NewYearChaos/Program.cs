using System;

namespace NewYearChaos
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new int[] {2, 1, 5, 3, 4};
            var input2 = new int[] {2, 5, 1, 3, 4};
            var input3 = new int[] {1, 2, 3, 5, 4, 6, 7, 8};
            var input4 = new int[] {5, 1, 2, 3, 7, 8, 6, 4};
            var input5 = new int[] {1, 2, 5, 3, 7, 8, 6, 4};

            minimumBribes(input);
            minimumBribes(input2);
            minimumBribes(input3);
            minimumBribes(input4);
            minimumBribes(input5);
        }

        static void minimumBribes(int[] q)
        {
            int[] arr = new int[q.Length];
            int count = 0;

            for (int i = 1; i <= q.Length; i++)
            {
                arr[i - 1] = q[i - 1] - i;

                if(arr[i - 1] > 2)
                {
                    count = -1;
                    break;
                }

                if(arr[i - 1] < 0)
                {
                    count += arr[i - 1] * -1;
                }
            }

            if(count == -1)
                Console.WriteLine("Too chaotic");
            else
                Console.WriteLine(count);
        }
    }
}
