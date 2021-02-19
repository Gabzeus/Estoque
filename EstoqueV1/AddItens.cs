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
    public partial class AddItens : Form
    {
        public AddItens()
        {
            InitializeComponent();         
        }

        MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;User id=root;database=pacstoque;password=");

        private void AddItens_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            
        }

        private void lblValor_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }     

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtQtd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtResponsavel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEntrada_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }

      

        private void txtDataValidade_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void AddItens_Load_1(object sender, EventArgs e)
        {
            MySqlDataAdapter da;
            BindingSource bsource = new BindingSource();
            DataSet ds = null;
            string carregaProdutos;


            carregaProdutos = "SELECT IdProduto, categoria, nome, quantidade, valor, dataEntrada, dataValidade, responsavel, fornecedor, estoque FROM produto";
            da = new MySqlDataAdapter(carregaProdutos, conn);
            conn.Open();
            ds = new DataSet();
            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(da);
            da.Fill(ds, "Produtos");
            bsource.DataSource = ds.Tables["Produtos"];
            DtgvEntradaProdutos.DataSource = bsource;
            conn.Close();
        }

        private void DtgvEntradaProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtNome.Text = DtgvEntradaProdutos.SelectedCells[2].Value.ToString();
            this.txtId.Text = DtgvEntradaProdutos.SelectedCells[0].Value.ToString();
            this.txtValor.Text = DtgvEntradaProdutos.SelectedCells[4].Value.ToString();
            this.txtResponsavel.Text = DtgvEntradaProdutos.SelectedCells[7].Value.ToString();
            this.txtFornecedor.Text = DtgvEntradaProdutos.SelectedCells[8].Value.ToString();
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            MySqlCommand cmd;

            if (DialogResult.Yes == MessageBox.Show("Confirmar alterações?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2))
            {
               
                string updateProduto;
                string verificaId = txtId.Text.ToString();
                int result;
                bool idProd = Int32.TryParse(verificaId, out result);
                if (idProd)
                {
                    try
                    {
                        int i = 0;
                        int erro = 0;

                        string textoDataEntrada = mtxtEntrada.Text;
                        string textoDataValidade= mtxtValidade.Text;
                       
                        if (txtQtd.Text != "" && txtValor.Text != "" && txtFornecedor.Text != "" && txtResponsavel.Text != "" && textoDataEntrada != "  /  /" && textoDataValidade != "  /  /")
                        {
                            DateTime dataEnt = Convert.ToDateTime(mtxtEntrada.Text);
                            DateTime dataVal = Convert.ToDateTime(mtxtValidade.Text);
                            string dataEntFormat = dataEnt.Date.ToString("yyyy-MM-dd");
                            string dataValFormat = dataVal.Date.ToString("yyyy-MM-dd");

                            updateProduto = "UPDATE produto SET quantidade = quantidade + " + txtQtd.Text + ", valor = '" + Double.Parse(txtValor.Text) + "', dataEntrada = '" + dataEntFormat + "', dataValidade = '" + dataValFormat + "', fornecedor = '" + txtFornecedor.Text + "', responsavel = '" + txtResponsavel.Text + "' WHERE IdProduto = " + txtId.Text + "";

                            cmd = new MySqlCommand(updateProduto, conn);
                            cmd.CommandType = CommandType.Text;
                            conn.Open();
                            try
                            {
                                int j = cmd.ExecuteNonQuery();
                                if (j > 0)
                                    MessageBox.Show("Entrada do produto registrada com sucesso!");
                                i++;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Erro: " + ex.ToString());
                                erro++;
                            }
                            finally
                            {
                                conn.Close();
                            }
                        }
                        else
                        {
                            if (txtQtd.Text != "")
                            {
                                updateProduto = "UPDATE produto SET quantidade = quantidade + " + txtQtd.Text + " WHERE IdProduto = " + txtId.Text + "";

                                cmd = new MySqlCommand(updateProduto, conn);
                                cmd.CommandType = CommandType.Text;
                                conn.Open();
                                try
                                {
                                    cmd.ExecuteNonQuery();
                                    i++;
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Erro: " + ex.ToString());
                                    erro++;
                                }
                                finally
                                {
                                    conn.Close();
                                }
                            }

                            if (txtValor.Text != "")
                            {
                                updateProduto = "UPDATE produto SET valor = '" + txtValor.Text + "' WHERE IdProduto = " + txtId.Text + "";

                                cmd = new MySqlCommand(updateProduto, conn);
                                cmd.CommandType = CommandType.Text;
                                conn.Open();
                                try
                                {
                                    cmd.ExecuteNonQuery();
                                    i++;
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Erro: " + ex.ToString());
                                    erro++;
                                }
                                finally
                                {
                                    conn.Close();
                                }
                            }

                            if (textoDataEntrada != "  /  /" || mtxtEntrada.Text != "  /  /")
                            {

                                DateTime dataEnt = Convert.ToDateTime(mtxtEntrada.Text);
                                string dataFormat = dataEnt.Date.ToString("yyyy-MM-dd");



                                updateProduto = "UPDATE produto SET dataEntrada = '" + dataFormat + "' WHERE IdProduto = " + txtId.Text + "";

                                cmd = new MySqlCommand(updateProduto, conn);
                                cmd.CommandType = CommandType.Text;
                                conn.Open();
                                try
                                {
                                    cmd.ExecuteNonQuery();
                                    i++;
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Erro: " + ex.ToString());
                                    erro++;
                                }
                                finally
                                {
                                    conn.Close();
                                }
                            }

                            if (textoDataValidade != "  /  /" || mtxtValidade.Text != "  /  /")
                            {

                                DateTime dataEnt = Convert.ToDateTime(mtxtValidade.Text);
                                string dataFormat = dataEnt.Date.ToString("yyyy-MM-dd");

                                updateProduto = "UPDATE produto SET dataValidade = '" + dataFormat + "' WHERE IdProduto = " + txtId.Text + "";

                                cmd = new MySqlCommand(updateProduto, conn);
                                cmd.CommandType = CommandType.Text;
                                conn.Open();
                                try
                                {
                                    cmd.ExecuteNonQuery();
                                    i++;
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Erro: " + ex.ToString());
                                    erro++;
                                }
                                finally
                                {
                                    conn.Close();
                                }
                            }

                            if (txtResponsavel.Text != "")
                            {
                                updateProduto = "UPDATE produto SET responsavel = '" + txtResponsavel.Text + "' WHERE IdProduto = " + txtId.Text + "";

                                cmd = new MySqlCommand(updateProduto, conn);
                                cmd.CommandType = CommandType.Text;
                                conn.Open();
                                try
                                {
                                    cmd.ExecuteNonQuery();
                                    i++;
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Erro: " + ex.ToString());
                                    erro++;
                                }
                                finally
                                {
                                    conn.Close();
                                }
                            }

                            if (txtFornecedor.Text != "")
                            {
                                updateProduto = "UPDATE produto SET fornecedor = '" + txtFornecedor.Text + "' WHERE IdProduto = " + txtId.Text + "";

                                cmd = new MySqlCommand(updateProduto, conn);
                                cmd.CommandType = CommandType.Text;
                                conn.Open();
                                try
                                {
                                    cmd.ExecuteNonQuery();
                                    i++;
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Erro: " + ex.ToString());
                                    erro++;
                                }
                                finally
                                {
                                    conn.Close();
                                }
                            }
                            if (erro >= 1)
                            {
                                MessageBox.Show("Algumas ou nenhuma informação foi alterada, tente novamente.");
                            }
                            else
                            {
                                MessageBox.Show("Entrada do produto registrada com sucesso!");
                                i++;
                            }
                        }
                        if (i > 0)
                        {
                            if (DialogResult.Yes == MessageBox.Show("Registrar entrada do produto?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2))
                            {
                                DateTime dataAtual = Convert.ToDateTime(DateTime.Now);
                                string dataFormat = dataAtual.Date.ToString("yyyy-MM-dd hh:mm:ss");

                                string insertHist = "INSERT INTO historico (tipoOperacao, produto, data, responsavel, qtdMovimentada) VALUES ('Entrada', '" + txtNome.Text + "', '" + dataFormat + "', '" + txtResponsavel.Text + "', '" + txtQtd.Text + "')";

                                cmd = new MySqlCommand(insertHist, conn);
                                cmd.CommandType = CommandType.Text;
                                conn.Open();
                                try
                                {
                                    cmd.ExecuteNonQuery();
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
                    catch (FormatException form)
                    {
                        MessageBox.Show("O formato de algum dado inserido não foi aceito em seu campo. Tente novamente.\n" + form.ToString());
                    }


                }
            }
        }

        private void txtQtd_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
