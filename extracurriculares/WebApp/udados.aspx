<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="udados.aspx.cs" Inherits="DaWebApp.udados" %>

  <!DOCTYPE html>
  <html xmlns="http://www.w3.org/1999/xhtml">

  <head runat="server">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title></title>
  </head>

  <body>
    <h1>Desenvolvimento Aberto - Altera Dados</h1>
    <form action="" id="form1" runat="server">
      <div>
        <asp:Label ID="Label1" runat="server" Text="Identificador:"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        Nome:<br />
        <asp:TextBox ID="TextBox2" runat="server" Width="194px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Menssagem:"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox3" runat="server" Height="122px" TextMode="MultiLine" Width="209px"></asp:TextBox>

        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Alterar" Width="112px" />
      </div>
    </form>
  </body>

  </html>