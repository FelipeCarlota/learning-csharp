using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DaWebApp
{
  public partial class ddados : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      //Recupera parametro
      string parametro = Request.QueryString["identificador"];

      // Alinha ID com indice da lista
      int id = Convert.ToInt32(parametro);
      id -= 1;

      // Recupera objeto da sessão
      List<Menssagem> registros = (List<Menssagem>)Session["registros"];

      //Remove registro da lista
      registros.RemoveAt(id);

      // Alinha indice com Id
      id += 1;

      // Define Menssagem ao usuário
      Response.Write("<h1>Desenvolvimento Aberto</h1>");
      Response.Write("Registro: ID:" + id + "removido com sucesso <br>");
      Response.Write("<a href='default.aspx'>Voltar</a>");
    }
  }
}
