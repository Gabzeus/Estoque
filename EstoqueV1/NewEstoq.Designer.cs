
namespace EstoqueV1
{
    partial class NewEstoq
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.DtgvDadosEstoque = new System.Windows.Forms.DataGridView();
            this.ColumIdEstoq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumTipoEstoq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumNomeEstoq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvDadosEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Categoria do estoque";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(252, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(96, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(84, 198);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvar.Location = new System.Drawing.Point(241, 198);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(15, 24);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 13;
            this.lblId.Text = "Id";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(71, 40);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(172, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(68, 24);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(91, 13);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "Nome do estoque";
            // 
            // DtgvDadosEstoque
            // 
            this.DtgvDadosEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgvDadosEstoque.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumIdEstoq,
            this.ColumTipoEstoq,
            this.ColumNomeEstoq});
            this.DtgvDadosEstoque.Location = new System.Drawing.Point(18, 66);
            this.DtgvDadosEstoque.Name = "DtgvDadosEstoque";
            this.DtgvDadosEstoque.Size = new System.Drawing.Size(330, 113);
            this.DtgvDadosEstoque.TabIndex = 16;
            this.DtgvDadosEstoque.TabStop = false;
            // 
            // ColumIdEstoq
            // 
            this.ColumIdEstoq.HeaderText = "Id";
            this.ColumIdEstoq.Name = "ColumIdEstoq";
            // 
            // ColumTipoEstoq
            // 
            this.ColumTipoEstoq.HeaderText = "Tipo de estoque";
            this.ColumTipoEstoq.Name = "ColumTipoEstoq";
            // 
            // ColumNomeEstoq
            // 
            this.ColumNomeEstoq.HeaderText = "Nome do estoque";
            this.ColumNomeEstoq.Name = "ColumNomeEstoq";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(12, 40);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(29, 20);
            this.txtId.TabIndex = 0;
            // 
            // NewEstoq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 248);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.DtgvDadosEstoque);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "NewEstoq";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Novo estoque";
            this.Load += new System.EventHandler(this.NewEstoq_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgvDadosEstoque)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DataGridView DtgvDadosEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumIdEstoq;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumTipoEstoq;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumNomeEstoq;
        private System.Windows.Forms.TextBox txtId;
    }
}