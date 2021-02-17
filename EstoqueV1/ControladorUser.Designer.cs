
namespace EstoqueV1
{
    partial class ControladorUser
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
            this.txtEditSenha = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvarSenhar = new System.Windows.Forms.Button();
            this.txtEditEmail = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtConfEditEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConfEditSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalvarEmail = new System.Windows.Forms.Button();
            this.lblAlterarDados = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Alterar senha:";
            // 
            // txtEditSenha
            // 
            this.txtEditSenha.Location = new System.Drawing.Point(118, 78);
            this.txtEditSenha.Name = "txtEditSenha";
            this.txtEditSenha.PasswordChar = '*';
            this.txtEditSenha.Size = new System.Drawing.Size(172, 20);
            this.txtEditSenha.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(669, 153);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvarSenhar
            // 
            this.btnSalvarSenhar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvarSenhar.Location = new System.Drawing.Point(296, 92);
            this.btnSalvarSenhar.Name = "btnSalvarSenhar";
            this.btnSalvarSenhar.Size = new System.Drawing.Size(91, 23);
            this.btnSalvarSenhar.TabIndex = 2;
            this.btnSalvarSenhar.Text = "&Alterar senha";
            this.btnSalvarSenhar.UseVisualStyleBackColor = true;
            this.btnSalvarSenhar.Click += new System.EventHandler(this.btnSalvarSenha_Click);
            // 
            // txtEditEmail
            // 
            this.txtEditEmail.Location = new System.Drawing.Point(486, 74);
            this.txtEditEmail.Name = "txtEditEmail";
            this.txtEditEmail.Size = new System.Drawing.Size(172, 20);
            this.txtEditEmail.TabIndex = 3;
            this.txtEditEmail.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(410, 78);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(70, 13);
            this.lblNome.TabIndex = 25;
            this.lblNome.Text = "Alterar e-mail:";
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // txtConfEditEmail
            // 
            this.txtConfEditEmail.Location = new System.Drawing.Point(486, 110);
            this.txtConfEditEmail.Name = "txtConfEditEmail";
            this.txtConfEditEmail.Size = new System.Drawing.Size(172, 20);
            this.txtConfEditEmail.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Confirmar e-mail:";
            // 
            // txtConfEditSenha
            // 
            this.txtConfEditSenha.Location = new System.Drawing.Point(118, 114);
            this.txtConfEditSenha.Name = "txtConfEditSenha";
            this.txtConfEditSenha.PasswordChar = '*';
            this.txtConfEditSenha.Size = new System.Drawing.Size(172, 20);
            this.txtConfEditSenha.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Confirmar senha:";
            // 
            // btnSalvarEmail
            // 
            this.btnSalvarEmail.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvarEmail.Location = new System.Drawing.Point(669, 92);
            this.btnSalvarEmail.Name = "btnSalvarEmail";
            this.btnSalvarEmail.Size = new System.Drawing.Size(91, 23);
            this.btnSalvarEmail.TabIndex = 5;
            this.btnSalvarEmail.Text = "&Alterar e-mail";
            this.btnSalvarEmail.UseVisualStyleBackColor = true;
            this.btnSalvarEmail.Click += new System.EventHandler(this.btnSalvarEmail_Click);
            // 
            // lblAlterarDados
            // 
            this.lblAlterarDados.AutoSize = true;
            this.lblAlterarDados.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlterarDados.Location = new System.Drawing.Point(258, 9);
            this.lblAlterarDados.Name = "lblAlterarDados";
            this.lblAlterarDados.Size = new System.Drawing.Size(189, 22);
            this.lblAlterarDados.TabIndex = 36;
            this.lblAlterarDados.Text = "Alteração de dados";
            // 
            // ControladorUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 188);
            this.Controls.Add(this.lblAlterarDados);
            this.Controls.Add(this.btnSalvarEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtConfEditSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtConfEditEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEditSenha);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvarSenhar);
            this.Controls.Add(this.txtEditEmail);
            this.Controls.Add(this.lblNome);
            this.Name = "ControladorUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alterar dados da conta";
            this.Load += new System.EventHandler(this.ControladorUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEditSenha;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvarSenhar;
        private System.Windows.Forms.TextBox txtEditEmail;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtConfEditEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConfEditSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalvarEmail;
        private System.Windows.Forms.Label lblAlterarDados;
    }
}