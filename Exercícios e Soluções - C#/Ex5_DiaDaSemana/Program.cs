using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_DiaDaSemana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercicio 5
             * 
             * Dia da Semana
             * 
             * Solicite um dia da semana (número inteiro) e seu 
             * programa deverá informar por extenso qual é o dia. EX: 1 = domingo.
             */

            Console.Write("Digite o dia da semana: 1 (domingo) até 7 (sábado): ");
            int dia = Convert.ToInt32(Console.ReadLine());

            if (dia == 1)
            {
                Console.WriteLine("Domingo");
                Console.ReadLine();
            }
            else if (dia == 2)
                Console.WriteLine("Segunda");
            else if (dia == 3)
                Console.WriteLine("Terça");
            else if (dia == 4)
                Console.WriteLine("Quarta");
            else if (dia == 5)
                Console.WriteLine("Quinta");
            else if (dia == 6)
                Console.WriteLine("Sexta");
            else if (dia == 7)
                Console.WriteLine("Sábado");
            else
                Console.WriteLine("O dia selecionado não é valido!");

            Console.ReadKey();
        }
    }
}