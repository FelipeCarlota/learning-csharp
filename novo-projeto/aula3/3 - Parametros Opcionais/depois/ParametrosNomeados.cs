using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
  class ParametrosNomeados : IAulaItem
  {
    public void Executar()
    {
      //O método pode ser chamado de forma ordenada, usando argumentos posicionais.
      ImprimirDetalhesDoPedido("Pedro Cassiano", 20, "Caneta Azul");

      //Argumentos nomeados podem ser fornecidos para os parâmetros em qualquer ordem.
      ImprimirDetalhesDoPedido(nomeProduto: "Caneca Vermelha", vendedor: "Thiago Pereira", numeroPedido: 05);

      //Argumentos nomeados misturados com argumentos posicionais são válidos
      // Desde que obedeçam a forma ordenada.
      ImprimirDetalhesDoPedido("Maria Cláudia", 51, nomeProduto: "Toalha de Rosto");
    }

    void ImprimirDetalhesDoPedido(string vendedor, int numeroPedido, string nomeProduto)
    {
      if (string.IsNullOrWhiteSpace(vendedor))
      {
        throw new ArgumentException(message: "Nome de vendedor não pode ser nulo ou vazio.", paramName: nameof(vendedor));
      }

      Console.WriteLine($"Vendedor: {vendedor}, Pedido No.: {numeroPedido}, Produto: {nomeProduto}");
    }
  }
}
