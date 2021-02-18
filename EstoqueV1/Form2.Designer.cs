
namespace EstoqueV1
{
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnHistorico = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSaldo = new System.Windows.Forms.Button();
            this.BtnCheckQtd = new System.Windows.Forms.Button();
            this.BtnAttGrafico = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.viewConta = new System.Windows.Forms.ListView();
            this.BtnAddUser = new System.Windows.Forms.Button();
            this.BtnExcluirUser = new System.Windows.Forms.Button();
            this.BtnNewDadosUser = new System.Windows.Forms.Button();
            this.TabCadItem = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSaidaItem = new System.Windows.Forms.Button();
            this.BtnEntrada = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.BtnCategoriaNova = new System.Windows.Forms.Button();
            this.TabMenu = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.TabCadItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.TabMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chart1);
            this.tabPage3.Controls.Add(this.btnHistorico);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.BtnSaldo);
            this.tabPage3.Controls.Add(this.BtnCheckQtd);
            this.tabPage3.Controls.Add(this.BtnAttGrafico);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(976, 547);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Rotinas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(313, 79);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // btnHistorico
            // 
            this.btnHistorico.Location = new System.Drawing.Point(18, 278);
            this.btnHistorico.Name = "btnHistorico";
            this.btnHistorico.Size = new System.Drawing.Size(131, 23);
            this.btnHistorico.TabIndex = 4;
            this.btnHistorico.Text = "&Historico";
            this.btnHistorico.UseVisualStyleBackColor = true;
            this.btnHistorico.Click += new System.EventHandler(this.btnHistorico_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline);
            this.label3.Location = new System.Drawing.Point(345, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dados da conta";
            // 
            // BtnSaldo
            // 
            this.BtnSaldo.Location = new System.Drawing.Point(18, 186);
            this.BtnSaldo.Name = "BtnSaldo";
            this.BtnSaldo.Size = new System.Drawing.Size(131, 26);
            this.BtnSaldo.TabIndex = 2;
            this.BtnSaldo.Text = "&Saldo";
            this.BtnSaldo.UseVisualStyleBackColor = true;
            // 
            // BtnCheckQtd
            // 
            this.BtnCheckQtd.Location = new System.Drawing.Point(18, 97);
            this.BtnCheckQtd.Name = "BtnCheckQtd";
            this.BtnCheckQtd.Size = new System.Drawing.Size(139, 39);
            this.BtnCheckQtd.TabIndex = 1;
            this.BtnCheckQtd.Text = "&Verificar quantidade de produto";
            this.BtnCheckQtd.UseVisualStyleBackColor = true;
            this.BtnCheckQtd.Click += new System.EventHandler(this.BtnCheckQtd_Click);
            // 
            // BtnAttGrafico
            // 
            this.BtnAttGrafico.Location = new System.Drawing.Point(704, 97);
            this.BtnAttGrafico.Name = "BtnAttGrafico";
            this.BtnAttGrafico.Size = new System.Drawing.Size(139, 23);
            this.BtnAttGrafico.TabIndex = 0;
            this.BtnAttGrafico.Text = "&Atualizar grafico";
            this.BtnAttGrafico.UseVisualStyleBackColor = true;
            this.BtnAttGrafico.Click += new System.EventHandler(this.BtnAttGrafico_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.viewConta);
            this.tabPage1.Controls.Add(this.BtnAddUser);
            this.tabPage1.Controls.Add(this.BtnExcluirUser);
            this.tabPage1.Controls.Add(this.BtnNewDadosUser);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(976, 547);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Configuração de conta";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline);
            this.label2.Location = new System.Drawing.Point(335, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Configuração de conta";
            // 
            // viewConta
            // 
            this.viewConta.HideSelection = false;
            this.viewConta.Location = new System.Drawing.Point(211, 66);
            this.viewConta.Name = "viewConta";
            this.viewConta.Size = new System.Drawing.Size(467, 321);
            this.viewConta.TabIndex = 3;
            this.viewConta.UseCompatibleStateImageBehavior = false;
            // 
            // BtnAddUser
            // 
            this.BtnAddUser.Location = new System.Drawing.Point(38, 340);
            this.BtnAddUser.Name = "BtnAddUser";
            this.BtnAddUser.Size = new System.Drawing.Size(131, 23);
            this.BtnAddUser.TabIndex = 2;
            this.BtnAddUser.Text = "&Adicionar usuario";
            this.BtnAddUser.UseVisualStyleBackColor = true;
            this.BtnAddUser.Click += new System.EventHandler(this.BtnAddUser_Click);
            // 
            // BtnExcluirUser
            // 
            this.BtnExcluirUser.Location = new System.Drawing.Point(38, 200);
            this.BtnExcluirUser.Name = "BtnExcluirUser";
            this.BtnExcluirUser.Size = new System.Drawing.Size(131, 23);
            this.BtnExcluirUser.TabIndex = 1;
            this.BtnExcluirUser.Text = "&Excluir";
            this.BtnExcluirUser.UseVisualStyleBackColor = true;
            this.BtnExcluirUser.Click += new System.EventHandler(this.BtnExcluirUser_Click);
            // 
            // BtnNewDadosUser
            // 
            this.BtnNewDadosUser.Location = new System.Drawing.Point(38, 66);
            this.BtnNewDadosUser.Name = "BtnNewDadosUser";
            this.BtnNewDadosUser.Size = new System.Drawing.Size(131, 23);
            this.BtnNewDadosUser.TabIndex = 0;
            this.BtnNewDadosUser.Text = "&Alterar dados ";
            this.BtnNewDadosUser.UseVisualStyleBackColor = true;
            this.BtnNewDadosUser.Click += new System.EventHandler(this.BtnNewDadosUser_Click);
            // 
            // TabCadItem
            // 
            this.TabCadItem.Controls.Add(this.dataGridView1);
            this.TabCadItem.Controls.Add(this.lblTitulo);
            this.TabCadItem.Controls.Add(this.btnSaidaItem);
            this.TabCadItem.Controls.Add(this.BtnEntrada);
            this.TabCadItem.Controls.Add(this.button2);
            this.TabCadItem.Controls.Add(this.btnEditar);
            this.TabCadItem.Controls.Add(this.BtnCategoriaNova);
            this.TabCadItem.Location = new System.Drawing.Point(4, 22);
            this.TabCadItem.Name = "TabCadItem";
            this.TabCadItem.Padding = new System.Windows.Forms.Padding(3);
            this.TabCadItem.Size = new System.Drawing.Size(976, 547);
            this.TabCadItem.TabIndex = 0;
            this.TabCadItem.Text = "Produtos";
            this.TabCadItem.UseVisualStyleBackColor = true;
            this.TabCadItem.Click += new System.EventHandler(this.TabCadItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(192, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(487, 223);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline);
            this.lblTitulo.Location = new System.Drawing.Point(375, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(100, 26);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Cadastro";
            // 
            // btnSaidaItem
            // 
            this.btnSaidaItem.Location = new System.Drawing.Point(18, 189);
            this.btnSaidaItem.Name = "btnSaidaItem";
            this.btnSaidaItem.Size = new System.Drawing.Size(131, 36);
            this.btnSaidaItem.TabIndex = 1;
            this.btnSaidaItem.Text = "&Registrar saída de produtos";
            this.btnSaidaItem.UseVisualStyleBackColor = true;
            this.btnSaidaItem.Click += new System.EventHandler(this.btnSaidaItem_Click);
            // 
            // BtnEntrada
            // 
            this.BtnEntrada.Location = new System.Drawing.Point(18, 85);
            this.BtnEntrada.Name = "BtnEntrada";
            this.BtnEntrada.Size = new System.Drawing.Size(131, 38);
            this.BtnEntrada.TabIndex = 0;
            this.BtnEntrada.Text = "&Registrar entrada de produtos";
            this.BtnEntrada.UseVisualStyleBackColor = true;
            this.BtnEntrada.Click += new System.EventHandler(this.BtnEntrada_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(611, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "&Confirmar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(695, 173);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(131, 23);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "&Editar ";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // BtnCategoriaNova
            // 
            this.BtnCategoriaNova.Location = new System.Drawing.Point(695, 110);
            this.BtnCategoriaNova.Name = "BtnCategoriaNova";
            this.BtnCategoriaNova.Size = new System.Drawing.Size(131, 23);
            this.BtnCategoriaNova.TabIndex = 2;
            this.BtnCategoriaNova.Text = "&Cadastrar item";
            this.BtnCategoriaNova.UseVisualStyleBackColor = true;
            this.BtnCategoriaNova.Click += new System.EventHandler(this.BtnCategoriaNova_Click);
            // 
            // TabMenu
            // 
            this.TabMenu.Controls.Add(this.TabCadItem);
            this.TabMenu.Controls.Add(this.tabPage1);
            this.TabMenu.Controls.Add(this.tabPage3);
            this.TabMenu.Location = new System.Drawing.Point(12, 12);
            this.TabMenu.Name = "TabMenu";
            this.TabMenu.SelectedIndex = 0;
            this.TabMenu.Size = new System.Drawing.Size(984, 573);
            this.TabMenu.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.TabMenu);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.TabCadItem.ResumeLayout(false);
            this.TabCadItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.TabMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnHistorico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnSaldo;
        private System.Windows.Forms.Button BtnCheckQtd;
        private System.Windows.Forms.Button BtnAttGrafico;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView viewConta;
        private System.Windows.Forms.Button BtnAddUser;
        private System.Windows.Forms.Button BtnExcluirUser;
        private System.Windows.Forms.Button BtnNewDadosUser;
        private System.Windows.Forms.TabPage TabCadItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSaidaItem;
        private System.Windows.Forms.Button BtnEntrada;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button BtnCategoriaNova;
        private System.Windows.Forms.TabControl TabMenu;
    }
}