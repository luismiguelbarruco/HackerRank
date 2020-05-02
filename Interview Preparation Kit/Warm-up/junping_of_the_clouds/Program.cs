using System;

namespace junping_of_the_clouds
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new int[6] {0, 0, 0, 0, 1, 0};
            var input2 = new int[7] {0, 0, 1, 0, 0, 1, 0};

            Console.WriteLine(jumpingOnClouds(input));
            Console.WriteLine(jumpingOnClouds(input2));
        }

        static int jumpingOnClouds(int[] c) 
        {
            var countOfJunps = 0;

            for (int i = 0; i < c.Length; i++)
            {
                if(c[i] == 1)
                    continue;

                if((i + 2) < c.Length && c[i + 2] == 0)
                {
                    ++countOfJunps;
                    i+= 1;
                }
                else if((i + 1) < c.Length && c[i + 1] == 0)
                {
                    ++countOfJunps;
                }
            }

            return countOfJunps;
        }
    }
}
