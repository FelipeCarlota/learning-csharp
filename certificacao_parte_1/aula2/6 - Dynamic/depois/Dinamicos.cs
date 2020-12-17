using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
  class Dinamicos : IAulaItem
  {
    public void Executar()
    {
      object objeto = 1;
      //objeto = objeto + 3; //O programa não permite fazer esta operação, pois não se pode
      // realizar operação de um objeto com variáveis de outro tipo.
      dynamic dinamico = 1;
      dinamico = dinamico + 3;
      Console.WriteLine($"O valor de dinâmico, que permite realizar operações como sendo objeto com outros tipos é: {dinamico}");
    }
  }
}
