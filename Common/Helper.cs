using System;
using System.Diagnostics;
namespace Common
{
    public class Helper
    {
        //public static void Main()
        //   {
        //       /* int firstElement = 8;
        //       int secondElement = 15;


        //       Console.WriteLine(" Before Swap: \n First element:" +firstElement +" Second element: " +secondElement);
        //       SwapWithoutTemp(ref firstElement, ref secondElement);
        //       Console.WriteLine(" After Swap: \n First element:" + firstElement + " Second element: " + secondElement);
        //       */

        //       int[] myArray1 = new int[6] { 8, 20, 44, 2, 7, 9 };
        //       int[] myArray2 = new int[6] { 2, 2, 2, 2, 2, 2 };
        //       int[] myArray3 = new int[6] { 8, 20, 44, 2, 7, 9 };
        //       int[] myArray4 = new int[6] { 8, 20, 44, 2, 7, 9 };

        //       Console.WriteLine("Before sorting: ");
        //       foreach (int i in myArray1)
        //           Console.Write(" " + i);

        //       Stopwatch sw = new Stopwatch();
        //       sw.Start();
        //       int[] sortedArray = BubbleSort(myArray1);
        //       sw.Stop();
        //       Console.WriteLine("Time taken: " + sw.ElapsedMilliseconds);

        //       sw.Start();
        //       int[] sortedArray1 = BubbleSort(myArray2);
        //       sw.Stop();
        //       Console.WriteLine("Time taken: " + sw.ElapsedMilliseconds);

        //       Console.WriteLine("After sorting: ");
        //       foreach (int i in sortedArray)
        //           Console.Write(" " + i);
        //   }

        public static void DisplayIntArray(int[] arr)
        {
            foreach (int item in arr)
            {
                Console.Write(" ");
                Console.Write(item);
            }
        }

        public static void SwapWithoutTemp(ref int firstElement, ref int secondElement)
        {
            firstElement = firstElement + secondElement;
            secondElement = firstElement - secondElement;
            firstElement = firstElement - secondElement;
        }

        public static void SwapWithTemp(ref int firstElement, ref int secondElement)
        {
            int temp = 0;
            temp = firstElement;
            firstElement = secondElement;
            secondElement = temp;
        }

        public static int[] BubbleSort(int[] arr)
        {
            int[] retArray = arr;

            for (int iPass = 0; iPass < arr.Length - 1; iPass++)
            {
                int iLeft = 0;
                int iRight = iLeft + 1;

                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[iLeft] > arr[iRight])
                        SwapWithoutTemp(ref arr[iLeft], ref arr[iRight]);

                    iLeft++;
                    iRight = iLeft + 1;
                }
            }
            return retArray;
        }
    }
}