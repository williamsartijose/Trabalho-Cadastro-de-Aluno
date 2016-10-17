<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Log.aspx.cs" Inherits="Site.Log" %>

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

        <br />

       <div class="container">
        <div class="row">
            <div class="col-md-4 col-md-offset-4">
                <div class="login-panel panel panel-default">
                    <div class="panel-heading">
                        <h3 class="panel-title">Iniciar</h3>
                    </div>
                    <div class="panel-body">
                        <form role="form">
                            <fieldset>
                                <div class="form-group">
                                    <input class="form-control" placeholder="E-mail" name="william" type="email" autofocus=""/>
                                </div>
                                <div class="form-group">
                                    <input class="form-control" placeholder="Password" name="1234" type="password" value=""/>
                                </div>
                                <div class="checkbox">
                                    <label>
                                        <input name="Lembrar" type="checkbox" value="Lembre de mim"/>
                                        </label>

                                </div>
                                <p class="fa fa-key">fa-key </p>
                                <!-- a partir do momento do click log -->
                                <a href="Default.aspx" class="btn btn-lg btn-success btn-block">Login</a>
                                
                            </fieldset>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>
    </div>
    </form>
</body>
</html>
