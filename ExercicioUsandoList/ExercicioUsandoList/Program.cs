using System;
using System.Collections.Generic;

namespace ExercicioUsandoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            int elements = 10;

            for (int i = 0; i < elements; i++)
            {
                list.Add(i.ToString());
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
                
            }

            Console.WriteLine("Tamanho da Lista -->>" + list.Count());


            Console.WriteLine("Informe um numero de 1 a 10");
            string number = Console.ReadLine();
            string result = list.Find(e => e == number);

            Console.WriteLine("encontrando o numeor -->>" + result);


        }   
    }
}