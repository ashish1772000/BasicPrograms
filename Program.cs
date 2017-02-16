using System;
using Common;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = new int[11] { 100, 90, 85, 70,89, 40,30,20,25, 11,1};
            Console.WriteLine("\n Data before sorting: ");
            Common.Helper.DisplayIntArray(inputArr);
            inputArr = Common.Helper.BubbleSort(inputArr);
            Console.WriteLine("\n \n Data after sorting: ");
            Common.Helper.DisplayIntArray(inputArr);
            Console.ReadLine();
        }

    }
}
