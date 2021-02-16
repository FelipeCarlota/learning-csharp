using System;

namespace atividade_7_soma_array_sem_repetidor
{
    class Program
    {
        static void Main(string[] args)
        {
           /*
           [Fazer uma função que realize a soma de todos os valores de um array]

            Deve ser criado uma classe que contenha um método que recebe como parâmetro um array de inteiros, esse método deve ter como retorno um numero inteiro que deve ser a soma de todos os elementos dentro do array.

            Obs: poderá ser usado qualquer operador matemático e qualquer estrutura de decisão, porém não poderá ser usado nenhuma estrutura de laço neste exercício como por exemplo: for, while, do .. while, foreach.*/

            CalculaArray calculaNumerosDeUmaArray = new CalculaArray();
            int[] novaTentativa = new int[]{5,4,3,2,1,3,2,-4};

            int somaDoArray = calculaNumerosDeUmaArray.mostraResultado(novaTentativa, novaTentativa.Length-1);
            Console.WriteLine(somaDoArray);         
        }
    }

    class CalculaArray
    {
        public int mostraResultado(int[] novoVetor, int i)
        {   
            int soma = 0;
            return i == 0 ? soma += novoVetor[i]: soma += novoVetor[i] + mostraResultado(novoVetor, i-1);
        }
    }
}
