using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex31_Sobrenome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            31.	PROGRAMA SOBRENOME

            Faça um programa que solicite um nome e após 
            validar se o nome foi digitado completo  
            (com nome e sobrenome), ele  deverá exibir apenas o sobrenome.  
            Caso não seja informado um sobrenome, exibir um erro. 
            Não utilize o comando substring!

            Ex:
            Informe um nome:  ana lucia da silva
            Seu sobrenome é:  lucia da silva
            */

            string nome;
            do
            {
                Console.Write("Digite seu nome completo: ");
                nome = Console.ReadLine().Trim();
            }
            while (nome.IndexOf(' ') == -1);

            int posicaoEspaco = nome.IndexOf(' ');

            for (int n = posicaoEspaco + 1; n < nome.Length; n++)
                Console.Write(nome[n]);

            Console.ReadLine();
        }
    }
}