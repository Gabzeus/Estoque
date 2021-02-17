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
    public partial class ProdutoCadastro : Form
    {
        public ProdutoCadastro()
        {
            InitializeComponent();
        }

      
     

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CatCadastro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_EstoquesDataSet1.Produtos'. Você pode movê-la ou removê-la conforme necessário.
            //this.produtosTableAdapter.Fill(this.db_EstoquesDataSet1.Produtos);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DtgvDadosCad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

            this.produtosTableAdapter.Fill(this.db_EstoquesDataSet1.Produtos);
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string addProduto = "INSERT INTO produto (nome, categoria, estoque) VALUES ('" + txtNome.Text + "', '" + txtCategoria.Text + "', '" + txtEstoque.Text + "')";

            MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;User id=root;database=pacstoque;password=");

            MySqlCommand cmd = new MySqlCommand(addProduto, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Produto cadastrado com sucesso!");
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
