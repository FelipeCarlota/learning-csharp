using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
  class Sobrecargas : IAulaItem
  {
    public void Executar()
    {
      //VOLUME DO CUBO = lado ^ 3;
      int lado = 3;
      Console.WriteLine($"O volume do cubo é: {Volume(lado)}");

      //VOLUME DO CILINDRO = altura * PI * raio ^ 2;
      double raio = 2;
      int altura = 10;
      Console.WriteLine($"O volume do cilindro é: {Volume(altura, raio)}");

      //VOLUME DO PRISMA = largura * profundidade * altura
      long largura = 10;
      altura = 6;
      int profundidade = 4;
      Console.WriteLine($"O volume do prisma é: {Volume(largura, profundidade, altura)}");
    }
    // A sobrecarga de método permite que vários métodos utilizem o mesmo desde que suas assiniaturas
    // variem no número, ordem e tipo dos parâmetros e também no valor de retorno.
    double Volume(double lado)
    {
      return Math.Pow(lado, 3);
    }

    double Volume(double altura, double raio)
    {
      return altura * Math.PI * Math.Pow(raio, 2);
    }

    double Volume(double largura, double profundidade, double altura) //porém esses tipos de variáveis são os mesmos. por que?
    {
      return largura * profundidade * altura;
    }
  }
}
