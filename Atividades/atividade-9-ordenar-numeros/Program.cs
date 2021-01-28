using System;

namespace atividade_9_ordenar_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            OrdenarSequencia ordenarSequencia = new OrdenarSequencia();

            int[] ordenar = new int[]{99, 44, 53, 65, 77, 3, 7, 74, 233, 100, 22, 5, 6, 7, 3};

            // for(int i = 0; i < ordenar.Length-2;i++)
            // {
            //     
            // }

            for(int i = 0; i < 1;i++)
            {
                ordenarSequencia.ordenaNumeros(ordenar, 0);
            }
            Console.WriteLine(" ");
        }
    }

    class OrdenarSequencia
    {
        // Reescrever em quick sort o mais rápido possível
        public int[] ordenaNumeros(int[] ordenar, int i)
        {   
            int tamanhoArrayDireita = 1, tamanhoArrayEsquerda = 1, tamanho = ordenar.Length;;
            int[] arrayPivo = new int[1];
            int[] arrayEsquerda = new int[tamanhoArrayEsquerda];
            int[] arrayDireita = new int[tamanhoArrayDireita];
            
            arrayPivo[0] = ordenar[ordenar.Length/2];

            if(ordenar[i] < arrayPivo[0])
            {
                tamanhoArrayEsquerda += 1;
                arrayEsquerda[i] = ordenar[i];

                Console.WriteLine($"Acho que adicionei na esquerda");
            }
            tamanhoArrayDireita += 1;
            arrayDireita[i] = ordenar[i];

            Console.WriteLine($"Acho que adicionei na direita");


            // Console.WriteLine(arrayEsquerda.Length);
            // Console.WriteLine(arrayEsquerda[i]); 
            Console.WriteLine($"Sou o ArrayPrincipal na posição {i}: {ordenar[i]}");
            Console.WriteLine($"Sou o ArrayPivo: {arrayPivo[0]}");
            Console.WriteLine($"Sou o i: {i}");
            // Console.WriteLine($"Sou o arrayEsquerda: {arrayEsquerda[0]}");
            Console.WriteLine($"Sou o arrayEsquerda: {tamanhoArrayEsquerda}");
            Console.WriteLine($"Sou o arrayEsquerda: {arrayEsquerda.Length}");
            // Console.WriteLine($"Sou o arrayDireita: {arrayDireita[0]}");
            Console.WriteLine($"Sou o arrayDireita: {tamanhoArrayDireita}");
            Console.WriteLine($"Sou o arrayDireita: {arrayDireita.Length}");
            
            ordenaNumeros(ordenar, i+1);
                
           
            // if (arrayEsquerda.Length >= 2 && arrayEsquerda[i+1] < arrayEsquerda[i])
            // {
            
            // } 

            // ordenaNumeros(ordenar, i+1);
               
            return ordenar;
            
        }
    }
}
