
namespace EstoqueV1
{
    partial class ProdutoCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.DtgvDadosCad = new System.Windows.Forms.DataGridView();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.db_EstoquesDataSet = new EstoqueV1.Db_EstoquesDataSet();
            this.dbEstoquesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dbEstoquesDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.IdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumNomeCad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumCateg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumQtdCad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbEstoquesDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.db_EstoquesDataSet1 = new EstoqueV1.Db_EstoquesDataSet1();
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produtosTableAdapter = new EstoqueV1.Db_EstoquesDataSet1TableAdapters.ProdutosTableAdapter();
            this.idProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEntradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataValidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsávelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdMinimaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdMaximaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvDadosCad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_EstoquesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEstoquesDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEstoquesDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEstoquesDataSetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_EstoquesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(547, 73);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(104, 20);
            this.txtNome.TabIndex = 0;
            // 
            // btnSalvar
            // 
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvar.Location = new System.Drawing.Point(525, 224);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(632, 224);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(544, 57);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(93, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome do Produto:";
            // 
            // DtgvDadosCad
            // 
            this.DtgvDadosCad.AllowUserToAddRows = false;
            this.DtgvDadosCad.AllowUserToDeleteRows = false;
            this.DtgvDadosCad.AllowUserToOrderColumns = true;
            this.DtgvDadosCad.AutoGenerateColumns = false;
            this.DtgvDadosCad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgvDadosCad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProduto,
            this.ColumNomeCad,
            this.ColumCateg,
            this.ColumQtdCad,
            this.idProdutoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.fornecedorDataGridViewTextBoxColumn,
            this.estoqueDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.dataEntradaDataGridViewTextBoxColumn,
            this.dataValidadeDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.responsávelDataGridViewTextBoxColumn,
            this.qtdMinimaDataGridViewTextBoxColumn,
            this.qtdMaximaDataGridViewTextBoxColumn});
            this.DtgvDadosCad.DataSource = this.produtosBindingSource;
            this.DtgvDadosCad.Location = new System.Drawing.Point(27, 57);
            this.DtgvDadosCad.Name = "DtgvDadosCad";
            this.DtgvDadosCad.ReadOnly = true;
            this.DtgvDadosCad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DtgvDadosCad.Size = new System.Drawing.Size(444, 241);
            this.DtgvDadosCad.TabIndex = 7;
            this.DtgvDadosCad.TabStop = false;
            this.DtgvDadosCad.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgvDadosCad_CellContentClick);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(544, 108);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(104, 13);
            this.lblCategoria.TabIndex = 8;
            this.lblCategoria.Text = "Categoria (opcional):";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(547, 124);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(104, 20);
            this.txtCategoria.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(544, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Estoque que pertence (opcional):";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(547, 176);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(104, 20);
            this.txtEstoque.TabIndex = 9;
            // 
            // db_EstoquesDataSet
            // 
            this.db_EstoquesDataSet.DataSetName = "Db_EstoquesDataSet";
            this.db_EstoquesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbEstoquesDataSetBindingSource
            // 
            this.dbEstoquesDataSetBindingSource.DataSource = this.db_EstoquesDataSet;
            this.dbEstoquesDataSetBindingSource.Position = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Produtos Cadastrados";
            // 
            // dbEstoquesDataSetBindingSource1
            // 
            this.dbEstoquesDataSetBindingSource1.DataSource = this.db_EstoquesDataSet;
            this.dbEstoquesDataSetBindingSource1.Position = 0;
            // 
            // IdProduto
            // 
            this.IdProduto.Frozen = true;
            this.IdProduto.HeaderText = "IdEstoque";
            this.IdProduto.Name = "IdProduto";
            this.IdProduto.ReadOnly = true;
            // 
            // ColumNomeCad
            // 
            this.ColumNomeCad.Frozen = true;
            this.ColumNomeCad.HeaderText = "Nome";
            this.ColumNomeCad.Name = "ColumNomeCad";
            this.ColumNomeCad.ReadOnly = true;
            // 
            // ColumCateg
            // 
            this.ColumCateg.HeaderText = "Categoria";
            this.ColumCateg.Name = "ColumCateg";
            this.ColumCateg.ReadOnly = true;
            // 
            // ColumQtdCad
            // 
            this.ColumQtdCad.HeaderText = "Estoque";
            this.ColumQtdCad.Name = "ColumQtdCad";
            this.ColumQtdCad.ReadOnly = true;
            // 
            // dbEstoquesDataSetBindingSource2
            // 
            this.dbEstoquesDataSetBindingSource2.DataSource = this.db_EstoquesDataSet;
            this.dbEstoquesDataSetBindingSource2.Position = 0;
            // 
            // db_EstoquesDataSet1
            // 
            this.db_EstoquesDataSet1.DataSetName = "Db_EstoquesDataSet1";
            this.db_EstoquesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "Produtos";
            this.produtosBindingSource.DataSource = this.db_EstoquesDataSet1;
            // 
            // produtosTableAdapter
            // 
            this.produtosTableAdapter.ClearBeforeFill = true;
            // 
            // idProdutoDataGridViewTextBoxColumn
            // 
            this.idProdutoDataGridViewTextBoxColumn.DataPropertyName = "IdProduto";
            this.idProdutoDataGridViewTextBoxColumn.HeaderText = "IdProduto";
            this.idProdutoDataGridViewTextBoxColumn.Name = "idProdutoDataGridViewTextBoxColumn";
            this.idProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            this.categoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fornecedorDataGridViewTextBoxColumn
            // 
            this.fornecedorDataGridViewTextBoxColumn.DataPropertyName = "Fornecedor";
            this.fornecedorDataGridViewTextBoxColumn.HeaderText = "Fornecedor";
            this.fornecedorDataGridViewTextBoxColumn.Name = "fornecedorDataGridViewTextBoxColumn";
            this.fornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estoqueDataGridViewTextBoxColumn
            // 
            this.estoqueDataGridViewTextBoxColumn.DataPropertyName = "Estoque";
            this.estoqueDataGridViewTextBoxColumn.HeaderText = "Estoque";
            this.estoqueDataGridViewTextBoxColumn.Name = "estoqueDataGridViewTextBoxColumn";
            this.estoqueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataEntradaDataGridViewTextBoxColumn
            // 
            this.dataEntradaDataGridViewTextBoxColumn.DataPropertyName = "DataEntrada";
            this.dataEntradaDataGridViewTextBoxColumn.HeaderText = "DataEntrada";
            this.dataEntradaDataGridViewTextBoxColumn.Name = "dataEntradaDataGridViewTextBoxColumn";
            this.dataEntradaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataValidadeDataGridViewTextBoxColumn
            // 
            this.dataValidadeDataGridViewTextBoxColumn.DataPropertyName = "DataValidade";
            this.dataValidadeDataGridViewTextBoxColumn.HeaderText = "DataValidade";
            this.dataValidadeDataGridViewTextBoxColumn.Name = "dataValidadeDataGridViewTextBoxColumn";
            this.dataValidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // responsávelDataGridViewTextBoxColumn
            // 
            this.responsávelDataGridViewTextBoxColumn.DataPropertyName = "Responsável";
            this.responsávelDataGridViewTextBoxColumn.HeaderText = "Responsável";
            this.responsávelDataGridViewTextBoxColumn.Name = "responsávelDataGridViewTextBoxColumn";
            this.responsávelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qtdMinimaDataGridViewTextBoxColumn
            // 
            this.qtdMinimaDataGridViewTextBoxColumn.DataPropertyName = "QtdMinima";
            this.qtdMinimaDataGridViewTextBoxColumn.HeaderText = "QtdMinima";
            this.qtdMinimaDataGridViewTextBoxColumn.Name = "qtdMinimaDataGridViewTextBoxColumn";
            this.qtdMinimaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qtdMaximaDataGridViewTextBoxColumn
            // 
            this.qtdMaximaDataGridViewTextBoxColumn.DataPropertyName = "QtdMaxima";
            this.qtdMaximaDataGridViewTextBoxColumn.HeaderText = "QtdMaxima";
            this.qtdMaximaDataGridViewTextBoxColumn.Name = "qtdMaximaDataGridViewTextBoxColumn";
            this.qtdMaximaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ProdutoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 358);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.DtgvDadosCad);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "ProdutoCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.CatCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgvDadosCad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_EstoquesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEstoquesDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEstoquesDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEstoquesDataSetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_EstoquesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DataGridView DtgvDadosCad;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.BindingSource dbEstoquesDataSetBindingSource;
        private Db_EstoquesDataSet db_EstoquesDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource dbEstoquesDataSetBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumNomeCad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumCateg;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumQtdCad;
        private System.Windows.Forms.BindingSource dbEstoquesDataSetBindingSource2;
        private Db_EstoquesDataSet1 db_EstoquesDataSet1;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private Db_EstoquesDataSet1TableAdapters.ProdutosTableAdapter produtosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEntradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataValidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsávelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdMinimaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdMaximaDataGridViewTextBoxColumn;
    }
}