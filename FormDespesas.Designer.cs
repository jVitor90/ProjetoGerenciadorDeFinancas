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
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAcoes = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesas)).BeginInit();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(240, 239, 232);
            this.lblTitulo.Location = new System.Drawing.Point(32, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "Despesas";

            // lblSubtitulo
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(122, 120, 110);
            this.lblSubtitulo.Location = new System.Drawing.Point(33, 48);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Text = "Todos os lançamentos";

            // btnNovaDespesa
            this.btnNovaDespesa.BackColor = System.Drawing.Color.FromArgb(200, 245, 90);
            this.btnNovaDespesa.FlatAppearance.BorderSize = 0;
            this.btnNovaDespesa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(180, 220, 75);
            this.btnNovaDespesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaDespesa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNovaDespesa.ForeColor = System.Drawing.Color.FromArgb(15, 15, 13);
            this.btnNovaDespesa.Location = new System.Drawing.Point(716, 28);
            this.btnNovaDespesa.Name = "btnNovaDespesa";
            this.btnNovaDespesa.Size = new System.Drawing.Size(152, 34);
            this.btnNovaDespesa.Text = "+ Nova despesa";
            this.btnNovaDespesa.Cursor = System.Windows.Forms.Cursors.Hand;
            // this.btnNovaDespesa.Click += new System.EventHandler(this.btnNovaDespesa_Click);

            // dgvDespesas
            this.dgvDespesas.AllowUserToAddRows = false;
            this.dgvDespesas.AllowUserToDeleteRows = false;
            this.dgvDespesas.BackgroundColor = System.Drawing.Color.FromArgb(22, 22, 20);
            this.dgvDespesas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvDespesas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDespesas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvDespesas.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(22, 22, 20);
            this.dgvDespesas.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.dgvDespesas.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(122, 120, 110);
            this.dgvDespesas.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(22, 22, 20);
            this.dgvDespesas.ColumnHeadersHeight = 40;
            this.dgvDespesas.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(22, 22, 20);
            this.dgvDespesas.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvDespesas.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(240, 239, 232);
            this.dgvDespesas.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(37, 37, 33);
            this.dgvDespesas.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(200, 245, 90);
            this.dgvDespesas.EnableHeadersVisualStyles = false;
            this.dgvDespesas.GridColor = System.Drawing.Color.FromArgb(38, 38, 34);
            this.dgvDespesas.Location = new System.Drawing.Point(32, 76);
            this.dgvDespesas.MultiSelect = false;
            this.dgvDespesas.Name = "dgvDespesas";
            this.dgvDespesas.ReadOnly = true;
            this.dgvDespesas.RowHeadersVisible = false;
            this.dgvDespesas.RowTemplate.Height = 46;
            this.dgvDespesas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDespesas.Size = new System.Drawing.Size(836, 460);
            this.dgvDespesas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colDescricao, this.colCategoria, this.colData, this.colPago, this.colValor, this.colAcoes });

            this.colDescricao.HeaderText = "DESCRIÇÃO";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.DataPropertyName = "Descricao";
            this.colDescricao.Width = 220;

            this.colCategoria.HeaderText = "CATEGORIA";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.DataPropertyName = "Categoria";
            this.colCategoria.Width = 150;

            this.colData.HeaderText = "DATA";
            this.colData.Name = "colData";
            this.colData.DataPropertyName = "Data";
            this.colData.Width = 110;

            this.colPago.HeaderText = "STATUS";
            this.colPago.Name = "colPago";
            this.colPago.DataPropertyName = "Pago";
            this.colPago.Width = 100;

            this.colValor.HeaderText = "VALOR";
            this.colValor.Name = "colValor";
            this.colValor.DataPropertyName = "Valor";
            this.colValor.DefaultCellStyle.Font = new System.Drawing.Font("Courier New", 9F);
            this.colValor.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(224, 92, 92);
            this.colValor.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colValor.Width = 120;

            this.colAcoes.HeaderText = "";
            this.colAcoes.Name = "colAcoes";
            this.colAcoes.Text = "Excluir";
            this.colAcoes.UseColumnTextForButtonValue = true;
            this.colAcoes.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(37, 37, 33);
            this.colAcoes.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(122, 120, 110);
            this.colAcoes.Width = 56;

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(15, 15, 13);
            this.ClientSize = new System.Drawing.Size(900, 560);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.btnNovaDespesa);
            this.Controls.Add(this.dgvDespesas);
            this.Name = "FormDespesas";
            this.Text = "Despesas";

            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Button btnNovaDespesa;
        private System.Windows.Forms.DataGridView dgvDespesas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.DataGridViewButtonColumn colAcoes;
    }
}