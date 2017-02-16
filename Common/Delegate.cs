using System;
using System.Diagnostics;

//class Program
//{
//    static void Main()
//    {
//        /*Console.WriteLine("Display odd numbers..........");
//        Stopwatch stopWatch = new Stopwatch();

//        stopWatch.Start();
//        Service objMyClass = new MyClass();
//        objMyClass.DisplayOddNumbers();
//        stopWatch.Stop();

//        Console.WriteLine("Direct call to the function in another class: " + stopWatch.ElapsedMilliseconds.ToString());*/
//        Client1 client = new Client1();
//        client.ServiceRequest();
//    }
//}
namespace Common
{
    public delegate void Is50OddDelegate(bool b);

    public class Client1
    {
        private Service ser = new Service();

        public void ServiceRequest()
        {            
            Is50OddDelegate del = new Is50OddDelegate(Is50Odd);
            Service ser = new Service();
            ser.Is50AppearsInOddNumbers(del);
        }

        public void Is50Odd(bool b)
        {
            Console.WriteLine(b.ToString());
        }
    }
    
    public class Service
    {

        public void Is50AppearsInOddNumbers(Is50OddDelegate del)
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    if (i == 50)
                        del(true);
                }
            }
        }
    }
}
