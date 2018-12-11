using System;
using System.Linq;


namespace RandomNumberGenerator
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            var rndnums = new int[32];
            for (int i = 0; i < 32; i++)
            {
                rndnums[i] = rnd.Next(51);
            }
            foreach (var num in rndnums)
            {
                if (num > 0)
                {
                    Console.Write(num + " ");
                }
            }
            var insertednums = new int[7];
            int sum = 0;
            for (int i = 0; i < 7; i++)
            {
                insertednums[i] = int.Parse(Console.ReadLine());
                if (insertednums[i] > 200 || insertednums[i] < 0)
                {
                    sum += insertednums[i];
                }
            }
            Console.WriteLine("the sum of the numbers bigger than 200 or less than 0 is:" + sum);

            var numberofrndms = int.Parse(Console.ReadLine());
            var threeinsertednums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var firsttemp = threeinsertednums[0] - threeinsertednums[1];
            if (firsttemp < 0)
            {
                firsttemp *= -1;
            }
            var secondtemp = threeinsertednums[2] + threeinsertednums[0];
            double first = Sred(firsttemp);
            double second = Sred(secondtemp);
            Console.WriteLine(first - second);
        }

        public static double Sred(int s)
        {
            Random rand = new Random();
            var b = new int[s];
            for (int i = 0; i < s; i++)
            {
                b[i] = rand.Next(10, 101);
            }
            double average = b.Average();
            return average;
        }

    }
}
