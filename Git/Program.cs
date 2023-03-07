using Git.Classes;
using Git.Triangles;

namespace Git
{
    internal class Program
    {
        static void Main()
        {
            Triangle triangle = new TriangleBuilder().CreateTriangle(5, 5, 5);
            Console.Write(triangle.GetSquare());
        }       
    }
}
