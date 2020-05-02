using System;
using System.Linq;

namespace repeted_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(repeatedString("abcac", 10));
            Console.WriteLine(repeatedString("ababa", 3));
            Console.WriteLine(repeatedString("aba", 10));
            Console.WriteLine(repeatedString("a", 1000000000000));
            Console.WriteLine(repeatedString("ceebbcb", 817723));
            Console.WriteLine(repeatedString("gfcaaaecbg", 547602));
            Console.WriteLine(repeatedString("bcbccacaacbbacabcabccacbccbababbbbabcccbbcbcaccababccbcbcaabbbaabbcaabbbbbbabcbcbbcaccbccaabacbbacbc", 649606239668));
        }

        static long repeatedString(string s, long n) 
        {
            if(s.Length == 1 && s == "a")
                return n;

            long totalRepeat = (long)(n / s.Length);

            if(totalRepeat == 0)
                totalRepeat = 1;
            
            long delta = (long)(n - (s.Length * totalRepeat));
            long countA = 0;
            long countAAux = 0;
            int x = 0;
            int max = (int)(s.Length > n ? n : s.Length);

            for (int i = 0; i < max; i++)
            {
                if(i >= n)
                    i = (int)n;

                if(s[i] != 'a') 
                {
                    delta--;
                    x++;
                    continue;
                }

                if(s[i] == 'a')
                    ++countA;

                if(s.Length <= n && delta > 0)
                {
                    if(s[x] == 'a')
                        ++countAAux;

                    delta--;
                    x++;
                }
            }

            return (countA * totalRepeat) + countAAux;
        }
    }
}
