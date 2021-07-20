using System;

namespace AdditionAndSubstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1, Num2;
            Console.WriteLine("Enter the Num1");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Num2");
            Num2 = Convert.ToInt32(Console.ReadLine());

            int add, sub;

            add = Num1 + Num2;
            sub = Num1 - Num2;
            Console.WriteLine("Sum of two numbers:" + add.ToString());
            Console.WriteLine("The Substraction of two numbers:" + sub.ToString());
        }
    }
}
