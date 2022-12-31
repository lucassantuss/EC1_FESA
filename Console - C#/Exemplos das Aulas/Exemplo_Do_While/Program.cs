using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont;
            int numero;

            //exibir os numeros de 0 a 10
            for (cont = 0; cont <= 10; cont++)
            {
                Console.WriteLine("Contador -> {0}", cont);
            }

            cont = 0; //inicialização do contador
            do
            {
                Console.WriteLine("Contador -> {0}", cont);

                cont++; //incremento do contador
            } while (cont <= 10); //condição de permanencia

            //Digitar n numeros até que seja digitado um numero negativo
            do
            {
                Console.Write("Digite um número qualquer, um negativo termina:");
                numero = Convert.ToInt32(Console.ReadLine());
            } while (numero >= 0);

            Console.ReadKey();
        }
    }
}