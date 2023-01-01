using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13_ClasseEleitoral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de variáveis
            int idade;

            Console.Write("Digite sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            if (idade < 16)
            {
                Console.WriteLine("\nNão Eleitor");
            }
            else if (idade >= 18 && idade < 65)
            {
                Console.WriteLine("\nEleitor Obrigatório");
            }
            else
            {
                Console.WriteLine("\nEleitor Facultativo");
            }

            Console.ReadKey();
        }
    }
}