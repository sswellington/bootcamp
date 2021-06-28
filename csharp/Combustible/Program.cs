using System;

namespace Combustible
{
    class Program
    {
        static void Main(string[] args)
        {   
            int distance;
            double value, avg;

            distance = Convert.ToInt32(Console.ReadLine());
            value = Convert.ToDouble(Console.ReadLine());

            avg = distance / value;

            Console.WriteLine("{0:0.000} km/l", avg);
        }
    }
}


