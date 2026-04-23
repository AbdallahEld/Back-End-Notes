namespace Binary_To_Decimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 25;
            string binary = Convert.ToString(number, 2);
            Console.WriteLine($"{number} in binary = {binary}"); 

            string binaryStr = "11001";
            int backToDecimal = Convert.ToInt32(binaryStr, 2);
            Console.WriteLine($"Binary {binaryStr} = {backToDecimal}");

            for (int i = 7; i >= 0; i--)
            {
                int bit = (number >> i) & 1;
                Console.Write(bit);
            }
        }
    }
}
