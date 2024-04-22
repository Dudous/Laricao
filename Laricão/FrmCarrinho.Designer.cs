namespace Laricão
{
    partial class FrmCarrinho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCarrinho));
            this.cartPanel = new System.Windows.Forms.Panel();
            this.rs = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnFinalizar = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // cartPanel
            // 
            this.cartPanel.AutoScroll = true;
            this.cartPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cartPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.cartPanel.Location = new System.Drawing.Point(0, 0);
            this.cartPanel.Name = "cartPanel";
            this.cartPanel.Size = new System.Drawing.Size(1225, 694);
            this.cartPanel.TabIndex = 20;
            // 
            // rs
            // 
            this.rs.AutoSize = true;
            this.rs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rs.Location = new System.Drawing.Point(214, 762);
            this.rs.Name = "rs";
            this.rs.Size = new System.Drawing.Size(33, 24);
            this.rs.TabIndex = 45;
            this.rs.Text = "R$";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(106, 762);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(110, 24);
            this.lbl1.TabIndex = 47;
            this.lbl1.Text = "Valor Total: ";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(253, 762);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(45, 24);
            this.lblValor.TabIndex = 46;
            this.lblValor.Text = "0,00";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.AnimationHoverSpeed = 0.07F;
            this.btnFinalizar.AnimationSpeed = 0.03F;
            this.btnFinalizar.BackColor = System.Drawing.Color.Transparent;
            this.btnFinalizar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnFinalizar.BorderColor = System.Drawing.Color.Black;
            this.btnFinalizar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFinalizar.FocusedColor = System.Drawing.Color.Empty;
            this.btnFinalizar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.White;
            this.btnFinalizar.Image = null;
            this.btnFinalizar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnFinalizar.Location = new System.Drawing.Point(860, 739);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnFinalizar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFinalizar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFinalizar.OnHoverImage = null;
            this.btnFinalizar.OnPressedColor = System.Drawing.Color.Black;
            this.btnFinalizar.Radius = 25;
            this.btnFinalizar.Size = new System.Drawing.Size(328, 59);
            this.btnFinalizar.TabIndex = 0;
            this.btnFinalizar.Text = "Continuar";
            this.btnFinalizar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // FrmCarrinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1225, 835);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.rs);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.cartPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCarrinho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCarrinho_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel cartPanel;
        private System.Windows.Forms.Label rs;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblValor;
        private Guna.UI.WinForms.GunaButton btnFinalizar;
    }
}