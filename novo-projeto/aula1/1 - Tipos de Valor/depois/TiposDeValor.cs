using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
  class TiposDeValor : IAulaItem
  {
    public void Executar()
    {
      int idade;
      idade = 25;
      //Console.WriteLine(idade);

      int copiaIdade = idade;

      Console.WriteLine($"A minha idade é: Idade {idade}");

      int novaIdade = idade + 5;
      Console.WriteLine($"5 anos se passaram e eu já tenho {novaIdade} anos");
      Console.WriteLine($"E pensar que há 5 anos atrás eu tinha apenas {copiaIdade} anos");

      //  char  resposta = 'S';// System.Char

      //   byte niveldeAzul = 0xF; // = 255 em decimal 
      //   //nivelDeAzul = -3
      //   short passageirosVoo = 230; // System.Int16
      //   passageirosVoo = -7;
      //   int populacao = 1500; // SystemInt.32
      //   populacao = -2300;
      //   long populacaoDoBrasil = 207_660_929; // +/- 207 milhões - System.Int64

      //   sbyte niveldeBrilho = -127; //System.SByte
      //   ushort passageirosNavio = 230; // System.UInt16 
      //   uint estoque = 1500; // System.UInt32
      //   ulong populacaoDoMundo = 7_000_000_000; //7 bilhões = System.UInt64

      //   Console.WriteLine($"resposta: {resposta}");

      //   Console.WriteLine($"nivelDeAzul: {nivelDeAzul}");
      //   Console.WriteLine($"passageirosVoo: {passageirosVoo}");
      //   Console.WriteLine($"populacao: {populacao}");
      //   Console.WriteLine($"populacaoDoBrasil: {populacaoDoBrasil}");

      //   Console.WriteLine($"niveldeBrilho: {niveldeBrilho}");
      //   Console.WriteLine($"estoque: {estoque}");
      //   Console.WriteLine($"populacaoDoMundo: {populacaoDoMundo}");

    }
  }
}
