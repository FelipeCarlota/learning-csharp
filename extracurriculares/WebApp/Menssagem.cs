using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DaWebApp
{
  public class Menssagem
  {
    //Declara atributos
    private int id;
    private string nome;
    private string menssagem;

    // Construtor padrão
    public Menssagem() { }

    //Construtor Overload
    public Menssagem(int id, string nome, string menssagem)
    {
      // Inicializa valores
      this.id = id;
      this.nome = nome;
      this.menssagem = menssagem;
    }

    //Propriedades
    public int Id
    {
      get
      {
        return id;
      }
      set
      {
        id = value;
      }
    }

    public string Nome
    {
      get
      {
        return nome;
      }
      set
      {
        nome = value;
      }
    }

    public string Msg
    {
      get
      {
        return menssagem;
      }
      set
      {
        menssagem = value;
      }
    }
  }
}