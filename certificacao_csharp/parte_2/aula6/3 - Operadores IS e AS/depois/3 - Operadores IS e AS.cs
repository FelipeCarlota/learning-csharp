using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
  class OperadoresISeAS : IAulaItem
  {
    public void Executar()
    {
      Animal animal = new Animal();
      Gato gato = new Gato();
      Cliente cliente = new Cliente("José da Silva", 30);
      // Console.WriteLine(cliente);

      Alimentar(animal);
      Alimentar(gato);
      Alimentar(cliente);
    }

    public void Alimentar(object obj)
    {
      if (obj is Animal animal)
      {
        animal.Beber();
        animal.Comer();
        return;
      }
      Console.WriteLine("Não é um animal");
    }
  }
  class Cliente
  {
    string nome;
    int idade;
    public Cliente(string cliente, int idade)
    {

    }
  }
}
