using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8_FaixaEtaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercício 8
             * 
             * Programa faixa etária:
             * 
             * Solicite o nome e a idade de uma pessoa.
             * 
             * Então, exiba:
             * 
             * Olá ______ ! Sua idade é ________
             * 
             * Exiba também a faixa etária de acordo com as regras abaixo:
             * Se idade = 0 "bebê"
             * Se idade > 0 e idade <= 12 "Criança"
             * Se idade > 12 e idade <= 18 "adolescente"
             * Se idade > 18 e idade <= 60 "adulto"
             * Se idade > 60 e idade <= 120 "idoso"
             * Se idade > 120 "múmia"
             */

            string nome;
            int idade;

            Console.Write("Digite o nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite a idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("\nOlá " + nome + "! Sua idade é " + idade);

            if (idade == 0)
                Console.WriteLine("\nA sua faixa etária é: Bebê");
            else if (idade > 0 && idade <= 12)
                Console.WriteLine("\nA sua faixa etária é: Criança");
            else if (idade > 12 && idade <= 18)
                Console.WriteLine("\nA sua faixa etária é: Adolescente");
            else if (idade > 18 && idade <= 60)
                Console.WriteLine("\nA sua faixa etária é: Adulto");
            else if (idade > 60 && idade <= 120)
                Console.WriteLine("\nA sua faixa etária é: Idoso");
            else if (idade > 120)
                Console.WriteLine("\nA sua faixa etária é: Múmia");

            Console.ReadKey();
        }
    }
}