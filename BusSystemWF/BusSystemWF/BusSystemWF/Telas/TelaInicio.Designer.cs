namespace BusSystemWF
{
    partial class TelaInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicio));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCadViagem = new System.Windows.Forms.Button();
            this.cmbBoxViagens = new System.Windows.Forms.ComboBox();
            this.lblViagensTI = new System.Windows.Forms.Label();
            this.btnCadPassageiro = new System.Windows.Forms.Button();
            this.btnInfoViagens = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            resources.ApplyResources(this.lblTitulo, "lblTitulo");
            this.lblTitulo.Name = "lblTitulo";
            // 
            // btnCadViagem
            // 
            resources.ApplyResources(this.btnCadViagem, "btnCadViagem");
            this.btnCadViagem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCadViagem.Name = "btnCadViagem";
            this.btnCadViagem.UseVisualStyleBackColor = false;
            this.btnCadViagem.Click += new System.EventHandler(this.btnCadViagem_Click);
            // 
            // cmbBoxViagens
            // 
            resources.ApplyResources(this.cmbBoxViagens, "cmbBoxViagens");
            this.cmbBoxViagens.FormattingEnabled = true;
            this.cmbBoxViagens.Name = "cmbBoxViagens";
            this.cmbBoxViagens.SelectedIndexChanged += new System.EventHandler(this.cmbBoxViagens_SelectedIndexChanged);
            this.cmbBoxViagens.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbBoxViagens_MouseClick);
            // 
            // lblViagensTI
            // 
            resources.ApplyResources(this.lblViagensTI, "lblViagensTI");
            this.lblViagensTI.Name = "lblViagensTI";
            // 
            // btnCadPassageiro
            // 
            resources.ApplyResources(this.btnCadPassageiro, "btnCadPassageiro");
            this.btnCadPassageiro.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCadPassageiro.Name = "btnCadPassageiro";
            this.btnCadPassageiro.UseVisualStyleBackColor = false;
            this.btnCadPassageiro.Click += new System.EventHandler(this.btnCadPassageiro_Click);
            // 
            // btnInfoViagens
            // 
            resources.ApplyResources(this.btnInfoViagens, "btnInfoViagens");
            this.btnInfoViagens.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnInfoViagens.Name = "btnInfoViagens";
            this.btnInfoViagens.UseVisualStyleBackColor = false;
            this.btnInfoViagens.Click += new System.EventHandler(this.btnInfoViagens_Click);
            // 
            // TelaInicio
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.btnInfoViagens);
            this.Controls.Add(this.btnCadPassageiro);
            this.Controls.Add(this.lblViagensTI);
            this.Controls.Add(this.cmbBoxViagens);
            this.Controls.Add(this.btnCadViagem);
            this.Controls.Add(this.lblTitulo);
            this.Name = "TelaInicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitulo;
        private Button btnCadViagem;
        private ComboBox cmbBoxViagens;
        private Label lblViagensTI;
        private Button btnCadPassageiro;
        private Button btnInfoViagens;
    }
}