using System;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            funcionario.salario = 1000;
            Console.WriteLine(funcionario.salario);

            funcionario.salario = -1200;
            Console.WriteLine(funcionario.salario);
            
            // funcionario.salario = -1200;
            funcionario.Salario = 1200;
            Console.WriteLine(funcionario.Salario);

        }
    }

    class Funcionario
    {
        public decimal salario;

        public decimal Salario 
        {
            //Encapsulamento do campo salário
            get
            {
                return salario;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("salário não pode ser menor do que 0.");
                }
                salario = value;
            }
        }

    }
}
