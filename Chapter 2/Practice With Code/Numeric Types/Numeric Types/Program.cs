namespace Numeric_Types
{
    internal class Program
    {
        public static void DrawLine(char symbol, int iterations)
        {
            for (int i = 0; i < iterations; i++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            #region Numeric Literals
            //// intergal type literals can use decimal or hexadecimal notation;
            //// hexadecimal is denoted 0x prefix. For example:
            //int x = 127;
            //long y = 0x7F; // 127

            //Console.WriteLine(x + y);

            ////You can insert an underscore anywhere within a numeric literal to make it
            //// more readable:

            //int million = 1_000_000;

            //// you can specify numbers in binary with the 0b prefix:
            //var b = 0b1010_1011_1101_1110_1111;
            //Console.WriteLine(b);

            //// Real Literals can use decimal and/or exponential notation:

            //double d = 1.5;
            //double millionE = 1E06;
            //DrawLine('-', 100);
            #endregion
            #region Numeric literal type inference
            //// if number has . or E its double else int

            //Console.WriteLine(1.0.GetType()); // Double
            //Console.WriteLine(1E06.GetType()); // Double
            //Console.WriteLine(1.GetType()); // Int32
            //Console.WriteLine(0xF000000.GetType()); // UInt32
            //Console.WriteLine((0x100000000.GetType()));// Int64
            //DrawLine('-', 100);
            #endregion
            #region Numeric Suffixes
            //var f = 1.0F; //Float
            //var d = 1D; // Double
            //var dc = 1.0M; // Decimal
            //var u = 1U; ; // UInt32
            //var i = 1L; // Int64
            //var ui = 1UL; // UInt64

            //Console.WriteLine(f.GetType());
            //Console.WriteLine(d.GetType());
            //Console.WriteLine(dc.GetType());
            //Console.WriteLine(u.GetType());
            //Console.WriteLine(i.GetType());
            //Console.WriteLine(ui.GetType());

            //// F and M suffixes are the most useful and should always be applied when
            //// specifying float or decimal literals without the F suffix, the following
            //// line whould not compile, because 4.5 would be inferred to be f type double
            //// whhich has implicit conversion to float

            //float ff = 4.5F;
            //decimal dd = -1.23M;
            #endregion
            #region Numeroc Conversions
            //// Converting between intergal types //

            //int x = 12345; // int is a 32-bit integer
            //long y = x; // Implicit conversion to 64-bit integral type
            //short z = (short)x; // Explicit conversion to 16-bit integral type (may cause loss in data)

            //// Converting between floating-point and integral types //
            //// Implicit from integral to float-point
            //int i = 1;
            //float f = i;

            //// reverse is explicit
            //int i2 = (int)f;
            #endregion
            #region Overflow
            //// At runtime, arthimetic operations on itegral types can overflow. By
            //// default, this happens silently-no exception is thrown, for Example
            //// decreasing the minimum possible int value results in the maximum possible int value
            //int a = int.MinValue;
            //a--;
            //Console.WriteLine(a == int.MaxValue); //True
            #endregion
        }
    }
}
