
namespace EstoqueV1
{
    partial class EditarExcluir
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
            this.DtgvDadosEstoque = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtEditFornecedor = new System.Windows.Forms.TextBox();
            this.txtEditEstoque = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblQtd = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtEditCat = new System.Windows.Forms.TextBox();
            this.lblIdProduto = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQtdMinima = new System.Windows.Forms.TextBox();
            this.txtQtdMaxima = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvDadosEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgvDadosEstoque
            // 
            this.DtgvDadosEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgvDadosEstoque.Location = new System.Drawing.Point(21, 94);
            this.DtgvDadosEstoque.Name = "DtgvDadosEstoque";
            this.DtgvDadosEstoque.ReadOnly = true;
            this.DtgvDadosEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgvDadosEstoque.Size = new System.Drawing.Size(443, 144);
            this.DtgvDadosEstoque.TabIndex = 25;
            this.DtgvDadosEstoque.TabStop = false;
            this.DtgvDadosEstoque.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgvDadosEstoque_CellContentClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(25, 244);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvar.Location = new System.Drawing.Point(393, 244);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(117, 41);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 23;
            this.lblCategoria.Text = "Categoria";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(21, 57);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(86, 20);
            this.txtNome.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(22, 41);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(89, 13);
            this.lblNome.TabIndex = 18;
            this.lblNome.Text = "Nome do produto";
            // 
            // btnExcluir
            // 
            this.btnExcluir.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnExcluir.Location = new System.Drawing.Point(494, 183);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "&Exlcuir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtEditFornecedor
            // 
            this.txtEditFornecedor.Location = new System.Drawing.Point(218, 57);
            this.txtEditFornecedor.Name = "txtEditFornecedor";
            this.txtEditFornecedor.Size = new System.Drawing.Size(70, 20);
            this.txtEditFornecedor.TabIndex = 2;
            this.txtEditFornecedor.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtEditEstoque
            // 
            this.txtEditEstoque.Location = new System.Drawing.Point(305, 57);
            this.txtEditEstoque.Name = "txtEditEstoque";
            this.txtEditEstoque.Size = new System.Drawing.Size(75, 20);
            this.txtEditEstoque.TabIndex = 3;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(302, 41);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(46, 13);
            this.lblValor.TabIndex = 29;
            this.lblValor.Text = "Estoque";
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Location = new System.Drawing.Point(215, 41);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(61, 13);
            this.lblQtd.TabIndex = 30;
            this.lblQtd.Text = "Fornecedor";
            // 
            // btnEditar
            // 
            this.btnEditar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEditar.Location = new System.Drawing.Point(494, 107);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtEditCat
            // 
            this.txtEditCat.Location = new System.Drawing.Point(120, 57);
            this.txtEditCat.Name = "txtEditCat";
            this.txtEditCat.Size = new System.Drawing.Size(86, 20);
            this.txtEditCat.TabIndex = 1;
            // 
            // lblIdProduto
            // 
            this.lblIdProduto.AutoSize = true;
            this.lblIdProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProduto.Location = new System.Drawing.Point(18, 9);
            this.lblIdProduto.Name = "lblIdProduto";
            this.lblIdProduto.Size = new System.Drawing.Size(179, 17);
            this.lblIdProduto.TabIndex = 31;
            this.lblIdProduto.Text = "ID do Produto selecionado:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(203, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(30, 23);
            this.textBox1.TabIndex = 32;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "(selecionar na tabela abaixo).";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(390, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Quantidade Mínima";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(491, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Quantidade Máxima";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtQtdMinima
            // 
            this.txtQtdMinima.Location = new System.Drawing.Point(393, 57);
            this.txtQtdMinima.Name = "txtQtdMinima";
            this.txtQtdMinima.Size = new System.Drawing.Size(81, 20);
            this.txtQtdMinima.TabIndex = 38;
            this.txtQtdMinima.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtdMinima_KeyPress);
            // 
            // txtQtdMaxima
            // 
            this.txtQtdMaxima.Location = new System.Drawing.Point(494, 56);
            this.txtQtdMaxima.Name = "txtQtdMaxima";
            this.txtQtdMaxima.Size = new System.Drawing.Size(86, 20);
            this.txtQtdMaxima.TabIndex = 39;
            this.txtQtdMaxima.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtdMaxima_KeyPress);
            // 
            // EditarExcluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 284);
            this.Controls.Add(this.txtQtdMaxima);
            this.Controls.Add(this.txtQtdMinima);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblIdProduto);
            this.Controls.Add(this.txtEditCat);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblQtd);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtEditEstoque);
            this.Controls.Add(this.txtEditFornecedor);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.DtgvDadosEstoque);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "EditarExcluir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edição";
            this.Load += new System.EventHandler(this.EditarExcluir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgvDadosEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgvDadosEstoque;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TextBox txtEditFornecedor;
        private System.Windows.Forms.TextBox txtEditEstoque;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtEditCat;
        private System.Windows.Forms.Label lblIdProduto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQtdMinima;
        private System.Windows.Forms.TextBox txtQtdMaxima;
    }
}