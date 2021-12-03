using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We will be performing several mathematical computations:");

            Console.WriteLine();
            Console.WriteLine("Please enter the first of two integers:");
            int intA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Please enter the second of two integers:");
            int intB = Convert.ToInt32(Console.ReadLine());

            Add(intA, intB);
            Subtract(intA, intB);
            Multiply(intA, intB);
            Divide(intA, intB);
        }

        public static void Add(int intA, int intB)
        {
            Console.WriteLine("Sum: " + (intA + intB));
      
        }

        public static void Subtract(int intA, int intB)
        {
            Console.WriteLine("Difference: " + (intA - intB));
           
        }

        public static void Multiply(int intA, int intB)
        {
            Console.WriteLine("Product: " + (intA * intB));
        }

        public static void Divide(int intA, int intB)
        {
            Console.WriteLine("Quotient: " + (Convert.ToDouble(intA) / Convert.ToDouble(intB)));
        }
    }
}
