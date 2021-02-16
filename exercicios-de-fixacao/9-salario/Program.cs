using System;

namespace _9_salario
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Escreva um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas decimais.

                Entrada
                O arquivo de entrada contém 2 números inteiros e 1 número com duas casas decimais, representando o número, quantidade de horas trabalhadas e o valor que o funcionário recebe por hora trabalhada, respectivamente.

                Saída
                Imprima o número e o salário do funcionário, conforme exemplo fornecido, com um espaço em branco antes e depois da igualdade. No caso do salário, também deve haver um espaço em branco após o $.

                Entrada:                Saída:
                25                      NUMBER = 25
                100                     SALARY = U$ 550.00
                5.50

                1                       NUMBER = 1
                200                     SALARY = U$ 4100.00
                20.50

                6                       NUMBER = 6
                145                     SALARY = U$ 2254.75
                15.55
            */

            string numeroFuncionario = "6";
            int horasTrabalhadas = 145;
            decimal valorHora = 15.55m, salario = 0;

            salario = valorHora * horasTrabalhadas;

            Console.WriteLine($"NUMBER = {numeroFuncionario}");
            Console.WriteLine($"SALARY = U$ {Math.Round(salario, 2)}");

        }
    }
}
