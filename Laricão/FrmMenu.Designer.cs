namespace Laricão
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogoff = new Guna.UI.WinForms.GunaImageButton();
            this.BtnProdutos = new Guna.UI.WinForms.GunaButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHome = new Guna.UI.WinForms.GunaButton();
            this.btnCardapio = new Guna.UI.WinForms.GunaButton();
            this.btnClientes = new Guna.UI.WinForms.GunaButton();
            this.btnPedidos = new Guna.UI.WinForms.GunaButton();
            this.btnCarrinho = new Guna.UI.WinForms.GunaButton();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.CenterPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.ctlClose = new Guna.UI.WinForms.GunaControlBox();
            this.ctlMin = new Guna.UI.WinForms.GunaControlBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.lblhelp = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.CenterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel2.Controls.Add(this.lblhelp);
            this.panel2.Controls.Add(this.btnLogoff);
            this.panel2.Controls.Add(this.BtnProdutos);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Controls.Add(this.btnCardapio);
            this.panel2.Controls.Add(this.btnClientes);
            this.panel2.Controls.Add(this.btnPedidos);
            this.panel2.Controls.Add(this.btnCarrinho);
            this.panel2.Controls.Add(this.gunaPictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 835);
            this.panel2.TabIndex = 1;
            // 
            // btnLogoff
            // 
            this.btnLogoff.BackgroundImage = global::Laricão.Properties.Resources.desligar;
            this.btnLogoff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogoff.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogoff.Image = null;
            this.btnLogoff.ImageSize = new System.Drawing.Size(64, 64);
            this.btnLogoff.Location = new System.Drawing.Point(62, 784);
            this.btnLogoff.Name = "btnLogoff";
            this.btnLogoff.OnHoverImage = null;
            this.btnLogoff.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnLogoff.Size = new System.Drawing.Size(69, 39);
            this.btnLogoff.TabIndex = 14;
            this.btnLogoff.Click += new System.EventHandler(this.btnLogoff_Click);
            // 
            // BtnProdutos
            // 
            this.BtnProdutos.AnimationHoverSpeed = 0.07F;
            this.BtnProdutos.AnimationSpeed = 0.03F;
            this.BtnProdutos.BackColor = System.Drawing.Color.Transparent;
            this.BtnProdutos.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BtnProdutos.BorderColor = System.Drawing.Color.Black;
            this.BtnProdutos.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnProdutos.FocusedColor = System.Drawing.Color.Empty;
            this.BtnProdutos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnProdutos.ForeColor = System.Drawing.Color.White;
            this.BtnProdutos.Image = ((System.Drawing.Image)(resources.GetObject("BtnProdutos.Image")));
            this.BtnProdutos.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnProdutos.Location = new System.Drawing.Point(24, 558);
            this.BtnProdutos.Name = "BtnProdutos";
            this.BtnProdutos.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnProdutos.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnProdutos.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnProdutos.OnHoverImage = null;
            this.BtnProdutos.OnPressedColor = System.Drawing.Color.Black;
            this.BtnProdutos.Radius = 20;
            this.BtnProdutos.Size = new System.Drawing.Size(211, 42);
            this.BtnProdutos.TabIndex = 13;
            this.BtnProdutos.Text = "Produtos";
            this.BtnProdutos.Click += new System.EventHandler(this.BtnProdutos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Hamburgueria";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Laricão";
            // 
            // btnHome
            // 
            this.btnHome.AnimationHoverSpeed = 0.07F;
            this.btnHome.AnimationSpeed = 0.03F;
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnHome.BorderColor = System.Drawing.Color.Black;
            this.btnHome.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHome.FocusedColor = System.Drawing.Color.Empty;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageSize = new System.Drawing.Size(20, 20);
            this.btnHome.Location = new System.Drawing.Point(24, 264);
            this.btnHome.Name = "btnHome";
            this.btnHome.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnHome.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnHome.OnHoverForeColor = System.Drawing.Color.White;
            this.btnHome.OnHoverImage = null;
            this.btnHome.OnPressedColor = System.Drawing.Color.Black;
            this.btnHome.Radius = 20;
            this.btnHome.Size = new System.Drawing.Size(211, 42);
            this.btnHome.TabIndex = 10;
            this.btnHome.Text = "Home";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnCardapio
            // 
            this.btnCardapio.AnimationHoverSpeed = 0.07F;
            this.btnCardapio.AnimationSpeed = 0.03F;
            this.btnCardapio.BackColor = System.Drawing.Color.Transparent;
            this.btnCardapio.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnCardapio.BorderColor = System.Drawing.Color.Black;
            this.btnCardapio.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCardapio.FocusedColor = System.Drawing.Color.Empty;
            this.btnCardapio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCardapio.ForeColor = System.Drawing.Color.White;
            this.btnCardapio.Image = ((System.Drawing.Image)(resources.GetObject("btnCardapio.Image")));
            this.btnCardapio.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCardapio.Location = new System.Drawing.Point(24, 322);
            this.btnCardapio.Name = "btnCardapio";
            this.btnCardapio.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnCardapio.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCardapio.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCardapio.OnHoverImage = null;
            this.btnCardapio.OnPressedColor = System.Drawing.Color.Black;
            this.btnCardapio.Radius = 20;
            this.btnCardapio.Size = new System.Drawing.Size(211, 42);
            this.btnCardapio.TabIndex = 9;
            this.btnCardapio.Text = "Cardapio";
            this.btnCardapio.Click += new System.EventHandler(this.btnCardapio_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.AnimationHoverSpeed = 0.07F;
            this.btnClientes.AnimationSpeed = 0.03F;
            this.btnClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnClientes.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnClientes.BorderColor = System.Drawing.Color.Black;
            this.btnClientes.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClientes.FocusedColor = System.Drawing.Color.Empty;
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClientes.Location = new System.Drawing.Point(24, 499);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnClientes.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClientes.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClientes.OnHoverImage = null;
            this.btnClientes.OnPressedColor = System.Drawing.Color.Black;
            this.btnClientes.Radius = 20;
            this.btnClientes.Size = new System.Drawing.Size(211, 42);
            this.btnClientes.TabIndex = 8;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.AnimationHoverSpeed = 0.07F;
            this.btnPedidos.AnimationSpeed = 0.03F;
            this.btnPedidos.BackColor = System.Drawing.Color.Transparent;
            this.btnPedidos.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnPedidos.BorderColor = System.Drawing.Color.Black;
            this.btnPedidos.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPedidos.FocusedColor = System.Drawing.Color.Empty;
            this.btnPedidos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPedidos.ForeColor = System.Drawing.Color.White;
            this.btnPedidos.Image = ((System.Drawing.Image)(resources.GetObject("btnPedidos.Image")));
            this.btnPedidos.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPedidos.Location = new System.Drawing.Point(24, 439);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnPedidos.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPedidos.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPedidos.OnHoverImage = null;
            this.btnPedidos.OnPressedColor = System.Drawing.Color.Black;
            this.btnPedidos.Radius = 20;
            this.btnPedidos.Size = new System.Drawing.Size(211, 42);
            this.btnPedidos.TabIndex = 7;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnCarrinho
            // 
            this.btnCarrinho.AnimationHoverSpeed = 0.07F;
            this.btnCarrinho.AnimationSpeed = 0.03F;
            this.btnCarrinho.BackColor = System.Drawing.Color.Transparent;
            this.btnCarrinho.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnCarrinho.BorderColor = System.Drawing.Color.Black;
            this.btnCarrinho.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCarrinho.FocusedColor = System.Drawing.Color.Empty;
            this.btnCarrinho.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCarrinho.ForeColor = System.Drawing.Color.White;
            this.btnCarrinho.Image = ((System.Drawing.Image)(resources.GetObject("btnCarrinho.Image")));
            this.btnCarrinho.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCarrinho.Location = new System.Drawing.Point(24, 381);
            this.btnCarrinho.Name = "btnCarrinho";
            this.btnCarrinho.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnCarrinho.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCarrinho.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCarrinho.OnHoverImage = null;
            this.btnCarrinho.OnPressedColor = System.Drawing.Color.Black;
            this.btnCarrinho.Radius = 20;
            this.btnCarrinho.Size = new System.Drawing.Size(211, 42);
            this.btnCarrinho.TabIndex = 6;
            this.btnCarrinho.Text = "Carrinho";
            this.btnCarrinho.Click += new System.EventHandler(this.btnCarrinho_Click);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::Laricão.Properties.Resources.LARICÃO2;
            this.gunaPictureBox1.Location = new System.Drawing.Point(40, 26);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Radius = 5;
            this.gunaPictureBox1.Size = new System.Drawing.Size(135, 120);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 4;
            this.gunaPictureBox1.TabStop = false;
            // 
            // CenterPanel
            // 
            this.CenterPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CenterPanel.Controls.Add(this.label3);
            this.CenterPanel.Controls.Add(this.gunaPictureBox2);
            this.CenterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterPanel.Location = new System.Drawing.Point(215, 65);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(1225, 835);
            this.CenterPanel.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(433, 601);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Faça seus pedidos agora";
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = global::Laricão.Properties.Resources.feliz;
            this.gunaPictureBox2.Location = new System.Drawing.Point(323, 197);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(476, 401);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox2.TabIndex = 0;
            this.gunaPictureBox2.TabStop = false;
            // 
            // ctlClose
            // 
            this.ctlClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlClose.AnimationHoverSpeed = 0.07F;
            this.ctlClose.AnimationSpeed = 0.03F;
            this.ctlClose.IconColor = System.Drawing.Color.White;
            this.ctlClose.IconSize = 15F;
            this.ctlClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ctlClose.Location = new System.Drawing.Point(1383, 12);
            this.ctlClose.Name = "ctlClose";
            this.ctlClose.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.ctlClose.OnHoverIconColor = System.Drawing.Color.White;
            this.ctlClose.OnPressedColor = System.Drawing.Color.Black;
            this.ctlClose.Size = new System.Drawing.Size(45, 29);
            this.ctlClose.TabIndex = 3;
            this.ctlClose.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // ctlMin
            // 
            this.ctlMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlMin.AnimationHoverSpeed = 0.07F;
            this.ctlMin.AnimationSpeed = 0.03F;
            this.ctlMin.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox;
            this.ctlMin.IconColor = System.Drawing.Color.White;
            this.ctlMin.IconSize = 15F;
            this.ctlMin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ctlMin.Location = new System.Drawing.Point(1332, 12);
            this.ctlMin.Name = "ctlMin";
            this.ctlMin.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.ctlMin.OnHoverIconColor = System.Drawing.Color.White;
            this.ctlMin.OnPressedColor = System.Drawing.Color.Black;
            this.ctlMin.Size = new System.Drawing.Size(45, 29);
            this.ctlMin.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.ctlMin);
            this.panel1.Controls.Add(this.ctlClose);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1440, 65);
            this.panel1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.Enabled = false;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(1440, 62);
            this.button4.TabIndex = 2;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // lblhelp
            // 
            this.lblhelp.AutoSize = true;
            this.lblhelp.ForeColor = System.Drawing.Color.White;
            this.lblhelp.Location = new System.Drawing.Point(59, 712);
            this.lblhelp.Name = "lblhelp";
            this.lblhelp.Size = new System.Drawing.Size(96, 13);
            this.lblhelp.TabIndex = 23;
            this.lblhelp.Text = "Precisa de Ajuda ?";
            this.lblhelp.Click += new System.EventHandler(this.Ajuda);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1440, 900);
            this.Controls.Add(this.CenterPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.CenterPanel.ResumeLayout(false);
            this.CenterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel CenterPanel;
        private System.Windows.Forms.Button button4;
        private Guna.UI.WinForms.GunaControlBox ctlClose;
        private Guna.UI.WinForms.GunaControlBox ctlMin;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaButton btnCarrinho;
        private Guna.UI.WinForms.GunaButton btnClientes;
        private Guna.UI.WinForms.GunaButton btnPedidos;
        private Guna.UI.WinForms.GunaButton btnCardapio;
        private Guna.UI.WinForms.GunaButton btnHome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaButton BtnProdutos;
        private Guna.UI.WinForms.GunaImageButton btnLogoff;
        private System.Windows.Forms.Label lblhelp;
    }
}