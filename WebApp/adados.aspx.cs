using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DaWebApp
{
  public partial class adados : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
      //Recupera parâmetro
      string parametro = Request.QueryString["identificador"];

      //Recupera objeto da sessão
      List<Menssagem> registros = (List<Menssagem>)Session["registros"];

      //Adiciona registros
      registros.Add(new Menssagem(Convert.ToInt32(TextBox1.Text), TextBox2.Text, TextBox3.Text));
      Response.Ridirect("default.aspx");
    }
  }
}