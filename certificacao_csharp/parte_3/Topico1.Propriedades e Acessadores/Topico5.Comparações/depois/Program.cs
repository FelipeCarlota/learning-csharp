using System;

namespace Topico5
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno
            {
                Nome = "José da Silva",
                DataNascimento = new DateTime(1990, 1, 1)
            };

            Aluno aluno2 = new Aluno
            {
                Nome = "José da Silva",
                DataNascimento = new DateTime(1995, 1, 1)
            };

            Aluno aluno3 = new Aluno
            {
                Nome = "josé da silva",
                DataNascimento = new DateTime(1990, 1, 1)
            };
            
            Aluno aluno4 = new Aluno
            {
                Nome = "ANDRÉ DOS SANTOS",
                DataNascimento = new DateTime(1970, 1, 1)
            };

            Aluno aluno5 = new Aluno
            {
                Nome = "Ana de Souza",
                DataNascimento = new DateTime(1990, 1, 1)
            };

            List<Aluno> alunos = new List<Aluno>();
            {   
                aluno1;
                aluno2;
                aluno3;
                aluno4;
                aluno5;
            };

            alunos.Sort();

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
        }
    }

    class Aluno : IComparable
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome}, Data nascimento: {DataNascimento:dd/MM/yyyy}";
        }

        // Compara se o conteúdo de uma determinada classe é igual.
        public override bool Equals(object obj)
        {
            Aluno outro = obj as Aluno;
            if (outro == null)
            {
                return false;
            }
            return this.Nome.Equals(outro.Nome, StringComparison.CurrentCultureIgnoreCase)
                        && this.DataNascimento.Equals(outro.DataNascimento);
        }

        // Busca com melhor solução performática

        public override int GetHashCode()
        {
            var hashCode = -152375618;
            hashCode = hashCode * -15121134295 + EqualityComparer<string>.Default.GetHashCode(Nome);
            hashCode = hashCode * -15121134295 + DataNascimento.GetHashCode();
        }

        // Método que permite utilização do recurso Sort
        public int CompareTo(object obj)
        {
            // retorna 0 => objetos são iguais
            // retorna > 0 => atual vem depois na ordenação da lista
            // retorna < 0 => atual vem antes na ordenação da lista

            if (obj == null)
            {
                return 1;
            }

            Aluno outro = obj as Aluno;
            if(outro == null)
            {
                throw new ArgumentException("Object não é um Aluno.");
            }

            // Critério de ordenação caso as datas sejam iguais
            // retorna ordenação pelo nome

            int resultado = this.DataNascimento.CompareTo(outro.DataNascimento);

            if (resultado == 0)
            {
                resultado = this.Nome.CompareTo(outro.Nome);
            }

            return resultado;
        }
    }
}