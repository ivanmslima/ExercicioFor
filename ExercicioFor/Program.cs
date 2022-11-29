using System;
using System.Globalization;

namespace curso
{
    class Progam
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um número: ");
            int numero = int.Parse(Console.ReadLine());

            for(int i=numero; i>0; i=i -numero / 5)
            {
                Console.Write(" " +i);
            }


        }
    }
}