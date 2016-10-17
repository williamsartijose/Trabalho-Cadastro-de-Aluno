using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace Site
{
    public partial class Logar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             if (!IsPostBack)
        {
            if (Request.Cookies["UNAME"]!=null && Request.Cookies["PWD"]!=null)
            {
                
                Usuario.Text = Request.Cookies["UNAME"].Value;
                Senha.Attributes["value"]= Request.Cookies["PWD"].Value;
               // CheckBox1.Checked = true;
            }
        }
    }

        

        protected void Button1_Click(object sender, EventArgs e)
        {
            String CS = ConfigurationManager.ConnectionStrings["dadosConnectionString1"].ConnectionString;
        using (SqlConnection con = new SqlConnection(CS))
        {
            SqlCommand cmd = new SqlCommand("select * from Usuarios where Usuario='"+Usuario.Text+"' and Senha='"+Senha.Text+"'",con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);//para armazenar informaçoes no banco 
            DataTable dt = new DataTable();//criando uma nova tabela para prencehr os dados
            sda.Fill(dt);

            if (dt.Rows.Count!=0)// se a senha e o nome concedir com a tabela ele joga na UsuarioInicio 
            {
                if (dt.Rows.Count!=0)
                {
                    Response.Redirect("~/Default.aspx");
                   

                 
                }
                else
                {
                    Response.Cookies["UNAME"].Expires = DateTime.Now.AddDays(-1);
                    Response.Cookies["PWD"].Expires = DateTime.Now.AddDays(-1);
                }

               
                Session["USERNAME"] = Usuario.Text;
                Response.Redirect("~/Default.aspx");
            }
            else
            {
                lblError.Text = "Invalido Usuario e Senha !!!";
            }
        }
    }
}
        }
