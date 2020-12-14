<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adados.aspx.cs" Inherits="DaWebApp.adados" %>

  <!DOCTYPE html>
  <html xmlns="http://www.w3.org/1999/xhtml">

  <head runat="server">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title></title>
  </head>

  <body>
    <h1>Desenvolvimento Aberto - Adiciona Mensagem</h1>
    <form action="" id="form1" runat="server">
      <div>
        <asp:Label ID="Label2" runat="server" Text="Id:entificador"></asp:Label></br>
        <asp:TextBox ID="TextBox" runat="server" Width="135px"></asp:TextBox></br>
        <asp:Label ID="Label1" runat="server" Text="Nome:"></asp:Label></br>
        <asp:TextBox ID="TextBox2" runat="server" Width="229px"></asp:TextBox></br></br>
        <asp:TextBox ID="TextBox3" runat="server" Height="118px" TexMode="MultiLine" Width="269px"></asp:TextBox></br></br>
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Adicionar" width="274px" />
      </div>
    </form>
  </body>

  </html>