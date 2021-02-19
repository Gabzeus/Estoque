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
    public partial class NewEstoq : Form
    {
        public NewEstoq()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Curadik\OneDrive\Documents\GitHub\EstoqueV1\EstoqueV1\Db_Estoques.mdf;Integrated Security = True; Connect Timeout = 30");
        SqlCommand cmd;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewEstoq_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            string criarEstoque = $"CREATE TABLE Estoque1 ([idestoque] INT IDENTITY (0, 1) NOT NULL, [nome] VARCHAR(50) NULL DEFAULT NULL, PRIMARY KEY CLUSTERED ([idestoque] ASC)";

            cmd = new SqlCommand(criarEstoque, conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            string criarTabProduto = $"CREATE TABLE 'Produtos' ('idproduto' INT IDENTITY (0,1) NOT NULL, 'nome' VARCHAR(50) NULL DEFAULT NULL, 'quantidade' INT NULL DEFAULT NULL, 'dataEntrada' DATE NULL DEFAULT NULL, 'dataValidade' DATE NULL DEFAULT NULL, 'valor' INT NULL, 'QtdMáxima' INT NULL, 'QtdMínima' INT NULL, PRIMARY KEY CLUSTERED ('idproduto' ASC), FOREIGN KEY ('idestoque')";

            cmd = new SqlCommand(criarTabProduto, conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }    
    }
}
