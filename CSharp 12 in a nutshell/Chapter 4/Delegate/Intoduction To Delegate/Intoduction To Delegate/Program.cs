namespace Intoduction_To_Delegate
{
    internal class Program
    {
        // A Simple Function That get Square of int x
        static int Square (int x)
        {
            return x * x;
        }
        static int Cube (int x)
        {
            return x * x * x;
        }   
        static void Transform (int[] values, Transformer t)
        {
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = t(values[i]);
            }
        }
        static void WriteProgressToConsole (int percentComplete)
            => Console.WriteLine(percentComplete);

        static void WriteProgressToFile (int percentComplete)
            => File.WriteAllText("progress.txt", percentComplete.ToString());
        // a pointer to function that take int as parameter and return int
        delegate int Transformer (int x);
        delegate void Log(string s);
        public delegate void ProgressReporter (int percentComplete);
        public delegate T Transformer<T>(T arg);
        delegate TResult Func<out TResult>();
        delegate TResult Func<in T, out TResult>(T arg);
        delegate TResult Func<in T1, in T2, out TResult>(T1 arg1, T2 arg2);
        // and so on up to T16
        delegate void Action();
        delegate void Action<in T>(T arg);
        delegate void Action<in T1, in T2>(T1 arg1, T2 arg2);
        // and so on up to T16
        // these delegates are extremely generic for ex the second Func take T and Return TRESULT which mean it will take a generic type and also return a generic type
        static void Main(string[] args)
        {
            #region Introduction
            //// declare instance of our delegate
            //Transformer t = Square;
            //// use t var to invoke 
            //int answer = t(5);
            //Console.WriteLine(answer); 
            #endregion
            #region Console.WriteLine Is Too Long
            // Simply it looks annoying to type Console.WriteLine Each time 
            //Log log = Console.WriteLine;
            //log("hi");

            #endregion
            #region Writing Plug in Methods with Delegates
            // instead of writing two methods to get square and cube of array of int we can write one method that take delegate as parameter and we can pass the method we want to use as delegate parameter
            //int[] values = { 1, 2, 3 };

            //Transform(values, Square);

            //Console.WriteLine("Transform used with Square method:");
            //foreach (int i in values)
            //{
            //    Console.Write($"{i} ");
            //}
            //Console.WriteLine();

            //int[] values2 = { 1, 2, 3 };
            //Console.WriteLine("Transform used with Cube method:");
            //Transform(values2, Cube);
            //foreach (int i in values2)
            //{
            //    Console.Write($"{i} ");
            //}
            #endregion
            #region Instance and Static Method Targets
            /// <summary>
            /// delegate can point to both instance and static method, if the method is static we can directly use the method name to assign it to delegate variable,
            /// but if the method is instance method we need to create an object of the class that contain the method 
            /// and then use the object to assign the method to delegate variable
            /// Delegate not only pointer to method but also contain reference to the object that contain the method
            /// if the method is instance method
            /// </summary>
            /// 
            //MyReporter r = new MyReporter();
            //r.Prefix = "%Complete: ";
            //ProgressReporter  p = r.ReportProgress;
            //p(99);
            //Console.WriteLine(p.Target == r);
            //Console.WriteLine(p.Method);
            //r.Prefix = "";
            //p(99);
            #endregion
            #region Multicast delegate
            /// <summary>
            /// A multicast delegate is a delegate that can point to multiple methods.
            /// When the delegate is invoked, all the methods it points to are called.
            /// </summary>
            ///
            //ProgressReporter p = WriteProgressToConsole;
            //p += WriteProgressToFile;
            //Util.HardWrok(p);
            #endregion
            #region Generic Delegate Types
            /// <summary>
            /// Generic delegate types allow you to define a delegate that can work with any data type.
            /// </summary>
            ///
            //int[] values = { 1, 2, 3 };
            //Util.Transform(values, Square);
            //foreach (int i in values)
            //{
            //    Console.Write($"{i} ");
            //}
            #endregion
            #region Delegates Versus Interfaces
            /// <summary>
            /// A problem that you can solve with a delegate can be also solved with an
            /// interface. For instance, we can rewrite our original example with an interface 
            /// called ITransformer instead of a delegate:
            /// </summary>
            /// 

            #endregion
        }
    }
}
