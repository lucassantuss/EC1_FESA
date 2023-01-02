using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Ex35_JogoArqTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exercicio 35
             * 
             * Solicite os seguintes dados de um jogo:
             * 
             * String - Nome
             * Char - Categoria (“A” para ação /aventura,  “C” corrida ,  “L” Luta , “R” Rpg  e  “E”esportes
             * String - Data da compra
             * Double - Valor de Locação
             * 
             * Salve os dados ao final em um arquivo texto.
             * Ao entrar no programa, caso o arquivo exista, leia seus valores e os exiba em vídeo.  
             */

            String nome;
            String data;
            char categoria;
            double valor;

            if (File.Exists("dados.txt") == true)
            {
                Console.WriteLine("DADOS QUE FORAM SALVOS DA ÚLTIMA VEZ: \n");
                string info = File.ReadAllText("dados.txt");

                int posPipe = info.IndexOf('|');
                nome = info.Substring(0, posPipe);
                Console.WriteLine("Nome: {0}", nome);
                info = info.Remove(0, posPipe + 1);

                posPipe = info.IndexOf('|');
                data = info.Substring(0, posPipe);
                Console.WriteLine("Data: {0}", data);
                info = info.Remove(0, posPipe + 1);

                posPipe = info.IndexOf('|');
                categoria = Convert.ToChar(info.Substring(0, posPipe));
                Console.WriteLine("Categoria: {0}", categoria);
                info = info.Remove(0, posPipe + 1);

                //só sobrou o valor na variável info.
                Console.WriteLine("Valor: {0}", info);

                Console.WriteLine("\n\n");
            }

            Console.Write("Digite o nome do jogo: ");
            nome = Console.ReadLine();

            Console.Write("Digite a data de compra: ");
            data = Console.ReadLine();

            do
            {
                Console.Write("Digite a categoria: [A] Ação / Aventura, [C] Corrida" +
                ", [L] Luta, [R] Rpg e [E] Esportes\n");
                categoria = Console.ReadLine().ToUpper()[0];
            }
            while (categoria != 'A' && categoria != 'C' &&
                  categoria != 'L' && categoria != 'R' &&
                  categoria != 'E');

            Console.Write("Digite o valor: ");
            valor = Convert.ToDouble(Console.ReadLine());

            string conteudo = nome + "|" +
                               data + "|" +
                               categoria + "|" +
                               valor;

            File.WriteAllText("dados.txt", conteudo);
        }
    }
}