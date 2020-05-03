using System;
using System.Collections.Generic;

namespace minimum_swaps
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new int[] { 7, 1, 3, 2, 4, 5, 6 };
            var input2 = new int[] { 4, 3, 1, 2 };
            var input3 = new int[] { 2, 3, 4, 1, 5 };

            Console.WriteLine(minimumSwaps(input));
            Console.WriteLine(minimumSwaps(input2));
            Console.WriteLine(minimumSwaps(input3));
        }

        //https://www.geeksforgeeks.org/minimum-number-swaps-required-sort-array/
        static int minimumSwaps(int[] arr)
        {
            List<Tuple<int, int>> tuplePair = new List<Tuple<int, int>>();
            bool[] visit = new bool[arr.Length];
            int countSwap = 0; 

            for (int i = 0; i < arr.Length; i++)
            {
                var pair = new Tuple<int, int>(arr[i], i);
                tuplePair.Add(pair); 
            }

            tuplePair.Sort();

            for (int i = 0; i < arr.Length - 1; i++) 
            { 
                if (visit[i] || tuplePair[i].Item2 == i)
                    continue; 
                    
                int cycle_size = 0; 
                int j = i;

                while (!visit[j])
                { 
                    visit[j] = true; 
        
                    j = tuplePair[j].Item2; 
                    cycle_size++; 
                } 
        
                if (cycle_size > 0) 
                    countSwap += (cycle_size - 1); 
            } 
        
            return countSwap;
        }
    }
}
