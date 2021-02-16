using System;

namespace _8_diferenca
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Diferença

                Leia quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).

                Entrada
                O arquivo de entrada contém 4 valores inteiros.

                Saída
                Imprima a mensagem DIFERENCA com todas as letras maiúsculas, conforme exemplo abaixo, com um espaço em branco antes e depois da igualdade.

                Entrada:                Saída:
                5                       DIFERENCA = -26
                6
                7
                8

                0                       DIFERENCA = -56
                0
                7
                8

                5                       DIFERENCA = 86
                6
                -7
                8  
            */

            int a = 5, b = 6, c = -7, d = 8, produtoAEB = 0, produtoCED = 0; 

            produtoAEB = a * b;
            produtoCED = c * d;

            Console.WriteLine($"DIFERENÇA = {produtoAEB - produtoCED}");

        }
    }
}
