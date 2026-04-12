using System.Collections;
using System.Diagnostics;

namespace Boxing_Performance_Cost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sw = Stopwatch.StartNew();

            var list = new List<int>();
            for (int i = 0; i < 10_000_000; i++)
            {
                list.Add(i);
            }

            sw.Stop();
            Console.WriteLine($"Time elapsed: {sw.ElapsedMilliseconds} ms");

            sw.Restart();
            // With boxing - ArrayList
            var arrayList = new ArrayList();
            for (int i = 0; i < 10_000_000 ; i++)
            {
                arrayList.Add(i); 
            }

            sw.Stop();
            Console.WriteLine($"ArrayList: {sw.ElapsedMilliseconds}ms");
        }
    }
}
