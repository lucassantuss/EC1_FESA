using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9_DiaDaSemana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercício 9
             * 
             * Dia da Semana
             * 
             * Solicite um dia da semana (número inteiro) e seu programa deverá informar por extenso qual é o dia.
             * 
             * EX: 1 = domingo
             */

            int dia;

            Console.Write("Digite um dia da semana (1-7): ");
            dia = int.Parse(Console.ReadLine());

            if (dia == 1)
                Console.WriteLine("\nO dia da semana é domingo");
            else if (dia == 2)
                Console.WriteLine("\nO dia da semana é segunda-feira");
            else if (dia == 3)
                Console.WriteLine("\nO dia da semana é terça-feira");
            else if (dia == 4)
                Console.WriteLine("\nO dia da semana é quarta-feira");
            else if (dia == 5)
                Console.WriteLine("\nO dia da semana é quinta-feira");
            else if (dia == 6)
                Console.WriteLine("\nO dia da semana é sexta-feira");
            else if (dia == 7)
                Console.WriteLine("\nO dia da semana é sábado");
            else
                Console.WriteLine("\nDia da semana inválido");

            Console.ReadKey();
        }
    }
}