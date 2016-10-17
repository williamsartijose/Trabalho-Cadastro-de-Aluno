using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Site.Page
{
    public partial class Consulta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
           // GridViewRow row = GridView1.Rows[Convert.ToInt32(e.CommandArgument)]; ///cria uma variavel que gaurda quando da um select na linha
            //lblId.Text = row.Cells[0].Text;
            //lblNome.Text = row.Cells[1].Text;
            //lblEnd.Text = row.Cells[2].Text;
            //lblEmail.Text = row.Cells[3].Text;

            
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

           
        }
    }
}