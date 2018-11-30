using System;

namespace _02_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            // Да се напише програма, която чете два масива от конзолата и прове­рява дали са еднакви.

            bool arraysEqual = true;

            Console.Write("Enter lenght of first array: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arrA = new int[length];

            for (int i = 0; i < arrA.Length; i++)
            {
                Console.Write("Enter element {0}: ", i);
                arrA[i] = Int32.Parse(Console.ReadLine());
            }

            Console.Write("\nEnter lenght of second array: ");

            if (length != Int32.Parse(Console.ReadLine())) Console.WriteLine("\nArrays have different lengths.");
            else
            {
                int[] arrB = new int[length];

                for (int i = 0; i < arrB.Length; i++)
                {
                    Console.Write("Enter element {0}: ", i);
                    arrB[i] = Int32.Parse(Console.ReadLine());
                }

                for (int i = 0; i < arrA.Length; i++)
                {
                    if (arrA[i] != arrB[i])
                    {
                        Console.WriteLine("\nArrays are different.");
                        arraysEqual = false;
                        break;
                    }
                }

                if (arraysEqual) Console.WriteLine("\nArrays are the same.");
            }
        }
    }
}
