using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_MediaAluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercício 6
             * 
             * Solicite os seguintes dados de um aluno:
             * 
             * Nome do aluno (string)
             * Nota N1 (double)
             * Nota N2 (double)
             * 
             * Ao final, exiba o nome do aluno e média baseando-se na seguinte fórmula: N1 * 0.4 + N2 * 0.6
             */

            string nome;
            double n1, n2, media;

            Console.Write("Digite o nome do aluno: ");
            nome = Console.ReadLine();

            Console.Write("Digite o valor da Nota N1: ");
            n1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor da Nota N2: ");
            n2 = double.Parse(Console.ReadLine());

            media = (n1 * 0.4) + (n2 * 0.6);

            Console.WriteLine("\nAluno: " + nome + "\nMédia: " + media);
            Console.ReadKey();
        }
    }
}