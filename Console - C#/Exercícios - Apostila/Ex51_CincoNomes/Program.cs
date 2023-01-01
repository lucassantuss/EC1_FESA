using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex51_CincoNomes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercício 51
             * 
             * Program CincoNomes;
             * 
             * Faça um programa que solicite 5 nomes e 5 salários e então exiba os dados no seguinte formato:
             * 
             * Nome - Salário
             * 
             * Ex:
             * 
             * José da silva 1580,00
             * Maria Xavier 1600,00
             * 
             * ...
             */

            String[] nomes = new string[5];
            double[] salarios = new double[5];

            //entrada de dados
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write("Digite o Nome[{0}]:", i + 1);
                nomes[i] = Console.ReadLine();

                Console.Write("Digite o Salario para {0}:", nomes[i]);
                salarios[i] = double.Parse(Console.ReadLine());
            }

            //saida de dados
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("{0} - {1}", nomes[i], salarios[i]);
            }

            Console.ReadKey();
        }
    }
}