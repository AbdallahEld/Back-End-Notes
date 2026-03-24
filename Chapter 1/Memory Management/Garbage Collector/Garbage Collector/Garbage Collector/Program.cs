namespace Garbage_Collector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region GC.Collect()
            //for(int i = 0; i < 1000; i++)
            //{
            //    var obj = new object();
            //}

            //GC.Collect(); // forces garbage collection
            //GC.WaitForPendingFinalizers();

            //Console.WriteLine("Forced garbage collection completed");
            #endregion
            #region GC.GetTotalMemory()
            // returns the number of bytes currently allocated in managed memory
            //long before = GC.GetTotalMemory(false);
            //int[] arr = new int[1000];
            //long after = GC.GetTotalMemory(false);

            //Console.WriteLine($"Memory before : {before}");
            //Console.WriteLine($"Memory after : {after}");
            #endregion
            #region GC.MaxGeneration
            // Returns The maximum generation supported by the system (usually 2)
            //Console.WriteLine("Maximum Generation: " + GC.MaxGeneration);
            #endregion
            #region GC.GetGeneration(object obj)
            // return the generation in which object resides
            //string name = "Hello";
            //Console.WriteLine("Generation of name: " + GC.GetGeneration(name));
            #endregion
            #region GC.WaitForPendingFinalizers()
            //GC.Collect();
            //GC.WaitForPendingFinalizers();
            #endregion
        }
    }
}
