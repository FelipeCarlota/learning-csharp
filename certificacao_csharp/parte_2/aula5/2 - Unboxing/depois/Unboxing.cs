using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
  class Unboxing : IAulaItem
  {
    public void Executar()
    {
      int numero = 57;      // tipo de valor

      object caixa = numero;

      try
      {
        int unboxed = (int)caixa;
        Console.WriteLine("Unbox ready.");
      }
      catch (InvalidCastException)
      {
        Console.WriteLine("Error: unboxing is not right, please review that unbox.");
      }
    }
  }
}
