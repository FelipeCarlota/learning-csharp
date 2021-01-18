using System;

namespace atividade_4_conta_dias
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            [Dever de casa]

                Faça um algoritmo que leia a idade de uma pessoa expressa em anos, 
                meses e dias e mostre-a expressa apenas em dias.
            */

            ContaDias funcaoContaDias = new ContaDias();

            var totalDias = funcaoContaDias.contaDias(60,0,11);
            Console.WriteLine(totalDias);
            

            // um ano comum tem 365 dias; um ano bise
            /* 
            Para ser bissexto, o ano deve ser:

                Divisível por 4. Sendo assim, a divisão é exata com o resto igual a zero;

                Não pode ser divisível por 100. Com isso, a divisão não é exata, ou seja, deixa resto diferente de zero;

                Pode ser que seja divisível por 400. Caso seja divisível por 400, a divisão deve ser exata, deixando o resto igual a zero.
            */

        }

        class ContaDias 
        {
            public int contaDias(int anos, int meses, int dias)
            {
                var diasPorMes = 0;
                int contagemDeDiasPorMes = 0;
                int contagemDeDiasPorAno = 0;
                int diasPorAno = 0;
                int anoCorrente = 2021;
                int totalDiasAno = 0;
                int anoNascimento = anoCorrente - anos;
                // Console.WriteLine(anoNascimento);

                //Conta dias por ano
                for (int a = anoNascimento; a < anoCorrente; a++)
                {
                    anoNascimento++;

                    // Caso mes == 0
                    if (anoNascimento % 4 == 0 && anoNascimento % 100 != 0 || anoNascimento % 400 == 0)
                    {
                        diasPorAno = 366;
                    }
                    else 
                    {
                        diasPorAno = 365;
                    }

                    totalDiasAno = contagemDeDiasPorAno += diasPorAno;
                }
                 
                for (int m = 0; m < meses; m++)
                {
                    diasPorMes = 31;

                    if (m == 1)
                    {
                        if (anoNascimento % 4 == 0 && anoNascimento % 100 != 0 || anoNascimento % 400 == 0)
                        {
                            diasPorMes = 29;
                        }
                        else 
                        {
                            diasPorMes = 28;
                        }
                    }
                    else
                    {
                        if (m == 3 || m == 5 || m == 8 || m == 10)
                        {
                            diasPorMes = 30;
                        }
                    }

                    contagemDeDiasPorMes += diasPorMes;

                }

                return totalDiasAno + contagemDeDiasPorMes + dias;      

            }
        }
    }
}
