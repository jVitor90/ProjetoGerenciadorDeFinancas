namespace GerenciadorDeFinanças
{
    partial class FormReceitas
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
            this.btnNovaReceita = new System.Windows.Forms.Button();
            this.dgvReceitas = new System.Windows.Forms.DataGridView();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObservacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAcoes = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceitas)).BeginInit();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(240, 239, 232);
            this.lblTitulo.Location = new System.Drawing.Point(32, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "Receitas";

            // lblSubtitulo
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(122, 120, 110);
            this.lblSubtitulo.Location = new System.Drawing.Point(33, 48);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Text = "Todos os lançamentos";

            // btnNovaReceita
            this.btnNovaReceita.BackColor = System.Drawing.Color.FromArgb(200, 245, 90);
            this.btnNovaReceita.FlatAppearance.BorderSize = 0;
            this.btnNovaReceita.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(180, 220, 75);
            this.btnNovaReceita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaReceita.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNovaReceita.ForeColor = System.Drawing.Color.FromArgb(15, 15, 13);
            this.btnNovaReceita.Location = new System.Drawing.Point(720, 28);
            this.btnNovaReceita.Name = "btnNovaReceita";
            this.btnNovaReceita.Size = new System.Drawing.Size(148, 34);
            this.btnNovaReceita.Text = "+ Nova receita";
            this.btnNovaReceita.Cursor = System.Windows.Forms.Cursors.Hand;
            // this.btnNovaReceita.Click += new System.EventHandler(this.btnNovaReceita_Click);

            // dgvReceitas
            this.dgvReceitas.AllowUserToAddRows = false;
            this.dgvReceitas.AllowUserToDeleteRows = false;
            this.dgvReceitas.BackgroundColor = System.Drawing.Color.FromArgb(22, 22, 20);
            this.dgvReceitas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvReceitas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReceitas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvReceitas.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(22, 22, 20);
            this.dgvReceitas.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.dgvReceitas.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(122, 120, 110);
            this.dgvReceitas.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(22, 22, 20);
            this.dgvReceitas.ColumnHeadersHeight = 40;
            this.dgvReceitas.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(22, 22, 20);
            this.dgvReceitas.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvReceitas.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(240, 239, 232);
            this.dgvReceitas.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(37, 37, 33);
            this.dgvReceitas.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(200, 245, 90);
            this.dgvReceitas.EnableHeadersVisualStyles = false;
            this.dgvReceitas.GridColor = System.Drawing.Color.FromArgb(38, 38, 34);
            this.dgvReceitas.Location = new System.Drawing.Point(32, 76);
            this.dgvReceitas.MultiSelect = false;
            this.dgvReceitas.Name = "dgvReceitas";
            this.dgvReceitas.ReadOnly = true;
            this.dgvReceitas.RowHeadersVisible = false;
            this.dgvReceitas.RowTemplate.Height = 46;
            this.dgvReceitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceitas.Size = new System.Drawing.Size(836, 460);
            this.dgvReceitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colDescricao, this.colCategoria, this.colData, this.colObservacao, this.colValor, this.colAcoes });

            this.colDescricao.HeaderText = "DESCRIÇÃO";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.DataPropertyName = "Descricao";
            this.colDescricao.Width = 220;

            this.colCategoria.HeaderText = "CATEGORIA";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.DataPropertyName = "Categoria";
            this.colCategoria.Width = 160;

            this.colData.HeaderText = "DATA";
            this.colData.Name = "colData";
            this.colData.DataPropertyName = "Data";
            this.colData.Width = 110;

            this.colObservacao.HeaderText = "OBSERVAÇÃO";
            this.colObservacao.Name = "colObservacao";
            this.colObservacao.DataPropertyName = "Observacao";
            this.colObservacao.Width = 170;

            this.colValor.HeaderText = "VALOR";
            this.colValor.Name = "colValor";
            this.colValor.DataPropertyName = "Valor";
            this.colValor.DefaultCellStyle.Font = new System.Drawing.Font("Courier New", 9F);
            this.colValor.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(200, 245, 90);
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
            this.Controls.Add(this.btnNovaReceita);
            this.Controls.Add(this.dgvReceitas);
            this.Name = "FormReceitas";
            this.Text = "Receitas";

            ((System.ComponentModel.ISupportInitialize)(this.dgvReceitas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Button btnNovaReceita;
        private System.Windows.Forms.DataGridView dgvReceitas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObservacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.DataGridViewButtonColumn colAcoes;
    }
}