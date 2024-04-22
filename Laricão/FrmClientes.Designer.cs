namespace Laricão
{
    partial class FrmClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            this.CenterPanel = new Guna.UI.WinForms.GunaPanel();
            this.Btnconsultar = new Guna.UI.WinForms.GunaImageButton();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnadicionar = new Guna.UI.WinForms.GunaButton();
            this.dtClientes = new Guna.UI.WinForms.GunaDataGridView();
            this.dgvId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSobre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSenha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPerfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.CenterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // CenterPanel
            // 
            this.CenterPanel.Controls.Add(this.Btnconsultar);
            this.CenterPanel.Controls.Add(this.txtPesquisar);
            this.CenterPanel.Controls.Add(this.btnadicionar);
            this.CenterPanel.Controls.Add(this.dtClientes);
            this.CenterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterPanel.Location = new System.Drawing.Point(0, 0);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(1225, 835);
            this.CenterPanel.TabIndex = 59;
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
            this.Btnconsultar.TabIndex = 67;
            this.Btnconsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPesquisar.Location = new System.Drawing.Point(721, 28);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(329, 20);
            this.txtPesquisar.TabIndex = 64;
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
            this.btnadicionar.TabIndex = 63;
            this.btnadicionar.Text = "Adicionar";
            this.btnadicionar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnadicionar.Click += new System.EventHandler(this.btnadicionar_Click);
            // 
            // dtClientes
            // 
            this.dtClientes.AllowUserToAddRows = false;
            this.dtClientes.AllowUserToDeleteRows = false;
            this.dtClientes.AllowUserToResizeColumns = false;
            this.dtClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtClientes.BackgroundColor = System.Drawing.Color.White;
            this.dtClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtClientes.ColumnHeadersHeight = 30;
            this.dtClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvId,
            this.dgvName,
            this.dgvSobre,
            this.dgvCpf,
            this.dgvTel,
            this.dgvSenha,
            this.dgvPerfil,
            this.dgvEmail,
            this.dgvEdit,
            this.dgvDelete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtClientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtClientes.EnableHeadersVisualStyles = false;
            this.dtClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtClientes.Location = new System.Drawing.Point(12, 76);
            this.dtClientes.Name = "dtClientes";
            this.dtClientes.ReadOnly = true;
            this.dtClientes.RowHeadersVisible = false;
            this.dtClientes.RowTemplate.Height = 30;
            this.dtClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtClientes.Size = new System.Drawing.Size(1201, 659);
            this.dtClientes.TabIndex = 62;
            this.dtClientes.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dtClientes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtClientes.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtClientes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtClientes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtClientes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtClientes.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtClientes.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtClientes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtClientes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtClientes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtClientes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtClientes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtClientes.ThemeStyle.HeaderStyle.Height = 30;
            this.dtClientes.ThemeStyle.ReadOnly = true;
            this.dtClientes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtClientes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtClientes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtClientes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtClientes.ThemeStyle.RowsStyle.Height = 30;
            this.dtClientes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtClientes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtClientes_CellClick);
            // 
            // dgvId
            // 
            this.dgvId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvId.FillWeight = 70F;
            this.dgvId.HeaderText = "Id";
            this.dgvId.Name = "dgvId";
            this.dgvId.ReadOnly = true;
            this.dgvId.Width = 50;
            // 
            // dgvName
            // 
            this.dgvName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvName.FillWeight = 30.24947F;
            this.dgvName.HeaderText = "Nome";
            this.dgvName.Name = "dgvName";
            this.dgvName.ReadOnly = true;
            this.dgvName.Width = 69;
            // 
            // dgvSobre
            // 
            this.dgvSobre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvSobre.FillWeight = 30.24947F;
            this.dgvSobre.HeaderText = "Sobrenome";
            this.dgvSobre.Name = "dgvSobre";
            this.dgvSobre.ReadOnly = true;
            this.dgvSobre.Width = 102;
            // 
            // dgvCpf
            // 
            this.dgvCpf.FillWeight = 30.24947F;
            this.dgvCpf.HeaderText = "CPF";
            this.dgvCpf.Name = "dgvCpf";
            this.dgvCpf.ReadOnly = true;
            // 
            // dgvTel
            // 
            this.dgvTel.FillWeight = 30.24947F;
            this.dgvTel.HeaderText = "Telefone";
            this.dgvTel.Name = "dgvTel";
            this.dgvTel.ReadOnly = true;
            // 
            // dgvSenha
            // 
            this.dgvSenha.HeaderText = "Senha";
            this.dgvSenha.Name = "dgvSenha";
            this.dgvSenha.ReadOnly = true;
            this.dgvSenha.Visible = false;
            // 
            // dgvPerfil
            // 
            this.dgvPerfil.FillWeight = 30.24947F;
            this.dgvPerfil.HeaderText = "Perfil";
            this.dgvPerfil.Name = "dgvPerfil";
            this.dgvPerfil.ReadOnly = true;
            // 
            // dgvEmail
            // 
            this.dgvEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvEmail.FillWeight = 30.24947F;
            this.dgvEmail.HeaderText = "E-mail";
            this.dgvEmail.Name = "dgvEmail";
            this.dgvEmail.ReadOnly = true;
            this.dgvEmail.Width = 70;
            // 
            // dgvEdit
            // 
            this.dgvEdit.FillWeight = 260.0894F;
            this.dgvEdit.HeaderText = "";
            this.dgvEdit.Image = global::Laricão.Properties.Resources.lapis;
            this.dgvEdit.MinimumWidth = 70;
            this.dgvEdit.Name = "dgvEdit";
            this.dgvEdit.ReadOnly = true;
            // 
            // dgvDelete
            // 
            this.dgvDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvDelete.FillWeight = 70F;
            this.dgvDelete.HeaderText = "";
            this.dgvDelete.Image = global::Laricão.Properties.Resources.trash;
            this.dgvDelete.MinimumWidth = 70;
            this.dgvDelete.Name = "dgvDelete";
            this.dgvDelete.ReadOnly = true;
            this.dgvDelete.Width = 70;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 309.1371F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Laricão.Properties.Resources.lapis;
            this.dataGridViewImageColumn1.MinimumWidth = 70;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 611;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn2.FillWeight = 70F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Laricão.Properties.Resources.trash;
            this.dataGridViewImageColumn2.MinimumWidth = 70;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 70;
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1225, 835);
            this.Controls.Add(this.CenterPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmClientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.CenterPanel.ResumeLayout(false);
            this.CenterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaPanel CenterPanel;
        private Guna.UI.WinForms.GunaDataGridView dtClientes;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSobre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSenha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPerfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEmail;
        private System.Windows.Forms.DataGridViewImageColumn dgvEdit;
        private System.Windows.Forms.DataGridViewImageColumn dgvDelete;
        private Guna.UI.WinForms.GunaButton btnadicionar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private Guna.UI.WinForms.GunaImageButton Btnconsultar;
    }
}