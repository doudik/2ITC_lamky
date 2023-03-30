using System.Diagnostics;
using System.Numerics;

namespace Multithreadingtest
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch s = new Stopwatch();
            Random rnd = new Random();
            double max = 1_000d;
            double min = 0d;
            long n = 1_000_000_000;
            double x;
            double y;
            long hit = 0;
            long total = 0;
            double pi = 0;
            /*
            s.Start();
            for (long i = 0; i < n; i++)
            {
                x = NextDouble(min, max);
                y = NextDouble(min, max);
                double tmp = (Math.Pow(x, 2) + Math.Pow(y, 2));
                double d = Math.Sqrt(tmp);

                if (d <= max)
                {
                    hit++;
                }
                total++;
            }
            pi = 4 * hit / total;
            s.Stop();
            Console.WriteLine("for:");
            Console.WriteLine("Time elapsed: {0}ms", s.Elapsed.TotalMilliseconds);
            Console.WriteLine(hit);
            Console.WriteLine(total);
            Console.WriteLine(pi);
            Console.WriteLine("Control pi: {0}", MathF.PI);
            s.Restart();
            */
            ParallelOptions options = new ParallelOptions();
            options.MaxDegreeOfParallelism = 24;
            s.Start();

            Parallel.For(0, n, f =>
            {   
                x = NextDouble(min, max);
                y = NextDouble(min, max);

                double d = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

                if (d <= max)
                {
                    hit = Interlocked.Increment(ref hit);
                }
                total = Interlocked.Increment(ref total);
            });

            pi = 4d * hit / total;
            s.Stop();
            Console.WriteLine("Parallel For");
            Console.WriteLine("Time elapsed: {0}ms", s.Elapsed.TotalMilliseconds);
            Console.WriteLine(hit);
            Console.WriteLine(total);
            Console.WriteLine(pi);
            Console.WriteLine("Control pi: {0}", MathF.PI);

            double NextDouble(double min ,double max)
            {
                return rnd.NextDouble() * (max - min) + min;
            }
        }
    }
}