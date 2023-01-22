using System;

namespace CSharpLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            //Working with Numbers
            int num1 = 5;
            int num2 = 10;

            int sum = num1 + num2;
            int multiply = num1 * num2;
            int substract = num2 - num1;
            double divide = num2 / num1;
            int modulo = num2 % num1;

            Console.WriteLine(num1 + " + " + num2  + " = " + sum);
            Console.WriteLine(num1 + " * " + num2 + " = " + multiply);
            Console.WriteLine(num2 + " - " + num1 + " = " + substract);
            Console.WriteLine(num2 + " / " + num1 + " = " + divide);
            Console.WriteLine(num2 + " % " + num1 + " = " + modulo);




            /*
             * Working with String
             String name = "Edward";

            Console.WriteLine(" I am " + name.Substring(2, 4) + " I want to learn\nC#");
            Console.WriteLine();    
            Console.WriteLine("C#\"My Future");
            */


            /*
             * Working with input
            Console.Write("Enter your Name: ");
            String name = Console.ReadLine();

            Console.Write("Enter your age: ");
            String age = Console.ReadLine();

            Console.WriteLine("Nice to meet you, " + name + " your age is " + age);
            */
        }
    }
}
