using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topico4
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario(1500);
            funcionario.CPF = "123.456.789-00";
            funcionario.Nome = "josé da silva";
            funcionario.DataNascimento = new DateTime(2000, 1, 1);

            ((IFuncionario)funcionario).CargaHorariaMensal = 168;
            ((IPlantonista)funcionario).CargaHorariaMensal = 32;
            funcionario.EfeturarPagamento();
            funcionario.CrachaGerado += (s, e) =>
            {
                Console.WriteLine("Crachá gerado");
            };
            ((IFuncionario)funcionario).GerarCracha();
            ((IPlantonista)funcionario).GerarCracha();

            // Cliente

            Cliente cliente = new Cliente
            {
                CPF = "172.393.848-90",
                DataNascimento = new DateTime(1998,1,1),
                Nome = "Terezo José",
                DataUltimaCompra = new DateTime(2019,4,4),
                ValorUltimaCompra = 1456.83
            };
        }
    }

    interface IFuncionario
    {
        string CPF { get; set; }
        string Nome { get; set; }
        DateTime DataNascimento { get; set; }

        event EventHandler CrachaGerado;

        void GerarCracha();

        decimal Salario { get; }
        int CargaHorariaMensal { get; set; }

        void EfeturarPagamento();
    }

    interface IPlantonista
    {
        int CargaHorariaMensal { get; set; }
        void GerarCracha();
    }

    class Funcionario : Pessoa, IFuncionario, IPlantonista //Nome de classe não pode ser colocado depois de nome de interfaces.
    {
        // public string CPF { get; set; }
        // public string Nome { get; set; }
        // public DateTime DataNascimento { get; set; }

        public event EventHandler CrachaGerado;

        void IFuncionario.GerarCracha()
        {
            if (CrachaGerado != null)
            {
                CrachaGerado(this, new EventArgs());
            }
        }

        void IPlantonista.GerarCracha()
        {
            if (CrachaGerado != null)
            {
                CrachaGerado(this, new EventArgs());
            }
        }

        public decimal Salario { get; }

        int IFuncionario.CargaHorariaMensal { get; set; }

        int IPlantonista.CargaHorariaMensal { get; set; }

        public Funcionario(decimal salario)
        {
            Salario = salario;
        }

        public void EfeturarPagamento()
        {
            Console.WriteLine("Pagamento Efetuado");
        }
    }

    sealed class Cliente : Pessoa //Modificador sealed não permite que sejam criadas classes derivadas herdando a partir desta classe.
    {
        // public string CPF { get; set; }
        // public string Nome { get; set; }
        // public DateTime DataNascimento { get; set; }
        public DateTime? DataUltimaCompra { get; set; } // interrogação informa que a propriedade também aceita valor null
        public decimal ValorUltimaCompra { get; set; }

        public override string ToString()
        {
        return $"Nome: {Nome}, Data da última compra: {DataUltimaCompra}";
        }

    }

    //Classe base, outras classes irão herdar informações a partir desta classe
    abstract class Pessoa // modificador abstract impede que um desenvolvedor instancie um novo objeto a partir desta classe.
    {
        public string CPF { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
