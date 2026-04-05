namespace Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Team team = new();
            team[0] = "Alice";
            team[1] = "Bob";
            team[2] = "Charlie";

            Console.WriteLine(team[0]); // Output: Alice
        }
    }
}
