namespace GerenciadorDeFinanças
{
    partial class FormDespesas
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
            this.btnNovaDespesa = new System.Windows.Forms.Button();
            this.dgvDespesas = new System.Windows.Forms.DataGridView();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colAcoes = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlEditar = new System.Windows.Forms.Panel();
            this.cmbStatusEditar = new System.Windows.Forms.ComboBox();
            this.btnSalvarStatus = new System.Windows.Forms.Button();
            this.btnFecharEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesas)).BeginInit();
            this.pnlEditar.SuspendLayout();
            this.SuspendLayout();

            // ── Paleta ───────────────────────────────────────────────────────────
            var cFundo = System.Drawing.Color.FromArgb(15, 15, 13);
            var cPainel = System.Drawing.Color.FromArgb(22, 22, 20);
            var cBorda = System.Drawing.Color.FromArgb(38, 38, 34);
            var cTexto = System.Drawing.Color.FromArgb(240, 239, 232);
            var cMuted = System.Drawing.Color.FromArgb(122, 120, 110);
            var cAcento = System.Drawing.Color.FromArgb(200, 245, 90);
            var cHover = System.Drawing.Color.FromArgb(180, 220, 75);
            var cSelecao = System.Drawing.Color.FromArgb(37, 37, 33);
            var cExcluir = System.Drawing.Color.FromArgb(50, 25, 25);
            var cExclTxt = System.Drawing.Color.FromArgb(200, 80, 80);
            var cEditar = System.Drawing.Color.FromArgb(25, 35, 50);
            var cEditTxt = System.Drawing.Color.FromArgb(100, 160, 220);

            // ── lblTitulo ────────────────────────────────────────────────────────
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lblTitulo.ForeColor = cTexto;
            this.lblTitulo.Location = new System.Drawing.Point(24, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "Despesas";

            // ── lblSubtitulo ─────────────────────────────────────────────────────
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSubtitulo.ForeColor = cMuted;
            this.lblSubtitulo.Location = new System.Drawing.Point(25, 40);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Text = "Todos os lançamentos";

            // ── btnNovaDespesa ───────────────────────────────────────────────────
            this.btnNovaDespesa.BackColor = cAcento;
            this.btnNovaDespesa.FlatAppearance.BorderSize = 0;
            this.btnNovaDespesa.FlatAppearance.MouseOverBackColor = cHover;
            this.btnNovaDespesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaDespesa.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnNovaDespesa.ForeColor = System.Drawing.Color.FromArgb(15, 15, 13);
            this.btnNovaDespesa.Location = new System.Drawing.Point(660, 20);
            this.btnNovaDespesa.Name = "btnNovaDespesa";
            this.btnNovaDespesa.Size = new System.Drawing.Size(136, 30);
            this.btnNovaDespesa.Text = "+ Nova despesa";
            this.btnNovaDespesa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovaDespesa.Click += new System.EventHandler(this.btnNovaDespesa_Click);

            // ── dgvDespesas ──────────────────────────────────────────────────────
            this.dgvDespesas.AllowUserToAddRows = false;
            this.dgvDespesas.AllowUserToDeleteRows = false;
            this.dgvDespesas.BackgroundColor = cPainel;
            this.dgvDespesas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDespesas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDespesas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDespesas.ColumnHeadersDefaultCellStyle.BackColor = cPainel;
            this.dgvDespesas.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.dgvDespesas.ColumnHeadersDefaultCellStyle.ForeColor = cMuted;
            this.dgvDespesas.ColumnHeadersDefaultCellStyle.SelectionBackColor = cPainel;
            this.dgvDespesas.ColumnHeadersHeight = 30;
            this.dgvDespesas.DefaultCellStyle.BackColor = cPainel;
            this.dgvDespesas.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.dgvDespesas.DefaultCellStyle.ForeColor = cTexto;
            this.dgvDespesas.DefaultCellStyle.SelectionBackColor = cSelecao;
            this.dgvDespesas.DefaultCellStyle.SelectionForeColor = cAcento;
            this.dgvDespesas.EnableHeadersVisualStyles = false;
            this.dgvDespesas.GridColor = cBorda;
            this.dgvDespesas.Location = new System.Drawing.Point(24, 62);
            this.dgvDespesas.MultiSelect = false;
            this.dgvDespesas.Name = "dgvDespesas";
            this.dgvDespesas.ReadOnly = true;
            this.dgvDespesas.RowHeadersVisible = false;
            this.dgvDespesas.RowTemplate.Height = 36;
            this.dgvDespesas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDespesas.Size = new System.Drawing.Size(812, 430);
            this.dgvDespesas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colStatus, this.colEditar, this.colAcoes });
            // this.dgvDespesas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDespesas_CellFormatting);
            this.dgvDespesas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDespesas_CellClick);
            this.dgvDespesas.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDespesas_DataError);

            // ── colStatus (TextBox — preenchido via código) ──────────────────────
            this.colStatus.HeaderText = "STATUS";
            this.colStatus.Name = "colStatus";
            this.colStatus.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.colStatus.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colStatus.Width = 90;
            this.colStatus.ReadOnly = true;

            // ── colEditar ────────────────────────────────────────────────────────
            this.colEditar.HeaderText = "";
            this.colEditar.Name = "colEditar";
            this.colEditar.UseColumnTextForButtonValue = true;
            this.colEditar.Text = "Editar";
            this.colEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colEditar.DefaultCellStyle.BackColor = cEditar;
            this.colEditar.DefaultCellStyle.ForeColor = cEditTxt;
            this.colEditar.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.colEditar.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colEditar.Width = 54;
            this.colEditar.ReadOnly = false;

            // ── colAcoes (excluir) ───────────────────────────────────────────────
            this.colAcoes.HeaderText = "";
            this.colAcoes.Name = "colAcoes";
            this.colAcoes.UseColumnTextForButtonValue = true;
            this.colAcoes.Text = "x";
            this.colAcoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colAcoes.DefaultCellStyle.BackColor = cExcluir;
            this.colAcoes.DefaultCellStyle.ForeColor = cExclTxt;
            this.colAcoes.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.colAcoes.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colAcoes.Width = 38;
            this.colAcoes.ReadOnly = false;

            // ── pnlEditar ────────────────────────────────────────────────────────
            this.pnlEditar.BackColor = System.Drawing.Color.FromArgb(30, 30, 27);
            this.pnlEditar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEditar.Name = "pnlEditar";
            this.pnlEditar.Size = new System.Drawing.Size(258, 46);
            this.pnlEditar.Visible = false;
            this.pnlEditar.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.cmbStatusEditar, this.btnSalvarStatus, this.btnFecharEditar });

            // ── cmbStatusEditar ──────────────────────────────────────────────────
            this.cmbStatusEditar.BackColor = System.Drawing.Color.FromArgb(37, 37, 33);
            this.cmbStatusEditar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStatusEditar.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.cmbStatusEditar.ForeColor = cTexto;
            this.cmbStatusEditar.Items.AddRange(new object[] { "Pendente", "Pago" });
            this.cmbStatusEditar.Location = new System.Drawing.Point(8, 10);
            this.cmbStatusEditar.Name = "cmbStatusEditar";
            this.cmbStatusEditar.Size = new System.Drawing.Size(110, 24);

            // ── btnSalvarStatus ──────────────────────────────────────────────────
            this.btnSalvarStatus.BackColor = cAcento;
            this.btnSalvarStatus.FlatAppearance.BorderSize = 0;
            this.btnSalvarStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarStatus.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnSalvarStatus.ForeColor = System.Drawing.Color.FromArgb(15, 15, 13);
            this.btnSalvarStatus.Location = new System.Drawing.Point(126, 10);
            this.btnSalvarStatus.Name = "btnSalvarStatus";
            this.btnSalvarStatus.Size = new System.Drawing.Size(62, 24);
            this.btnSalvarStatus.Text = "Salvar";
            this.btnSalvarStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvarStatus.Click += new System.EventHandler(this.btnSalvarStatus_Click);

            // ── btnFecharEditar ──────────────────────────────────────────────────
            this.btnFecharEditar.BackColor = System.Drawing.Color.FromArgb(50, 30, 30);
            this.btnFecharEditar.FlatAppearance.BorderSize = 0;
            this.btnFecharEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharEditar.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnFecharEditar.ForeColor = cExclTxt;
            this.btnFecharEditar.Location = new System.Drawing.Point(194, 10);
            this.btnFecharEditar.Name = "btnFecharEditar";
            this.btnFecharEditar.Size = new System.Drawing.Size(56, 24);
            this.btnFecharEditar.Text = "✕ Fechar";
            this.btnFecharEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFecharEditar.Click += new System.EventHandler(this.btnFecharEditar_Click);

            // ── Form ─────────────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = cFundo;
            this.ClientSize = new System.Drawing.Size(860, 510);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.btnNovaDespesa);
            this.Controls.Add(this.pnlEditar);
            this.Controls.Add(this.dgvDespesas);
            this.Name = "FormDespesas";
            this.Text = "Despesas";

            this.pnlEditar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Button btnNovaDespesa;
        private System.Windows.Forms.DataGridView dgvDespesas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewButtonColumn colEditar;
        private System.Windows.Forms.DataGridViewButtonColumn colAcoes;
        private System.Windows.Forms.Panel pnlEditar;
        private System.Windows.Forms.ComboBox cmbStatusEditar;
        private System.Windows.Forms.Button btnSalvarStatus;
        private System.Windows.Forms.Button btnFecharEditar;
    }
}