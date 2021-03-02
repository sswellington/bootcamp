using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, x;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            x = a + b;

            Console.WriteLine("X = {0}", x);
        }
    }
}
