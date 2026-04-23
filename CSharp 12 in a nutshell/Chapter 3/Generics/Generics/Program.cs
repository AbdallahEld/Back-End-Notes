namespace Generics
{
    internal class Program
    {
        // With generics many fundamental algorithms can be implemented in
        // a general purpose way. for example here is a function that is used to
        // swap two variables from the same data type
        static void Swap<T> (ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
        // Here we use generic constrains to build a max function that return
        // the biggest value of T type, 
        static T Max<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
        static void Main(string[] args)
        {
            var stack = new Stack<int>();
            stack.Push(5);
            stack.Push(10);
            int x = stack.Pop(); // 10
            int y = stack.Pop(); // 5

            int a = 5;
            int b = 10;
            Swap<int>(ref a, ref b);
        }
    }
}
