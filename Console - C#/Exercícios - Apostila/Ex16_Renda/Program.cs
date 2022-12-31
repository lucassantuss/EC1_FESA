using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16_Renda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exercício 16
             * 
             * Renda
             * 
             * Solicite: nome, salário, sexo(M/F) e exiba ao final:
             * 
             * Olá sr(a) nome, seu salário é ____
             * 
             * Seu sexo é:
             * (se for 'M' ou 'm' exibir "masculino"
             * se for 'F' ou 'f' exibir "feminino")
             * 
             * (Se salario = 0 exibir "falido"
             * salario entre 1 e 15000 "marajá"
             * salario > 15000 "Corintiano")
             */

            string nome;
            double salario;
            char sexo;

            Console.Write("Digite seu Nome: ");
            nome = Console.ReadLine();

            Console.Write("Informe seu salário: ");
            salario = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe seu sexo (M/F): ");

            //ja converte para maiusculo
            sexo = Console.ReadLine().ToUpper()[0]; //vai pegar somente a primeira letra

            Console.WriteLine("\nOlá Sr(a) {0}, seu salario é R$ {1:0.00}", nome, salario);

            if (sexo == 'M')
                Console.WriteLine("\nSeu sexo é Masculino");
            else if (sexo == 'F')
                Console.WriteLine("\nSeu sexo é Feminino");
            else
                Console.WriteLine("\nVocê não escolheu um sexo válido...");

            //salario...
            if (salario == 0)
                Console.WriteLine("\nSeu fálido!!!");
            else if (salario <= 15000)
                Console.WriteLine("\nMarajá...");
            else
                Console.WriteLine("\nCorintianuuuuuuuu");

            Console.ReadKey();
        }
    }
}