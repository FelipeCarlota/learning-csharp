using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
  class ConversoesExplicitas : IAulaItem
  {
    public void Executar()
    {
      double numeroFlutuante = 2159.65;
      // long numeroInteiroLongo = numeroFlutuante; O compilador não permite esse tipo de conversão do tipo
      //implícita devido o fato de que double não pode ser convertido para nenhum outro tipo inferior a ele.
      //Neste caso, deve-se usar o tipo de conversão explícita, forçando a conversão. Neste caso:
      long numeroInteiroLongo = (long)numeroFlutuante;
      Console.WriteLine(numeroInteiroLongo);
    }
  }
}
