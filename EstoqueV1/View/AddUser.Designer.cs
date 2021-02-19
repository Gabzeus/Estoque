
namespace EstoqueV1
{
    partial class AddUser
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
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtbSenha = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.txtSenhaConf = new System.Windows.Forms.TextBox();
            this.TxtNomeUser = new System.Windows.Forms.TextBox();
            this.lblNomeUser = new System.Windows.Forms.Label();
            this.lblConfirme = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblConfEmail = new System.Windows.Forms.Label();
            this.txtConfEmail = new System.Windows.Forms.TextBox();
            this.cboxFunção = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(46, 77);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(92, 13);
            this.lblSenha.TabIndex = 24;
            this.lblSenha.Text = "Digite uma senha:";
            this.lblSenha.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtbSenha
            // 
            this.txtbSenha.Location = new System.Drawing.Point(144, 77);
            this.txtbSenha.Name = "txtbSenha";
            this.txtbSenha.PasswordChar = '*';
            this.txtbSenha.Size = new System.Drawing.Size(181, 20);
            this.txtbSenha.TabIndex = 1;
            this.txtbSenha.TextChanged += new System.EventHandler(this.txtbSenha_TextChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(373, 139);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalvar.Location = new System.Drawing.Point(373, 103);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(-16, 35);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 22;
            this.lblId.Text = "Id";
            // 
            // txtSenhaConf
            // 
            this.txtSenhaConf.Location = new System.Drawing.Point(144, 110);
            this.txtSenhaConf.Name = "txtSenhaConf";
            this.txtSenhaConf.PasswordChar = '*';
            this.txtSenhaConf.Size = new System.Drawing.Size(181, 20);
            this.txtSenhaConf.TabIndex = 2;
            this.txtSenhaConf.TextChanged += new System.EventHandler(this.txtSenhaConf_TextChanged);
            // 
            // TxtNomeUser
            // 
            this.TxtNomeUser.Location = new System.Drawing.Point(144, 46);
            this.TxtNomeUser.Name = "TxtNomeUser";
            this.TxtNomeUser.Size = new System.Drawing.Size(181, 20);
            this.TxtNomeUser.TabIndex = 0;
            this.TxtNomeUser.TabStop = false;
            this.TxtNomeUser.TextChanged += new System.EventHandler(this.TxtId_TextChanged);
            // 
            // lblNomeUser
            // 
            this.lblNomeUser.AutoSize = true;
            this.lblNomeUser.Location = new System.Drawing.Point(48, 46);
            this.lblNomeUser.Name = "lblNomeUser";
            this.lblNomeUser.Size = new System.Drawing.Size(90, 13);
            this.lblNomeUser.TabIndex = 17;
            this.lblNomeUser.Text = "Nome do usuario:";
            // 
            // lblConfirme
            // 
            this.lblConfirme.AutoSize = true;
            this.lblConfirme.Location = new System.Drawing.Point(46, 113);
            this.lblConfirme.Name = "lblConfirme";
            this.lblConfirme.Size = new System.Drawing.Size(92, 13);
            this.lblConfirme.TabIndex = 25;
            this.lblConfirme.Text = "Confirme a senha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Função";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(57, 139);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(81, 13);
            this.lblEmail.TabIndex = 30;
            this.lblEmail.Text = "Digite um email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(144, 136);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(181, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // lblConfEmail
            // 
            this.lblConfEmail.AutoSize = true;
            this.lblConfEmail.Location = new System.Drawing.Point(57, 165);
            this.lblConfEmail.Name = "lblConfEmail";
            this.lblConfEmail.Size = new System.Drawing.Size(87, 13);
            this.lblConfEmail.TabIndex = 32;
            this.lblConfEmail.Text = "Confirme o email:";
            // 
            // txtConfEmail
            // 
            this.txtConfEmail.Location = new System.Drawing.Point(144, 162);
            this.txtConfEmail.Name = "txtConfEmail";
            this.txtConfEmail.Size = new System.Drawing.Size(181, 20);
            this.txtConfEmail.TabIndex = 4;
            // 
            // cboxFunção
            // 
            this.cboxFunção.AutoCompleteCustomSource.AddRange(new string[] {
            "Administrador",
            "Supervisor",
            "Usuario"});
            this.cboxFunção.FormattingEnabled = true;
            this.cboxFunção.Items.AddRange(new object[] {
            "Administrador",
            "Supervisor",
            "Usuario"});
            this.cboxFunção.Location = new System.Drawing.Point(346, 45);
            this.cboxFunção.Name = "cboxFunção";
            this.cboxFunção.Size = new System.Drawing.Size(102, 21);
            this.cboxFunção.TabIndex = 33;
            this.cboxFunção.TabStop = false;
            this.cboxFunção.SelectedIndexChanged += new System.EventHandler(this.cboxFunção_SelectedIndexChanged);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 234);
            this.Controls.Add(this.cboxFunção);
            this.Controls.Add(this.lblConfEmail);
            this.Controls.Add(this.txtConfEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblConfirme);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtbSenha);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtSenhaConf);
            this.Controls.Add(this.TxtNomeUser);
            this.Controls.Add(this.lblNomeUser);
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Novo usuario";
            this.Load += new System.EventHandler(this.AddUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtbSenha;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtSenhaConf;
        private System.Windows.Forms.TextBox TxtNomeUser;
        private System.Windows.Forms.Label lblNomeUser;
        private System.Windows.Forms.Label lblConfirme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblConfEmail;
        private System.Windows.Forms.TextBox txtConfEmail;
        private System.Windows.Forms.ComboBox cboxFunção;
    }
}