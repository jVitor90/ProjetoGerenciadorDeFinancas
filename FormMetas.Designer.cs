namespace GerenciadorDeFinanças
{
    partial class FormMetas
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
            this.btnNovaMeta = new System.Windows.Forms.Button();
            this.dgvMetas = new System.Windows.Forms.DataGridView();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAlvo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAtual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProgresso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExcluir = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetas)).BeginInit();
            this.SuspendLayout();

            // ── lblTitulo ──────────────────────────────────────────────
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(240, 239, 232);
            this.lblTitulo.Location = new System.Drawing.Point(32, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "Metas";

            // ── lblSubtitulo ───────────────────────────────────────────
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(122, 120, 110);
            this.lblSubtitulo.Location = new System.Drawing.Point(33, 48);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Text = "Acompanhe seus objetivos financeiros";

            // ── btnNovaMeta ────────────────────────────────────────────
            this.btnNovaMeta.BackColor = System.Drawing.Color.FromArgb(200, 245, 90);
            this.btnNovaMeta.FlatAppearance.BorderSize = 0;
            this.btnNovaMeta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(180, 220, 75);
            this.btnNovaMeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaMeta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNovaMeta.ForeColor = System.Drawing.Color.FromArgb(15, 15, 13);
            this.btnNovaMeta.Location = new System.Drawing.Point(716, 28);
            this.btnNovaMeta.Name = "btnNovaMeta";
            this.btnNovaMeta.Size = new System.Drawing.Size(152, 34);
            this.btnNovaMeta.Text = "+ Nova meta";
            this.btnNovaMeta.Cursor = System.Windows.Forms.Cursors.Hand;

            // ── dgvMetas ───────────────────────────────────────────────
            this.dgvMetas.AllowUserToAddRows = false;
            this.dgvMetas.AllowUserToDeleteRows = false;
            this.dgvMetas.BackgroundColor = System.Drawing.Color.FromArgb(22, 22, 20);
            this.dgvMetas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvMetas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMetas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvMetas.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(22, 22, 20);
            this.dgvMetas.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.dgvMetas.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(122, 120, 110);
            this.dgvMetas.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(22, 22, 20);
            this.dgvMetas.ColumnHeadersHeight = 40;
            this.dgvMetas.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(22, 22, 20);
            this.dgvMetas.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvMetas.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(240, 239, 232);
            this.dgvMetas.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(37, 37, 33);
            this.dgvMetas.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(200, 245, 90);
            this.dgvMetas.EnableHeadersVisualStyles = false;
            this.dgvMetas.GridColor = System.Drawing.Color.FromArgb(38, 38, 34);
            this.dgvMetas.Location = new System.Drawing.Point(32, 76);
            this.dgvMetas.MultiSelect = false;
            this.dgvMetas.Name = "dgvMetas";
            this.dgvMetas.ReadOnly = true;
            this.dgvMetas.RowHeadersVisible = false;
            this.dgvMetas.RowTemplate.Height = 46;
            this.dgvMetas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMetas.Size = new System.Drawing.Size(836, 460);
            this.dgvMetas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colNome, this.colCategoria, this.colAlvo,
                this.colAtual, this.colProgresso, this.colPrazo, this.colExcluir });

            // colNome
            this.colNome.HeaderText = "META";
            this.colNome.Name = "colNome";
            this.colNome.DataPropertyName = "Nome";
            this.colNome.Width = 200;

            // colCategoria
            this.colCategoria.HeaderText = "CATEGORIA";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.DataPropertyName = "Categoria";
            this.colCategoria.Width = 130;

            // colAlvo
            this.colAlvo.HeaderText = "VALOR ALVO";
            this.colAlvo.Name = "colAlvo";
            this.colAlvo.DataPropertyName = "ValorAlvo";
            this.colAlvo.DefaultCellStyle.Font = new System.Drawing.Font("Courier New", 9F);
            this.colAlvo.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(200, 245, 90);
            this.colAlvo.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colAlvo.Width = 120;

            // colAtual
            this.colAtual.HeaderText = "ACUMULADO";
            this.colAtual.Name = "colAtual";
            this.colAtual.DataPropertyName = "ValorAtual";
            this.colAtual.DefaultCellStyle.Font = new System.Drawing.Font("Courier New", 9F);
            this.colAtual.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(200, 245, 90);
            this.colAtual.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colAtual.Width = 120;

            // colProgresso
            this.colProgresso.HeaderText = "PROGRESSO";
            this.colProgresso.Name = "colProgresso";
            this.colProgresso.DataPropertyName = "Progresso";
            this.colProgresso.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colProgresso.Width = 90;

            // colPrazo
            this.colPrazo.HeaderText = "PRAZO";
            this.colPrazo.Name = "colPrazo";
            this.colPrazo.DataPropertyName = "Prazo";
            this.colPrazo.Width = 110;

            // colExcluir
            this.colExcluir.HeaderText = "";
            this.colExcluir.Name = "colExcluir";
            this.colExcluir.Text = "Excluir";
            this.colExcluir.UseColumnTextForButtonValue = true;
            this.colExcluir.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(37, 37, 33);
            this.colExcluir.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(122, 120, 110);
            this.colExcluir.Width = 66;

            // ── Form ───────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(15, 15, 13);
            this.ClientSize = new System.Drawing.Size(900, 560);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.btnNovaMeta);
            this.Controls.Add(this.dgvMetas);
            this.Name = "FormMetas";
            this.Text = "Metas";

            ((System.ComponentModel.ISupportInitialize)(this.dgvMetas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Button btnNovaMeta;
        private System.Windows.Forms.DataGridView dgvMetas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAlvo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAtual;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProgresso;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrazo;
        private System.Windows.Forms.DataGridViewButtonColumn colExcluir;
    }
}