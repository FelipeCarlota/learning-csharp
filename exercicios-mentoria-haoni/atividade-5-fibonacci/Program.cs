using System;
using System.Collections.Generic;
using System.Collections;

namespace atividade_5_fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                [Fibonacci]
                Criar uma classe que tenha uma método que calcule o 
                Enésimo numero fibonacci de acordo com a entrada do usuário.
            */

            Fibonacci sequencia = new Fibonacci();
            
            int numero = 10;
            
            for (int i = 0; i < numero; i++)
            {
                Console.Write(sequencia.fibonacci(i) + " ");
            }
            Console.WriteLine();
            
            

        }

        class Fibonacci
        {
            public int fibonacci( int numero)

            {
                if (numero == 0)
                {
                    return 0;
                }
                else if (numero == 1)
                {
                    return 1;
                }
                else
                {
                    return fibonacci(numero - 1) + fibonacci(numero - 2);
                }
                
            }
        }
    }
}
