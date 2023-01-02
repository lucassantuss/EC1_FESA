using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex44_ProcuraNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            44.	FindNum

            Faça um programa que solicite 10 números inteiros.
            Depois o programa deverá entrar em uma repetição, 
            onde ele solicitará um número qualquer e dirá se o número 
            existe ou não no vetor previamente digitado.

            Isso se repetirá até que o usuário queira sair
            */

            int[] numeros = new int[10];

            for (int n = 0; n < numeros.Length; n++)
            {
                Console.WriteLine("Digite um número positivo: ");
                numeros[n] = Convert.ToInt32(Console.ReadLine());
            }

            int num;
            do
            {
                Console.WriteLine("Digite um numero pra pesquisar no vetor ou -1 para sair");
                num = Convert.ToInt32(Console.ReadLine());

                if (num != -1)
                {
                    bool existe = false;

                    for (int n = 0; n < numeros.Length; n++)
                    {
                        if (numeros[n] == num)
                        {
                            existe = true;
                            break;
                        }
                    }

                    if (existe == true)
                        Console.WriteLine("Existe!");
                    else
                        Console.WriteLine("Não Existe!");
                }
            }
            while (num != -1);
        }
    }
}