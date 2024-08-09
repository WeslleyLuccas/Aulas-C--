using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Exercicio
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Qual sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            int maioridade = 18;

            if (idade >= maioridade)
            {
                Console.WriteLine("Voce e maior de idade!");
            }
            else
            {
                Console.WriteLine("Voce e de menor idade!");
            }
        }
    }
}
