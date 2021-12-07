/***********************************************************************************************************
 *  Diferença
 ************************************** Desafio:
 *
 *  Leia quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto de A e B 
 *  pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).
 *
 ************************************** Entrada:
 *
 *  O arquivo de entrada contém 4 valores inteiros.
 *
 ************************************** Saída:
 *
 *  Imprima a mensagem DIFERENCA com todas as letras maiúsculas, conforme exemplo abaixo, com um espaço em
 *  branco antes e depois da igualdade.
 *
 **********************************************************************************************************/

using System;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
          var numeros = new int[4];

          for (int i = 0; i < numeros.Length; i++)
              numeros[i] = int.Parse(Console.ReadLine());

          var diferenca = (numeros[0] * numeros[1]) - (numeros[2] * numeros[3]);

          Console.WriteLine($"DIFERENCA = {diferenca}");
          Console.ReadKey();
        }
    }
}