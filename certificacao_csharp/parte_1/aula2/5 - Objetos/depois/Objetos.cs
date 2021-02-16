using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
  class Objetos : IAulaItem
  {
    public void Executar()
    {
      //Armazenando tipo de valor
      int pontuacao = 10;
      Console.WriteLine($"pontuacao: {pontuacao}");

      Console.WriteLine("OBJECT COM VALOR PRIMITIVO");
      object meuObjeto;
      meuObjeto = pontuacao;
      Console.WriteLine($"meuObjeto: {meuObjeto}");
      Console.WriteLine($"meuObjeto.GetType(): {meuObjeto.GetType()}");

      //Armazenando tipo de referência
      Console.WriteLine();
      Console.WriteLine("OBJECT COM REFERÊNCIA DE OBJETO");

      meuObjeto = new Jogador();
      Jogador classRef;
      classRef = (Jogador)meuObjeto; //É necessário informar a classe Jogador antes do objeto, pois
                                     //a classe variável de referência não pode referenciar para
                                     //um objeto, o que seria uma conversão implícita. Por isso,
                                     // colocando entre parênteses a classe "Jogador", tornamos
                                     // a atribuição em uma conversão explícita ou "cast".

      Console.WriteLine($"classRef.Pontuacao: {classRef.Pontuacao}");
    }
  }

  class Jogador
  {
    public int Pontuacao { get; set; } = 10;
  }
}
