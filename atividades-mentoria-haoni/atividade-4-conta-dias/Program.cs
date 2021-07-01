using System;

namespace atividade_4_conta_dias
{
    class Program
    {
        static void Sec(string[] args)
        {
            /*
            [Dever de casa]

                Faça um algoritmo que leia a idade de uma pessoa expressa em anos, 
                meses e dias e mostre-a expressa apenas em dias.
            */

            ContaDias calculaDias = new ContaDias();

            Console.WriteLine("Dia de Nascimento");

            int diaNascimento = 1;
            // int diaNascimento = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Mês de Nascimento");
            int mesNascimento = 1;
            // int mesNascimento = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ano de Nascimento");
            int anoNascimento = 2021;
            // int anoNascimento = Int32.Parse(Console.ReadLine());

            //data atual
            int diaAtual = DateTime.Now.Day;
            int mesAtual = DateTime.Now.Month;
            int anoAtual = DateTime.Now.Year;

            var totalDias = calculaDias.CalculaDias(diaNascimento, mesNascimento, anoNascimento);
            Console.WriteLine($"Você viveu exatos {totalDias} dias.");
            
        }
    }
}
