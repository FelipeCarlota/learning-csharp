using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
  class Strings : IAulaItem
  {
    public void Executar()
    {
      string a = "bom dia";
      string b = "b";
      //Concatenação em C# é feito com o sinal de +
      b = b + "om dia";
      Console.WriteLine($"Conferência: a é igual a b?\n {a == b}");

      //Verficando espaço da memória entre as duas variáveis:
      Console.WriteLine($"Ocupam o mesmo espaço na memória? {(object)a == (object)b}");

      //Imprimindo a letra em uma posição do array de caracteres ou string

      string bomDia = "Bom dia";
      Console.WriteLine($"A letra na posição 4 é a letra: {bomDia[4]}");

      var caractereQuartaPosicao = bomDia[4];
      Console.WriteLine($"Tipo do caractere: {caractereQuartaPosicao.GetType()}");

    }
  }
}
