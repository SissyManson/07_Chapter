using System;

namespace _04_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която намира максимална редица от последова­телни еднакви елементи в масив. 
            //Пример: { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1}
            //à { 2, 2, 2}.

            int count = 1, tempCount = 1, number = 0;

            Console.Write("Enter array length: ");
            int length = Int32.Parse(Console.ReadLine());
            int[] arr = new int[length];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1]) tempCount++;
                else tempCount = 1;

                if (tempCount > count)
                {
                    count = tempCount;
                    number = arr[i];
                }
            }

            for (int i = 0; i < count; i++) Console.Write("{0}, ", number);
        }
    }
}
