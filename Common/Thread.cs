using System;
using System.Threading;
namespace Common
{
    public class Sample1
    {
        //public static void Main()
        //{
        //    Thread workerThread1 = new Thread(getResource1);
        //    Thread workerThread2 = new Thread(getResource2);

        //    Console.WriteLine("Entering to Resource 1");
        //    // getResource1();
        //    workerThread1.Start();
        //    Console.WriteLine("Exiting from Resource 1");

        //    Console.WriteLine("Entering to Resource 2");
        //    //getResource2();
        //    workerThread2.Start();
        //    Console.WriteLine("Exiting from Resource 2");
        //}

        public static void getResource1()
        {
            Console.WriteLine("Resource 1 access!");
            Thread.Sleep(5000);
        }

        public static void getResource2()
        {
            Console.WriteLine("Resource 2 access!");
            Thread.Sleep(5000);
        }
    }
}