using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int fat = 1;
            
            for (int i = 1; i <= N; i++) {
                fat *= i;
            }
            Console.WriteLine(fat);
        }
    }
}
