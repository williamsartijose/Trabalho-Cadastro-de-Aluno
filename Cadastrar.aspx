<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastrar.aspx.cs" Inherits="Site.Page.Cadastrar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bem-Vindo a pagina de cadastro </title>

    <link type ="text/css"rel="stylesheet" href="Content/bootstrap.css" />

</head>
    <script src = " Scripts/jquery-1.9.1.min.js"></script>
    <script src ="Scripts/bootstrep.mim.js"></script>
<body>
    <form id="form1" runat="server">
    <div>


         <div>
             <div class="navbar navbar-default navbar-fixed-top" role="navigation">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
             <a class="navbar-brand " href="Inicio.aspx"> <span> <img alt="logo" src="Imagens/x.png" height="30" /></span>Sistema de Cadastro Web</a>
                </div>

                <div class="navbar-collapse collapse">
                    <ul class="nav navbar-nav navbar-right">
                        <li class="active"><a href="Default.aspx">Home</a></li>
                        <li><a href="Log.aspx">Logar</a></li>
                        <li><a href="Cadastrar.aspx">Cadastre-se</a></li>

      
                        </ul>
                    
                  
                </div>
                </div>
                 </div>
            </div>
    

        <br />
        <br />
        

         <!-- log -->
         <div class="center-page">
           
            <label class="col-xs-11">Usuario</label>
            <div class="col-xs-11">
             <asp:TextBox ID="tbUsuario" runat="server" CssClass="form-control" placeholder="usuario"></asp:TextBox>
            </div>



             <label class="col-xs-11">Senha</label>
            <div class="col-xs-11">
             <asp:TextBox ID="tbSenha" runat="server" CssClass="form-control" placeholder="Senha" TextMode="Password"></asp:TextBox>
         
            </div>



             <label class="col-xs-11">Confirma Senha</label>
            <div class="col-xs-11">
             <asp:TextBox ID="tbConfirma" runat="server" CssClass="form-control" placeholder="Confirma Senha" TextMode="Password"></asp:TextBox>
            </div>


             <label class="col-xs-11">Nome</label>
            <div class="col-xs-11">
             <asp:TextBox ID="tbNome" runat="server" CssClass="form-control" placeholder="Nome"></asp:TextBox>
            </div>

             <label class="col-xs-11">E-mail</label>
            <div class="col-xs-11">
             <asp:TextBox ID="tbEmail" runat="server" CssClass="form-control" placeholder="E-mail" TextMode="Email"></asp:TextBox>
            </div>

            <div class="col-xs-11">
            <asp:Button ID="Button1" runat="server" CssClass="btn-success" Text="Gravar" OnClick="Button1_Click" />
                <asp:Label ID="lblMens" runat="server"></asp:Label>
                </div>

             
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1" EmptyDataText="There are no data records to display." AllowPaging="True" AllowSorting="True" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" />
                    <asp:BoundField DataField="Usuario" HeaderText="Usuario" SortExpression="Usuario" />
                    <asp:BoundField DataField="Senha" HeaderText="Senha" SortExpression="Senha" />
                    <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                    <asp:BoundField DataField="Nome" HeaderText="Nome" SortExpression="Nome" />
                    <asp:CommandField ButtonType="Image" CancelImageUrl="~/Imagens/x.png" DeleteImageUrl="~/Imagens/remover.jpg" EditImageUrl="~/Imagens/selecionar.jpg" InsertImageUrl="~/Imagens/inserir.jpg" ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dadosConnectionString1 %>" DeleteCommand="DELETE FROM [Usuarios] WHERE [Id] = @Id" InsertCommand="INSERT INTO [Usuarios] ([Usuario], [Senha], [Email], [Nome]) VALUES (@Usuario, @Senha, @Email, @Nome)" ProviderName="<%$ ConnectionStrings:dadosConnectionString1.ProviderName %>" SelectCommand="SELECT [Id], [Usuario], [Senha], [Email], [Nome] FROM [Usuarios]" UpdateCommand="UPDATE [Usuarios] SET [Usuario] = @Usuario, [Senha] = @Senha, [Email] = @Email, [Nome] = @Nome WHERE [Id] = @Id">
                <DeleteParameters>
                    <asp:Parameter Name="Id" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="Usuario" Type="String" />
                    <asp:Parameter Name="Senha" Type="String" />
                    <asp:Parameter Name="Email" Type="String" />
                    <asp:Parameter Name="Nome" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="Usuario" Type="String" />
                    <asp:Parameter Name="Senha" Type="String" />
                    <asp:Parameter Name="Email" Type="String" />
                    <asp:Parameter Name="Nome" Type="String" />
                    <asp:Parameter Name="Id" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>



        </div>


    </div>
    </form>
</body>
</html>
