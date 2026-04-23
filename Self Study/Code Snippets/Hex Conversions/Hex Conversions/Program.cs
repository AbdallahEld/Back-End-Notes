namespace Hex_Conversions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = 250;
            string hex = Convert.ToString(value, 16).ToUpper();
            Console.WriteLine($"{value} in hex = 0x{hex}");

            string hexStr = "FA";
            int fromHex = Convert.ToInt32( hexStr, 16 );
            Console.WriteLine($"0x{hexStr} = {fromHex}");

            int opcode = 0xFA;
            Console.WriteLine(opcode);

            Console.WriteLine($"Address: 0x{value:X4}");
        }
    }
}
