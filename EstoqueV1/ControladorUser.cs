using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EstoqueV1
{
    public partial class ControladorUser : Form
    {
        public ControladorUser()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Usuário\Desktop\Trabalhos - Mestrado\PROGRAMAÇÃO\GitHub\EstoqueV1\EstoqueV1\Db_Estoques.mdf;Integrated Security=True;Connect Timeout=30");
        
        private void btnSalvarSenha_Click(object sender, EventArgs e)
        {
            
            if (txtEditSenha.Text == txtConfEditSenha.Text)
            {
                string editSenha = "UPDATE Contas SET Senha = '" + txtEditSenha.Text + "' WHERE Login = '" + Form1.loginEmUso + "'";                               
                SqlCommand cmd = new SqlCommand(editSenha, conn);
                cmd.CommandType = CommandType.Text;
                conn.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Senha alterada com sucesso.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void ControladorUser_Load(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvarEmail_Click(object sender, EventArgs e)
        {
            if (txtEditEmail.Text == txtConfEditEmail.Text)
            {
                string editEmail = "UPDATE Contas SET Email = '" + txtEditEmail.Text + "' WHERE Login = '" + Form1.loginEmUso + "'";
                SqlCommand cmd = new SqlCommand(editEmail, conn);
                cmd.CommandType = CommandType.Text;
                conn.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("E-mail alterado com sucesso.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
