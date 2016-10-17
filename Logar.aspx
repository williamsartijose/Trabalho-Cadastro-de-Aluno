<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Logar.aspx.cs" Inherits="Site.Logar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link type ="text/css"rel="stylesheet" href="Content/bootstrap.css" />
</head>
     <script src = " Scripts/jquery-1.9.1.min.js"><</script>
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
                        <li><a href="Logar.aspx">Logar</a></li>
                        <li><a href="Cadastrar.aspx">Cadastre-se</a></li>

      
                        </ul>
                    
                  
                </div>
                </div>
                 </div>
            </div>
    

        <br />
        <br />
        

        <!--- Sign in start  -->
        <div class="container">
            <div class="form-horizontal">
                <h2>Login</h2>
                <hr />
                <div class="form-group">
                    <asp:Label ID="Label1" runat="server" CssClass="col-md-2 control-label" Text="Usuario"></asp:Label>
                    <div class="col-md-3">
                        <asp:TextBox ID="Usuario" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorUsuario" CssClass="text-danger" runat="server" ErrorMessage="Usuario Errado " ControlToValidate="Usuario"></asp:RequiredFieldValidator>
                    </div>
                    </div>
                
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label2" runat="server" CssClass="col-md-2 control-label" Text="Senha"></asp:Label>
                    <br />
                    <div class="col-md-3">
                          <asp:TextBox ID="Senha" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorSenha" runat="server" ErrorMessage="Senha errada!!" ControlToValidate="Senha"></asp:RequiredFieldValidator>
                
                                 </div>
                </div>
        
                 <div class="form-group">
                        <div class="col-md-2"></div>                    
                     <div class="col-md-6">

                         <div class="form-group">
                             <div class="col-md-2">
                                 <asp:Button ID="Button1" runat="server" Text="Login" CssClass="btn btn-default" OnClick="Button1_Click" />
                                <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Cadastrar.aspx">Cadastre-se</asp:LinkButton>
                             </div>
                             
                         </div>
                         <div class="col-md-6">
                             <asp:Label ID="lblError" runat="server" CssClass="text-danger"></asp:Label>
                         </div>
                     </div>
            </div>
        </div>
        <!--- Sign in end  -->


    </form>
    <!--- Footer  -->

    <hr />

  
  
</body>
</html>

  