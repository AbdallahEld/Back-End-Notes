using System.Drawing;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = ['a', 'e', 'i', 'o', 'u'];
            Console.WriteLine(vowels[1]); //e

            // Default Element Intialization //
            int[] a = new int[1000];
            Console.Write(a[123]); // 0

            // Value types versus reference types

            SPoint[] aa = new SPoint[1000];
            int x = aa[500].X;

            CPoint[] aaa = new CPoint[1000];
            int xx = aaa[500].X; // Runtime error, NullReferenceException

            // To Solve this problem
            CPoint[] aaaa = new CPoint[1000];
            for (int i = 0; i < a.Length; i++) // Iterate i from 0 to 999 
            {
                aaaa[i] = new CPoint();
            }
            // Set array element i with new point
        }
    }
}
