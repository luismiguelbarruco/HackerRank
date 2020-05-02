using System;
using System.Collections.Generic;
using System.IO;

namespace sock_merchant
{
    class Program
    {
        // static void Main(string[] args)
        // {
        //     int[] input = new int [9] { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
        //     Console.WriteLine(sockMerchant(9, input));
        // }

        static void Main(string[] args) 
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int result = sockMerchant(n, ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }

        static int sockMerchant(int n, int[] ar) 
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            int parCount = 0;

            for (int i = 0; i < ar.Length; i++)
            {
                if(!dic.ContainsKey(ar[i]))
                {
                    dic.Add(ar[i], 1);
                }
                else
                {
                    dic[ar[i]] = ++dic[ar[i]];

                    if(dic[ar[i]] != 0 && dic[ar[i]] % 2 == 0)
                    {
                        parCount++;
                    }
                }
            }

            return parCount;
        }
    }
}
