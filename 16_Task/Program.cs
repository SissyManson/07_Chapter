using System;

namespace _16_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Да се реализира двоично търсене (binary search) в сортиран целочислен масив.*/

            Console.Write("Enter array length: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            Console.Write("Enter searched number: ");
            int number = Int32.Parse(Console.ReadLine());

            int index = Array.BinarySearch(arr, number);

            if (index >= 0) Console.Write("Number is on {0} index.", index);
            else Console.Write("Number wasn't found.");
        }
    }
}
