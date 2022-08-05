namespace BusSystemWF
{
    partial class CadastrarPassageiro
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.checkIdoso = new System.Windows.Forms.CheckBox();
            this.checkEstudante = new System.Windows.Forms.CheckBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.mskTxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.cmbBoxIdade = new System.Windows.Forms.ComboBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblAfterCheck = new System.Windows.Forms.Label();
            this.txtEscola = new System.Windows.Forms.TextBox();
            this.mskTxtRg = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(11, 9);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 15);
            this.lblNome.TabIndex = 58;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.Location = new System.Drawing.Point(11, 28);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(275, 32);
            this.txtNome.TabIndex = 57;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCadastrar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCadastrar.Location = new System.Drawing.Point(67, 237);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(175, 54);
            this.btnCadastrar.TabIndex = 62;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // checkIdoso
            // 
            this.checkIdoso.AutoSize = true;
            this.checkIdoso.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkIdoso.Location = new System.Drawing.Point(187, 204);
            this.checkIdoso.Margin = new System.Windows.Forms.Padding(2);
            this.checkIdoso.Name = "checkIdoso";
            this.checkIdoso.Size = new System.Drawing.Size(79, 26);
            this.checkIdoso.TabIndex = 61;
            this.checkIdoso.Text = "Idoso";
            this.checkIdoso.UseVisualStyleBackColor = true;
            this.checkIdoso.CheckedChanged += new System.EventHandler(this.checkIdoso_CheckedChanged);
            // 
            // checkEstudante
            // 
            this.checkEstudante.AutoSize = true;
            this.checkEstudante.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkEstudante.Location = new System.Drawing.Point(47, 204);
            this.checkEstudante.Margin = new System.Windows.Forms.Padding(2);
            this.checkEstudante.Name = "checkEstudante";
            this.checkEstudante.Size = new System.Drawing.Size(119, 26);
            this.checkEstudante.TabIndex = 60;
            this.checkEstudante.Text = "Estudante";
            this.checkEstudante.UseVisualStyleBackColor = true;
            this.checkEstudante.CheckedChanged += new System.EventHandler(this.checkEstudante_CheckedChanged);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTelefone.Location = new System.Drawing.Point(11, 76);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(63, 15);
            this.lblTelefone.TabIndex = 64;
            this.lblTelefone.Text = "Telefone";
            // 
            // mskTxtTelefone
            // 
            this.mskTxtTelefone.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskTxtTelefone.Location = new System.Drawing.Point(11, 93);
            this.mskTxtTelefone.Margin = new System.Windows.Forms.Padding(2);
            this.mskTxtTelefone.Mask = "(00) 00000-0000";
            this.mskTxtTelefone.Name = "mskTxtTelefone";
            this.mskTxtTelefone.Size = new System.Drawing.Size(172, 32);
            this.mskTxtTelefone.TabIndex = 65;
            // 
            // cmbBoxIdade
            // 
            this.cmbBoxIdade.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbBoxIdade.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99",
            "100"});
            this.cmbBoxIdade.Location = new System.Drawing.Point(200, 92);
            this.cmbBoxIdade.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBoxIdade.Name = "cmbBoxIdade";
            this.cmbBoxIdade.Size = new System.Drawing.Size(86, 32);
            this.cmbBoxIdade.TabIndex = 66;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIdade.Location = new System.Drawing.Point(200, 76);
            this.lblIdade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(42, 15);
            this.lblIdade.TabIndex = 67;
            this.lblIdade.Text = "Idade";
            // 
            // lblAfterCheck
            // 
            this.lblAfterCheck.AutoSize = true;
            this.lblAfterCheck.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAfterCheck.Location = new System.Drawing.Point(11, 145);
            this.lblAfterCheck.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAfterCheck.Name = "lblAfterCheck";
            this.lblAfterCheck.Size = new System.Drawing.Size(49, 15);
            this.lblAfterCheck.TabIndex = 68;
            this.lblAfterCheck.Text = "Escola";
            this.lblAfterCheck.Visible = false;
            // 
            // txtEscola
            // 
            this.txtEscola.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEscola.Location = new System.Drawing.Point(11, 162);
            this.txtEscola.Margin = new System.Windows.Forms.Padding(2);
            this.txtEscola.Name = "txtEscola";
            this.txtEscola.Size = new System.Drawing.Size(275, 32);
            this.txtEscola.TabIndex = 69;
            this.txtEscola.Visible = false;
            // 
            // mskTxtRg
            // 
            this.mskTxtRg.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskTxtRg.Location = new System.Drawing.Point(11, 162);
            this.mskTxtRg.Margin = new System.Windows.Forms.Padding(2);
            this.mskTxtRg.Mask = "00 000 000-0";
            this.mskTxtRg.Name = "mskTxtRg";
            this.mskTxtRg.Size = new System.Drawing.Size(155, 32);
            this.mskTxtRg.TabIndex = 70;
            this.mskTxtRg.Visible = false;
            // 
            // CadastrarPassageiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(309, 311);
            this.Controls.Add(this.mskTxtRg);
            this.Controls.Add(this.txtEscola);
            this.Controls.Add(this.lblAfterCheck);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.cmbBoxIdade);
            this.Controls.Add(this.mskTxtTelefone);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.checkIdoso);
            this.Controls.Add(this.checkEstudante);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximumSize = new System.Drawing.Size(325, 350);
            this.MinimumSize = new System.Drawing.Size(325, 350);
            this.Name = "CadastrarPassageiro";
            this.Text = "CadastrarPassageiro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Label lblNome;
        public TextBox txtNome;
        public Button btnCadastrar;
        public CheckBox checkIdoso;
        public CheckBox checkEstudante;
        public Label lblTelefone;
        public MaskedTextBox mskTxtTelefone;
        public ComboBox cmbBoxIdade;
        public Label lblIdade;
        public Label lblAfterCheck;
        public TextBox txtEscola;
        public MaskedTextBox mskTxtRg;
    }
}