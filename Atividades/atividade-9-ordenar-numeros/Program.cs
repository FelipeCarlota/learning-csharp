using System;

namespace atividade_9_ordenar_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            OrdenarSequencia ordenarSequencia = new OrdenarSequencia();

            int[] ordenar = new int[]{99, 44, 53, 65, 77, 3, 7, 74, 233, 100, 22, 5, 6, 7, 3};

            for(int i = 0; i < ordenar.Length-2;i++)
            {
                ordenarSequencia.ordenaNumeros(ordenar, 0);
            }

            for(int i = 0; i < ordenar.Length;i++)
            {
                Console.Write(ordenar[i] + " ");
            }
            Console.WriteLine(" ");
        }
    }

    class OrdenarSequencia
    {
        public int[] ordenaNumeros(int[] ordenar, int i)
        {
            if(i > ordenar.Length-2)
            {
                return ordenar;
            }
            else
            {
                var proximoNumero = ordenar[i+1];
                var numeroAtual = ordenar[i];

                if (proximoNumero < numeroAtual)
                {   
                    ordenar[i] = proximoNumero;
                    ordenar[i+1] = numeroAtual;
                } else {
                    ordenar[i+1] = proximoNumero;
                    ordenar[i] = numeroAtual;                    
                }
                return ordenaNumeros(ordenar, i+1);

            }
        }
    }
}
