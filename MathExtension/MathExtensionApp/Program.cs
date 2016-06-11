using System;
using MathExtension.Extensions;

namespace MathExtensionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = 1.Add(9).Subtract(8).Multiply(5).Divide(10);
            Console.WriteLine(result);
        }
    }
}
