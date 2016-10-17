using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;



namespace Site
{
    public partial class Cadastroo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Biblioteca.Camadas.BLL.Aluno aluno = new Biblioteca.Camadas.BLL.Aluno();


             
                
              Cache["OP"] = "X";
              habilitaCampos(false);
            
           }
        }


        protected void habilitaCampos(bool status)
        {

            //se o cache "browser " habilitar campos então lipa todos os formuarios 
            if (Cache["OP"].ToString() != "E")
            {
                txtId.Text = " ";
                txtNome.Text = " ";
                txtEndereco.Text = " ";
                txtEmail.Text = " ";
                txtEstado.Text = " ";
                txtCidade.Text = " ";
            }


            txtNome.Enabled = status;
            txtEndereco.Enabled = status;
            txtEmail.Enabled = status;
            txtCidade.Enabled = status;
            txtEstado.Enabled = status;


            btnInserir.Enabled = !status;
            btnEditar.Enabled = !status;
            //btnRemover.Enabled = !status;
            btnGravar.Enabled = status;
            btnCancelar.Enabled = !status;

        }

        protected void btnGravar_Click(object sender, EventArgs e)
        {
            Biblioteca.Camadas.BLL.Aluno bllAluno = new Biblioteca.Camadas.BLL.Aluno();
           Biblioteca.Camadas.MODEL.Aluno aluno = new Biblioteca.Camadas.MODEL.Aluno();



           aluno.id = Convert.ToInt32(txtId.Text);
           aluno.nome = txtNome.Text;
           aluno.endereco = txtEndereco.Text;//txtEndereco.Text;
           aluno.email = txtEmail.Text;
           aluno.cidade = txtCidade.Text;
           aluno.estado = txtEstado.Text;
                                                                         ///Como usar Console.WriteLine em ASP.NET (C #) durante a depuração 
                //                                                           System.Diagnostics.Debug.WriteLine("SomeText" + aluno.id);
                                                                        ////////////////////////////////////////////////////////////////
           if (Cache["OP"].ToString() == "I")// se a opcço for I chamei o metodos do insert
               bllAluno.Insert(aluno);
            else if (Cache["OP"].ToString() == "E")// se a opção for E chamei o metodo do updat
                bllAluno.Update(aluno);
//
              Cache["OP"] = "X";
           habilitaCampos(false);
        }

      

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            Cache["OP"] = "I"; //cache é para limpar o browser " i de insert  e
            habilitaCampos(true);
            txtId.Text = " -1";// cada vez que chama uma pagina ele perdi
            txtNome.Focus();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {

        }

        protected void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
        

      

       