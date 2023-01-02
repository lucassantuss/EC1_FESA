using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_Delegacia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercício 2 - Delegacia
             * 
             * Solicite os seguintes dados:  nome, sobrenome, rua, nº, bairro,cidade, estado, cep.
             * 
             * Exiba:
             * 
             * Sr: Nome + “  “ +Sobrenome +  Residente à Rua, nº, 
             * bairro, cidade - estado, CEP. Favor comparer à delegacia.
             */

            string nome, sobrenome, rua, numero, bairro, cidade,
                   estado, cep;

            Console.Write("Digite o nome: ");
            nome = Console.ReadLine();

            Console.Write("Digite o sobrenome: ");
            sobrenome = Console.ReadLine();

            Console.Write("Digite a rua : ");
            rua = Console.ReadLine();

            Console.Write("Digite o número: ");
            numero = Console.ReadLine();

            Console.Write("Digite o bairro: ");
            bairro = Console.ReadLine();

            Console.Write("Digite a cidade : ");
            cidade = Console.ReadLine();

            Console.Write("Digite o estado : ");
            estado = Console.ReadLine();

            Console.Write("Digite o CEP: ");
            cep = Console.ReadLine();

            Console.WriteLine("Sr: {0} {1} Residente à Rua {2}," +
                "nº {3}, bairro {4}, cidade {5}-{6}, CEP: {7}. " +
                "Favor comparecer à delegacia.", nome, sobrenome,
                rua, numero, bairro, cidade, estado, cep);

            Console.WriteLine(
               "Sr: " + nome + " " + sobrenome +
               " Residente à Rua " + rua +
               ",nº " + numero + ", bairro " + bairro + ", cidade " +
               cidade + "-" + estado + ", CEP: " + cep +
               ". Favor comparecer à delegacia.");

            Console.ReadKey();
        }
    }
}