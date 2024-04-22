namespace LaricãoHamburgueria
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btn_logar = new Guna.UI.WinForms.GunaButton();
            this.btnRec = new Guna.UI.WinForms.GunaButton();
            this.btnCad = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtLogin = new Guna.UI.WinForms.GunaTextBox();
            this.txtSenha = new Guna.UI.WinForms.GunaTextBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.ctlClose = new Guna.UI.WinForms.GunaControlBox();
            this.lblhelp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_logar
            // 
            this.btn_logar.AnimationHoverSpeed = 0.07F;
            this.btn_logar.AnimationSpeed = 0.03F;
            this.btn_logar.BackColor = System.Drawing.Color.Transparent;
            this.btn_logar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_logar.BorderColor = System.Drawing.Color.Black;
            this.btn_logar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_logar.FocusedColor = System.Drawing.Color.Empty;
            this.btn_logar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_logar.ForeColor = System.Drawing.Color.White;
            this.btn_logar.Image = null;
            this.btn_logar.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_logar.Location = new System.Drawing.Point(695, 298);
            this.btn_logar.Name = "btn_logar";
            this.btn_logar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_logar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_logar.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_logar.OnHoverImage = null;
            this.btn_logar.OnPressedColor = System.Drawing.Color.Black;
            this.btn_logar.Radius = 5;
            this.btn_logar.Size = new System.Drawing.Size(160, 31);
            this.btn_logar.TabIndex = 3;
            this.btn_logar.Text = "Entrar";
            this.btn_logar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_logar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // btnRec
            // 
            this.btnRec.AnimationHoverSpeed = 0.07F;
            this.btnRec.AnimationSpeed = 0.03F;
            this.btnRec.BackColor = System.Drawing.Color.Transparent;
            this.btnRec.BaseColor = System.Drawing.Color.White;
            this.btnRec.BorderColor = System.Drawing.Color.Black;
            this.btnRec.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRec.FocusedColor = System.Drawing.Color.Empty;
            this.btnRec.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnRec.Image = null;
            this.btnRec.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRec.Location = new System.Drawing.Point(695, 372);
            this.btnRec.Name = "btnRec";
            this.btnRec.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnRec.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRec.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRec.OnHoverImage = null;
            this.btnRec.OnPressedColor = System.Drawing.Color.Black;
            this.btnRec.Radius = 5;
            this.btnRec.Size = new System.Drawing.Size(160, 31);
            this.btnRec.TabIndex = 0;
            this.btnRec.Text = "Recuperar senha";
            this.btnRec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRec.Click += new System.EventHandler(this.btnRec_Click);
            // 
            // btnCad
            // 
            this.btnCad.AnimationHoverSpeed = 0.07F;
            this.btnCad.AnimationSpeed = 0.03F;
            this.btnCad.BackColor = System.Drawing.Color.Transparent;
            this.btnCad.BaseColor = System.Drawing.Color.White;
            this.btnCad.BorderColor = System.Drawing.Color.Black;
            this.btnCad.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCad.FocusedColor = System.Drawing.Color.Empty;
            this.btnCad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnCad.Image = null;
            this.btnCad.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCad.Location = new System.Drawing.Point(695, 335);
            this.btnCad.Name = "btnCad";
            this.btnCad.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnCad.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCad.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCad.OnHoverImage = null;
            this.btnCad.OnPressedColor = System.Drawing.Color.Black;
            this.btnCad.Radius = 5;
            this.btnCad.Size = new System.Drawing.Size(160, 31);
            this.btnCad.TabIndex = 12;
            this.btnCad.Text = "Cadastrar-se";
            this.btnCad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaLabel1.Location = new System.Drawing.Point(633, 29);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(51, 30);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Olá!";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaLabel3.Location = new System.Drawing.Point(633, 59);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(118, 30);
            this.gunaLabel3.TabIndex = 16;
            this.gunaLabel3.Text = "Bem-vindo";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaLabel2.Location = new System.Drawing.Point(690, 146);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(147, 30);
            this.gunaLabel2.TabIndex = 17;
            this.gunaLabel2.Text = "Faça seu login";
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.Transparent;
            this.txtLogin.BaseColor = System.Drawing.Color.Silver;
            this.txtLogin.BorderColor = System.Drawing.Color.Transparent;
            this.txtLogin.BorderSize = 0;
            this.txtLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLogin.FocusedBaseColor = System.Drawing.Color.White;
            this.txtLogin.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtLogin.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLogin.Location = new System.Drawing.Point(695, 208);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.PasswordChar = '\0';
            this.txtLogin.Radius = 15;
            this.txtLogin.SelectedText = "";
            this.txtLogin.Size = new System.Drawing.Size(160, 30);
            this.txtLogin.TabIndex = 1;
            this.txtLogin.Text = "Login";
            this.txtLogin.Enter += new System.EventHandler(this.Login_Enter);
            this.txtLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLogin_KeyDown);
            this.txtLogin.Leave += new System.EventHandler(this.Login_Leave);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.Transparent;
            this.txtSenha.BaseColor = System.Drawing.Color.Silver;
            this.txtSenha.BorderColor = System.Drawing.Color.Transparent;
            this.txtSenha.BorderSize = 0;
            this.txtSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSenha.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSenha.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSenha.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSenha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSenha.Location = new System.Drawing.Point(695, 244);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Radius = 15;
            this.txtSenha.SelectedText = "";
            this.txtSenha.Size = new System.Drawing.Size(160, 30);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.Text = "Senha";
            this.txtSenha.Enter += new System.EventHandler(this.Senha_Enter);
            this.txtSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLogin_KeyDown);
            this.txtSenha.Leave += new System.EventHandler(this.Senha_Leave);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::Laricão.Properties.Resources.LARICÃO__1_;
            this.gunaPictureBox1.Location = new System.Drawing.Point(-3, -1);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(610, 569);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 20;
            this.gunaPictureBox1.TabStop = false;
            // 
            // ctlClose
            // 
            this.ctlClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlClose.AnimationHoverSpeed = 0.07F;
            this.ctlClose.AnimationSpeed = 0.03F;
            this.ctlClose.IconColor = System.Drawing.Color.Black;
            this.ctlClose.IconSize = 15F;
            this.ctlClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ctlClose.Location = new System.Drawing.Point(902, -1);
            this.ctlClose.Name = "ctlClose";
            this.ctlClose.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.ctlClose.OnHoverIconColor = System.Drawing.Color.White;
            this.ctlClose.OnPressedColor = System.Drawing.Color.Black;
            this.ctlClose.Size = new System.Drawing.Size(45, 29);
            this.ctlClose.TabIndex = 21;
            this.ctlClose.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblhelp
            // 
            this.lblhelp.AutoSize = true;
            this.lblhelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.lblhelp.Location = new System.Drawing.Point(741, 503);
            this.lblhelp.Name = "lblhelp";
            this.lblhelp.Size = new System.Drawing.Size(96, 13);
            this.lblhelp.TabIndex = 22;
            this.lblhelp.Text = "Precisa de Ajuda ?";
            this.lblhelp.Click += new System.EventHandler(this.Ajuda);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(947, 548);
            this.Controls.Add(this.lblhelp);
            this.Controls.Add(this.ctlClose);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.btnCad);
            this.Controls.Add(this.btnRec);
            this.Controls.Add(this.btn_logar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaButton btn_logar;
        private Guna.UI.WinForms.GunaButton btnRec;
        private Guna.UI.WinForms.GunaButton btnCad;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaTextBox txtLogin;
        private Guna.UI.WinForms.GunaTextBox txtSenha;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaControlBox ctlClose;
        private System.Windows.Forms.Label lblhelp;
    }
}

