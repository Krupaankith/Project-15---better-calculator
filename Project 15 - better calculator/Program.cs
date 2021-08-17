using System;

namespace Project_15___better_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter an Operator: ");
            string op = Console.ReadLine();

            Console.Write("Enter an integer: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.Write(num1 + num2);
            }
            else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }

            else if (op == "^")
            {
                if (num2 != 3)
                {
                    Console.WriteLine(num1 * num1);
                }
                else if (op == "^") num2 = 3;
                {
                    Console.WriteLine(num1 * num1 * num1);
                }
            }

            else if (op == "^") num2 = 4; 
            {
                Console.WriteLine(num1 * num1 * num1 * num1);
            }
               
            Console.ReadLine();
        }
    }
}
