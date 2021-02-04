using System;

namespace _7_media_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Media 2
            Leia 3 valores, no caso, variáveis A, B e C, que são as três notas de um aluno. A seguir, calcule a média do aluno, sabendo que a nota A tem peso 2, a nota B tem peso 3 e a nota C tem peso 5. Considere que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.

            Entrada
            O arquivo de entrada contém 3 valores com uma casa decimal, de dupla precisão (double).

            Saída
            Imprima a mensagem "MEDIA" e a média do aluno conforme exemplo abaixo, com 1 dígito após o ponto decimal e com um espaço em branco antes e depois da igualdade. Assim como todos os problemas, não esqueça de imprimir o fim de linha após o resultado, caso contrário, você receberá "Presentation Error".

            Entrada:                            Saída:
            5.0                                 MEDIA = 6.3
            6.0
            7.0

            5.0                                 MEDIA = 9.0
            10.0
            10.0

            10.0                                 MEDIA = 7.5
            10.0
            5.0
            */

            double media = 0, a = 5.0, b = 10.0, c = 10.0, pesoA = 2, pesoB = 3, pesoC = 5;

            media = (((a * pesoA) + (b * pesoB) + (c * pesoC)) / (pesoA + pesoB + pesoC));

            Console.WriteLine($"MEDIA = {Math.Round(media, 1)}");

        }
    }
}
