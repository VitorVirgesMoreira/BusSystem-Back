namespace BusSystemWF
{
    partial class CadastrarViagem
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
            this.mskHoraViagem = new System.Windows.Forms.MaskedTextBox();
            this.mskDataViagem = new System.Windows.Forms.MaskedTextBox();
            this.mskTxtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.lblHoraViagem = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.lblDataViagem = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.CheckInterMunicipal = new System.Windows.Forms.CheckBox();
            this.CheckMunicipal = new System.Windows.Forms.CheckBox();
            this.txtNomeMotorista = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mskHoraViagem
            // 
            this.mskHoraViagem.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskHoraViagem.Location = new System.Drawing.Point(264, 91);
            this.mskHoraViagem.Margin = new System.Windows.Forms.Padding(2);
            this.mskHoraViagem.Mask = "00:00";
            this.mskHoraViagem.Name = "mskHoraViagem";
            this.mskHoraViagem.Size = new System.Drawing.Size(59, 30);
            this.mskHoraViagem.TabIndex = 51;
            this.mskHoraViagem.ValidatingType = typeof(System.DateTime);
            // 
            // mskDataViagem
            // 
            this.mskDataViagem.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskDataViagem.Location = new System.Drawing.Point(129, 91);
            this.mskDataViagem.Margin = new System.Windows.Forms.Padding(2);
            this.mskDataViagem.Mask = "00/00/0000";
            this.mskDataViagem.Name = "mskDataViagem";
            this.mskDataViagem.Size = new System.Drawing.Size(110, 30);
            this.mskDataViagem.TabIndex = 50;
            this.mskDataViagem.ValidatingType = typeof(System.DateTime);
            // 
            // mskTxtPlaca
            // 
            this.mskTxtPlaca.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mskTxtPlaca.Location = new System.Drawing.Point(11, 91);
            this.mskTxtPlaca.Margin = new System.Windows.Forms.Padding(2);
            this.mskTxtPlaca.Mask = "AAA-0000";
            this.mskTxtPlaca.Name = "mskTxtPlaca";
            this.mskTxtPlaca.Size = new System.Drawing.Size(88, 30);
            this.mskTxtPlaca.TabIndex = 49;
            // 
            // lblHoraViagem
            // 
            this.lblHoraViagem.AutoSize = true;
            this.lblHoraViagem.Location = new System.Drawing.Point(264, 74);
            this.lblHoraViagem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoraViagem.Name = "lblHoraViagem";
            this.lblHoraViagem.Size = new System.Drawing.Size(35, 15);
            this.lblHoraViagem.TabIndex = 55;
            this.lblHoraViagem.Text = "Hora";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(11, 74);
            this.lblPlaca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(42, 15);
            this.lblPlaca.TabIndex = 58;
            this.lblPlaca.Text = "Placa";
            // 
            // lblDataViagem
            // 
            this.lblDataViagem.AutoSize = true;
            this.lblDataViagem.Location = new System.Drawing.Point(129, 74);
            this.lblDataViagem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataViagem.Name = "lblDataViagem";
            this.lblDataViagem.Size = new System.Drawing.Size(35, 15);
            this.lblDataViagem.TabIndex = 57;
            this.lblDataViagem.Text = "Data";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(11, 9);
            this.lblNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(126, 15);
            this.lblNome.TabIndex = 56;
            this.lblNome.Text = "Nome do motorista";
            // 
            // CheckInterMunicipal
            // 
            this.CheckInterMunicipal.AutoSize = true;
            this.CheckInterMunicipal.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckInterMunicipal.Location = new System.Drawing.Point(151, 155);
            this.CheckInterMunicipal.Margin = new System.Windows.Forms.Padding(2);
            this.CheckInterMunicipal.Name = "CheckInterMunicipal";
            this.CheckInterMunicipal.Size = new System.Drawing.Size(169, 26);
            this.CheckInterMunicipal.TabIndex = 53;
            this.CheckInterMunicipal.Text = "Intermunicipal";
            this.CheckInterMunicipal.UseVisualStyleBackColor = true;
            this.CheckInterMunicipal.CheckedChanged += new System.EventHandler(this.CheckInterMunicipal_CheckedChanged);
            // 
            // CheckMunicipal
            // 
            this.CheckMunicipal.AutoSize = true;
            this.CheckMunicipal.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckMunicipal.Location = new System.Drawing.Point(11, 155);
            this.CheckMunicipal.Margin = new System.Windows.Forms.Padding(2);
            this.CheckMunicipal.Name = "CheckMunicipal";
            this.CheckMunicipal.Size = new System.Drawing.Size(119, 26);
            this.CheckMunicipal.TabIndex = 52;
            this.CheckMunicipal.Text = "Municipal";
            this.CheckMunicipal.UseVisualStyleBackColor = true;
            this.CheckMunicipal.CheckedChanged += new System.EventHandler(this.CheckMunicipal_CheckedChanged);
            // 
            // txtNomeMotorista
            // 
            this.txtNomeMotorista.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNomeMotorista.Location = new System.Drawing.Point(11, 26);
            this.txtNomeMotorista.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeMotorista.Name = "txtNomeMotorista";
            this.txtNomeMotorista.Size = new System.Drawing.Size(312, 36);
            this.txtNomeMotorista.TabIndex = 48;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCadastrar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCadastrar.Location = new System.Drawing.Point(77, 193);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(175, 54);
            this.btnCadastrar.TabIndex = 59;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnInfoViagens_Click);
            // 
            // CadastrarViagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.mskHoraViagem);
            this.Controls.Add(this.mskDataViagem);
            this.Controls.Add(this.mskTxtPlaca);
            this.Controls.Add(this.lblHoraViagem);
            this.Controls.Add(this.lblPlaca);
            this.Controls.Add(this.lblDataViagem);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.CheckInterMunicipal);
            this.Controls.Add(this.CheckMunicipal);
            this.Controls.Add(this.txtNomeMotorista);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximumSize = new System.Drawing.Size(350, 300);
            this.MinimumSize = new System.Drawing.Size(350, 300);
            this.Name = "CadastrarViagem";
            this.Text = "CadastrarViagem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaskedTextBox mskHoraViagem;
        private MaskedTextBox mskDataViagem;
        private MaskedTextBox mskTxtPlaca;
        private Label lblHoraViagem;
        private Label lblPlaca;
        private Label lblDataViagem;
        private Label lblNome;
        private CheckBox CheckInterMunicipal;
        private CheckBox CheckMunicipal;
        private TextBox txtNomeMotorista;
        private Button btnCadastrar;
    }
}