using Animals;
namespace Instance_versus_static_members
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Panda panda1 = new Panda("Jessica");
            Panda panda2 = new Panda("Shawn");

            Console.WriteLine(Panda.Population);
        }
    }
}
namespace Animals
{
    public class Panda
    {
        public string Name { get; set; }
        public static int Population { get; set; } = 0;

        public Panda(string name)
        {
            Name = name;
            Population = Population + 1;
        }
    }
}

