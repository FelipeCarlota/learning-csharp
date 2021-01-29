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

            //Defininod os arrays que serão utilizados
            int[] arrayPivo = new int[1];
            int tamanhoDoArrayDosMenores = 0;
            int tamanhoDoArrayDosMaiores = 0;

            // Definindo qual será meu pivo de comparação
            arrayPivo[0] = ordenar[ordenar.Length/2];
            Console.WriteLine($"Meu número pivo do array principal é: {arrayPivo[0]}");

            // Descobrindo quantos números no arrau principal são menores do que o valor pivo
            for (i = 0; i < ordenar.Length; i++)
            {
                if (ordenar[i] < arrayPivo[0])
                {
                    tamanhoDoArrayDosMenores += 1;
                }
                if (ordenar[i] > arrayPivo[0])
                {
                    tamanhoDoArrayDosMaiores += 1;
                }
            }

            Console.WriteLine($"Eu sou o tamanho do array da esquerda: {tamanhoDoArrayDosMenores}");
            Console.WriteLine($"Eu sou o tamanho do array da direita: {tamanhoDoArrayDosMaiores}");

            // Definindo o tamanho do ArrayEsqureda
            int[] arrayDosMenores = new int[tamanhoDoArrayDosMenores];

            // Definindo o tamanho do ArrayDireita
            int[] arrayDosMaiores = new int[tamanhoDoArrayDosMaiores];

            if (ordenar[i] < arrayPivo[0])
            {
                arrayDosMenores[i] = ordenar[i];
            }
            if (ordenar[i] > arrayPivo[0])
            {
                arrayDosMaiores[i] = ordenar[i];
            }
            ordenaNumeros(ordenar, i+1);

            for (int j = 0; j < tamanhoDoArrayDosMaiores; i++){Console.WriteLine(arrayDosMaiores[j]);}
               
            return ordenar;
            
        }
    }
}
