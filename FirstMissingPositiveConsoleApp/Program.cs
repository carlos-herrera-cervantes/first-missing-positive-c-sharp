using System;
using System.Linq;
using FirstMissingPositiveDomain.Models;

namespace FirstMissingPositiveConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new []{ 1, 2, 0 };
            int result = SuperInteger.GetFirstMissingPositive(numbers);

            numbers?.ToList()?.ForEach(number => Console.Write($"{number}, "));
            Console.WriteLine();
            Console.WriteLine($"The first missing positive number is: {result}");
        }
    }
}