using BenchmarkDotNet.Running;
using System.Diagnostics;

namespace Primitive_vs_non_Premitive_Performance_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int iterations = 100_000_000;
            var sw1 = Stopwatch.StartNew();

            int x = 0;
            for (int i = 0; i < iterations; i++)
            {
                x += 1;
            }

            sw1.Stop();

            Console.WriteLine($"int time: {sw1.ElapsedMilliseconds}ms");

            var sw2 = Stopwatch.StartNew();

            decimal y = 0;
            for(int i = 0;i < iterations; i++)
            {
                y += 1;
            }
            sw2.Stop();

            Console.WriteLine($"decimal time: {sw2.ElapsedMilliseconds}ms");

            Console.WriteLine("----------------------------------------------");

            BenchmarkRunner.Run<Test>();
        }
    }
}
