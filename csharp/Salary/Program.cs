using System;

namespace Salary
{
    class Program
    {   
        public static void str(double salary, double adjustment) 
        {   
            double bonus = salary * adjustment;
            double new_salary = salary + bonus;

            Console.WriteLine("Novo salario: {0:0.00}", new_salary);
            Console.WriteLine("Reajuste ganho: {0:0.00}", bonus);
            Console.WriteLine("Em percentual: {0} %", (int)(adjustment * 100));
        }

        public static void checked_salary(double salary)
        {
            if (salary <= 400.00)
            {
                str(salary, 0.15);
            }
            else if (salary <= 800.00)
            {
                str(salary, 0.12);
            }
            else if (salary <= 1200.00)
            {
                str(salary, 0.1);
            }
            else if (salary <= 2000.00)
            {
                str(salary, 0.07);
            }
            else
            {
                str(salary, 0.04);
            }
        }

        static void Main(string[] args)
        {
            double salary;
            salary = Convert.ToDouble(Console.ReadLine());

           checked_salary(salary);
        }
    }
}
