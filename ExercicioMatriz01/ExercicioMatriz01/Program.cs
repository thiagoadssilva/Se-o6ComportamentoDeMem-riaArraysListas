using System;

namespace ExercicioMatriz01 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe quantidade da matriz");
            int amountMatriz = int.Parse(Console.ReadLine());

            int[,] mat = new int[amountMatriz, amountMatriz];
            Console.WriteLine("Informe os " + amountMatriz + "numeros");

            for (int i=0; i < mat.GetLength(0); i++) {
                string[] values = Console.ReadLine().Split();
                for (int x=0; x < mat.GetLength(1); x++) {
                    //Console.WriteLine("Informe os numeros da linha " + i + " e coluna " + x);
                    //mat[i, x] = int.Parse(Console.ReadLine());
                    mat[i, x] = int.Parse(values[x]);
                }
            }

            Console.WriteLine("Main diagonal");
            for (int i=0; i < mat.GetLength(0); i++)
            {
                Console.WriteLine(mat[i,i] + "");
            }

            int count = 0;
            for(int i=0; i<mat.GetLength(0); i++)
            {
                for (int x=0; x<mat.GetLength(1); x++) {
                    if(mat[i,x] < 0)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine("Negative number -->" + count);

            /*Console.WriteLine(mat.Length);
            Console.WriteLine(mat.GetLength(0));
            Console.WriteLine(mat.GetLength(1));
            Console.WriteLine(mat.Rank);*/
        }
    }
}