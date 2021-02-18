﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstoqueV1
{
    public partial class AddItens : Form
    {
        public AddItens()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
=======
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
                        if (txtQtd.Text != "" && txtValor.Text != "" && txtFornecedor.Text != "" && txtResponsavel.Text != "" && txtDataValidade.Text != "" && txtEntrada.Text != "")
                        {

                            updateProduto = "UPDATE produto SET quantidade =+ '" + Int32.Parse(txtQtd.Text) + "', valor = '" + Double.Parse(txtValor.Text) + "', dataEntrada = '" + txtEntrada.Text + "', dataValidade = '" + txtDataValidade.Text + "', fornecedor = '" + txtFornecedor.Text + "', responsavel = '" + txtResponsavel.Text + "' WHERE IdProduto = " + txtId.Text + "";

                            cmd = new MySqlCommand(updateProduto, conn);
                            cmd.CommandType = CommandType.Text;
                            conn.Open();
                            try
                            {
                                int j = cmd.ExecuteNonQuery();
                                if (j > 0)
                                    MessageBox.Show("Entrada do produto registrada com sucesso!");
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
                            if (txtQtd.Text != "")
                            {
                                updateProduto = "UPDATE produto SET quantidade =+ " + Int32.Parse(txtQtd.Text) + " WHERE IdProduto = " + txtId.Text + "";

                                cmd = new MySqlCommand(updateProduto, conn);
                                cmd.CommandType = CommandType.Text;
                                conn.Open();
                                try
                                {
                                    cmd.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Erro: " + ex.ToString());
                                    i++;
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
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Erro: " + ex.ToString());
                                    i++;
                                }
                                finally
                                {
                                    conn.Close();
                                }
                            }

                            if (txtEntrada.Text != "")
                            {
                                updateProduto = "UPDATE produto SET dataEntrada = '" + txtEntrada.Text + "' WHERE IdProduto = " + txtId.Text + "";

                                cmd = new MySqlCommand(updateProduto, conn);
                                cmd.CommandType = CommandType.Text;
                                conn.Open();
                                try
                                {
                                    cmd.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Erro: " + ex.ToString());
                                    i++;
                                }
                                finally
                                {
                                    conn.Close();
                                }
                            }

                            if (txtDataValidade.Text != "")
                            {
                                updateProduto = "UPDATE produto SET dataValidade = '" + txtDataValidade.Text + "' WHERE IdProduto = " + txtId.Text + "";

                                cmd = new MySqlCommand(updateProduto, conn);
                                cmd.CommandType = CommandType.Text;
                                conn.Open();
                                try
                                {
                                    cmd.ExecuteNonQuery();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Erro: " + ex.ToString());
                                    i++;
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
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Erro: " + ex.ToString());
                                    i++;
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
                            if (i >= 1)
                            {
                                MessageBox.Show("Algumas ou nenhuma informação foi alterada, tente novamente.");
                            }
                            else
                            {
                                MessageBox.Show("Entrada do produto registrada com sucesso!");
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

        private void lblValor_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DtgvEntradaProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtNome.Text = DtgvEntradaProdutos.SelectedCells[2].Value.ToString();
            this.txtId.Text = DtgvEntradaProdutos.SelectedCells[0].Value.ToString();
            this.txtValor.Text = DtgvEntradaProdutos.SelectedCells[4].Value.ToString();
            this.txtResponsavel.Text = DtgvEntradaProdutos.SelectedCells[7].Value.ToString();
            this.txtFornecedor.Text = DtgvEntradaProdutos.SelectedCells[8].Value.ToString();
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddItens_Load(object sender, EventArgs e)
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
>>>>>>> Stashed changes

        }
    }
}
