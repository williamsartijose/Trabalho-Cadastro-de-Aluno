using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Site
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btnAcessar(object sender, EventArgs e){
                //capturar o valor selecionado na drop down list 
                string opcao = ddlMenu.SelectedValue;

                switch(opcao)
                {
                    case "0":

                        lblMensagem.Text = "Por favor , selecione uma opção valida";
                    break;    
                    
                    
                    case "1":
                        Response.Redirect("/Page/Cadastro.aspx");

                           break ;

                    case "2":
                        Response.Redirect("/Page/Consulta.aspx");
                           break ;

                    case "3":
                        Response.Redirect("/Page/Detalhes.aspx");
                           break ;



                    case "4":
                           Response.Redirect("~/Page/Home.aspx");
                           break;
                       
                    case "5":
                           Response.Redirect(" /Page/Avaliacao.aspx");
                           break;

                    case "6":
                           Response.Redirect("/Page/Funcionario.aspx");
                           break;

                    case "7":
                           Response.Redirect("/Page/Detalhes.aspx");
                           break;

                    
                }
        }
    }
}