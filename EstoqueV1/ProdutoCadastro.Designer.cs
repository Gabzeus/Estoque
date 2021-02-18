
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
            this.produtosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.dbEstoquesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dbEstoquesDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbEstoquesDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DtgvDadosCad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEstoquesDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEstoquesDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEstoquesDataSetBindingSource2)).BeginInit();
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
            this.btnSalvar.Location = new System.Drawing.Point(522, 275);
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
            this.btnCancelar.Location = new System.Drawing.Point(633, 275);
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
            this.DtgvDadosCad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgvDadosCad.Location = new System.Drawing.Point(27, 57);
            this.DtgvDadosCad.Name = "DtgvDadosCad";
            this.DtgvDadosCad.ReadOnly = true;
            this.DtgvDadosCad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DtgvDadosCad.Size = new System.Drawing.Size(444, 241);
            this.DtgvDadosCad.TabIndex = 7;
            this.DtgvDadosCad.TabStop = false;
            this.DtgvDadosCad.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgvDadosCad_CellContentClick);
            // 
            // produtosBindingSource
            // 
            this.produtosBindingSource.DataMember = "Produtos";
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
            ((System.ComponentModel.ISupportInitialize)(this.produtosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEstoquesDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEstoquesDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEstoquesDataSetBindingSource2)).EndInit();
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
        private System.Windows.Forms.BindingSource dbEstoquesDataSetBindingSource2;
        private Db_EstoquesDataSet1 db_EstoquesDataSet1;
        private System.Windows.Forms.BindingSource produtosBindingSource;
        private Db_EstoquesDataSet1TableAdapters.ProdutosTableAdapter produtosTableAdapter;
    }
}