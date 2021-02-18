
namespace EstoqueV1
{
    partial class AddItens
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
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DtgvEntradaProdutos = new System.Windows.Forms.DataGridView();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResponsavel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEntrada = new System.Windows.Forms.MaskedTextBox();
            this.txtDataValidade = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvEntradaProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(384, 114);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(91, 13);
            this.lblValor.TabIndex = 31;
            this.lblValor.Text = "Valor unitário (R$)";
            this.lblValor.Click += new System.EventHandler(this.lblValor_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(389, 130);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(49, 20);
            this.txtValor.TabIndex = 2;
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Location = new System.Drawing.Point(526, 70);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(69, 13);
            this.lblEntrada.TabIndex = 28;
            this.lblEntrada.Text = "Data entrada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(386, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Quantidade adicionada";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(389, 86);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(49, 20);
            this.txtQtd.TabIndex = 1;
            this.txtQtd.TextChanged += new System.EventHandler(this.txtQtd_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(389, 38);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(104, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(386, 22);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(89, 13);
            this.lblNome.TabIndex = 26;
            this.lblNome.Text = "Nome do produto";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(27, 316);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvar.Location = new System.Drawing.Point(324, 316);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(526, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Data validade";
            // 
            // DtgvEntradaProdutos
            // 
            this.DtgvEntradaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgvEntradaProdutos.Location = new System.Drawing.Point(12, 22);
            this.DtgvEntradaProdutos.Name = "DtgvEntradaProdutos";
            this.DtgvEntradaProdutos.ReadOnly = true;
            this.DtgvEntradaProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgvEntradaProdutos.Size = new System.Drawing.Size(366, 258);
            this.DtgvEntradaProdutos.TabIndex = 35;
            this.DtgvEntradaProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgvEntradaProdutos_CellContentClick);
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Location = new System.Drawing.Point(529, 211);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(96, 20);
            this.txtFornecedor.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(526, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Fornecedor";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(504, 38);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(28, 20);
            this.txtId.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(505, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "ID";
            // 
            // txtResponsavel
            // 
            this.txtResponsavel.Location = new System.Drawing.Point(384, 211);
            this.txtResponsavel.Name = "txtResponsavel";
            this.txtResponsavel.Size = new System.Drawing.Size(96, 20);
            this.txtResponsavel.TabIndex = 40;
            this.txtResponsavel.TextChanged += new System.EventHandler(this.txtResponsavel_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Responsável";
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(529, 87);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(96, 20);
            this.txtEntrada.TabIndex = 42;
            this.txtEntrada.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtEntrada_MaskInputRejected);
            // 
            // txtDataValidade
            // 
            this.txtDataValidade.Location = new System.Drawing.Point(529, 130);
            this.txtDataValidade.Name = "txtDataValidade";
            this.txtDataValidade.Size = new System.Drawing.Size(100, 20);
            this.txtDataValidade.TabIndex = 43;
            this.txtDataValidade.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtDataValidade_MaskInputRejected);
            // 
            // AddItens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 353);
            this.Controls.Add(this.txtDataValidade);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.txtResponsavel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DtgvEntradaProdutos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblEntrada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Name = "AddItens";
            this.Text = "Adicionar itens";
            this.Load += new System.EventHandler(this.AddItens_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgvEntradaProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DtgvEntradaProdutos;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResponsavel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtEntrada;
        private System.Windows.Forms.MaskedTextBox txtDataValidade;
    }
}