using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data.Common;

namespace Basic_calculator_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 ; int num2 ;

            Console.WriteLine("Enter the Number for num1:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Numner for num2:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the type of operator to be performed:");
            // Console.WriteLine("Choose an option from the following list:");
            //Console.WriteLine("+");
            //Console.WriteLine("-");
            //Console.WriteLine("*");
            //Console.WriteLine("/");
            //Console.Write("Your option? ");



                    switch (Console.ReadLine())
                    {
                case "+":
                    Console.WriteLine("Addition = " + (num1 + num2));
                    break;

                case "-":
                    Console.WriteLine("Substration = " + (num1 - num2));
                    break;

                case "*":
                    Console.WriteLine("Multiplication = " + (num1 * num2));
                    break;

                case "/":
                    Console.WriteLine("Divison= " + (num1 / num2));
                    break;
            }
        }
    }
              
}


