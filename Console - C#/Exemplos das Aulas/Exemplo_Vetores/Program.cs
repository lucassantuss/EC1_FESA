using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //criando um vetor/array de 10 posições de inteiros
            int[] idade = new int[10];

            for (int cont = 0; cont < 10; cont++)
            {
                Console.Write($"Digite a {cont + 1}ª idade: ");
                idade[cont] = Convert.ToInt32(Console.ReadLine());
            }

            for (int cont = 0; cont < 10; cont++)
            {
                Console.WriteLine($"Idade: {idade[cont]}");
            }
        }
    }
}