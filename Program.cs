using System;

namespace DoubleMethods
{
    class Program
    {
        public static int[] Inserter(int[] s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = int.Parse(Console.ReadLine());
            }
            return s;
        }
        public static int Summer(int[] d)
        {
            int sums = 0;
            foreach (var num in d)
            {
                if (num > 0 && num < 50 && num % 3 == 0)
                {
                    sums += num;
                }
            }
            return sums;
        }
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var a = new int[n];
            a = Inserter(a);
            var b = new int[n];
            b = Inserter(b);
            var c = new int[n];
            c = Inserter(c);
            var sumA = Summer(a);
            Console.WriteLine(sumA);
            var sumB = Summer(b);
            Console.WriteLine(sumB);
            var sumC = Summer(c);
            Console.WriteLine(sumC);
            for (int i = 0; i < n; i++)
            {
                c[i] = a[i] * b[n - i];
            }
        }
    }
}
