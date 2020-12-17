using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using systen.web.ui.webcontrols;

namespace DaWebApp
{
  public partial class usados : System.Web.ui.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      //Verifica se a resposta não é um postback
      if (!IsPostBack)
      {
        // Recupera parâmetro
        string parametro = Request.QueryString["identificador"];

        // Alinha ID com indice da lista
        int id = Convert.ToInt32(parametro);
        id -= 1;

        // Recupera objeto da sessão
        List<Menssagem> registros = (List<Menssagem>)Session["registros"];

        // Exibe objeto
        if (Session["registros"] != null)
        {
          TextBox1.Text = Convert.ToString(registros[id].Id);
          TextBox2.Text = registros[id].Nome;
          TextBox3.Text = registros[id].Msg;
        }
      }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
      //Recupera parametro
      string parametro = request.querystring["identificador"];

      // Alinha ID com o indice
      int id = Convert.ToInt32(parametro);
      id -= 1;

      // Recupera objeto da sessão
      List<Menssagem> registros = (List<Menssagem>)Session["registros"];

      //Altera propriedades da lista
      registros[id].Id = Convert.ToInt32(TextBox1.Text);
      registros[id].Nome = TextBox2.Text;
      registros[id].Msg = TextBox3.Text;

      // Redireciona página
      Response.Redirect("default.aspx");
    }
  }
}