using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8_MultiplicaImpares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            8-) (até 1,5 ptos) 
            Dada uma string informada pelo usuário, onde há números separados por uma barra “/”,
            faça um programa em C# que multiplique todos os números ímpares contidos nessa string. 
            
            EX:  para string  “10/1/2/15/”
            Neste caso, o resultado da multiplicação dos números ímpares será 15, ou seja,  1*15 .
            Obs: não utilize o comando Split.  Note que a string sempre deve terminar com “/”.
            */

            Console.WriteLine("Digite um valor. Finalize com /");
            string valor = Console.ReadLine();

            int resultado = 1;

            while (valor != "")
            {
                string extraido = valor.Substring(0, valor.IndexOf('/'));
                valor = valor.Remove(0, valor.IndexOf('/') + 1);

                if (Convert.ToInt32(extraido) % 2 == 1)
                    resultado = resultado * Convert.ToInt32(extraido);
            }

            Console.WriteLine("\nResultado : {0}", resultado);
            Console.ReadKey();
        }
    }
}