using System;

namespace _24_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която прочита цели числа N и K от конзолата и
            //отпечатва всички вариации от К елемента на числата[1…N].
            //Пример: N = 3, K = 2  { 1, 1}, { 1, 2}, { 1, 3}, { 2, 1}, { 2, 2}, { 2, 3}, { 3, 1}, { 3, 2}, { 3, 3}

            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());

            if (1 <= k && k <= n)
            {
                int variations = 1;
                for (int i = n; i > n - k; i--)
                {
                    variations *= i;
                }
                Console.WriteLine("Variations = " + variations);

                for (int i = 0; i < variations; i++)
                {

                    bool[] isNotAvailable = new bool[n];

                    int numberOfAvailElems = n;
                    int variationsOfAvailElems = variations;

                    for (int j = 0; j < k; j++)
                    {
                        numberOfAvailElems--;


                        if (numberOfAvailElems + 1 > 0)
                        {
                            variationsOfAvailElems /= (numberOfAvailElems + 1);
                        }
                        else
                        {
                            variationsOfAvailElems = 1;
                        }


                        int lotId = i / variationsOfAvailElems;

                        int indexInListOfAvailElems =
                           lotId % (numberOfAvailElems + 1);

                        int x = 0;
                        int counterOfAvailElems =
                           indexInListOfAvailElems + 1;
                        while (x < n && counterOfAvailElems > 0)
                        {
                            if (!isNotAvailable[x])
                            {
                                counterOfAvailElems--;
                            }
                            x++;
                        }
                        isNotAvailable[x - 1] = true;

                        Console.Write("{0,3}", x);
                    }
                    Console.WriteLine();
                }

            }
            else
            {
                Console.WriteLine(
                   "Invalid data! Let 1 <= k <= n.");
            }
        }
    }
}
