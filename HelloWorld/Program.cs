using System;

namespace BaiTapCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;

            if (a % 2 == 0)
                Console.WriteLine("\n {0} la so chan !", a);
            else
                Console.WriteLine("\n {0} la so le !", a);
        }
    }
}