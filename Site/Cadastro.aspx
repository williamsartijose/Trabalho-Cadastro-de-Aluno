<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Site.Cadastroo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <title>Cadastro de Alunos</title>
    <!-- Incluindo o CSS do Bootstrap -->
     <link type ="text/css"rel="stylesheet" href="Content/bootstrap.css" />
    <link href="css/bootstrap.min.css" rel="stylesheet">


</head>
     <!-- Incluindo o jQuery que é requisito do JavaScript do Bootstrap -->
    <script src = "Scripts/jquery-1.9.1.min.js"></script>
     <!-- Incluindo o JavaScript do Bootstrap -->
    <script src ="Scripts/bootstrep.mim.js"></script>   
     <!-- jQuery (necessario para os plugins Javascript do Bootstrap) -->
  <script src="js/jquery.js"></script>
 
      
<body>

   
    <form id="form1" runat="server">
            
                <!-- Os Botâo ID: -->

               <div class="center-page"></div>

                <label class="col-xs-11">ID</label>
                <div class="col-xs-11">
                
                    <asp:Label ID="txtId" CssClass="form-control" runat="server" Text="Label"></asp:Label>
                </div>
        


              

                <!-- Os txtNome -->



                 <label class="col-xs-11">Nome</label>
                <div class="col-xs-11">
                    <asp:TextBox ID="txtNome" runat="server" CssClass="form-control" placehoder="Nome" OnTextChanged="txtNome_TextChanged"></asp:TextBox>
                </div>
                

                <!-- Text txtEndereco -->
                
                  <label class="col-xs-11">Endereço</label>
                <div class="col-xs-11">
                    <asp:TextBox ID="txtEndereco" runat="server" CssClass="form-control" placehoder="Endereço"></asp:TextBox>
                </div>

                <!-- txtCidade -->
                  <label class="col-xs-11">Cidade</label>
                <div class="col-xs-11">
                    <asp:TextBox ID="txtCidade" runat="server" CssClass="form-control" placehoder="Cidade"></asp:TextBox>
                </div>

                <!-- txtEmail-->
                 <label class="col-xs-11">E-mail</label>
                <div class="col-xs-11">
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" placehoder="Email"></asp:TextBox>
                </div>

                <!-- txtEstado-->
                <label class="col-xs-11">estado</label>
                <div class="col-xs-11">
                    <asp:TextBox ID="txtEstado" runat="server" CssClass="form-control" placehoder="Estado"></asp:TextBox>
                </div>

                <!-- Button -->
                <!-- Button -->
<div class="form-group">
  <label class="col-md-4 control-label" for="btnInserir"></label>
  <div class="col-md-4">
      <asp:Button ID="btnInserir" class="btn btn-primary" runat="server" Text="Inserir" OnClick="btnInserir_Click" />      
      <asp:Button ID="btnEditar" class="btn btn-primary" runat="server" Text="Editar" />
     
      <asp:Button ID="btnGravar" CssClass="btn btn-primary" runat="server" Text="Gravar" OnClick="btnGravar_Click" />
      <asp:Button ID="btnCancelar" CssClass="btn btn-primary" runat="server" Text="Cancelar" OnClick="Button5_Click" />
  </div>
</div>
                </form>
    </body>
    </html>

                      <a href="/Default.aspx" class="glyphicon glyphicon-home"></a>
                        
                      
                        
                        