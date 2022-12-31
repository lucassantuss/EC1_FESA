using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criação de variáveis
            string nome;
            int idade;

            //Entrada de Dados
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            idade = Convert.ToInt16(Console.ReadLine());

            //Exibir os dados na tela
            Console.Write("Olá " + nome + ", você tem " + idade + " anos de idade");

            Console.Write("\nOlá {0}, você tem {1} anos de idade", nome, idade);

            Console.Write($"\nOlá {nome}, você tem {idade} anos de idade");

            Console.ReadKey();
        }
    }
}