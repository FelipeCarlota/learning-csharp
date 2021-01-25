using System;

namespace atividade_8_maior_quadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculaOMaiorQuadrado calculaOMaiorQuadrado = new CalculaOMaiorQuadrado();

            int valorBase = 3;
            int altura = 87;
            int area = valorBase * altura;  
            // int i = 0;
            
            string resposta = calculaOMaiorQuadrado.calculaQuadrado(valorBase, altura);

        }
    }
    class CalculaOMaiorQuadrado
    {
        public string calculaQuadrado(int valor1, int valor2)
        {
            if ( valor1 == valor2)
            {
                Console.WriteLine($"O maior quadrado é {valor1}x{valor2}");
                //return $"O maior quadrado é {valor1}x{valor2}";
                return "";
            }
            else 
            {
                if(valor1 < valor2)
                {
                    valor2 = valor2 - valor1;
                    calculaQuadrado(valor1, valor2);
                }
                else
                {
                    valor1 = valor1 - valor2;
                    calculaQuadrado(valor1, valor2);

                }
            }
            return "";
        }
    }
}
