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
    public partial class ControladorSaida : Form
    {
        public ControladorSaida()
        {
            InitializeComponent();
        }

        MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;User id=root;database=pacstoque;password=");

        private void ControladorSaida_Load(object sender, EventArgs e)
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

        private void txtSaida_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtNome2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQtdRemovida_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void txtValor2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtResponsavel2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEntrada2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtDataValidade2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtFornecedor2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            string id = txtId2.Text.ToString();

            if (String.IsNullOrEmpty(id) == false)
            {



                if (DialogResult.Yes == MessageBox.Show("Confirmar alterações?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2))
                {
                    string updateProduto;
                    string verificaId = txtId2.Text.ToString();
                    int result;
                    bool idProd = Int32.TryParse(verificaId, out result);
                    if (idProd)
                    {
                        try
                        {
                            int i = 0;
                            int erro = 0;
                            if (txtQtdRemovida.Text != "" && txtValor2.Text != "" && txtFornecedor2.Text != "" && txtResponsavel2.Text != "")
                            {

                                updateProduto = "UPDATE produto SET quantidade = quantidade - '" + txtQtdRemovida.Text + "', valor = '" + txtValor2.Text + "', fornecedor = '" + txtFornecedor2.Text + "', responsavel = '" + txtResponsavel2.Text + "' WHERE IdProduto = " + txtId2.Text + "";

                                cmd = new MySqlCommand(updateProduto, conn);
                                cmd.CommandType = CommandType.Text;
                                conn.Open();
                                try
                                {
                                    int j = cmd.ExecuteNonQuery();
                                    if (j > 0)
                                        MessageBox.Show("Saída do produto registrada com sucesso!");
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
                                if (txtQtdRemovida.Text != "")
                                {
                                    updateProduto = "UPDATE produto SET quantidade = quantidade - " + txtQtdRemovida.Text + " WHERE IdProduto = " + txtId2.Text + "";

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

                                if (txtValor2.Text != "")
                                {
                                    updateProduto = "UPDATE produto SET valor = '" + txtValor2.Text + "' WHERE IdProduto = " + txtId2.Text + "";

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

                                if (txtResponsavel2.Text != "")
                                {
                                    updateProduto = "UPDATE produto SET responsavel = '" + txtResponsavel2.Text + "' WHERE IdProduto = " + txtId2.Text + "";

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

                                if (txtFornecedor2.Text != "")
                                {
                                    updateProduto = "UPDATE produto SET fornecedor = '" + txtFornecedor2.Text + "' WHERE IdProduto = " + txtId2.Text + "";

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
                            }
                            if (erro >= 1)
                            {
                                MessageBox.Show("Algumas ou nenhuma informação foi alterada, tente novamente.");
                            }
                            else
                            {
                                MessageBox.Show("Saída do produto registrada com sucesso!");
                                i++;
                            }
                            if (i > 0)
                            {
                                if (DialogResult.Yes == MessageBox.Show("Registrar saída do produto?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2))
                                {
                                    DateTime dataAtual = Convert.ToDateTime(DateTime.Now);
                                    string dataFormat = dataAtual.Date.ToString("yyyy-MM-dd hh:mm:ss");

                                    string insertHist = "INSERT INTO historico (tipoOperacao, produto, data, responsavel, qtdMovimentada) VALUES ('Saída', '" + txtNome2.Text + "', '" + dataFormat + "', '" + txtResponsavel2.Text + "', '" + txtQtdRemovida.Text + "')";

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
                            if (i > 0)
                            {
                                string minima;

                                minima = "SELECT quantidade, qtdMinimo FROM produto";

                                List<NotificaQtd> minimo = new List<NotificaQtd>();
                                cmd = new MySqlCommand(minima, conn);

                                conn.Open();

                                MySqlDataReader dr;
                                dr = cmd.ExecuteReader();

                                while (dr.Read())
                                {
                                    if (dr["quantidade"] != DBNull.Value || dr["qtdMinimo"] != DBNull.Value)
                                    {
                                        int qtdAtual = Convert.ToInt32(dr["quantidade"]);
                                        int qtdMinima = Convert.ToInt32(dr["qtdMinimo"]);
                                        NotificaQtd verificaQtd = new NotificaQtd(qtdAtual, qtdMinima);

                                        minimo.Add(verificaQtd);
                                    }
                                }

                                dr.Close();
                                conn.Close();
                                

                                foreach (var item in minimo)
                                {
                                    if (item.Quantidade <= item.QtdMinimo)
                                    {
                                        MessageBox.Show("Um ou mais produtos atingiram a quantidade mínima estabelecida");
                                    }

                                }
                            }
                        }
                        catch (FormatException)
                        {
                            MessageBox.Show("Id do produto inserido não é um número. Tente novamente.");
                            throw;
                        }

                    }
                }
            }
            else if(String.IsNullOrEmpty(id))
            {
                MessageBox.Show("Nenhum Id do produto foi especificado. Preencha a caixa de texto correspondente");
            }
        }

        private void DtgvEntradaProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtNome2.Text = DtgvEntradaProdutos.SelectedCells[2].Value.ToString();
            this.txtId2.Text = DtgvEntradaProdutos.SelectedCells[0].Value.ToString();
            this.txtValor2.Text = DtgvEntradaProdutos.SelectedCells[4].Value.ToString();
            this.txtResponsavel2.Text = DtgvEntradaProdutos.SelectedCells[7].Value.ToString();
            this.txtFornecedor2.Text = DtgvEntradaProdutos.SelectedCells[8].Value.ToString();
        }
    }
}
