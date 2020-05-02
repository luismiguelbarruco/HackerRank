using System;

namespace counting_valleys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(countingValleys(8, "UDDDUDUU"));
            Console.WriteLine(countingValleys(12, "DDUUDDUDUUUD"));
            Console.WriteLine(countingValleys(8, "UUDDDDUU"));
        }

        static int countingValleys(int n, string s) 
        {
            int valleysCount = 0;
            int steps = 0;

            for (int i = 0; i < s.Length; i++)
            {
                steps = s[i].Equals('D') ? --steps : ++steps;

                if(steps == 0 && i < s.Length - 1)
                    valleysCount++;
            }

            return valleysCount;
        }
    }
}
