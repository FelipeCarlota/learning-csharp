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
        }
    }

    class Aluno
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
    }
}