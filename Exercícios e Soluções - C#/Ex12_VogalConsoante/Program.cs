using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12_VogalConsoante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercicio 12
             * 
             * Solicite o nome e o sexo de uma pessoa.
             * 
             * Exibir:
             * 
             * Se o nome da pessoa começar com uma vogal, exibir:
             * Olá _______  seu nome inicia com uma vogal.
             * 
             * Caso contrário, exiba:
             * Olá _______  seu nome inicia com uma consoante.
             * 
             * Se o sexo for 'M' ou 'm', exiba:
             * Sexo: Masculino
             * Se o sexo for 'F' ou 'f', exiba:
             * Sexo: Feminino
             */

            string nome;
            char sexo;

            Console.WriteLine("Digite o nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o sexo (F/M): ");
            sexo = Convert.ToChar(Console.ReadLine());

            char pLetra = nome.ToLower()[0];

            if (pLetra == 'a' || pLetra == 'e' ||
                pLetra == 'i' ||
                pLetra == 'o' || pLetra == 'u')
                Console.WriteLine("Seu nome começa com uma vogal.");
            else
                Console.WriteLine("Seu nome começa com uma consoante.");

            if (sexo == 'M' || sexo == 'm')
                Console.WriteLine("Sexo: Masculino");
            else if (sexo == 'F' || sexo == 'f')
                Console.WriteLine("Sexo: Feminino");
            else
                Console.WriteLine("Sexo: indefinido");

            Console.ReadKey();
        }
    }
}