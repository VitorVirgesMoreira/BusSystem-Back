namespace BusSystemWF
{
    partial class InfoViagens
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cbxHora = new System.Windows.Forms.ComboBox();
            this.cbxData = new System.Windows.Forms.ComboBox();
            this.cbxPlaca = new System.Windows.Forms.ComboBox();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.ListViewCSV = new System.Windows.Forms.ListView();
            this.Nome = new System.Windows.Forms.ColumnHeader();
            this.Idade = new System.Windows.Forms.ColumnHeader();
            this.Telefone = new System.Windows.Forms.ColumnHeader();
            this.Tarifa = new System.Windows.Forms.ColumnHeader();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnExportarCsv = new System.Windows.Forms.Button();
            this.btnPesquisarMaisVelhos = new System.Windows.Forms.Button();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblTotalPessoasOciosas = new System.Windows.Forms.Label();
            this.lblOciosas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Consolas", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(9, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(341, 41);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Pesquisar Viagens";
            // 
            // cbxHora
            // 
            this.cbxHora.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxHora.FormattingEnabled = true;
            this.cbxHora.Location = new System.Drawing.Point(301, 86);
            this.cbxHora.Margin = new System.Windows.Forms.Padding(10);
            this.cbxHora.Name = "cbxHora";
            this.cbxHora.Size = new System.Drawing.Size(129, 32);
            this.cbxHora.TabIndex = 12;
            this.cbxHora.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbxHora_MouseClick);
            // 
            // cbxData
            // 
            this.cbxData.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxData.FormattingEnabled = true;
            this.cbxData.Location = new System.Drawing.Point(160, 86);
            this.cbxData.Margin = new System.Windows.Forms.Padding(10);
            this.cbxData.Name = "cbxData";
            this.cbxData.Size = new System.Drawing.Size(129, 32);
            this.cbxData.TabIndex = 11;
            this.cbxData.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbxData_MouseClick);
            // 
            // cbxPlaca
            // 
            this.cbxPlaca.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbxPlaca.FormattingEnabled = true;
            this.cbxPlaca.Location = new System.Drawing.Point(19, 86);
            this.cbxPlaca.Margin = new System.Windows.Forms.Padding(10);
            this.cbxPlaca.Name = "cbxPlaca";
            this.cbxPlaca.Size = new System.Drawing.Size(129, 32);
            this.cbxPlaca.TabIndex = 10;
            this.cbxPlaca.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbxPlaca_MouseClick);
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(19, 63);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(42, 15);
            this.lblPlaca.TabIndex = 13;
            this.lblPlaca.Text = "Placa";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(160, 63);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(35, 15);
            this.lblData.TabIndex = 14;
            this.lblData.Text = "Data";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(301, 63);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(35, 15);
            this.lblHora.TabIndex = 15;
            this.lblHora.Text = "Hora";
            // 
            // ListViewCSV
            // 
            this.ListViewCSV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListViewCSV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nome,
            this.Idade,
            this.Telefone,
            this.Tarifa});
            this.ListViewCSV.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListViewCSV.Location = new System.Drawing.Point(19, 140);
            this.ListViewCSV.Margin = new System.Windows.Forms.Padding(2);
            this.ListViewCSV.MultiSelect = false;
            this.ListViewCSV.Name = "ListViewCSV";
            this.ListViewCSV.Size = new System.Drawing.Size(555, 266);
            this.ListViewCSV.TabIndex = 16;
            this.ListViewCSV.UseCompatibleStateImageBehavior = false;
            this.ListViewCSV.View = System.Windows.Forms.View.Details;
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 150;
            // 
            // Idade
            // 
            this.Idade.Text = "Idade";
            this.Idade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Telefone
            // 
            this.Telefone.Text = "Telefone";
            this.Telefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Telefone.Width = 140;
            // 
            // Tarifa
            // 
            this.Tarifa.Text = "Tarifa";
            this.Tarifa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Tarifa.Width = 80;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPesquisar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPesquisar.Location = new System.Drawing.Point(445, 86);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(5);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(129, 32);
            this.btnPesquisar.TabIndex = 18;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnExportarCsv
            // 
            this.btnExportarCsv.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnExportarCsv.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnExportarCsv.Location = new System.Drawing.Point(445, 413);
            this.btnExportarCsv.Margin = new System.Windows.Forms.Padding(5);
            this.btnExportarCsv.Name = "btnExportarCsv";
            this.btnExportarCsv.Size = new System.Drawing.Size(129, 54);
            this.btnExportarCsv.TabIndex = 19;
            this.btnExportarCsv.Text = "Exportar CSV";
            this.btnExportarCsv.UseVisualStyleBackColor = false;
            this.btnExportarCsv.Click += new System.EventHandler(this.btnExportarCsv_Click);
            // 
            // btnPesquisarMaisVelhos
            // 
            this.btnPesquisarMaisVelhos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPesquisarMaisVelhos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPesquisarMaisVelhos.Location = new System.Drawing.Point(301, 413);
            this.btnPesquisarMaisVelhos.Margin = new System.Windows.Forms.Padding(5);
            this.btnPesquisarMaisVelhos.Name = "btnPesquisarMaisVelhos";
            this.btnPesquisarMaisVelhos.Size = new System.Drawing.Size(129, 54);
            this.btnPesquisarMaisVelhos.TabIndex = 20;
            this.btnPesquisarMaisVelhos.Text = "Pesquisar Mais Velhos";
            this.btnPesquisarMaisVelhos.UseVisualStyleBackColor = false;
            this.btnPesquisarMaisVelhos.Click += new System.EventHandler(this.btnPesquisarMaisVelhos_Click);
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(19, 413);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(168, 15);
            this.lblValorTotal.TabIndex = 21;
            this.lblValorTotal.Text = "Valor Total da Viagem: ";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(193, 413);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(63, 15);
            this.lblPreco.TabIndex = 22;
            this.lblPreco.Text = "R$ 00,00";
            // 
            // lblTotalPessoasOciosas
            // 
            this.lblTotalPessoasOciosas.AutoSize = true;
            this.lblTotalPessoasOciosas.Location = new System.Drawing.Point(19, 433);
            this.lblTotalPessoasOciosas.Name = "lblTotalPessoasOciosas";
            this.lblTotalPessoasOciosas.Size = new System.Drawing.Size(168, 15);
            this.lblTotalPessoasOciosas.TabIndex = 23;
            this.lblTotalPessoasOciosas.Text = "Total Pessoas Ociosas: ";
            // 
            // lblOciosas
            // 
            this.lblOciosas.AutoSize = true;
            this.lblOciosas.Location = new System.Drawing.Point(193, 433);
            this.lblOciosas.Name = "lblOciosas";
            this.lblOciosas.Size = new System.Drawing.Size(14, 15);
            this.lblOciosas.TabIndex = 24;
            this.lblOciosas.Text = "0";
            this.lblOciosas.Visible = false;
            // 
            // InfoViagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblOciosas);
            this.Controls.Add(this.lblTotalPessoasOciosas);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.btnPesquisarMaisVelhos);
            this.Controls.Add(this.btnExportarCsv);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.ListViewCSV);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.cbxHora);
            this.Controls.Add(this.cbxData);
            this.Controls.Add(this.cbxPlaca);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.Name = "InfoViagens";
            this.Text = "InfoViagens";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitulo;
        private ComboBox cbxHora;
        private ComboBox cbxData;
        private ComboBox cbxPlaca;
        private Label lblPlaca;
        private Label lblData;
        private Label lblHora;
        private ListView ListViewCSV;
        private ColumnHeader Nome;
        private ColumnHeader Idade;
        private ColumnHeader Telefone;
        private ColumnHeader Tarifa;
        private Button btnPesquisar;
        private Button btnExportarCsv;
        private Button btnPesquisarMaisVelhos;
        private Label lblValorTotal;
        private Label lblPreco;
        private Label lblTotalPessoasOciosas;
        private Label lblOciosas;
    }
}