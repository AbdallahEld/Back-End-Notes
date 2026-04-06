namespace The_Object_Type
{
    /// <summary>
    /// Object is the super type of all types literally anything in C# inherit from object Type,
    /// so you can assign any type of object to a variable of type object,
    /// but to use the object you need to downcast it to the correct type
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // you can push any type of object onto the stack, to pop it you need to know the type of object you are popping and downcast it to that type
            //Stack stack = new Stack();
            //stack.Push(1);
            //stack.Push("susage");
            //stack.Push(2);


            //stack.Push(3);
            //int three = (int)stack.Pop();

            #region Boxing, Unboxing
            //// Boxing is the act of converting a value type to a reference type instance.
            //// the referemce type can be either the object class or an interface (which we visit later in the chapter).
            //// in this example we box an int into an object
            //int x = 9;
            //object obj = x; // boxing for int x

            //// Unboxing is the act of converting a reference type instance back to a value type.
            //int y = (int)obj;

            //object obj2 = 9;
            //long x2 = (int)obj2; // Runtime Error: InvalidCastException, 9 is inferred to ba of type int; // small HINT : To Make code work you can type 9l (the l is a suffix that make sure the 9 is long type if you didnt type it by default its treated as int)

            //object obj3 = 3.5;
            //int x3 = (int)(double)obj3; // x3 is now 3, the double value 3.5 is unboxed and then casted to int, which results in truncation of the decimal part
            #endregion
            #region ToString Method
            // All objects has a function called ToString that return default textual representation of a type instance
            int x = 9;
            Stack y = new Stack();
            Console.WriteLine(x.ToString());
            Console.WriteLine(y.ToString());
            #endregion
        }
    }
}
