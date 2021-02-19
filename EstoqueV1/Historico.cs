using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EstoqueV1
{
    public partial class Historico : Form
    {
        public Historico()
        {
            InitializeComponent();
        }

        MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;User id=root;database=pacstoque;password=");

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Historico_Load(object sender, EventArgs e)
        {
            MySqlDataAdapter da;
            BindingSource bsource = new BindingSource();
            DataSet ds = null;
            string carregaProdutos;


            carregaProdutos = "SELECT * FROM historico";
            da = new MySqlDataAdapter(carregaProdutos, conn);
            conn.Open();
            ds = new DataSet();
            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(da);
            da.Fill(ds, "Histórico");
            bsource.DataSource = ds.Tables["Histórico"];
            dgvDados.DataSource = bsource;
            conn.Close();
        }

        private void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
