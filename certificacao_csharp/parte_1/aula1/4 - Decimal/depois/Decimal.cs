using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
  class Decimal : IAulaItem
  {
    public void Executar()
    {
      double valorProduto1 = 10;
      double valorProduto2 = 20;
      double subtotal = 30;

      Console.WriteLine("Descobrindo se valorProduto1 + valorProduto2 == subtotal");
      Console.WriteLine((valorProduto1 + valorProduto2) == subtotal);

      valorProduto1 = 10.10;
      valorProduto2 = 20.20;
      subtotal = 30.30;

      Console.WriteLine("Descobrindo se 10.10 + 20.20 == 30.30");
      Console.WriteLine((valorProduto1 + valorProduto2) == subtotal);

      Console.WriteLine(valorProduto1 + valorProduto2);

      Console.WriteLine("Descobrindo se (10.1 + 20.2) == 30.299999999999997");
      Console.WriteLine((valorProduto1 + valorProduto2) == 30.299999999999997);

      //devido o arredondamento do double e do float, 
      //para representar números decimais com 2 posições após a vírgula, deve-se usar o tipo decimal.
      //Dica: Sempre que for trabalhar com valores monetários, ex.: Matéria prima, custo, salário, etc...
      //    usar o tipo decimal para representaçõa.

      decimal materiaPrima = 10.1m;
      decimal maoDeObra = 20.2m;
      decimal custo = 30.3m;

      Console.WriteLine("Descobrindo se (10.1m + 20.2m) == 30.3m");
      Console.WriteLine((materiaPrima + maoDeObra) == custo);

      //Tipo C#       : decimal
      //Tipo .NET     : System.Decimal
      //Precisão      : (-7.9 x 10^28 a 7.9 x 10^28)
      //Tamanho       : 28-29 dígitos
    }
  }
}
