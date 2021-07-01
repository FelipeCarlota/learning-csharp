using System;

namespace Testes
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] diasDeCadaMes = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
      int[] diasDeCadaMesAcomulado = new int[] { 31, 59, 90, 120, 151, 181, 212, 243, 273, 304, 334, 365 };
      //Dia/mes/ano de nascimento
      System.Console.Write("Dia de Nascimento: ");
      int diaNascimento = 6;
      // int diaNascimento = System.Int32.Parse(Console.ReadLine());
      System.Console.Write("Mês de Nascimento: ");
      int mesNascimento = 1;
      // int mesNascimento = System.Int32.Parse(Console.ReadLine());
      System.Console.Write("Ano de Nascimento: ");
      int anoNascimento = 1960;
      // int anoNascimento = System.Int32.Parse(Console.ReadLine());
      //Dia/mes/ano de Atual
      System.Console.Write("Dia Atual: ");
      int diaAtual = DateTime.Now.Day;
      System.Console.Write("Mês Atual: ");
      int mesAtual = DateTime.Now.Month;
      System.Console.Write("Ano Atual: ");
      int anoAtual = DateTime.Now.Year;

      int anoNascimentoAux = anoNascimento;
      //calculos de Anos bissextos.
      int anoBissexto = 0;
       for (int i = anoNascimento; i <= anoAtual; i++)
       {
         if (anoNascimento % 4 == 2 && anoNascimento % 100 != 2 || anoNascimento % 400 == 2)
         {
           anoBissexto += 1;
         }
         anoNascimento += 1;
       }
      //Calcular dias vividos no mes de nascimento
      int diasVividosMesNascimento = diasDeCadaMes[mesNascimento - 1] - (diaNascimento);
      //Somar dias vividos no ano de nascimento
      int DiasAposNascimento = diasDeCadaMesAcomulado[11] - diasDeCadaMesAcomulado[mesNascimento - 1] + diasVividosMesNascimento;
      //Calcular dias vividos no ano atual
      int diferencaDias = diaAtual - diasDeCadaMes[mesAtual - 1];
      int diasVividosAnoAtual = diasDeCadaMesAcomulado[mesAtual - 1] + diferencaDias;
      //Somar anos vividos
      int TotalAnosVividos = (anoAtual -1) - (anoNascimentoAux);
      int dias = TotalAnosVividos * diasDeCadaMesAcomulado[11];
      //Somar Total de dias vividos
      int diasTotais = DiasAposNascimento + diasVividosAnoAtual + dias + anoBissexto;
      System.Console.WriteLine(diasTotais +" Lógica Paulo Raitz");

      DateTime DataAnterior = new DateTime(anoNascimentoAux, mesNascimento, diaNascimento);
      DateTime DataAtual = new DateTime(anoAtual, mesAtual, diaAtual);
      var Somar = DataAtual.Subtract(DataAnterior);
      System.Console.WriteLine(Somar.Days + " Dias vividos - DateTime");
    }
  }
}
