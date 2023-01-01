using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex19_MaisNovo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercício 19
             * 
             * Leia o nome e a idade de 10 pessoas e exiba o nome da pessoa mais nova. 
             */

            // Declaração de Variáveis
            string nome = "", nomenovo = "";
            double idade = 0, novo = 0;

            Console.WriteLine("Vamos ver quem é o mais novo?");

            Console.WriteLine("\nDigite o nome e a idade de 10 pessoas:");

            //Laço de repetição de 1 até 10 
            for (int i = 1; i <= 10; i++)
            {
                //Solicitando as próximas idade
                Console.Write("\n" + i + "° nome: ");
                nome = Console.ReadLine();

                Console.Write("" + i + "ª idade: ");
                idade = Convert.ToDouble(Console.ReadLine());

                //Condição para ser o mais novo 
                if (novo > idade)
                {
                    nomenovo = nome;
                    novo = idade;
                }
            }

            // Imprimindo resultado na tela do usuário
            Console.WriteLine($"\nO(a) mais novo(a) é o(a) {nomenovo}, com {novo} anos.");

            // Comando para esperar o usuário usar uma tecla
            Console.ReadKey();
        }
    }
}