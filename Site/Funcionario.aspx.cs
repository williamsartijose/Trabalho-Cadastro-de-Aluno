using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Site
{
    public partial class Funcionario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            if(txtFun.Text!= string.Empty)
                dplFun.Items.Add(txtFun.Text);
            txtFun.Text = "";
            txtFun.Focus();
        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            Label1.Text = DataList1.DataKeys[e.Item.ItemIndex].ToString();
            Response.Redirect("Detalhes.aspx?id" + Label1);//redirecinando para pagina detlahes 
        }
    }
}