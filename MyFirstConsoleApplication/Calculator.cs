using EnsureThat;
using System;

namespace Calculator
{
    public class Calculator
    {
        public int add(int first, int second)
        {
            Ensure.That(first, nameof(first)).IsGt(0);
            Ensure.That(second, nameof(second)).IsGt(0);
            return first + second;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();

            Console.WriteLine(calculator.add(6, 6));
        }
    }
}