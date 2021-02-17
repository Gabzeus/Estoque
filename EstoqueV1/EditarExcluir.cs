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
    public partial class EditarExcluir : Form
    {
        public EditarExcluir()
        {
            InitializeComponent();
        }

        MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;User id=root;database=pacstoque;password=");

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;
           
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja excluir o produto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2))
            {
                string deleteProduto;
                string verificaId = textBox1.Text.ToString();
                int result;
                bool idProd = Int32.TryParse(verificaId, out result);
                if (idProd)
                {
                    deleteProduto = "DELETE FROM produto WHERE IdProduto = " + textBox1.Text + "";

                    cmd = new MySqlCommand(deleteProduto, conn);
                    cmd.CommandType = CommandType.Text;
                    conn.Open();
                    try
                    {
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                            MessageBox.Show("Produto excluido com sucesso!");
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

        private void EditarExcluir_Load(object sender, EventArgs e)
        {
            MySqlDataAdapter da;
            BindingSource bsource = new BindingSource();
            DataSet ds = null;
            string carregaProdutos;
            

            carregaProdutos = "SELECT IdProduto, nome, categoria, fornecedor, estoque FROM produto";
            da = new MySqlDataAdapter(carregaProdutos, conn);
            conn.Open();
            ds = new DataSet();
            MySqlCommandBuilder commandBuilder = new MySqlCommandBuilder(da);
            da.Fill(ds, "produto");
            bsource.DataSource = ds.Tables["produto"];
            DtgvDadosEstoque.DataSource = bsource;
            conn.Close();
        }

        private void DtgvDadosEstoque_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.textBox1.Text = DtgvDadosEstoque.SelectedCells[0].Value.ToString();

        }
        private void DtgvDadosEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.textBox1.Text = DtgvDadosEstoque.SelectedCells[0].Value.ToString();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;

            string editProduto;
            string verificaId = textBox1.Text.ToString();
            int result;
            bool idProd = Int32.TryParse(verificaId, out result);
            if (idProd)
            {
                try
                {
                    if (txtNome.Text != "" && txtEditCat.Text != "" && txtEditFornecedor.Text != "" && txtEditEstoque.Text != "")
                    {

                        editProduto = "UPDATE produto SET nome = '" + txtNome.Text + "', categoria = '" + txtEditCat.Text + "', fornecedor = '" + txtEditFornecedor.Text + "', estoque = '" + txtEditEstoque.Text + "' WHERE IdProduto = " + textBox1.Text + "";

                        cmd = new MySqlCommand(editProduto, conn);
                        cmd.CommandType = CommandType.Text;
                        conn.Open();
                        try
                        {
                            int i = cmd.ExecuteNonQuery();
                            if (i > 0)
                                MessageBox.Show("Produto editado com sucesso!");
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
                        if (txtNome.Text != "")
                        {
                            editProduto = "UPDATE produto SET nome = '" + txtNome.Text + "' WHERE IdProduto = " + textBox1.Text + "";

                            cmd = new MySqlCommand(editProduto, conn);
                            cmd.CommandType = CommandType.Text;
                            conn.Open();
                            try
                            {
                                int i = cmd.ExecuteNonQuery();
                                if (i > 0)
                                    MessageBox.Show("Produto editado com sucesso!");
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
                        else if (txtEditCat.Text != "")
                        {                           
                            editProduto = "UPDATE produto SET categoria = '" + txtEditCat.Text + "' WHERE IdProduto = " + textBox1.Text + "";

                            cmd = new MySqlCommand(editProduto, conn);
                            cmd.CommandType = CommandType.Text;
                            conn.Open();
                            try
                            {
                                int i = cmd.ExecuteNonQuery();
                                if (i > 0)
                                    MessageBox.Show("Produto editado com sucesso!");
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
                        else if (txtEditFornecedor.Text != "")
                        {
                            editProduto = "UPDATE produto SET fornecedor = '" + txtEditFornecedor.Text + "' WHERE IdProduto = " + textBox1.Text + "";

                            cmd = new MySqlCommand(editProduto, conn);
                            cmd.CommandType = CommandType.Text;
                            conn.Open();
                            try
                            {
                                int i = cmd.ExecuteNonQuery();
                                if (i > 0)
                                    MessageBox.Show("Produto editado com sucesso!");
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
                        else if (txtEditEstoque.Text != "")
                        {
                            editProduto = "UPDATE produto SET estoque = '" + txtEditEstoque.Text + "' WHERE IdProduto = " + textBox1.Text + "";

                            cmd = new MySqlCommand(editProduto, conn);
                            cmd.CommandType = CommandType.Text;
                            conn.Open();
                            try
                            {
                                int i = cmd.ExecuteNonQuery();
                                if (i > 0)
                                    
                                    MessageBox.Show("Produto editado com sucesso!");                                    
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
                catch (FormatException)
                {
                    MessageBox.Show("Id do produto inserido não é um número. Tente novamente.");
                    throw;
                }
            }           
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }        
      
    }
}
