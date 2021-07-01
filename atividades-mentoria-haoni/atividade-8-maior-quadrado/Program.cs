using System;

namespace atividade_8_maior_quadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculaOMaiorQuadrado calculaOMaiorQuadrado = new CalculaOMaiorQuadrado();

            int valorBase = 1680;
            int altura = 640;            
            Console.WriteLine(calculaOMaiorQuadrado.calculaQuadrado(valorBase, altura));

        }
    }
    class CalculaOMaiorQuadrado
    {
        public string calculaQuadrado(int valor1, int valor2)
        {

            // int maiorLado = valor1;
            // int menorLado = valor2;

            // if(valor1 < valor2)
            // {
            //     menorLado = valor1;
            //     maiorLado = valor2;
            // }

            // if( maiorLado % menorLado == 0)
            // {
            //     return $"O maior quadrado é {menorLado}x{menorLado}";
            // }
            
            // return calculaQuadrado(maiorLado - menorLado, menorLado);

            if ( valor1 == valor2)
            {
                // Console.WriteLine($"O maior quadrado é {valor1}x{valor2}");
                //return $"O maior quadrado é {valor1}x{valor2}";
                return $"O maior quadrado é {valor1}x{valor2}";
            }
            else 
            {
                if(valor1 < valor2)
                {
                    valor2 = valor2 - valor1;
                    return calculaQuadrado(valor1, valor2);
                }
                else
                {
                    valor1 = valor1 - valor2;
                    return calculaQuadrado(valor1, valor2);
                }
            }
            // return "";
        }
    }
}
