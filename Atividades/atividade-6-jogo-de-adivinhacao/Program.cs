using System;

namespace atividade_6_jogo_de_adivinhacao
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Criar um jogo que adivinha um número em 8 tentativas
            */
            
            int[] numeros = new int[100];
            
            int i = 0;
            string respostaUsuario = ">";
            int adivinhaNumero = 0;

            while (respostaUsuario == ">")
            {
                for (i = 1; i < numeros.Length; i++)
                {  
                    numeros[i] = i + 1;
                    Console.Write(numeros[i] + " ");
                }

                Console.WriteLine();
                Console.WriteLine(adivinhaNumero);
                respostaUsuario = Console.ReadLine();
                if (respostaUsuario == ">")
                {
                    numeros = new int[adivinhaNumero];
                }

            }
        }
    }
}
