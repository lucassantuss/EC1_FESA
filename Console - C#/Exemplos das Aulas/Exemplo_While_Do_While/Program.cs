using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_While_Do_While
{
    internal class Program
    {
        /*
         * Diferenças entre o comando while e o do.. while
         */

        static void Main(string[] args)
        {
            int cont1, cont2;
            double nota1, nota2;

            cont1 = 100;
            do
            {
                Console.WriteLine("do while -> {0}", cont1);
                cont1++;
            } while (cont1 <= 10);


            cont2 = 100;
            while (cont2 <= 10)
            {
                Console.WriteLine("while -> {0}", cont2);
                cont2++;
            }

            //solicitar uma nota para o usuário. Esta nota deve estar entre 0 e 10
            do
            {
                Console.Write("Informe a nota1: ");
                nota1 = Double.Parse(Console.ReadLine());
            } while (nota1 < 0 || nota1 > 10);


            nota2 = 50; //forçar a entrada no laço
            while (nota2 < 0 || nota2 > 10)
            {
                Console.Write("Informe a nota2: ");
                nota2 = Double.Parse(Console.ReadLine());
            }
        }
    }
}