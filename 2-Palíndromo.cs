using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___Desafio_do_Palíndromo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*    Crie um programa em C# que recebe uma string e verifica se ela é um palíndromo, ou seja,
                    se pode ser lida da mesma forma tanto da esquerda para a direita quanto da direita para
                    a esquerda. Desconsidere espaços em branco e letras maiúsculas ou minúsculas. Se a string
                    for um palíndromo, exiba a mensagem "A string X é um palíndromo"; caso contrário, exiba a mensagem 
                    "A string X não é um palíndromo", em que X é a string recebida como entrada.*/
            Console.WriteLine("Digite um texto");
            string texto = Console.ReadLine();
            texto.Trim();
            texto.ToLower();
            texto.Replace(" ", "");
            string tinvertido = "";
            for (int i = 0; i < texto.Length; i++)
            {
                int indice = texto.Length - (i + 1);
                tinvertido += texto[indice];
            }
            Console.WriteLine(texto.Equals(tinvertido) ? $"{texto} -> É um palíndromo" : $"{texto} -> Não é um palíndromo");


            Console.ReadKey();
        }
    }
}
