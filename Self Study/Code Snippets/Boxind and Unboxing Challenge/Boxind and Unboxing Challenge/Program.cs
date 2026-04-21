using System.Diagnostics;

namespace Boxind_and_Unboxing_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int iterations = 1_000_000;
            int id = 42;
            DateTime time = DateTime.Now;

            Span<char> buffer = stackalloc char[100];

            var sw1 = Stopwatch.StartNew();
            for (int i = 0; i < iterations; i++)
            {
                Helper.FormatUserLog(id, time, buffer);

            }
            long allocatedBytes1 = GC.GetTotalAllocatedBytes();
            sw1.Stop();
            

            var sw2 = Stopwatch.StartNew();
            for (int i = 0; i < iterations; i++)
            {
                Helper.FormatUserLogV2(id, time);
            }
            long allocatedBytes2 = GC.GetTotalAllocatedBytes();
            sw2.Stop();

            Console.WriteLine($"FormatUserLog: {sw1.ElapsedMilliseconds} ms, Allocated Bytes: {allocatedBytes1}");
            Console.WriteLine($"FormatUserLogV2: {sw2.ElapsedMilliseconds} ms, Allocated Bytes: {allocatedBytes2}");
            // you may noticed buffer is not always the fastest, but it is more memory efficient, cause it put the load more on cpu through the operations we make 
            // while the string version is more memory intensive but it is faster, cause it is optimized for that kind of operations, and it is more efficient in terms of cpu usage, but it is not as memory efficient as the buffer version.
            // tbh i dont see a use for it in 99% of the cases, but just good to know theres always a more memory efficient way in case you need to optimize for memory usage,
            // but in most cases you should just use the string version, cause it is more convenient and it is optimized for that kind of operations, and it is more efficient in terms of cpu usage,
            // but it is not as memory efficient as the buffer version.
        }
    }
}
