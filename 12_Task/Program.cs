using System;

namespace _12_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която създава следните квадратни матрици и ги извежда на конзолата във форматиран вид.
            //Размерът на матриците се въвежда от конзолата.

            Console.Write("12 a) ");
            Console.Write("Enter height: ");
            int y = Int32.Parse(Console.ReadLine());

            Console.Write("Enter width: ");
            int x = Int32.Parse(Console.ReadLine());

            int a = 0;

            for (int i = 1; i <= y; i++)
            {
                Console.Write("{0} ", i);

                a += i;

                for (int j = 1; j < x; j++)
                {
                    a += y;
                    Console.Write("{0} ", a);
                }

                a = 0;
                Console.WriteLine();
            }

            Console.Write("\n12 б) ");
            Console.WriteLine("Enter matrix size: ");
            int nB = Int32.Parse(Console.ReadLine());

            int[,] arrB = new int[nB, nB];
            arrB[0, 0] = 1;

            for (int k = 1; k < arrB.GetLength(0); k++)
                if (k % 2 == 1) arrB[0, k] = arrB[0, k - 1] + nB * 2 - 1;
                else arrB[0, k] = arrB[0, k - 1] + 1;

            for (int l = 1; l < arrB.GetLength(0); l++)
                for (int p = 0; p < arrB.GetLength(1); p++)
                    if (p % 2 == 1) arrB[l, p] = arrB[l - 1, p] - 1;
                    else arrB[l, p] = arrB[l - 1, p] + 1;

            for (int o = 0; o < arrB.GetLength(0); o++)
            {
                for (int u = 0; u < arrB.GetLength(1); u++) Console.Write("{0, 4}", arrB[o, u]);
                Console.WriteLine();
            }

            Console.Write("\n12 в) ");
            Console.Write("Enter arr size: ");
            int lengthC = Int32.Parse(Console.ReadLine());

            int[,] arrC = new int[lengthC, lengthC];
            arrC[lengthC - 1, 0] = 1;
            int counter = 1;
            for (int row = lengthC - 2; row >= 0; row--)
            {
                arrC[row, 0] = arrC[row + 1, 0] + counter;
                int newRow = row;
                for (int diagonal = 1; diagonal <= counter; diagonal++)
                {
                    arrC[newRow + 1, diagonal] = arrC[newRow, diagonal - 1] + 1;
                    newRow++;
                }
                counter++;
            }

            arrC[0, lengthC - 1] = lengthC * lengthC;
            int diagonalLength = 2;
            int posX = 1;
            int posY = lengthC - 1;
            int prevX = 0;
            int prevY = lengthC - 1;

            for (int w = 1; w < counter - 1; w++)
            {
                for (int s = 1; s <= diagonalLength; s++)
                {
                    arrC[posX, posY] = arrC[prevX, prevY] - 1;
                    prevX = posX;
                    prevY = posY;
                    posX--;
                    posY--;
                }
                diagonalLength++;
                posX = w + 1;
                posY = lengthC - 1;
            }

            for (int z = 0; z < arrC.GetLength(0); z++)
            {
                for (int j = 0; j < arrC.GetLength(1); j++) Console.Write("{0, 4}", arrC[z, j]);
                Console.WriteLine();
            }

            Console.Write("\n12 г) ");
            Console.Write("Enter arr size: ");
            int Dlength = Int32.Parse(Console.ReadLine());

            int[,] Darr = new int[Dlength, Dlength];
            int numConcentricSquares = (int)Math.Ceiling((Dlength) / 2.0);
            int sideLen = Dlength;
            int currNum = 0;

            for (int v = 0; v < numConcentricSquares; v++)
            {

                for (int f = 0; f < sideLen; f++) Darr[v + f, v] = ++currNum;

                for (int f = 1; f < sideLen - 1; f++) Darr[Dlength - 1 - v, v + f] = ++currNum;

                for (int f = sideLen - 1; f > 0; f--) Darr[v + f, Dlength - 1 - v] = ++currNum;

                for (int f = sideLen - 1; f > 0; f--) Darr[v, v + f] = ++currNum;

                sideLen -= 2;
            }


            for (int g = 0; g < Darr.GetLength(0); g++)
            {
                for (int h = 0; h < Darr.GetLength(1); h++) Console.Write("{0, 4}", Darr[g, h]);
                Console.WriteLine();
            }

        }
    }
}
