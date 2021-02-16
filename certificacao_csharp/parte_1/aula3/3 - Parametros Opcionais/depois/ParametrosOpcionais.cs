using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
  class ParametrosOpcionais : IAulaItem
  {
    public void Executar()
    {
      ClienteEspecial clienteEspecial = new ClienteEspecial("Túlio Maravilha");
      clienteEspecial.FazerPedido(1, "Residencial", 3);

      clienteEspecial = new ClienteEspecial();
      clienteEspecial.FazerPedido(2, "Residencial");

      clienteEspecial = new ClienteEspecial("Gabriel Coice");
      clienteEspecial.FazerPedido(quantidade: 3, produtoId: 2, endereco: "Comercial");

    }
  }

  class ClienteEspecial
  {
    private readonly string nome;
    public ClienteEspecial(string nome = "Anônimo") // Nesse caso, a atribuição de "Anônimo" torna o parâmetro nome em um parâmetro opicioal, permitindo que o argumento da nova instância ClienteEspecial() seja vazio.
    {
      this.nome = nome;
    }

    public void FazerPedido(int produtoId = 0, string endereco = "Não informado", int quantidade = 10)
    {
      Console.WriteLine("cliente: {0}, produtoId: {1}, endereço: {2}, quantidade: {3}.", nome, produtoId, endereco, quantidade);
    }
  }
}
