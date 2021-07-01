using System;

namespace Testes
{
    class Program
    {
        static void Main(string[] args)
        {
            Busca resolva = new Busca();
            Console.WriteLine("Qual número está procurando?");
            int entrada = Int32.Parse(Console.ReadLine());
            // string resposta = resolva.busca(entrada);
            string resposta = resolva.buscaBin(entrada);
            Console.WriteLine(resposta);


        }
    }

    class Busca {
        public string busca(int num) {
            int[] array = new int[] { 1, 3, 4, 6, 19, 20 };
            int i;
            for(i = 0; i < array.Length; i++) {
                if (num == array[i]) 
                    return $"A posição do número é {i}";
            }
            return "Não encontrei este número na lista.";
        }
        public string buscaBin(int num){
            int[] array = new int[] { 1, 3, 4, 6, 19, 20, 35, 37, 42, 50, 613, 7183 };
            int inicio = 0, fim = array.Length-1, meio;


            while(inicio <= fim) {
                meio = (inicio + fim) / 2;

                if (array[meio] == num)
                    return $"Opa! Achei o numero {num} na posição {meio}";
                
                if (num > array[meio])
                    inicio = meio + 1;
                if (num < array[meio])
                    fim = meio - 1;

            }
            return "Ué, não encontrei seu número na lista.";
        }
    }
}