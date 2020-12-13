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


    }
  }
}
