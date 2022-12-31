using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_For
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Termomecanica");
            Console.WriteLine("Termomecanica");
            Console.WriteLine("Termomecanica");
            Console.WriteLine("Termomecanica");
            Console.WriteLine("Termomecanica");

            Console.WriteLine("1-Termomecanica");
            Console.WriteLine("2-Termomecanica");
            Console.WriteLine("3-Termomecanica");
            Console.WriteLine("4-Termomecanica");
            Console.WriteLine("5-Termomecanica");

            int cont;

            cont = 10;
            Console.WriteLine($"{cont}-Termomecanica");
            cont = cont + 1;
            Console.WriteLine($"{cont}-Termomecanica");
            cont = cont + 1;
            Console.WriteLine($"{cont}-Termomecanica");
            cont = cont + 1;
            Console.WriteLine($"{cont}-Termomecanica");
            cont = cont + 1;
            Console.WriteLine($"{cont}-Termomecanica");
            cont = cont + 1;

            //escrevendo Termomecanica via laço de repetição
            //pagina 47 fala sobre o ++
            //for (cont = 1; cont <= 5; cont++)
            for (cont = 1; cont <= 5; cont = cont + 1)
            {
                Console.WriteLine($"{cont}-Termomecanica no FOR");
            }

            for (int i = 0; ; i++)
            {
                Console.WriteLine($"Infinito - {i}");

                if (i == 45)
                    break; //interrompe o laço
            }

            //for (int i = 100; i > 80; i /= 2)
            for (double i = 1; i >= 0; i = i - 0.1)
            {
                Console.WriteLine($"indo para trás {i:0.0}");
            }

            Console.ReadKey();
        }
    }
}