namespace Intoduction_To_Delegate
{
    internal class Program
    {
        // A Simple Function That get Square of int x
        static int Square (int x)
        {
            return x * x;
        }
        // a pointer to function that take int as parameter and return int
        delegate int Transformer (int x);
        delegate void Log(string s);
        static void Main(string[] args)
        {
            #region Introduction
            //// declare instance of our delegate
            //Transformer t = Square;
            //// use t var to invoke 
            //int answer = t(5);
            //Console.WriteLine(answer); 
            #endregion
            #region Console.WriteLine Is To Long
            // Simply it looks annoying to type Console.WriteLine Each time 
            Log log = Console.WriteLine;
            log("hi");

            #endregion
        }
    }
}
