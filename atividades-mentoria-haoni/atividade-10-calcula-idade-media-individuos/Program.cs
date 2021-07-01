using System;

namespace atividade_10_calcula_idade_media_individuos
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
            * Fazer um algoritmo que:
            * - Leia um número indeterminado de linhas contendo cada uma a idade de um individuo. \
            *   A última linha, que não entrará no cálculo, conte'm o valor da idade igual a zero.
            * - Calcule e escreva a idade média deste grupo de indivíduos.
            */
        
            int idade = 1, somaIdades = 0, contador = 0;
            
            Console.WriteLine("Para encerrar o programa digite 0.");
            while (idade != 0) 
            {
                idade = Convert.ToInt32(Console.ReadLine());
                contador++;
                somaIdades += idade;
            }
            Console.WriteLine();
            double mediaIdades = somaIdades / (--contador);
            Console.WriteLine($"A média de idade é: {mediaIdades}");
        }
    }
}
