using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._03_lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero para saber se e impar ou par!");
            int numero = int.Parse(Console.ReadLine());
            int divisao = numero % 2;

            if (divisao == 0)
            {
                Console.WriteLine("O seu numero (" + numero + ") e par!");
            }
            else
            {
                Console.WriteLine("O seu numero (" + numero + ") e impar!");
            }
            Console.ReadKey();

        }
    }
}
