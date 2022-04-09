namespace prjForca
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnLetra = new System.Windows.Forms.Panel();
            this.btnJogar = new System.Windows.Forms.Button();
            this.txtLetra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnPalavraSecreta = new System.Windows.Forms.Panel();
            this.lblLetrasDigitadas = new System.Windows.Forms.Label();
            this.pbForca = new System.Windows.Forms.PictureBox();
            this.pbEnforcado = new System.Windows.Forms.PictureBox();
            this.lbCronometro = new System.Windows.Forms.Label();
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.pbMorcego = new System.Windows.Forms.PictureBox();
            this.pbMorcego2 = new System.Windows.Forms.PictureBox();
            this.btnNovoJogo = new System.Windows.Forms.Button();
            this.lblDica = new System.Windows.Forms.Label();
            this.pnLetra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbForca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnforcado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMorcego)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMorcego2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnLetra
            // 
            this.pnLetra.BackColor = System.Drawing.Color.Transparent;
            this.pnLetra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnLetra.Controls.Add(this.btnJogar);
            this.pnLetra.Controls.Add(this.txtLetra);
            this.pnLetra.Controls.Add(this.label1);
            this.pnLetra.Location = new System.Drawing.Point(12, 12);
            this.pnLetra.Name = "pnLetra";
            this.pnLetra.Size = new System.Drawing.Size(200, 188);
            this.pnLetra.TabIndex = 0;
            // 
            // btnJogar
            // 
            this.btnJogar.BackColor = System.Drawing.Color.Transparent;
            this.btnJogar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnJogar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnJogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJogar.ForeColor = System.Drawing.Color.Orange;
            this.btnJogar.Location = new System.Drawing.Point(9, 126);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(179, 46);
            this.btnJogar.TabIndex = 2;
            this.btnJogar.Text = "JOGAR";
            this.btnJogar.UseVisualStyleBackColor = false;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // txtLetra
            // 
            this.txtLetra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLetra.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLetra.Location = new System.Drawing.Point(9, 64);
            this.txtLetra.MaxLength = 1;
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.Size = new System.Drawing.Size(179, 43);
            this.txtLetra.TabIndex = 1;
            this.txtLetra.Text = "A";
            this.txtLetra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLetra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtLetra_KeyUp);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "DIGITE UMA LETRA:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnPalavraSecreta
            // 
            this.pnPalavraSecreta.BackColor = System.Drawing.Color.Transparent;
            this.pnPalavraSecreta.Location = new System.Drawing.Point(218, 47);
            this.pnPalavraSecreta.Name = "pnPalavraSecreta";
            this.pnPalavraSecreta.Size = new System.Drawing.Size(607, 153);
            this.pnPalavraSecreta.TabIndex = 1;
            // 
            // lblLetrasDigitadas
            // 
            this.lblLetrasDigitadas.BackColor = System.Drawing.Color.Transparent;
            this.lblLetrasDigitadas.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetrasDigitadas.ForeColor = System.Drawing.Color.White;
            this.lblLetrasDigitadas.Location = new System.Drawing.Point(270, 206);
            this.lblLetrasDigitadas.Name = "lblLetrasDigitadas";
            this.lblLetrasDigitadas.Padding = new System.Windows.Forms.Padding(5);
            this.lblLetrasDigitadas.Size = new System.Drawing.Size(519, 182);
            this.lblLetrasDigitadas.TabIndex = 2;
            this.lblLetrasDigitadas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbForca
            // 
            this.pbForca.BackColor = System.Drawing.Color.Transparent;
            this.pbForca.Image = ((System.Drawing.Image)(resources.GetObject("pbForca.Image")));
            this.pbForca.Location = new System.Drawing.Point(12, 206);
            this.pbForca.Name = "pbForca";
            this.pbForca.Size = new System.Drawing.Size(252, 426);
            this.pbForca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbForca.TabIndex = 3;
            this.pbForca.TabStop = false;
            // 
            // pbEnforcado
            // 
            this.pbEnforcado.BackColor = System.Drawing.Color.Transparent;
            this.pbEnforcado.Location = new System.Drawing.Point(76, 300);
            this.pbEnforcado.Name = "pbEnforcado";
            this.pbEnforcado.Size = new System.Drawing.Size(188, 332);
            this.pbEnforcado.TabIndex = 4;
            this.pbEnforcado.TabStop = false;
            // 
            // lbCronometro
            // 
            this.lbCronometro.BackColor = System.Drawing.Color.Transparent;
            this.lbCronometro.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCronometro.ForeColor = System.Drawing.Color.Orange;
            this.lbCronometro.Image = ((System.Drawing.Image)(resources.GetObject("lbCronometro.Image")));
            this.lbCronometro.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbCronometro.Location = new System.Drawing.Point(674, 529);
            this.lbCronometro.Name = "lbCronometro";
            this.lbCronometro.Size = new System.Drawing.Size(151, 103);
            this.lbCronometro.TabIndex = 5;
            this.lbCronometro.Text = "60";
            this.lbCronometro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Temporizador
            // 
            this.Temporizador.Interval = 1000;
            this.Temporizador.Tick += new System.EventHandler(this.Temporizador_Tick);
            // 
            // pbMorcego
            // 
            this.pbMorcego.BackColor = System.Drawing.Color.Transparent;
            this.pbMorcego.Image = ((System.Drawing.Image)(resources.GetObject("pbMorcego.Image")));
            this.pbMorcego.Location = new System.Drawing.Point(722, 391);
            this.pbMorcego.Name = "pbMorcego";
            this.pbMorcego.Size = new System.Drawing.Size(100, 73);
            this.pbMorcego.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMorcego.TabIndex = 7;
            this.pbMorcego.TabStop = false;
            // 
            // pbMorcego2
            // 
            this.pbMorcego2.BackColor = System.Drawing.Color.Transparent;
            this.pbMorcego2.Image = ((System.Drawing.Image)(resources.GetObject("pbMorcego2.Image")));
            this.pbMorcego2.Location = new System.Drawing.Point(646, 455);
            this.pbMorcego2.Name = "pbMorcego2";
            this.pbMorcego2.Size = new System.Drawing.Size(88, 67);
            this.pbMorcego2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMorcego2.TabIndex = 8;
            this.pbMorcego2.TabStop = false;
            // 
            // btnNovoJogo
            // 
            this.btnNovoJogo.BackColor = System.Drawing.Color.Orange;
            this.btnNovoJogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoJogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoJogo.ForeColor = System.Drawing.Color.Black;
            this.btnNovoJogo.Location = new System.Drawing.Point(382, 581);
            this.btnNovoJogo.Margin = new System.Windows.Forms.Padding(0);
            this.btnNovoJogo.Name = "btnNovoJogo";
            this.btnNovoJogo.Size = new System.Drawing.Size(215, 51);
            this.btnNovoJogo.TabIndex = 9;
            this.btnNovoJogo.Text = "NOVO JOGO";
            this.btnNovoJogo.UseVisualStyleBackColor = false;
            this.btnNovoJogo.Click += new System.EventHandler(this.btnNovoJogo_Click);
            // 
            // lblDica
            // 
            this.lblDica.BackColor = System.Drawing.Color.Transparent;
            this.lblDica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDica.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDica.ForeColor = System.Drawing.Color.White;
            this.lblDica.Location = new System.Drawing.Point(218, 13);
            this.lblDica.Name = "lblDica";
            this.lblDica.Size = new System.Drawing.Size(607, 31);
            this.lblDica.TabIndex = 10;
            this.lblDica.Text = "DICA";
            this.lblDica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(834, 637);
            this.Controls.Add(this.lblDica);
            this.Controls.Add(this.btnNovoJogo);
            this.Controls.Add(this.pbMorcego2);
            this.Controls.Add(this.pbMorcego);
            this.Controls.Add(this.lbCronometro);
            this.Controls.Add(this.pbEnforcado);
            this.Controls.Add(this.pbForca);
            this.Controls.Add(this.lblLetrasDigitadas);
            this.Controls.Add(this.pnPalavraSecreta);
            this.Controls.Add(this.pnLetra);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JOGO DA FORCA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnLetra.ResumeLayout(false);
            this.pnLetra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbForca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnforcado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMorcego)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMorcego2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnLetra;
        private System.Windows.Forms.TextBox txtLetra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnPalavraSecreta;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Label lblLetrasDigitadas;
        private System.Windows.Forms.PictureBox pbForca;
        private System.Windows.Forms.PictureBox pbEnforcado;
        private System.Windows.Forms.Label lbCronometro;
        private System.Windows.Forms.Timer Temporizador;
        private System.Windows.Forms.PictureBox pbMorcego;
        private System.Windows.Forms.PictureBox pbMorcego2;
        private System.Windows.Forms.Button btnNovoJogo;
        private System.Windows.Forms.Label lblDica;
    }
}

