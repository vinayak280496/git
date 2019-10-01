using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArthmaticOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This Program is developed by Shubham Sajannavar");
            Console.WriteLine("Roll No : CA172007, Rani Channamma University, Belgavi");
            int add, sub, mul, num1, num2;
            float div;
            try
            {
                Console.WriteLine("Enter 1st Number : ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 2nd Number : ");
                num2 = Convert.ToInt32(Console.ReadLine());
                add = num1 + num2;
                sub = num1 - num2;
                mul = num1 * num2;
                div = num1 / num2;
                Console.WriteLine("Addition of \t\t" + num1 + " and " + num2 + " = " + add);
                Console.WriteLine("\nSubstration of \t\t" + num1 + " and " + num2 + " = " + sub);
                Console.WriteLine("Multiplication of \t" + num1 + " and " + num2 + " = " + mul);
                Console.WriteLine("\nDivision of \t\t" + num1 + " and " + num2 + " = " + div);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Enter valid Number");

            }
            Console.ReadKey();

        }
    }
}
