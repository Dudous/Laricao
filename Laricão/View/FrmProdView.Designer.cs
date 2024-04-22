namespace Laricão.View
{
    partial class FrmProdView
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnSalvar = new Guna.UI.WinForms.GunaButton();
            this.BtnCancelar = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.lblfoto = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.ptbfoto = new System.Windows.Forms.PictureBox();
            this.txtNome = new Guna.UI.WinForms.GunaTextBox();
            this.txtpreco = new Guna.UI.WinForms.GunaTextBox();
            this.cbctg = new Guna.UI.WinForms.GunaComboBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbfoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 78;
            this.label3.Text = "Preço:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 77;
            this.label4.Text = "Categoria:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 76;
            this.label7.Text = "Nome:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.BtnSalvar);
            this.panel2.Controls.Add(this.BtnCancelar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 306);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(603, 61);
            this.panel2.TabIndex = 72;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.AnimationHoverSpeed = 0.07F;
            this.BtnSalvar.AnimationSpeed = 0.03F;
            this.BtnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.BtnSalvar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BtnSalvar.BorderColor = System.Drawing.Color.Black;
            this.BtnSalvar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnSalvar.FocusedColor = System.Drawing.Color.Empty;
            this.BtnSalvar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnSalvar.ForeColor = System.Drawing.Color.White;
            this.BtnSalvar.Image = null;
            this.BtnSalvar.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnSalvar.Location = new System.Drawing.Point(299, 7);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnSalvar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnSalvar.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnSalvar.OnHoverImage = null;
            this.BtnSalvar.OnPressedColor = System.Drawing.Color.Black;
            this.BtnSalvar.Radius = 15;
            this.BtnSalvar.Size = new System.Drawing.Size(138, 42);
            this.BtnSalvar.TabIndex = 0;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.AnimationHoverSpeed = 0.07F;
            this.BtnCancelar.AnimationSpeed = 0.03F;
            this.BtnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.BtnCancelar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BtnCancelar.BorderColor = System.Drawing.Color.Black;
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnCancelar.FocusedColor = System.Drawing.Color.Empty;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Image = null;
            this.BtnCancelar.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnCancelar.Location = new System.Drawing.Point(443, 7);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnCancelar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnCancelar.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnCancelar.OnHoverImage = null;
            this.BtnCancelar.OnPressedColor = System.Drawing.Color.Black;
            this.BtnCancelar.Radius = 15;
            this.BtnCancelar.Size = new System.Drawing.Size(138, 42);
            this.BtnCancelar.TabIndex = 1;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(118, 31);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(0, 15);
            this.gunaLabel1.TabIndex = 1;
            // 
            // lblfoto
            // 
            this.lblfoto.AutoSize = true;
            this.lblfoto.Location = new System.Drawing.Point(424, 262);
            this.lblfoto.Name = "lblfoto";
            this.lblfoto.Size = new System.Drawing.Size(35, 13);
            this.lblfoto.TabIndex = 79;
            this.lblfoto.Text = "lblfoto";
            this.lblfoto.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Controls.Add(this.gunaPictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 77);
            this.panel1.TabIndex = 71;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::Laricão.Properties.Resources.local_na_rede_internet;
            this.gunaPictureBox1.Location = new System.Drawing.Point(12, 3);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(88, 71);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            // 
            // ptbfoto
            // 
            this.ptbfoto.Location = new System.Drawing.Point(344, 94);
            this.ptbfoto.Margin = new System.Windows.Forms.Padding(0);
            this.ptbfoto.Name = "ptbfoto";
            this.ptbfoto.Size = new System.Drawing.Size(212, 158);
            this.ptbfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbfoto.TabIndex = 80;
            this.ptbfoto.TabStop = false;
            this.ptbfoto.Click += new System.EventHandler(this.AlterarImg);
            // 
            // txtNome
            // 
            this.txtNome.BaseColor = System.Drawing.Color.White;
            this.txtNome.BorderColor = System.Drawing.Color.Silver;
            this.txtNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNome.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNome.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNome.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNome.Location = new System.Drawing.Point(107, 103);
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.SelectedText = "";
            this.txtNome.Size = new System.Drawing.Size(160, 30);
            this.txtNome.TabIndex = 0;
            // 
            // txtpreco
            // 
            this.txtpreco.BaseColor = System.Drawing.Color.White;
            this.txtpreco.BorderColor = System.Drawing.Color.Silver;
            this.txtpreco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpreco.FocusedBaseColor = System.Drawing.Color.White;
            this.txtpreco.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtpreco.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtpreco.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtpreco.Location = new System.Drawing.Point(107, 164);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.PasswordChar = '\0';
            this.txtpreco.SelectedText = "";
            this.txtpreco.Size = new System.Drawing.Size(160, 30);
            this.txtpreco.TabIndex = 1;
            // 
            // cbctg
            // 
            this.cbctg.BackColor = System.Drawing.Color.Transparent;
            this.cbctg.BaseColor = System.Drawing.Color.White;
            this.cbctg.BorderColor = System.Drawing.Color.Silver;
            this.cbctg.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbctg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbctg.FocusedColor = System.Drawing.Color.Empty;
            this.cbctg.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbctg.ForeColor = System.Drawing.Color.Black;
            this.cbctg.FormattingEnabled = true;
            this.cbctg.Items.AddRange(new object[] {
            "Hamburguer",
            "Bebidas",
            "Porções",
            "Sobremesas"});
            this.cbctg.Location = new System.Drawing.Point(107, 226);
            this.cbctg.Name = "cbctg";
            this.cbctg.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbctg.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbctg.Size = new System.Drawing.Size(160, 26);
            this.cbctg.TabIndex = 2;
            // 
            // FrmProdView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 367);
            this.Controls.Add(this.cbctg);
            this.Controls.Add(this.txtpreco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ptbfoto);
            this.Controls.Add(this.lblfoto);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProdView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmProdView";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbfoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaButton BtnSalvar;
        private Guna.UI.WinForms.GunaButton BtnCancelar;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        public System.Windows.Forms.PictureBox ptbfoto;
        public System.Windows.Forms.Label lblfoto;
        public Guna.UI.WinForms.GunaTextBox txtNome;
        public Guna.UI.WinForms.GunaTextBox txtpreco;
        public Guna.UI.WinForms.GunaComboBox cbctg;
    }
}