using System;

namespace FindingPi
{
    class Program
    {
        static void Main(string[] args)
        {
            double a=double.Parse(Console.ReadLine());
            int counter = 1;
            double sum = 0;
            for (int i = 1; i < 10000; i+=2)
            {
                if (counter % 2 == 0)
                {
                    sum = sum + (a / i);
                    counter++;
                }
                else
                {
                    sum = sum - (a / i);
                    counter++;
                }
            }
            double p = 4 * sum;
            Console.WriteLine(p);
        }
    }
}
