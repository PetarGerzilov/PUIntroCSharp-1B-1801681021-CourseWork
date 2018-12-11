using System;

namespace NumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = Console.ReadLine();
            var isNumeric = int.TryParse(test, out int n);
        }
    }
}
