using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Ex36_PalavrasArqTexto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            36. Faça um programa que leia uma string e vá acumulando as 
            strings digitadas até que o usuário digite “sair”. O programa 
            deve persistir em disco todas as strings digitadas e fechar o 
            programa assim que for digitado “sair”.
             
            Ao abrir o programa novamente, caso o arquivo com os dados exista,
            exiba todas as palavras digitadas na tela, uma por linha. 
            */

            if (File.Exists("dados.txt"))
                Console.WriteLine(File.ReadAllText("dados.txt"));

            Console.WriteLine("Digite qualquer coisa ou SAIR para sair!");
            string texto;
            string textoAcumulado = "";

            do
            {
                texto = Console.ReadLine();
                if (texto.ToUpper() != "SAIR")
                    textoAcumulado = textoAcumulado + texto + Environment.NewLine;
            }
            while (texto.ToUpper() != "SAIR");

            //para sobrescrever o arquivo:
            //File.WriteAllText("dados.txt", textoAcumulado);

            //para acumular
            File.AppendAllText("dados.txt", textoAcumulado);
        }
    }
}