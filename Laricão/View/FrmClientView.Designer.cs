namespace Laricão.View
{
    partial class FrmClientView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbledit = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btncancel = new Guna.UI.WinForms.GunaButton();
            this.btnedit = new Guna.UI.WinForms.GunaButton();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtnome = new Guna.UI.WinForms.GunaTextBox();
            this.txtsobre = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtcpf = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txttel = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.txtemail = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.cbperfil = new Guna.UI.WinForms.GunaComboBox();
            this.txtsenha = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.txtsenha1 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.lbledit);
            this.panel1.Controls.Add(this.gunaPictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 74);
            this.panel1.TabIndex = 0;
            // 
            // lbledit
            // 
            this.lbledit.AutoSize = true;
            this.lbledit.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lbledit.ForeColor = System.Drawing.Color.White;
            this.lbledit.Location = new System.Drawing.Point(112, 24);
            this.lbledit.Name = "lbledit";
            this.lbledit.Size = new System.Drawing.Size(81, 32);
            this.lbledit.TabIndex = 1;
            this.lbledit.Text = "Editar";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::Laricão.Properties.Resources.local_na_rede_internet1;
            this.gunaPictureBox1.Location = new System.Drawing.Point(3, 3);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(81, 68);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.btncancel);
            this.panel2.Controls.Add(this.btnedit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 380);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(645, 62);
            this.panel2.TabIndex = 1;
            // 
            // btncancel
            // 
            this.btncancel.AnimationHoverSpeed = 0.07F;
            this.btncancel.AnimationSpeed = 0.03F;
            this.btncancel.BackColor = System.Drawing.Color.Transparent;
            this.btncancel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btncancel.BorderColor = System.Drawing.Color.Black;
            this.btncancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btncancel.FocusedColor = System.Drawing.Color.Empty;
            this.btncancel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btncancel.ForeColor = System.Drawing.Color.White;
            this.btncancel.Image = null;
            this.btncancel.ImageSize = new System.Drawing.Size(20, 20);
            this.btncancel.Location = new System.Drawing.Point(473, 8);
            this.btncancel.Name = "btncancel";
            this.btncancel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btncancel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btncancel.OnHoverForeColor = System.Drawing.Color.White;
            this.btncancel.OnHoverImage = null;
            this.btncancel.OnPressedColor = System.Drawing.Color.Black;
            this.btncancel.Radius = 15;
            this.btncancel.Size = new System.Drawing.Size(160, 42);
            this.btncancel.TabIndex = 1;
            this.btncancel.Text = "Cancelar";
            this.btncancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnedit
            // 
            this.btnedit.AnimationHoverSpeed = 0.07F;
            this.btnedit.AnimationSpeed = 0.03F;
            this.btnedit.BackColor = System.Drawing.Color.Transparent;
            this.btnedit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnedit.BorderColor = System.Drawing.Color.Black;
            this.btnedit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnedit.FocusedColor = System.Drawing.Color.Empty;
            this.btnedit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnedit.ForeColor = System.Drawing.Color.White;
            this.btnedit.Image = null;
            this.btnedit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnedit.Location = new System.Drawing.Point(307, 8);
            this.btnedit.Name = "btnedit";
            this.btnedit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnedit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnedit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnedit.OnHoverImage = null;
            this.btnedit.OnPressedColor = System.Drawing.Color.Black;
            this.btnedit.Radius = 15;
            this.btnedit.Size = new System.Drawing.Size(160, 42);
            this.btnedit.TabIndex = 0;
            this.btnedit.Text = "Editar";
            this.btnedit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.FillWeight = 309.1371F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Laricão.Properties.Resources.cardapio;
            this.dataGridViewImageColumn1.MinimumWidth = 70;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 70;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn2.FillWeight = 70F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Laricão.Properties.Resources.login;
            this.dataGridViewImageColumn2.MinimumWidth = 70;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 70;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(37, 107);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(48, 15);
            this.gunaLabel1.TabIndex = 2;
            this.gunaLabel1.Text = "Nome *";
            // 
            // txtnome
            // 
            this.txtnome.BaseColor = System.Drawing.Color.White;
            this.txtnome.BorderColor = System.Drawing.Color.Silver;
            this.txtnome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnome.FocusedBaseColor = System.Drawing.Color.White;
            this.txtnome.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtnome.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtnome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtnome.Location = new System.Drawing.Point(40, 125);
            this.txtnome.Name = "txtnome";
            this.txtnome.PasswordChar = '\0';
            this.txtnome.SelectedText = "";
            this.txtnome.Size = new System.Drawing.Size(209, 30);
            this.txtnome.TabIndex = 0;
            // 
            // txtsobre
            // 
            this.txtsobre.BaseColor = System.Drawing.Color.White;
            this.txtsobre.BorderColor = System.Drawing.Color.Silver;
            this.txtsobre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsobre.FocusedBaseColor = System.Drawing.Color.White;
            this.txtsobre.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtsobre.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtsobre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtsobre.Location = new System.Drawing.Point(40, 188);
            this.txtsobre.Name = "txtsobre";
            this.txtsobre.PasswordChar = '\0';
            this.txtsobre.SelectedText = "";
            this.txtsobre.Size = new System.Drawing.Size(209, 30);
            this.txtsobre.TabIndex = 1;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(37, 171);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(76, 15);
            this.gunaLabel2.TabIndex = 4;
            this.gunaLabel2.Text = "Sobrenome *";
            // 
            // txtcpf
            // 
            this.txtcpf.BaseColor = System.Drawing.Color.White;
            this.txtcpf.BorderColor = System.Drawing.Color.Silver;
            this.txtcpf.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcpf.FocusedBaseColor = System.Drawing.Color.White;
            this.txtcpf.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtcpf.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtcpf.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtcpf.Location = new System.Drawing.Point(40, 259);
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.PasswordChar = '\0';
            this.txtcpf.SelectedText = "";
            this.txtcpf.Size = new System.Drawing.Size(209, 30);
            this.txtcpf.TabIndex = 2;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(37, 241);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(36, 15);
            this.gunaLabel3.TabIndex = 6;
            this.gunaLabel3.Text = "CPF *";
            // 
            // txttel
            // 
            this.txttel.BaseColor = System.Drawing.Color.White;
            this.txttel.BorderColor = System.Drawing.Color.Silver;
            this.txttel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttel.FocusedBaseColor = System.Drawing.Color.White;
            this.txttel.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txttel.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txttel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txttel.Location = new System.Drawing.Point(40, 320);
            this.txttel.Name = "txttel";
            this.txttel.PasswordChar = '\0';
            this.txttel.SelectedText = "";
            this.txttel.Size = new System.Drawing.Size(209, 30);
            this.txttel.TabIndex = 3;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(37, 302);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(59, 15);
            this.gunaLabel4.TabIndex = 8;
            this.gunaLabel4.Text = "Telefone *";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(384, 111);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(42, 15);
            this.gunaLabel5.TabIndex = 10;
            this.gunaLabel5.Text = "Perfil *";
            // 
            // txtemail
            // 
            this.txtemail.BaseColor = System.Drawing.Color.White;
            this.txtemail.BorderColor = System.Drawing.Color.Silver;
            this.txtemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtemail.FocusedBaseColor = System.Drawing.Color.White;
            this.txtemail.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtemail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtemail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtemail.Location = new System.Drawing.Point(387, 188);
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '\0';
            this.txtemail.SelectedText = "";
            this.txtemail.Size = new System.Drawing.Size(209, 30);
            this.txtemail.TabIndex = 5;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel6.Location = new System.Drawing.Point(384, 170);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(49, 15);
            this.gunaLabel6.TabIndex = 12;
            this.gunaLabel6.Text = "E-mail *";
            // 
            // cbperfil
            // 
            this.cbperfil.BackColor = System.Drawing.Color.Transparent;
            this.cbperfil.BaseColor = System.Drawing.Color.White;
            this.cbperfil.BorderColor = System.Drawing.Color.Silver;
            this.cbperfil.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbperfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbperfil.FocusedColor = System.Drawing.Color.Empty;
            this.cbperfil.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbperfil.ForeColor = System.Drawing.Color.Black;
            this.cbperfil.FormattingEnabled = true;
            this.cbperfil.Items.AddRange(new object[] {
            "Usuario",
            "Administrador"});
            this.cbperfil.Location = new System.Drawing.Point(387, 129);
            this.cbperfil.Name = "cbperfil";
            this.cbperfil.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbperfil.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbperfil.Size = new System.Drawing.Size(209, 26);
            this.cbperfil.TabIndex = 4;
            // 
            // txtsenha
            // 
            this.txtsenha.BaseColor = System.Drawing.Color.White;
            this.txtsenha.BorderColor = System.Drawing.Color.Silver;
            this.txtsenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsenha.FocusedBaseColor = System.Drawing.Color.White;
            this.txtsenha.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtsenha.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtsenha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtsenha.Location = new System.Drawing.Point(387, 259);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '●';
            this.txtsenha.SelectedText = "";
            this.txtsenha.Size = new System.Drawing.Size(209, 30);
            this.txtsenha.TabIndex = 13;
            this.txtsenha.UseSystemPasswordChar = true;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel7.Location = new System.Drawing.Point(384, 241);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(39, 15);
            this.gunaLabel7.TabIndex = 14;
            this.gunaLabel7.Text = "Senha";
            // 
            // txtsenha1
            // 
            this.txtsenha1.BaseColor = System.Drawing.Color.White;
            this.txtsenha1.BorderColor = System.Drawing.Color.Silver;
            this.txtsenha1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsenha1.FocusedBaseColor = System.Drawing.Color.White;
            this.txtsenha1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtsenha1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtsenha1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtsenha1.Location = new System.Drawing.Point(387, 320);
            this.txtsenha1.Name = "txtsenha1";
            this.txtsenha1.PasswordChar = '*';
            this.txtsenha1.SelectedText = "";
            this.txtsenha1.Size = new System.Drawing.Size(209, 30);
            this.txtsenha1.TabIndex = 15;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel8.Location = new System.Drawing.Point(384, 302);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(99, 15);
            this.gunaLabel8.TabIndex = 16;
            this.gunaLabel8.Text = " Repita sua Senha";
            // 
            // FrmClientView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 442);
            this.Controls.Add(this.txtsenha1);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.cbperfil);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.txtcpf);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.txtsobre);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmClientView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmClientView";
            this.Load += new System.EventHandler(this.FrmClientView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLabel lbledit;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        public Guna.UI.WinForms.GunaTextBox txtsobre;
        public Guna.UI.WinForms.GunaComboBox cbperfil;
        public Guna.UI.WinForms.GunaTextBox txtnome;
        public Guna.UI.WinForms.GunaTextBox txtcpf;
        public Guna.UI.WinForms.GunaTextBox txttel;
        public Guna.UI.WinForms.GunaTextBox txtemail;
        private Guna.UI.WinForms.GunaButton btncancel;
        private Guna.UI.WinForms.GunaButton btnedit;
        public Guna.UI.WinForms.GunaTextBox txtsenha;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        public Guna.UI.WinForms.GunaTextBox txtsenha1;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
    }
}