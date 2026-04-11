using System.Collections;
using System.Numerics;
using System.Security.Cryptography;

namespace Value_types_vs_reference_types
{
    internal class Program
    {
        //static void ApplyDamage(Player player, int damage)
        //{
        //    player.Health -= damage;
        //} this only modify the copy of the player struct that is passed to the method, not the original player struct that is created in the Main method.
        static void ApplyDamage(ref Player player, int damage)
        {
            player.Health -= damage; // ← modifies the original
        }
        static void Main(string[] args)
        {
            #region Popular Mistake (variables Capturing)
            //var actions = new List<Action>();
            //for (int i = 0; i < 3; i++)
            //{
            //    actions.Add(() => Console.WriteLine(i));
            //}

            //foreach (var action in actions)
            //{
            //    action(); // Output: 3, 3, 3
            //}

            //var actions = new List<Action>();
            //for (int i = 0; i < 3; i++)
            //{
            //    int copy = i;
            //    actions.Add(() => Console.WriteLine(copy));
            //}

            //foreach (var action in actions)
            //{
            //    action(); // Output: 0, 1, 2
            //}
            // The Diffrence here is that in the first example, the variable 'i' is captured by the lambda expression, and since its declared in the loop,
            // it will have the same reference for all iterations, resulting in all actions printing the final value of 'i' (which is 3). In the second example,
            // we create a new variable 'copy' inside the loop, which captures the current value of 'i' for each iteration. This way, each action will print its own captured value of 'copy',
            // resulting in the expected output of 0, 1, and 2.
            #endregion
            #region Check This problem
            //var canvas = new Canvas();
            //var p = canvas.Origin;
            //p.X = 10;

            //Console.WriteLine(canvas.Origin.X); // what is the output? and why?

            // Output is 0
            // because canvas.Origin is a struct (value type) so p  will have a new value that is not associated with the old value canvas.Origin so any mofiy on p will not affect canvas.Origin
            #endregion
            #region Another Problem
            var players = new Player[3];
            players[0] = new Player() { Name = "Alice", Health = 100 };
            ApplyDamage(ref players[0], 30);
            Console.WriteLine(players[0].Health); // Output: 70

            // Another way to fix this problem is to make the Player struct a class (reference type) instead of a struct (value type). This way,
            #endregion
            #region Game Engine Problem
            // You are designing a game engine.
            // You need a type to represent a 3D coordinate.
            // you have 2 Options: Vector3 struct or Vector3 class.?

            // You will have:
            // - Arrays of 100,000 Vector3 objects (particle systems)
            // - Methods that frequently update X, Y, Z values
            // - Vectors passed between many methods

            // To Solve this problem, we need to put in consideration 3 things:
            // 1. Memory Layout and GC Pressure
            // 2. Copy Semantics and mutation
            // 3. The ref keyword as a potential solution

            // What we are gonna do is to make Vector3 a struct (value type) because:
            // - It will be stored on the stack, reducing GC pressure.
            // - Copying small structs is cheap.
            // - We can use the ref keyword to avoid unnecessary copies when needed.
            #endregion
            #region Defensive Copy and readonly struct
            // The problem - compiler makes SILENT defensive copies
            //public struct Vecotr3
            //{
            //    public float X, Y, Z;
            //    public float Length() => MathF.Sqrt(X * X + Y * Y + Z * Z);
            //}

            // When you do this:
            //void ProcessVector(in Vector3 v) // 'in' =  pass by ref, no copy
            //{
            //    var len = v.Length(); // ← compiler secretly copies v here!
            //                          // because Length() MIGHT mutate the struct
            //                          // and 'in' generates no mutation
            //}

            // The fix:
            //public readonly struct Vector3
            //{
            //    public float X { get; }
            //    public float Y { get; }
            //    public float Z { get; }
            //    public Vector3(float x, float y, float z) => (X, Y, Z) = (x, y, z);
            //    public float Length() => MathF.Sqrt(X * X + Y * Y + Z * Z);
            //    // Mutation returns a NEW struct instead of modifying
            //    public Vector3 WithX(float x) => new Vector3(x, Y, Z);
            //}

            // Making the struct readonly tells the compiler that it cannot be mutated,
            // so it won't make defensive copies when you call methods on it.
            // This can improve performance by avoiding unnecessary copying of the struct,
            // especially when it's passed by reference using the 'in' keyword.
            #endregion
        }
    }
}
