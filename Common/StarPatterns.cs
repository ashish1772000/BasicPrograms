using System;
namespace Common
{
    public class StarPatterns
    {
        //public static void Main()
        //{
        //    TriangleBottomToTop();
        //    TriangleTopToBottom();        
        //}

        public static void TriangleBottomToTop()
        {
            for (int row = 8; row >= 1; --row)
            {
                for (int col = 1; col <= row; ++col)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
        public static void TriangleTopToBottom()
        {
            for (int row = 1; row <= 8; ++row)
            {
                for (int col = 1; col <= row; ++col)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }

    }

}