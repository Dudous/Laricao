namespace Laricão
{
    partial class FrmProduto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgprod = new Guna.UI.WinForms.GunaDataGridView();
            this.dgvid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvnome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvpreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvctg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvfoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvedit = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvdelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnadicionar = new Guna.UI.WinForms.GunaButton();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Btnconsultar = new Guna.UI.WinForms.GunaImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgprod)).BeginInit();
            this.SuspendLayout();
            // 
            // dgprod
            // 
            this.dgprod.AllowUserToAddRows = false;
            this.dgprod.AllowUserToDeleteRows = false;
            this.dgprod.AllowUserToResizeColumns = false;
            this.dgprod.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgprod.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgprod.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgprod.BackgroundColor = System.Drawing.Color.White;
            this.dgprod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgprod.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgprod.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgprod.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgprod.ColumnHeadersHeight = 30;
            this.dgprod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvid,
            this.dgvnome,
            this.dgvpreco,
            this.dgvctg,
            this.dgvfoto,
            this.dgvedit,
            this.dgvdelete});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgprod.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgprod.EnableHeadersVisualStyles = false;
            this.dgprod.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgprod.Location = new System.Drawing.Point(12, 76);
            this.dgprod.Name = "dgprod";
            this.dgprod.RowHeadersVisible = false;
            this.dgprod.RowTemplate.Height = 30;
            this.dgprod.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgprod.ShowCellErrors = false;
            this.dgprod.Size = new System.Drawing.Size(1201, 659);
            this.dgprod.TabIndex = 0;
            this.dgprod.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgprod.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgprod.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgprod.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgprod.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgprod.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgprod.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgprod.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgprod.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgprod.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgprod.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgprod.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgprod.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgprod.ThemeStyle.HeaderStyle.Height = 30;
            this.dgprod.ThemeStyle.ReadOnly = false;
            this.dgprod.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgprod.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgprod.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgprod.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgprod.ThemeStyle.RowsStyle.Height = 30;
            this.dgprod.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgprod.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgprod.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgprod_CellContentClick);
            // 
            // dgvid
            // 
            this.dgvid.HeaderText = "Id";
            this.dgvid.Name = "dgvid";
            this.dgvid.Visible = false;
            // 
            // dgvnome
            // 
            this.dgvnome.HeaderText = "Nome";
            this.dgvnome.Name = "dgvnome";
            // 
            // dgvpreco
            // 
            this.dgvpreco.HeaderText = "Preço";
            this.dgvpreco.Name = "dgvpreco";
            // 
            // dgvctg
            // 
            this.dgvctg.HeaderText = "Categoria";
            this.dgvctg.Name = "dgvctg";
            // 
            // dgvfoto
            // 
            this.dgvfoto.HeaderText = "";
            this.dgvfoto.Name = "dgvfoto";
            this.dgvfoto.Visible = false;
            // 
            // dgvedit
            // 
            this.dgvedit.HeaderText = "";
            this.dgvedit.Image = global::Laricão.Properties.Resources.lapis;
            this.dgvedit.Name = "dgvedit";
            // 
            // dgvdelete
            // 
            this.dgvdelete.HeaderText = "";
            this.dgvdelete.Image = global::Laricão.Properties.Resources.trash;
            this.dgvdelete.Name = "dgvdelete";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPesquisar.Location = new System.Drawing.Point(721, 28);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(329, 20);
            this.txtPesquisar.TabIndex = 68;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // btnadicionar
            // 
            this.btnadicionar.AnimationHoverSpeed = 0.07F;
            this.btnadicionar.AnimationSpeed = 0.03F;
            this.btnadicionar.BackColor = System.Drawing.Color.Transparent;
            this.btnadicionar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnadicionar.BorderColor = System.Drawing.Color.Black;
            this.btnadicionar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnadicionar.FocusedColor = System.Drawing.Color.Empty;
            this.btnadicionar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnadicionar.ForeColor = System.Drawing.Color.White;
            this.btnadicionar.Image = null;
            this.btnadicionar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnadicionar.Location = new System.Drawing.Point(12, 770);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnadicionar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnadicionar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnadicionar.OnHoverImage = null;
            this.btnadicionar.OnPressedColor = System.Drawing.Color.Black;
            this.btnadicionar.Radius = 15;
            this.btnadicionar.Size = new System.Drawing.Size(160, 42);
            this.btnadicionar.TabIndex = 70;
            this.btnadicionar.Text = "Adicionar";
            this.btnadicionar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnadicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Laricão.Properties.Resources.lapis;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 240;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Laricão.Properties.Resources.trash;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 240;
            // 
            // Btnconsultar
            // 
            this.Btnconsultar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btnconsultar.BackgroundImage = global::Laricão.Properties.Resources.search;
            this.Btnconsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btnconsultar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Btnconsultar.Image = null;
            this.Btnconsultar.ImageSize = new System.Drawing.Size(64, 64);
            this.Btnconsultar.Location = new System.Drawing.Point(1056, 28);
            this.Btnconsultar.Name = "Btnconsultar";
            this.Btnconsultar.OnHoverImage = null;
            this.Btnconsultar.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.Btnconsultar.Size = new System.Drawing.Size(42, 20);
            this.Btnconsultar.TabIndex = 69;
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 835);
            this.Controls.Add(this.btnadicionar);
            this.Controls.Add(this.Btnconsultar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.dgprod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProduto";
            this.Text = "FrmProduto";
            this.Load += new System.EventHandler(this.FrmProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgprod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView dgprod;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvnome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvpreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvctg;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvfoto;
        private System.Windows.Forms.DataGridViewImageColumn dgvedit;
        private System.Windows.Forms.DataGridViewImageColumn dgvdelete;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private Guna.UI.WinForms.GunaImageButton Btnconsultar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private Guna.UI.WinForms.GunaButton btnadicionar;
    }
}