using System;

namespace TheCordinatesOfD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Define xa:");
            var xa = double.Parse(Console.ReadLine());
            Console.WriteLine("Define ya:");
            var ya = double.Parse(Console.ReadLine());
            Console.WriteLine("Define xb:");
            var xb = double.Parse(Console.ReadLine());
            Console.WriteLine("Define yb:");
            var yb = double.Parse(Console.ReadLine());
            double t = Math.Pow(xa - xb, 2);
            double p = Math.Pow(ya - yb, 2);
            double d = Math.Sqrt(t - p);
            Console.WriteLine("the result is:"+d);

        }
    }
}
