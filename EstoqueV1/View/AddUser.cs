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
using MySql.Data.MySqlClient;

namespace EstoqueV1
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void TxtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cklb_Permissoes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            
        }

        private void txtbSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenhaConf_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtbSenha.Text == txtSenhaConf.Text & txtEmail.Text == txtConfEmail.Text)
            {

                string addUser = "INSERT INTO conta (login, senha, email, funcao) VALUES ('" + TxtNomeUser.Text + "', '" + txtbSenha.Text + "', '" + txtEmail.Text + "', '" + cboxFunção.Text + "')";

                MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;User id=root;database=pacstoque;password=");

                MySqlCommand cmd = new MySqlCommand(addUser, conn);
                cmd.CommandType = CommandType.Text;
                conn.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Cadastro realizado com sucesso!");
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
            else
            {
                MessageBox.Show("Os dados dos campos de confirmação (senha/e-mail) não correspondem com a primeira digitação. Tente novamente.");
            }
        }

        private void cboxFunção_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
