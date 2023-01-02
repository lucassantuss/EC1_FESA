using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8_MediaAluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            8.	Solicite 3 notas de um aluno.

            Calcule a média: 

            m = (n1 + n2 + n3) / 3

            Depois exibir a média e exibir  a situação de acordo com as regras a seguir:

            se m < 4 -> reprovado direto
            se m >=7 -> aprovado
            caso contrário, está de recuperação. 
            
            Neste caso, solicite a nota de recuperação. 
            Se esta nota for < 5 -> reprovado
            Se for >= 5 -> aprovado
            */

            double m, n1, n2, n3;

            Console.Write("Digite a 1ª nota: ");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a 2ª nota: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a 3ª nota: ");
            n3 = Convert.ToDouble(Console.ReadLine());

            m = (n1 + n2 + n3) / 3;

            Console.WriteLine("Média : {0:F2}", m);

            if (m < 4)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("REPROVADOOOO");
                Console.ResetColor();
            }
            else if (m >= 7)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Aprovado");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Digite a nota da recuperação: ");
                Console.ResetColor();
                double recuperacao = Convert.ToDouble(Console.ReadLine());

                if (recuperacao >= 5)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Aprovado");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("REPROVADOOOO");
                    Console.ResetColor();
                }
            }

            Console.ReadKey();
        }
    }
}