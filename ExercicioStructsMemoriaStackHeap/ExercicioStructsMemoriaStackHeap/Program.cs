using System;

namespace ExercicioStructsMemoriaStackHeap // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p;

            p.x = 1;
            p.y = 2;

            Console.WriteLine(p);

            Point p2 = new Point();

            Console.WriteLine(p2);
        }
    }
}