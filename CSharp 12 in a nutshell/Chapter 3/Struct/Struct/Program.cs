using System.Runtime.InteropServices;

namespace Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebOptions options = default;
            Console.WriteLine(options.Protocol);

            // Ref Struct Rules
            // it cannot be moved out of the stack (porhibited)
            // lifetime short
            MyRefStruct refStruct = new MyRefStruct();
            //object x = refStruct; // Compile-Error cannot be boxed
            // cannot be stored in class
            // cannot be used in async or lambdas
            // cannot be stored or sent to IEnumrable

            // its used for Performance + Security when dealing with memory and its mostly common use
            // Span<T>, ReadOnlySpan<T> (I touched these subjects but i am not fully aware of them yet i think i will reach them at Chapter 23 of the book)
        }
    }
    public class UseMyRefStruct 
    {
        //MyRefStruct s; // Compile Error
    }
}
