// See https://aka.ms/new-console-template for more information
using System;

namespace ActivityArithmethic1 {
    public class Math {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Sub(int num1, int num2)
        {
            return num1 - num2;
        }
        public int Mult(int num1, int num2)
        {
            return num1 * num2;
        }
        public int Div(int num1, int num2)
        {
            return num1 / num2;
        }

    }

    class program
    {
        static void Main(string[] args)
        {
            Math math = new Math();

            int num1, num2;

            //ADDITION
            Console.WriteLine("Enter number to add: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number to add: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Total number = " + math.Add(num1, num2));
            Console.WriteLine("_____________________________________________");

            //SUBTRACTION
            Console.WriteLine("Enter number to subtract: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number to subtract: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Total number = " + math.Sub(num1, num2));
            Console.WriteLine("_____________________________________________");

            //DIVISION
            Console.WriteLine("Enter number to divide: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number to divide: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Total numbe = " + math.Div(num1, num2));
            Console.WriteLine("_____________________________________________");

            //MULTIPLICATION
            Console.WriteLine("Enter number to multiply: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number to multiply: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Total number = " + math.Mult(num1, num2));
            Console.WriteLine("_____________________________________________");
        }
    }
}



