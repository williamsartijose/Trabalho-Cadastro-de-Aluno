<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Funcionario.aspx.cs" Inherits="Site.Funcionario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Funcionarios</title>
        <link type ="text/css"rel="stylesheet" href="Content/bootstrap.css" />
   
</head>
<body>





    <form id="form1" runat="server" style="background-image: none; background-color: #FFFFFF;">


    <nav class="navbar navbar-inverse" style="text-align: center">
            
        <br />

        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">Home</asp:HyperLink>
        
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Page/Funcionario.aspx">Voltar</asp:HyperLink>
            
</nav>
     




        <br />
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:WEBConnectionString %>" SelectCommand="SELECT [id], [nome], [perfil] FROM [Funcionarioo]"></asp:SqlDataSource>
&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                <br />
                <br />
                <asp:DataList ID="DataList1" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" DataKeyField="nome" DataSourceID="SqlDataSource1" ForeColor="Black" HorizontalAlign="Left" OnItemCommand="DataList1_ItemCommand" RepeatColumns="4" RepeatDirection="Horizontal" style="margin-left: 34px; margin-right: 2px; margin-top: 0px;" Width="857px" Height="228px">
                    <AlternatingItemStyle BackColor="PaleGoldenrod" />
                    <FooterStyle BackColor="Tan" />
                    <HeaderStyle BackColor="Tan" Font-Bold="True" />
                    <ItemTemplate>
                        ID:
                        <asp:Label ID="idLabel" runat="server" Text='<%# Eval("id") %>' />
                        <br />
                        NOME:
                        <asp:Label ID="nomeLabel" runat="server" Text='<%# Eval("nome") %>' />
                        <br />
                        PERFIL:<asp:Label ID="perfilLabel" runat="server" Text='<%# Eval("perfil") %>' />
                        <br />
<br />
                        <asp:Button ID="Button1" runat="server" Text="Selecionar" />
                    </ItemTemplate>
                    <SelectedItemStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                </asp:DataList>
                <br />
                <br style="background-image: url('../Imagens/leg.jpg')" />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
                <br />
        <br />
        <br />
        <br />
        <br />
&nbsp;DataList<br />
&nbsp; <span class="auto-style1">O FUNCIONARIO&nbsp; SELECIONADO FOI: </span>
                <asp:Label ID="Label1" runat="server" CssClass="auto-style1" ForeColor="Red"></asp:Label>
                <br />
                <br />
        <br />
    <div style="height: 249px; width: 179px; margin-left: 22px; text-align: left;">
    
        INFORME O NOME:<br />
        <br />
        <br />
        <asp:TextBox ID="txtFun" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        <asp:Button ID="btnFun" runat="server" OnClick="Button1_Click" Text="Enviar" />
        <br />
        05_PostBack<br />
        <asp:DropDownList ID="dplFun" runat="server" Height="16px" Width="138px">
        </asp:DropDownList>
    
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
