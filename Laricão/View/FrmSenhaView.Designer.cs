namespace Laricão
{
    partial class FrmSenhaView
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
            this.btncancel = new Guna.UI.WinForms.GunaButton();
            this.btnok = new Guna.UI.WinForms.GunaButton();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.btncancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btncancel.ForeColor = System.Drawing.Color.White;
            this.btncancel.Image = null;
            this.btncancel.ImageSize = new System.Drawing.Size(20, 20);
            this.btncancel.Location = new System.Drawing.Point(134, 8);
            this.btncancel.Name = "btncancel";
            this.btncancel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btncancel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btncancel.OnHoverForeColor = System.Drawing.Color.White;
            this.btncancel.OnHoverImage = null;
            this.btncancel.OnPressedColor = System.Drawing.Color.Black;
            this.btncancel.Size = new System.Drawing.Size(83, 32);
            this.btncancel.TabIndex = 1;
            this.btncancel.Text = "Cancelar";
            this.btncancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnok
            // 
            this.btnok.AnimationHoverSpeed = 0.07F;
            this.btnok.AnimationSpeed = 0.03F;
            this.btnok.BackColor = System.Drawing.Color.Transparent;
            this.btnok.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnok.BorderColor = System.Drawing.Color.Black;
            this.btnok.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnok.FocusedColor = System.Drawing.Color.Empty;
            this.btnok.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnok.ForeColor = System.Drawing.Color.White;
            this.btnok.Image = null;
            this.btnok.ImageSize = new System.Drawing.Size(20, 20);
            this.btnok.Location = new System.Drawing.Point(223, 8);
            this.btnok.Name = "btnok";
            this.btnok.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnok.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnok.OnHoverForeColor = System.Drawing.Color.White;
            this.btnok.OnHoverImage = null;
            this.btnok.OnPressedColor = System.Drawing.Color.Black;
            this.btnok.Size = new System.Drawing.Size(81, 32);
            this.btnok.TabIndex = 0;
            this.btnok.Text = "OK";
            this.btnok.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBox1.BaseColor = System.Drawing.Color.Silver;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox1.BorderSize = 0;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.Silver;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox1.Location = new System.Drawing.Point(108, 57);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '●';
            this.gunaTextBox1.Radius = 15;
            this.gunaTextBox1.SelectedText = "";
            this.gunaTextBox1.Size = new System.Drawing.Size(151, 30);
            this.gunaTextBox1.TabIndex = 16;
            this.gunaTextBox1.Text = "senha";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnok);
            this.panel1.Controls.Add(this.btncancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 52);
            this.panel1.TabIndex = 18;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::Laricão.Properties.Resources.feliz;
            this.gunaPictureBox1.Location = new System.Drawing.Point(-23, -9);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(200, 148);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 17;
            this.gunaPictureBox1.TabStop = false;
            // 
            // FrmSenhaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(318, 184);
            this.Controls.Add(this.gunaTextBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gunaPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSenhaView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSenhaview";
            this.Load += new System.EventHandler(this.FrmSenhaView_Load_1);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaButton btncancel;
        private Guna.UI.WinForms.GunaButton btnok;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}