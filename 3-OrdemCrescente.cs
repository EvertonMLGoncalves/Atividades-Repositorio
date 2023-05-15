using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _3___Desafio_da_Ordem
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            Ordenar uma lista de números sem utilizar os métodos da linguagem.
Crie um programa em C# que recebe uma lista de números inteiros e ordena essa lista em ordem crescente. 
                Exiba a lista ordenada na tela.    */

            List<int> numeros = new List<int>();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Selecione: \n1- para adicionar os números \n0 - para sair");
                int op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Adicione um número");
                        int num = int.Parse(Console.ReadLine());
                        numeros.Add(num);
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        flag = false;
                        break;

                }
            }
            for (int i = 0; i < numeros.Count; i++)
            {
                for (int j = i + 1; j < numeros.Count; j++)
                {
                    int elemento1 = numeros[i];
                    int elemento2 = numeros[j];
                    if (elemento1 > elemento2)
                    {
                        numeros[i] = elemento2;
                        numeros[j] = elemento1;
                    }
                }
            }
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }


            Console.ReadLine();
        }
    }
}
