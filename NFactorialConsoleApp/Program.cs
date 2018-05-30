using System;
using NFactorialConsoleApp.Services;

namespace NFactorialConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculate = new Calculate();
            Console.WriteLine("Enter a number N and we will return N!");
            var nString  = Console.ReadLine();
            Console.WriteLine(nString + "! =" + calculate.Factorial(Convert.ToInt32(nString)));
        }
    }
}
