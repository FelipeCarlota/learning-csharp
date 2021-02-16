using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
  class PontoFlutuante : IAulaItem
  {
    public void Executar()
    {
      float massaDaTerra = 5.9736e24f; //System.Single 
      float numeroPi = 3.14159f; //System.Single 

      // float numeroMuitoMaior = 6e100f; //System.Single 
      double numeroMuitoMaior = 6e100;

      Console.WriteLine($"O valor MÍNIMO do tipo long é: {long.MinValue}");
      Console.WriteLine($"O valor MÁXIMO do tipo long é: {long.MaxValue}");
      Console.WriteLine($"A massa da terra é de: {massaDaTerra}");
      Console.WriteLine($"O valor de PI é: {numeroPi}");
      Console.WriteLine($"Número muito maior: {numeroMuitoMaior}");

      int x = 3;
      short y = 4;

      var resultado = x * y;

      Console.WriteLine($"O resultado de x * y = {resultado}");
      Console.WriteLine($"O resultado é do tipo {resultado.GetType()}");

      float z = 4.5f;

      var resultado2 = (x * y) / z;

      Console.WriteLine($"O resultado de (x * y) / z = {resultado2}");
      Console.WriteLine($"O resultado é do tipo {resultado2.GetType()}");

      //    C#		| 	 	 .NET  	  |    Faixa de Valores    |    Precisão    |
      //=====================================================================
      //  float 	| System.Single | 	t1.Se-45 to t3.4e38	 | 7		Digitos   |
      //  double	| System.Double |  t5.0e-324 to t1.7e308 | 15-16	Digitos |


    }
  }
}
