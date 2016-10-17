<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consulta.aspx.cs" Inherits="Site.Page.Consulta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CONSULTA</title>
    <link type ="text/css"rel="stylesheet" href="Content/bootstrap.css" />
    <style type="text/css">
        .auto-style1 {
            font-size: large;
        }
        .auto-style2 {
            font-size: xx-large;
        }
    </style>
</head>
    <script src = " Scripts/jquery-1.9.1.min.js"></script>
    <script src ="Scripts/bootstrep.mim.js"></script>
<body>

    <div class="panel panel-primary">
  <div class="panel-heading">
    <h3 class="panel-title">Consultas de Alunos</h3>
  </div>
  <div class="panel-body">  
       <form id="form1" runat="server">   
                        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="Biblioteca.Camadas.MODEL.Aluno" DeleteMethod="Delete" InsertMethod="Insert" SelectMethod="Select" TypeName="Biblioteca.Camadas.BLL.Aluno" UpdateMethod="Update"></asp:ObjectDataSource>
                        <br />
                    </div>
                    <br />
                    <br />
                    <br />
                <br />
                    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" DataSourceID="ObjectDataSource1" ForeColor="#333333" GridLines="None" Width="1039px" HorizontalAlign="Center">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <Columns>
                            <asp:BoundField DataField="id" HeaderText="id" SortExpression="id" />
                            <asp:BoundField DataField="nome" HeaderText="nome" SortExpression="nome" >
                            <ItemStyle Width="200px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="endereco" HeaderText="endereco" SortExpression="endereco" >
                            <ItemStyle Width="200px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" >
                            <ItemStyle Width="200px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="cidade" HeaderText="cidade" SortExpression="cidade" >
                            <ItemStyle Width="100px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="estado" HeaderText="estado" SortExpression="estado" >
                            <ItemStyle Width="50px" />
                            </asp:BoundField>
                            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" ButtonType="Image" DeleteImageUrl="~/Imagens/remover.jpg" EditImageUrl="~/Imagens/inserir.jpg" InsertImageUrl="~/Imagens/selecionar.jpg" />
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
                <br />
                <span class="auto-style1"><asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" AutoGenerateRows="False" CellPadding="3" DataSourceID="ObjectDataSource1" ForeColor="Black" GridLines="Vertical" Height="50px" Width="810px" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" HorizontalAlign="Center">
                    <AlternatingRowStyle BackColor="#CCCCCC" />
                    <EditRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                    <Fields>
                        <asp:BoundField DataField="id" HeaderText="id" SortExpression="id" >
                        </asp:BoundField>
                        <asp:BoundField DataField="nome" HeaderText="nome" SortExpression="nome" />
                        <asp:BoundField DataField="endereco" HeaderText="endereco" SortExpression="endereco" />
                        <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                        <asp:BoundField DataField="cidade" HeaderText="cidade" SortExpression="cidade" />
                        <asp:BoundField DataField="estado" HeaderText="estado" SortExpression="estado" />
                    </Fields>
                    <FooterStyle BackColor="#CCCCCC" />
                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                </asp:DetailsView>


                </span></div>
            </div>
        </div>
        <span class="auto-style2">
                
                <a href="/Default.aspx" class="btn btn-primary">Voltar</a></span><br />


    
        </form>

      </div>
      </div>

   
</body>
</html>
