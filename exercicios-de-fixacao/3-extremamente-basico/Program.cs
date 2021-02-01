using System;

namespace _3_extremamente_basico
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

            Extremamente Básico

            Leia 2 valores inteiros e armazene-os nas variáveis A e B. Efetue a soma de A e B atribuindo o seu resultado na variável X. Imprima X conforme exemplo apresentado abaixo. Não apresente mensagem alguma além daquilo que está sendo especificado e não esqueça de imprimir o fim de linha após o resultado, caso contrário, você receberá "Presentation Error".

            Entrada
            A entrada contém 2 valores inteiros.

            Saída
            Imprima a mensagem "X = " (letra X maiúscula) seguido pelo valor da variável X e pelo final de linha. Cuide para que tenha um espaço antes e depois do sinal de igualdade, conforme o exemplo abaixo.
            Console.WriteLine("Hello World!");

            Entrada:                                Saída:
            10                                      X = 19
            9

            -10                                     X = -6
            4

            15                                     X = 8
            -7
            */

            int a = 15, b = -7, x = 0;

            x = a + b;
            Console.WriteLine($"X = {x}");
        }
    }
}
