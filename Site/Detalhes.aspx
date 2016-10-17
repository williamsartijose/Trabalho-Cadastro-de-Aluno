<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Detalhes.aspx.cs" Inherits="Site.Page.Detalhes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="background-image: url('../Imagens/Fun.png')">
<head runat="server">
    <title>Detalhes</title>
     <link type ="text/css"rel="stylesheet" href="Content/bootstrap.css" />

    


   
<p> &nbsp;</p>
</body>
</head>
<body>

    <nav class="navbar navbar-inverse" style="text-align: center">
            
        <br />

        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/Default.aspx">Home</asp:HyperLink>
        
        <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/Page/Funcionario.aspx">Voltar</asp:HyperLink>
            
</nav>
    <form id="form1" runat="server">
    <div>
    
        

        Detalhes
        <br />
        <br />
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataSourceID="SqlDataSource1" GridLines="Vertical" Height="102px" style="font-size: large; margin-bottom: 0px" Width="337px" AllowPaging="True">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <EditRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <Fields>
                <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="nome" HeaderText="nome" SortExpression="nome" />
                <asp:BoundField DataField="perfil" HeaderText="perfil" SortExpression="perfil" />
                <asp:CommandField ButtonType="Button" />
            </Fields>
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
        </asp:DetailsView>
        <br />
        <br />
        <br />
        <br />
    
        

    </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:WEBConnectionString %>" SelectCommand="SELECT [id], [nome], [perfil] FROM [Funcionarioo] WHERE ([id] = @id)">
            <SelectParameters>
                <asp:QueryStringParameter DefaultValue="1" Name="id" QueryStringField="id" Type="Int32" />
            </SelectParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>
