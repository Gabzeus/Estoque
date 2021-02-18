
namespace EstoqueV1
{
    partial class ControladorSaida
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtResponsavel2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFornecedor2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DtgvEntradaProdutos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.lblEntrada = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQtdRemovida = new System.Windows.Forms.TextBox();
            this.txtNome2 = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
<<<<<<< Updated upstream
            this.lblSaida = new System.Windows.Forms.Label();
            this.txtSaida = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.viewSaida = new System.Windows.Forms.ListView();
=======
            this.mtxtEntrada = new System.Windows.Forms.MaskedTextBox();
            this.mtxtValidade = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvEntradaProdutos)).BeginInit();
>>>>>>> Stashed changes
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(43, 321);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvar.Location = new System.Drawing.Point(340, 321);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtResponsavel2
            // 
            this.txtResponsavel2.Location = new System.Drawing.Point(384, 213);
            this.txtResponsavel2.Name = "txtResponsavel2";
            this.txtResponsavel2.Size = new System.Drawing.Size(96, 20);
            this.txtResponsavel2.TabIndex = 57;
            this.txtResponsavel2.TextChanged += new System.EventHandler(this.txtResponsavel2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Responsável";
            // 
            // txtId2
            // 
            this.txtId2.Location = new System.Drawing.Point(504, 40);
            this.txtId2.Name = "txtId2";
            this.txtId2.ReadOnly = true;
            this.txtId2.Size = new System.Drawing.Size(28, 20);
            this.txtId2.TabIndex = 55;
            this.txtId2.TextChanged += new System.EventHandler(this.txtId2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(505, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "ID";
            // 
            // txtFornecedor2
            // 
            this.txtFornecedor2.Location = new System.Drawing.Point(529, 213);
            this.txtFornecedor2.Name = "txtFornecedor2";
            this.txtFornecedor2.Size = new System.Drawing.Size(96, 20);
            this.txtFornecedor2.TabIndex = 53;
            this.txtFornecedor2.TextChanged += new System.EventHandler(this.txtFornecedor2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(526, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Fornecedor";
            // 
            // DtgvEntradaProdutos
            // 
            this.DtgvEntradaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgvEntradaProdutos.Location = new System.Drawing.Point(12, 24);
            this.DtgvEntradaProdutos.Name = "DtgvEntradaProdutos";
            this.DtgvEntradaProdutos.ReadOnly = true;
            this.DtgvEntradaProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgvEntradaProdutos.Size = new System.Drawing.Size(366, 258);
            this.DtgvEntradaProdutos.TabIndex = 52;
            this.DtgvEntradaProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgvEntradaProdutos_CellContentClick);
            // 
<<<<<<< Updated upstream
            // txtSaida
            // 
            this.txtSaida.Location = new System.Drawing.Point(289, 40);
            this.txtSaida.Name = "txtSaida";
            this.txtSaida.Size = new System.Drawing.Size(96, 20);
            this.txtSaida.TabIndex = 3;
            // 
            // txtValor
=======
            // label2
>>>>>>> Stashed changes
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(526, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Data validade";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(384, 116);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(91, 13);
            this.lblValor.TabIndex = 50;
            this.lblValor.Text = "Valor unitário (R$)";
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(389, 132);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(49, 20);
            this.txtValor2.TabIndex = 46;
            this.txtValor2.TextChanged += new System.EventHandler(this.txtValor2_TextChanged);
            // 
            // lblEntrada
            // 
            this.lblEntrada.AutoSize = true;
            this.lblEntrada.Location = new System.Drawing.Point(526, 72);
            this.lblEntrada.Name = "lblEntrada";
            this.lblEntrada.Size = new System.Drawing.Size(69, 13);
            this.lblEntrada.TabIndex = 49;
            this.lblEntrada.Text = "Data entrada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(386, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Quantidade removida";
            // 
            // txtQtdRemovida
            // 
            this.txtQtdRemovida.Location = new System.Drawing.Point(389, 88);
            this.txtQtdRemovida.Name = "txtQtdRemovida";
            this.txtQtdRemovida.Size = new System.Drawing.Size(49, 20);
            this.txtQtdRemovida.TabIndex = 45;
            this.txtQtdRemovida.TextChanged += new System.EventHandler(this.txtQtdRemovida_TextChanged);
            // 
            // txtNome2
            // 
            this.txtNome2.Location = new System.Drawing.Point(389, 40);
            this.txtNome2.Name = "txtNome2";
            this.txtNome2.ReadOnly = true;
            this.txtNome2.Size = new System.Drawing.Size(104, 20);
            this.txtNome2.TabIndex = 44;
            this.txtNome2.TextChanged += new System.EventHandler(this.txtNome2_TextChanged);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(386, 24);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(89, 13);
            this.lblNome.TabIndex = 47;
            this.lblNome.Text = "Nome do produto";
            // 
<<<<<<< Updated upstream
=======
            // mtxtEntrada
            // 
            this.mtxtEntrada.Location = new System.Drawing.Point(529, 88);
            this.mtxtEntrada.Name = "mtxtEntrada";
            this.mtxtEntrada.Size = new System.Drawing.Size(100, 20);
            this.mtxtEntrada.TabIndex = 59;
            // 
            // mtxtValidade
            // 
            this.mtxtValidade.Location = new System.Drawing.Point(529, 132);
            this.mtxtValidade.Name = "mtxtValidade";
            this.mtxtValidade.Size = new System.Drawing.Size(100, 20);
            this.mtxtValidade.TabIndex = 60;
            // 
>>>>>>> Stashed changes
            // ControladorSaida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< Updated upstream
            this.ClientSize = new System.Drawing.Size(428, 352);
            this.Controls.Add(this.viewSaida);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtSaida);
            this.Controls.Add(this.lblSaida);
=======
            this.ClientSize = new System.Drawing.Size(642, 352);
            this.Controls.Add(this.mtxtValidade);
            this.Controls.Add(this.mtxtEntrada);
            this.Controls.Add(this.txtResponsavel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtId2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFornecedor2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DtgvEntradaProdutos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.lblEntrada);
>>>>>>> Stashed changes
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQtdRemovida);
            this.Controls.Add(this.txtNome2);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Name = "ControladorSaida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Saida de itens";
<<<<<<< Updated upstream
=======
            this.Load += new System.EventHandler(this.ControladorSaida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgvEntradaProdutos)).EndInit();
>>>>>>> Stashed changes
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtResponsavel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtId2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFornecedor2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DtgvEntradaProdutos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQtdRemovida;
        private System.Windows.Forms.TextBox txtNome2;
        private System.Windows.Forms.Label lblNome;
<<<<<<< Updated upstream
        private System.Windows.Forms.Label lblSaida;
        private System.Windows.Forms.TextBox txtSaida;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.ListView viewSaida;
=======
        private System.Windows.Forms.MaskedTextBox mtxtEntrada;
        private System.Windows.Forms.MaskedTextBox mtxtValidade;
>>>>>>> Stashed changes
    }
}