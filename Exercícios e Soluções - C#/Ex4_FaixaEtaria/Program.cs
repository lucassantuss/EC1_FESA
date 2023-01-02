using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_FaixaEtaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercicio 4
             * 
             * Programa faixa etária: (C# e fluxograma)
             * 
             * Solicite o nome e a idade de uma pessoa.
             * 
             * Então, exiba:
             * 
             * Olá ______ ! Sua idade é ________
             * 
             * Exiba também:
             * 
             * Se idade = 0  "bebê"
             * Se idade > 0 e idade <= 12  "Criança"
             * Se idade > 12 e idade <= 18  "adolescente"
             * Se idade > 18 e idade <= 60  "adulto"
             * Se idade > 60 e idade <= 120  "idoso"
             * Se idade > 120 "múmia" 
             */

            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Olá {0}! Sua idade é {1}", nome, idade);

            if (idade <= 0)
                Console.WriteLine("Você é um bebê!");
            else if (idade <= 12)
                Console.WriteLine("Você é uma criança!");
            else if (idade <= 18)
                Console.WriteLine("Você é um Adolescente");
            else if (idade > 18 && idade <= 60)
                Console.WriteLine("Você é um Adulto");
            else if (idade <= 120)
                Console.WriteLine("Você é um Idoso");
            else
                Console.WriteLine("Você é uma Múuuumia!");

            Console.ReadKey();
        }
    }
}