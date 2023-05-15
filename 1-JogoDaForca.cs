using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _1___Desafio_de_jogo_da_forca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*            Escreva um programa que implemente o jogo da forca.O programa deve gerar uma
                            palavra aleatória para ser adivinhada pelo jogador, e permitir que o jogador
                                     insira uma letra por vez para tentar adivinhar a palavra. O programa deve exibir
                                     a palavra com os espaços em branco para as letras não adivinhadas.*/

            List<string> palavras = new List<string>() { "Pato", "Galo", "Prova", "Vermelho" };
            Random aleatorio = new Random();
            int indice = aleatorio.Next(palavras.Count);
            string palavra = palavras[indice];
            Console.WriteLine(palavra);
            string[] underline = new string[palavra.Length];
            for (int i = 0; i < palavra.Length; i++)
            {
                underline[i] = "_";
            }
            while (true)
            {
                Console.WriteLine($"Digite uma letra: {string.Join("", underline)}");
                string letra = Console.ReadLine();
                if (palavra.Contains(letra) && letra.Length == 1)
                {
                    underline[palavra.IndexOf(letra)] = letra;
                    underline[palavra.LastIndexOf(letra)] = letra;
                }
                if (!(underline.Contains("_")))
                {
                    break;
                }
            }
            Console.WriteLine("Parabéns, você concluiu a forca");

            Console.ReadLine();
        }
    }
}
