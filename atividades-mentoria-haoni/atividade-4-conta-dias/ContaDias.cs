using System;

public class ContaDias
{
  int diaNascimento;
  int mesNascimento;
  int anoNascimento;
  int diaAtual = DateTime.Now.Day;
  int mesAtual = DateTime.Now.Month;
  int anoAtual = DateTime.Now.Year;
  int bissexto;
  int diasPorMes;

  int dias;

  int mes = 1;
  public int DiasAnoBissexto (int anoNascimento, int anoAtual)
  {
    /*
      Calcula mais um dia, se o ano for bissexto
      Para ser bissexto, o ano deve ser:

        Divisível por 4. Sendo assim, a divisão é exata com o resto igual a zero;

        Não pode ser divisível por 100. Com isso, a divisão não é exata, ou seja, deixa resto diferente de zero;

        Pode ser que seja divisível por 400. Caso seja divisível por 400, a divisão deve ser exata, deixando o resto igual a zero.
    */
    if((anoNascimento % 4 == 0 && anoNascimento % 100 != 0 || anoNascimento % 400 == 0) || 
      (anoAtual % 4 == 0 && anoAtual % 100 != 0 || anoAtual % 400 == 0) && anoNascimento != anoAtual)
    {
      this.bissexto += 1;
    }
      

    if(anoNascimento == anoAtual) 
      return this.bissexto;
    
    return DiasAnoBissexto(anoNascimento + 1, anoAtual);
  }

  //Regra de dias por mês
  public int CalculaDiasPorMes(int dia, int mes, int ano)
  {

    if (ano == anoAtual && mes == mesAtual)
      return diasPorMes;

    if(mes > 12)
      mes = 1;
      dia = 1;
      ano += 1;      

    if (mes == 2)
      diasPorMes += 28;
    
    if(mes == 4 || mes == 6 || mes == 9 || mes == 11)
      diasPorMes += 30; 
    
    if(mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
      diasPorMes += 31;

    if (mes == this.mesNascimento)
      diasPorMes -= this.diaNascimento;
    
    return CalculaDiasPorMes(dia+=1, mes+=1, ano);
    
  }

  public int CalculaDias(int diaNascimento, int mesNascimento, int anoNascimento)
  {

    // //inicializa variáveis
    this.diaNascimento = diaNascimento;
    this.mesNascimento = mesNascimento;
    this.anoNascimento = anoNascimento;

    int CalculaDiasPorAno = (anoAtual - anoNascimento) * 365;
    Console.WriteLine($"Quantidade de dias no ano {CalculaDiasPorAno}");

    int diasBissextos = DiasAnoBissexto(anoNascimento, anoAtual);
    Console.WriteLine($"Quantidade de dias bissextos: {diasBissextos}");

    // int diasPorMes = CalculaDiasPorMes(mes, mesAtual) + diaAtual;
    Console.WriteLine($"Quantidade dias por mês {diasPorMes}");

    return dias;  
  }

}