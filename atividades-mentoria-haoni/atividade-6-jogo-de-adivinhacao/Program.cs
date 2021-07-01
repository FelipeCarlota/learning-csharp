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

      Console.WriteLine("Escolha um número de 1 a 100.");

        int palpite = 0;
        int inicioIntervalo = 1;
        int finalIntervalo = 100;

      for(int i = 0; i < 9; i++)
      {
        palpite = (inicioIntervalo + finalIntervalo) / 2;
        Console.WriteLine("Seu número é " + palpite + "?");

        string resposta = Console.ReadLine(); 

        if(resposta == ">")
        { 
          inicioIntervalo = palpite;
        }
        else if (resposta == "<")
        {
          finalIntervalo = palpite;
        }
        else
        {
          Console.WriteLine("Acertei finalemente!");
          break;
        }
      }
    }
  }
}