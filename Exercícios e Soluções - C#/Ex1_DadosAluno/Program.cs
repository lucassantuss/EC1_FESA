using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_DadosAluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome, telefone, endereco;

            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite seu endereço: ");
            endereco = Console.ReadLine();

            Console.Write("Digite seu telefone: ");
            telefone = Console.ReadLine();

            Console.WriteLine("Nome: {0} \nEndereço: {1} \nTelefone: {2}" +
                "\n\nObrigado por usar este programa, {0}",
                 nome, endereco, telefone);

            Console.ReadKey();
        }
    }
}