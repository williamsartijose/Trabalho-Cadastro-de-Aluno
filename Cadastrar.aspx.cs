using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;

namespace Site.Page
{
    public partial class Cadastrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {



            if (tbUsuario.Text != "" & tbSenha.Text != "" && tbNome.Text != "" && tbEmail.Text != "" && tbSenha.Text != "")
            {
                if (tbSenha.Text == tbSenha.Text)
                {

                    String CS = ConfigurationManager.ConnectionStrings["dadosConnectionString1"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(CS))
                    {
                        SqlCommand cmd = new SqlCommand("insert into Usuarios values('" + tbUsuario.Text + "','" + tbSenha.Text + "','" + tbEmail.Text + "','" + tbNome.Text + "')", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        lblMens.Text = "Cadastrado com Sucesso";
                        lblMens.ForeColor = Color.Green;
                        Response.Redirect("~/Log.aspx");


                    }

                }
                else
                {
                    lblMens.ForeColor = Color.Red;
                    lblMens.Text = "senhas não são idênticas";
                }
            }
            else
            {
                lblMens.ForeColor = Color.Red;
                lblMens.Text = "É obrigatorio o preenchimento de todos os campos";

            }
        }
    }


}