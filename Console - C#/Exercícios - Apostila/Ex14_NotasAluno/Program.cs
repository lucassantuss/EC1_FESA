using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14_NotasAluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercício 14
             * 
             * Solicite 3 notas de um aluno.
             * 
             * Calcule a média:
             * 
             * m = (n1 + n2 + n3) / 3
             * 
             * Depois exibir a média e exibir a situação de acordo com as regras a seguir:
             * 
             * se m < 4 -> reprovado direto
             * se m >=7 -> aprovado
             * 
             * caso contrário, está de recuperação. Neste caso, solicite a nota de recuperação.
             * 
             * Se esta nota for < 5 -> reprovado
             * Se for >= 5 -> aprovado
             */

            float n1, n2, n3, n4, media;

            Console.WriteLine("Digite o valor da primeira nota: ");
            n1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da segunda nota: ");
            n2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da terceira nota: ");
            n3 = float.Parse(Console.ReadLine());

            media = (n1 + n2 + n3) / 3;

            Console.WriteLine("\nMédia: " + media);

            if (media < 4)
                Console.WriteLine("\nSituação: Reprovado direto");
            else if (media >= 7)
                Console.WriteLine("\nSituação: Aprovado");
            else
            {
                Console.WriteLine("\nSituação: Está de Recuperação");

                Console.WriteLine("\nDigite o valor da nota de recuperação: ");
                n4 = float.Parse(Console.ReadLine());

                if (n4 < 5)
                    Console.WriteLine("\nSituação: Reprovado");
                else if (n4 >= 5)
                    Console.WriteLine("\nSituação: Aprovado");
            }

            Console.ReadKey();
        }
    }
}