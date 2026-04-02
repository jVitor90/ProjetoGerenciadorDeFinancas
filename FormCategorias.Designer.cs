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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.btnNovaCategoria = new System.Windows.Forms.Button();
            this.panelCadastro = new System.Windows.Forms.Panel();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.panelCadastro.SuspendLayout();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(240, 239, 232);
            this.lblTitulo.Location = new System.Drawing.Point(32, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "Categorias";

            // lblSubtitulo
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(122, 120, 110);
            this.lblSubtitulo.Location = new System.Drawing.Point(33, 48);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Text = "Gerencie seus grupos";

            // btnNovaCategoria
            this.btnNovaCategoria.BackColor = System.Drawing.Color.FromArgb(200, 245, 90);
            this.btnNovaCategoria.FlatAppearance.BorderSize = 0;
            this.btnNovaCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(180, 220, 75);
            this.btnNovaCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaCategoria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNovaCategoria.ForeColor = System.Drawing.Color.FromArgb(15, 15, 13);
            this.btnNovaCategoria.Location = new System.Drawing.Point(648, 28);
            this.btnNovaCategoria.Name = "btnNovaCategoria";
            this.btnNovaCategoria.Size = new System.Drawing.Size(164, 34);
            this.btnNovaCategoria.Text = "+ Nova categoria";
            this.btnNovaCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            // this.btnNovaCategoria.Click += new System.EventHandler(this.btnNovaCategoria_Click);

            // panelCadastro
            this.panelCadastro.BackColor = System.Drawing.Color.FromArgb(22, 22, 20);
            this.panelCadastro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCadastro.Controls.Add(this.lblNome);
            this.panelCadastro.Controls.Add(this.txtNome);
            this.panelCadastro.Controls.Add(this.lblTipo);
            this.panelCadastro.Controls.Add(this.cmbTipo);
            this.panelCadastro.Controls.Add(this.btnSalvar);
            this.panelCadastro.Controls.Add(this.btnCancelar);
            this.panelCadastro.Location = new System.Drawing.Point(32, 76);
            this.panelCadastro.Name = "panelCadastro";
            this.panelCadastro.Size = new System.Drawing.Size(780, 100);
            this.panelCadastro.Visible = false;

            // lblNome
            this.lblNome = CriarLabel("NOME", 16, 12);
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(30, 30, 27);
            this.txtNome.ForeColor = System.Drawing.Color.FromArgb(240, 239, 232);
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNome.Location = new System.Drawing.Point(16, 28);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(300, 24);

            // lblTipo
            this.lblTipo = CriarLabel("TIPO", 332, 12);
            this.cmbTipo.BackColor = System.Drawing.Color.FromArgb(30, 30, 27);
            this.cmbTipo.ForeColor = System.Drawing.Color.FromArgb(240, 239, 232);
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbTipo.Items.AddRange(new object[] { "receita", "despesa" });
            this.cmbTipo.SelectedIndex = 0;
            this.cmbTipo.Location = new System.Drawing.Point(332, 28);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(180, 24);

            // btnCancelar
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(30, 30, 27);
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 60, 56);
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(37, 37, 33);
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(122, 120, 110);
            this.btnCancelar.Location = new System.Drawing.Point(592, 28);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 32);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            // this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            // btnSalvar
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(200, 245, 90);
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(180, 220, 75);
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.ForeColor = System.Drawing.Color.FromArgb(15, 15, 13);
            this.btnSalvar.Location = new System.Drawing.Point(688, 28);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(80, 32);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            // this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);

            // dgvCategorias
            this.dgvCategorias.AllowUserToAddRows = false;
            this.dgvCategorias.AllowUserToDeleteRows = false;
            this.dgvCategorias.BackgroundColor = System.Drawing.Color.FromArgb(22, 22, 20);
            this.dgvCategorias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvCategorias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCategorias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCategorias.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(22, 22, 20);
            this.dgvCategorias.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.dgvCategorias.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(122, 120, 110);
            this.dgvCategorias.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(22, 22, 20);
            this.dgvCategorias.ColumnHeadersHeight = 40;
            this.dgvCategorias.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(22, 22, 20);
            this.dgvCategorias.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvCategorias.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(240, 239, 232);
            this.dgvCategorias.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(37, 37, 33);
            this.dgvCategorias.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(200, 245, 90);
            this.dgvCategorias.EnableHeadersVisualStyles = false;
            this.dgvCategorias.GridColor = System.Drawing.Color.FromArgb(38, 38, 34);
            this.dgvCategorias.Location = new System.Drawing.Point(32, 76);
            this.dgvCategorias.MultiSelect = false;
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.ReadOnly = true;
            this.dgvCategorias.RowHeadersVisible = false;
            this.dgvCategorias.RowTemplate.Height = 44;
            this.dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategorias.Size = new System.Drawing.Size(780, 440);
            this.dgvCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colNome, this.colTipo, this.colExcluir });

            this.colNome.HeaderText = "NOME";
            this.colNome.Name = "colNome";
            this.colNome.DataPropertyName = "Nome";
            this.colNome.Width = 400;

            this.colTipo.HeaderText = "TIPO";
            this.colTipo.Name = "colTipo";
            this.colTipo.DataPropertyName = "Tipo";
            this.colTipo.Width = 300;

            this.colExcluir.HeaderText = "";
            this.colExcluir.Name = "colExcluir";
            this.colExcluir.Text = "Excluir";
            this.colExcluir.UseColumnTextForButtonValue = true;
            this.colExcluir.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(37, 37, 33);
            this.colExcluir.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(122, 120, 110);
            this.colExcluir.Width = 80;

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(15, 15, 13);
            this.ClientSize = new System.Drawing.Size(844, 540);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.btnNovaCategoria);
            this.Controls.Add(this.panelCadastro);
            this.Controls.Add(this.dgvCategorias);
            this.Name = "FormCategorias";
            this.Text = "Categorias";

            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.panelCadastro.ResumeLayout(false);
            this.panelCadastro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
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