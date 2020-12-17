using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
  class MetodosAuxiliares : IAulaItem
  {
    public void Executar()
    {
      string textoDigitado = "123";
      //int numeroConvertido = textoDigitado; //Não permitido conversão implicita.
      //int numeroConvertido = (int)textoDigitado; //Não permitido conversão explicita.
      //int numeroConvertido = textoDigitado as int //Não permitido operador de conversão as
      int numeroConvertido = int.Parse(textoDigitado);

      textoDigitado = "abc";
      //numerConvertido = int.Parse(textoDigitado); // Não consegue converter, pois não é número
      int.TryParse(textoDigitado, out numeroConvertido);
      if (int.TryParse(textoDigitado, out numeroConvertido))
      {
        Console.WriteLine(numeroConvertido);
      }
      else
      {
        Console.WriteLine("O texto não é numeral");
      }

      textoDigitado = "R$ 123,45";
      decimal.TryParse(textoDigitado,
                System.Globalization.NumberStyles.Currency,
                System.Globalization.CultureInfo.CurrentCulture,
                out decimal valorConvertido);
      Console.WriteLine(valorConvertido);
    }
  }
}
