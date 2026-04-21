using System.Collections;
using System.Text;

namespace Boolean__Character_and_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Boolean
            //// Boolean Theoratically need only 1 bit but Technically it takes 1 byte (8 bits)
            //// Smallest Unit CPU store is 1 byte thats why it get stored in 1 byte
            //bool[] arr = new bool[1000]; // 1000 byte
            //BitArray arr2 = new BitArray(1000); // 125 byte

            ////you cannot convert from int to bool or the opposite
            //int x = (int)true;  // error
            //bool b = (bool)1;   // error

            //// Equality //
            //// Value Type
            //int xx = 1;
            //int y = 1;

            //Console.WriteLine(x == y); // True

            //// Ref Type
            //var d1 = new Dude("John");
            //var d2 = new Dude("John");

            //Console.WriteLine(d1 == d2); // False
            #endregion
            #region Character
            //char c = 'A'; // Take 2 bytes

            ////Escape Sequences
            //char newLine = '\n';
            //char backSlash = '\\';

            ////Unicode
            //char omega = '\u03A9';
            //Console.WriteLine(omega);
            #endregion
            #region String
//            string s = "Hello"; //ref type + Immutable
//            s += "World"; // new object created - Old One Handeld by Garbage collector

//            // Equal //
//            string a = "test";
//            string b = "test";
//            Console.WriteLine(a == b); // Despite it being ref type it compare Values

//            // New Line //
//            string ss = @"Line 1
//Line 2";
//            Console.Write(ss);

//            string sss = """He said "Hello" """;
//            Console.WriteLine(sss);

//            // Using for loop with string to Concatenation //
//            // is horrible 
//            // for (...)
//            //     s += "add"
//            // This is make new obj Each time
//            // Instead Use
//            var sb = new StringBuilder();
//            sb.Append("text");

//            // Strin Interpolation //
//            int x = 4;
//            Console.WriteLine($"Square has {x} sides");
            #endregion
        }
    }
}
