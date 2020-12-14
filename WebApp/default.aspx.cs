using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DaWebApp
{
  public partial class _default : System.Web.UI.Page
  {

    protected void Page_Load(object sender, EventArgs e)
    {
      if (Session["registros"] == null)
      {
        // Cria lista para o objeto
        List<Menssagem> msg = new List<Menssagem>();

        // Adicionar dados ao objeto
        msg.Add(new Menssagem(1, "Ricardo", "Olá Pessoal"));
        msg.Add(new Menssagem(2, "Mantovani", "Bem-vindos ao desenvolvimento aberto," +
                                "adicione, altere e exclua dados nesta tabela"));

        // Adiciona objeto a sessão
        Session["registros"] = msg;
      }

      // Cria página no método HTTP Get
      if (Request.HttpMethod.Equals("GET"))
      {
        doGet();
      }
    }

    private void doGet()
    {
      //Cria estilo css
      Response.Write("<head>");
      Response.Write("<style>");
      Response.Write("td, th {");
      Response.Write("border: none;");
      Response.Write("background-color: #ddd;");
      Response.Write("padding: .5rem;");
      Response.Write("width: 40vw");
      Response.Write("</style>");
      Response.Write("</head>");

      //Titulo da página
      Response.Write("<h1>Desenvolvimento Aberto - Listas</h1>");

      //Cria Tabela
      Response.Write("<table>");
      Response.Write("<tr>");
      Response.Write("<th>ID:</th>");
      Response.Write("<th>Nome:</th>");
      Response.Write("<th>Comentário:</th>");
      Response.Write("<th>Ação:</th>");
      Response.Write("</tr>");

      //Recupera o objeto da sessão
      List<Menssagem> registros = (List<Menssagem>)Session["registros"];

      //Itera objeto
      foreach (Menssagem reg in registros)
      {
        Response.Write("<tr>");
        Response.Write("<td>" + reg.Id + "</td>");
        Response.Write("<td>" + reg.Nome + "</td>");
        Response.Write("<td>" + reg.Msg + "</td>");

        //Link da edição
        Response.Write("<td><center>");
        Response.Write("<a href='usados.aspx?identificador=" + reg.Id + "'>Editar</a> | ");
        Response.Write("<a href='ddados.aspx?identificador=" + reg.Id + "'>Apagar</a>");
        Response.Write("</center></td>");
        Response.Write("</tr>");
      }
      Response.Write("</table>");

      //Define link para formulário de adicionar dados
      Response.Write("<p><a href='adados.aspx'>Adicione um comentário</a></p>");

    }
  }
}