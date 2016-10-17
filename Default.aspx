<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Site.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>HOME</title>
   <!-- Bootstrap -->
    <link href="css/bootstrap.min.css" rel="stylesheet"/>
    <link href="css/Custom-Cs.css" rel="stylesheet" />
    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->

</head>
    <script src = " Scripts/jquery-1.9.1.min.js"><</script>
    <script src ="Scripts/bootstrep.mim.js"></script>
<body>
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
    <form id="form1" runat="server">
    <div class="jumbotron">
        <h1 class="text-center">Controles de Alunos <asp:Image ID="Image1" runat="server" BorderStyle="Solid" Height="104px" ImageUrl="~/Imagens/logo.gif" Width="134px" />
 </h1>


         <!-- /comentarios -->

       <p></p>
        <p class="text-center">Selecione a opeção desejada:</p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlMenu" runat="server">
           <asp:ListItem Value="0" Text="-Escolher uma Opção-" />
            <asp:ListItem Value="1" Text="-Cadastrar Aluno-" />
            <asp:ListItem Value="2" Text="-Consultar Aluno-" />
            <asp:ListItem Value="3" Text="-Funcionario-" />
             <asp:ListItem Value="4" Text="-Curso-" />
             <asp:ListItem Value="5" Text="-Avalição-" />
             <asp:ListItem Value="6" Text="-Detalhes Funcionario-" />

     
    </asp:DropDownList >
         
        &nbsp;<asp:Button ID="btnMenu" runat="server" Text="acessar" CssClass="btn btn-primary btn-lg" OnClick="btnAcessar" />

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

        

 <!--- Middle Contents -->
        <div class="container center">
            <div class="row">
                <div class="col-lg-4">
                    <img class="img-circle" src="Imagens/logo.gif" alt="thumb01" height="30" />
                    <h2>Sobre a Universidade</h2>
                    <p>Lorem ipsum </p>
                     <p> 2016 - William Sarti & Mateus Tormes
                                      <a href="https://www.facebook.com/william.Delonge.357284" target="balnk"> Facebook William</a> </p>
                                      <a href="https://www.facebook.com/mateus.tormes?fref=ts" target="balnk"> Facebook Mateus</a> </p>

                </div>



            
                              
            
            
            
                <asp:Label ID="lblMensagem" runat="server" />

    </div>
    </form>
</body>
</html>
