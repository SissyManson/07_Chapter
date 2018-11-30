using System;
using System.Collections.Generic;

namespace _19_Task
{
    class Program
    {

        /* Напишете програма, която намира всички прости числа в диапазона [1…10 000 000]. 
         * Упътване: Потърсете в Интернет информация за "Sieve of Erathostenes" 
         * (Решетото на Ератостен, учено в часовете по математика).*/

        static void PrintList(List<int> nums, bool printZero = true)
        {
            foreach (int n in nums)
            {
                if (!printZero && n == 0) continue;
                Console.Write("{0}\t", n);
            }
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            // 1 is not a prime number
            for (int i = 2; i <= 10000000; ++i) nums.Add(i);

            int p = 2;
            int indexAt = 0;
            bool limitReached = false;

            while (!limitReached)
            {
                for (int i = 0; i < nums.Count; ++i)
                {
                    int v = nums[i];
                    if (v % p == 0 && v != p) nums[i] = 0;
                }
                do
                {
                    p = nums[++indexAt];
                    if (indexAt >= nums.Count - 1)
                    {
                        limitReached = true;
                        break;
                    }
                } while (p == 0);
            }

            PrintList(nums, false);
        }
    }
}