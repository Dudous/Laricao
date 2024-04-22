namespace Laricão
{
    partial class FrmEscolha
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
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.btnadmin = new Guna.UI.WinForms.GunaImageButton();
            this.btnusuario = new Guna.UI.WinForms.GunaImageButton();
            this.SuspendLayout();
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(243, 121);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(74, 30);
            this.gunaLabel2.TabIndex = 24;
            this.gunaLabel2.Text = "Admin";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(88, 121);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(83, 30);
            this.gunaLabel1.TabIndex = 23;
            this.gunaLabel1.Text = "Usuário";
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.Black;
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 195);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(402, 39);
            this.gunaPanel1.TabIndex = 20;
            // 
            // btnadmin
            // 
            this.btnadmin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnadmin.Image = global::Laricão.Properties.Resources.profile;
            this.btnadmin.ImageSize = new System.Drawing.Size(64, 64);
            this.btnadmin.Location = new System.Drawing.Point(225, 26);
            this.btnadmin.Name = "btnadmin";
            this.btnadmin.OnHoverImage = null;
            this.btnadmin.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnadmin.Size = new System.Drawing.Size(117, 100);
            this.btnadmin.TabIndex = 22;
            this.btnadmin.Click += new System.EventHandler(this.btnadmin_Click);
            // 
            // btnusuario
            // 
            this.btnusuario.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnusuario.Image = global::Laricão.Properties.Resources.man;
            this.btnusuario.ImageSize = new System.Drawing.Size(64, 64);
            this.btnusuario.Location = new System.Drawing.Point(71, 26);
            this.btnusuario.Name = "btnusuario";
            this.btnusuario.OnHoverImage = null;
            this.btnusuario.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.btnusuario.Size = new System.Drawing.Size(117, 100);
            this.btnusuario.TabIndex = 21;
            this.btnusuario.Click += new System.EventHandler(this.btnusuario_Click);
            // 
            // FrmEscolha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(402, 234);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.btnadmin);
            this.Controls.Add(this.btnusuario);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEscolha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEscolha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaImageButton btnadmin;
        private Guna.UI.WinForms.GunaImageButton btnusuario;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
    }
}