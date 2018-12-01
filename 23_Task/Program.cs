using System;

namespace _23_Task
{
    class Program
    {
        /*Напишете програма, която прочита цяло число N от конзолата и отпечатва всички пермутации на числата [1…N].
         * Пример: N = 3 à {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}*/
        public static int n;

        static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            n = Int32.Parse(Console.ReadLine());

            Console.Write("Enter K: ");
            int k = Int32.Parse(Console.ReadLine());

            int[] arr = new int[k];

            RecSolution(arr, 0);
        }

        static void RecSolution(int[] array, int index)
        {
            if (index != array.Length)
                for (int i = 1; i <= n; i++)
                {
                    array[index] = i;
                    RecSolution(array, index + 1);
                }
            else
            {
                for (int i = 0; i < array.Length; i++) Console.Write(array[i] + " ");
                Console.WriteLine();
            }
        }
    }
}