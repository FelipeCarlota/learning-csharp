using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topico1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cria uma nova instäncia da classe fundionário
            Funcionario funcionario = new Funcionario();

            //Propriedades
            // funcionario.salario = 1000;
            // Console.WriteLine(funcionario.salario);

            // funcionário.salario = -1200;
            // Console.WriteLine(funcionario.salario);
            
            funcionário.Salario = 1200;
            Console.WriteLine(funcionario.salario);
        }
    }   

    class Funcionario
    {
        public decimal salario;
        
        public decimal salario {
            //encapsulacao
            get
            {
                return salario;
            }
            // set
            // {
            //     if (value < 0)
            //     {
            //         throw new ArgumentOutOfRangeException("O salário não pode ser negativo");
            //     }
            //     salario = value;
            // }
        }

        // private decimal salario;
        // public decimal salario
        // {
        //     get { return salario; }
        //     set { myVar = value; }
        // }

        //Propriedade auto implementada
        // uma maneira de declarar uma propriedade com get e set sem precisar mencionar o campo.
        // public decimal Salario{get; set;}
        
    }
}
