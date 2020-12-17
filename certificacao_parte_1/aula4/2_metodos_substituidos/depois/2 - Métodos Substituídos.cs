using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
  class MetodosSubstituidos : IAulaItem
  {
    public void Executar()
    {
      Animal gato = new Gato() { Nome = "Bichano" };
      Animal cachorro = new Cachorro() { Nome = "Fred" };
      // Fazendo o Fred andar até a tigela que está há 3 passos de distância e beber água
      Console.WriteLine(cachorro.Nome);
      cachorro.Andar();
      cachorro.Andar();
      cachorro.Andar();
      cachorro.Beber();
      Console.WriteLine();
      // Fazendo o Bichano andar até a cama atrás dele e dormir
      Console.WriteLine(gato.Nome);
      gato.VirarADireita();
      gato.VirarADireita();
      gato.Deitar();

    }

  }

  class Animal
  {
    public String Nome { get; set; }

    public virtual void Beber()
    {
      Console.WriteLine("Beber");
    }
    public virtual void VirarADireita()
    {
      Console.WriteLine("Virar à Direita");
    }
    public virtual void VirarAEsquerda()
    {
      Console.WriteLine("Virar à esquerda");
    }

    public virtual void Comer()
    {
      Console.WriteLine("Comer");
    }

    public virtual void Andar()
    {
      Console.WriteLine("Dar um passo");
    }
    public virtual void Deitar()
    {
      Console.WriteLine("Deitar");
    }
  }

  class Gato : Animal
  {
    public override void Beber()
    {
      Console.WriteLine("Beber");
    }
    public override void VirarADireita()
    {
      Console.WriteLine("Virar à Direita");
    }
    public override void VirarAEsquerda()
    {
      Console.WriteLine("Virar à esquerda");
    }

    public override void Comer()
    {
      Console.WriteLine("Comer");
    }

    public override void Andar()
    {
      Console.WriteLine("Dar um passo");
    }
    public override void Deitar()
    {
      Console.WriteLine("Deitar");
    }
  }
  class Cachorro : Animal
  {
    public override void Beber()
    {
      Console.WriteLine("Beber");
    }
    public override void VirarADireita()
    {
      Console.WriteLine("Virar à Direita");
    }
    public override void VirarAEsquerda()
    {
      Console.WriteLine("Virar à esquerda");
    }

    public override void Comer()
    {
      Console.WriteLine("Comer");
    }

    public override void Andar()
    {
      Console.WriteLine("Dar um passo");
    }
    public override void Deitar()
    {
      Console.WriteLine("Deitar");
    }
  }
}