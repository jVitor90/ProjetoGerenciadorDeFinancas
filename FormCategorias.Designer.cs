namespace GerenciadorDeFinanças
{
    partial class FormCategorias
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            btnNovaCategoria = new Button();
            panelCadastro = new Panel();
            lblNome = new Label();
            txtNome = new TextBox();
            lblTipo = new Label();
            cmbTipo = new ComboBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            dgvCategorias = new DataGridView();
            colNome = new DataGridViewTextBoxColumn();
            colTipo = new DataGridViewTextBoxColumn();
            colExcluir = new DataGridViewButtonColumn();
            panelCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F);
            lblTitulo.ForeColor = Color.FromArgb(240, 239, 232);
            lblTitulo.Location = new Point(32, 24);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(102, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Categorias";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 8.5F);
            lblSubtitulo.ForeColor = Color.FromArgb(122, 120, 110);
            lblSubtitulo.Location = new Point(33, 48);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(119, 15);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Gerencie seus grupos";
            // 
            // btnNovaCategoria
            // 
            btnNovaCategoria.BackColor = Color.FromArgb(200, 245, 90);
            btnNovaCategoria.Cursor = Cursors.Hand;
            btnNovaCategoria.FlatAppearance.BorderSize = 0;
            btnNovaCategoria.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, 220, 75);
            btnNovaCategoria.FlatStyle = FlatStyle.Flat;
            btnNovaCategoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNovaCategoria.ForeColor = Color.FromArgb(15, 15, 13);
            btnNovaCategoria.Location = new Point(648, 28);
            btnNovaCategoria.Name = "btnNovaCategoria";
            btnNovaCategoria.Size = new Size(164, 34);
            btnNovaCategoria.TabIndex = 2;
            btnNovaCategoria.Text = "+ Nova categoria";
            btnNovaCategoria.UseVisualStyleBackColor = false;
            btnNovaCategoria.Click += btnNovaCategoria_Click;
            // 
            // panelCadastro
            // 
            panelCadastro.BackColor = Color.FromArgb(22, 22, 20);
            panelCadastro.BorderStyle = BorderStyle.FixedSingle;
            panelCadastro.Controls.Add(lblNome);
            panelCadastro.Controls.Add(txtNome);
            panelCadastro.Controls.Add(lblTipo);
            panelCadastro.Controls.Add(cmbTipo);
            panelCadastro.Controls.Add(btnSalvar);
            panelCadastro.Controls.Add(btnCancelar);
            panelCadastro.Location = new Point(32, 76);
            panelCadastro.Name = "panelCadastro";
            panelCadastro.Size = new Size(780, 100);
            panelCadastro.TabIndex = 3;
            panelCadastro.Visible = false;
            // 
            // lblNome
            // 
            lblNome.Location = new Point(0, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(100, 23);
            lblNome.TabIndex = 0;
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.FromArgb(30, 30, 27);
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Font = new Font("Segoe UI", 9.5F);
            txtNome.ForeColor = Color.FromArgb(240, 239, 232);
            txtNome.Location = new Point(16, 28);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(300, 24);
            txtNome.TabIndex = 1;
            // 
            // lblTipo
            // 
            lblTipo.Location = new Point(0, 0);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(100, 23);
            lblTipo.TabIndex = 2;
            // 
            // cmbTipo
            // 
            cmbTipo.BackColor = Color.FromArgb(30, 30, 27);
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FlatStyle = FlatStyle.Flat;
            cmbTipo.Font = new Font("Segoe UI", 9.5F);
            cmbTipo.ForeColor = Color.FromArgb(240, 239, 232);
            cmbTipo.Items.AddRange(new object[] { "receita", "despesa" });
            cmbTipo.Location = new Point(332, 28);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(180, 25);
            cmbTipo.TabIndex = 3;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(200, 245, 90);
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, 220, 75);
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSalvar.ForeColor = Color.FromArgb(15, 15, 13);
            btnSalvar.Location = new Point(688, 28);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(80, 32);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(30, 30, 27);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 56);
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 37, 33);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F);
            btnCancelar.ForeColor = Color.FromArgb(122, 120, 110);
            btnCancelar.Location = new Point(592, 28);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(84, 32);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // dgvCategorias
            // 
            dgvCategorias.AllowUserToAddRows = false;
            dgvCategorias.AllowUserToDeleteRows = false;
            dgvCategorias.BackgroundColor = Color.FromArgb(22, 22, 20);
            dgvCategorias.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCategorias.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(22, 22, 20);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 7.5F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(122, 120, 110);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(22, 22, 20);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCategorias.ColumnHeadersHeight = 40;
            dgvCategorias.Columns.AddRange(new DataGridViewColumn[] { colNome, colTipo, colExcluir });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(22, 22, 20);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(240, 239, 232);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(37, 37, 33);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(200, 245, 90);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvCategorias.DefaultCellStyle = dataGridViewCellStyle3;
            dgvCategorias.EnableHeadersVisualStyles = false;
            dgvCategorias.GridColor = Color.FromArgb(38, 38, 34);
            dgvCategorias.Location = new Point(32, 76);
            dgvCategorias.MultiSelect = false;
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.ReadOnly = true;
            dgvCategorias.RowHeadersVisible = false;
            dgvCategorias.RowTemplate.Height = 44;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.Size = new Size(780, 440);
            dgvCategorias.TabIndex = 4;
            dgvCategorias.CellContentClick += dgvCategorias_CellContentClick;
            // 
            // colNome
            // 
            colNome.DataPropertyName = "Nome";
            colNome.HeaderText = "NOME";
            colNome.Name = "colNome";
            colNome.ReadOnly = true;
            colNome.Width = 400;
            // 
            // colTipo
            // 
            colTipo.DataPropertyName = "Tipo";
            colTipo.HeaderText = "TIPO";
            colTipo.Name = "colTipo";
            colTipo.ReadOnly = true;
            colTipo.Width = 300;
            // 
            // colExcluir
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(37, 37, 33);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(122, 120, 110);
            colExcluir.DefaultCellStyle = dataGridViewCellStyle2;
            colExcluir.HeaderText = "";
            colExcluir.Name = "colExcluir";
            colExcluir.ReadOnly = true;
            colExcluir.Text = "Excluir";
            colExcluir.UseColumnTextForButtonValue = true;
            colExcluir.Width = 80;
            // 
            // FormCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 13);
            ClientSize = new Size(844, 540);
            Controls.Add(lblTitulo);
            Controls.Add(lblSubtitulo);
            Controls.Add(btnNovaCategoria);
            Controls.Add(panelCadastro);
            Controls.Add(dgvCategorias);
            Name = "FormCategorias";
            Text = "Categorias";
            panelCadastro.ResumeLayout(false);
            panelCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label CriarLabel(string texto, int x, int y)
        {
            var lbl = new System.Windows.Forms.Label();
            lbl.AutoSize = true;
            lbl.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            lbl.ForeColor = System.Drawing.Color.FromArgb(122, 120, 110);
            lbl.Location = new System.Drawing.Point(x, y);
            lbl.Text = texto;
            return lbl;
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Button btnNovaCategoria;
        private System.Windows.Forms.Panel panelCadastro;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewButtonColumn colExcluir;
    }
}