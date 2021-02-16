using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
  class Boxing : IAulaItem
  {
    public void Executar()
    {
      int numero = 57;

      // Boxing: Colocando a variável número do tipo inteiro em uma caixa
      object caixa = numero;
      Console.WriteLine(caixa);

      // Chamando o objeto e utilizando o método para concatenação
      Console.WriteLine(string.Concat("Resposta: ", numero, " ", true));
    }
  }
}
