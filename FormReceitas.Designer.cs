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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            btnNovaReceita = new Button();
            dgvReceitas = new DataGridView();
            colDescricao = new DataGridViewTextBoxColumn();
            colCategoria = new DataGridViewTextBoxColumn();
            colData = new DataGridViewTextBoxColumn();
            colObservacao = new DataGridViewTextBoxColumn();
            colValor = new DataGridViewTextBoxColumn();
            colAcoes = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvReceitas).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F);
            lblTitulo.ForeColor = Color.FromArgb(240, 239, 232);
            lblTitulo.Location = new Point(32, 24);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(80, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Receitas";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 8.5F);
            lblSubtitulo.ForeColor = Color.FromArgb(122, 120, 110);
            lblSubtitulo.Location = new Point(33, 48);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(124, 15);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Todos os lançamentos";
            // 
            // btnNovaReceita
            // 
            btnNovaReceita.BackColor = Color.FromArgb(200, 245, 90);
            btnNovaReceita.Cursor = Cursors.Hand;
            btnNovaReceita.FlatAppearance.BorderSize = 0;
            btnNovaReceita.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, 220, 75);
            btnNovaReceita.FlatStyle = FlatStyle.Flat;
            btnNovaReceita.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNovaReceita.ForeColor = Color.FromArgb(15, 15, 13);
            btnNovaReceita.Location = new Point(720, 28);
            btnNovaReceita.Name = "btnNovaReceita";
            btnNovaReceita.Size = new Size(148, 34);
            btnNovaReceita.TabIndex = 2;
            btnNovaReceita.Text = "+ Nova receita";
            btnNovaReceita.UseVisualStyleBackColor = false;
            // 
            // dgvReceitas
            // 
            dgvReceitas.AllowUserToAddRows = false;
            dgvReceitas.AllowUserToDeleteRows = false;
            dgvReceitas.BackgroundColor = Color.FromArgb(22, 22, 20);
            dgvReceitas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvReceitas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(22, 22, 20);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 7.5F);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(122, 120, 110);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(22, 22, 20);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvReceitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvReceitas.ColumnHeadersHeight = 40;
            dgvReceitas.Columns.AddRange(new DataGridViewColumn[] { colDescricao, colCategoria, colData, colObservacao, colValor, colAcoes });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(22, 22, 20);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(240, 239, 232);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(37, 37, 33);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(200, 245, 90);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvReceitas.DefaultCellStyle = dataGridViewCellStyle8;
            dgvReceitas.EnableHeadersVisualStyles = false;
            dgvReceitas.GridColor = Color.FromArgb(38, 38, 34);
            dgvReceitas.Location = new Point(32, 76);
            dgvReceitas.MultiSelect = false;
            dgvReceitas.Name = "dgvReceitas";
            dgvReceitas.ReadOnly = true;
            dgvReceitas.RowHeadersVisible = false;
            dgvReceitas.RowTemplate.Height = 46;
            dgvReceitas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReceitas.Size = new Size(836, 460);
            dgvReceitas.TabIndex = 3;
            // 
            // colDescricao
            // 
            colDescricao.DataPropertyName = "Descricao";
            colDescricao.HeaderText = "DESCRIÇÃO";
            colDescricao.Name = "colDescricao";
            colDescricao.ReadOnly = true;
            colDescricao.Width = 220;
            // 
            // colCategoria
            // 
            colCategoria.DataPropertyName = "Categoria";
            colCategoria.HeaderText = "CATEGORIA";
            colCategoria.Name = "colCategoria";
            colCategoria.ReadOnly = true;
            colCategoria.Width = 160;
            // 
            // colData
            // 
            colData.DataPropertyName = "Data";
            colData.HeaderText = "DATA";
            colData.Name = "colData";
            colData.ReadOnly = true;
            colData.Width = 110;
            // 
            // colObservacao
            // 
            colObservacao.DataPropertyName = "Observacao";
            colObservacao.HeaderText = "OBSERVAÇÃO";
            colObservacao.Name = "colObservacao";
            colObservacao.ReadOnly = true;
            colObservacao.Width = 170;
            // 
            // colValor
            // 
            colValor.DataPropertyName = "Valor";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Font = new Font("Courier New", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(200, 245, 90);
            colValor.DefaultCellStyle = dataGridViewCellStyle6;
            colValor.HeaderText = "VALOR";
            colValor.Name = "colValor";
            colValor.ReadOnly = true;
            colValor.Width = 120;
            // 
            // colAcoes
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(37, 37, 33);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(122, 120, 110);
            colAcoes.DefaultCellStyle = dataGridViewCellStyle7;
            colAcoes.HeaderText = "";
            colAcoes.Name = "colAcoes";
            colAcoes.ReadOnly = true;
            colAcoes.Text = "Excluir";
            colAcoes.UseColumnTextForButtonValue = true;
            colAcoes.Width = 56;
            // 
            // FormReceitas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 13);
            ClientSize = new Size(900, 560);
            Controls.Add(lblTitulo);
            Controls.Add(lblSubtitulo);
            Controls.Add(btnNovaReceita);
            Controls.Add(dgvReceitas);
            Name = "FormReceitas";
            Text = "Receitas";
            ((System.ComponentModel.ISupportInitialize)dgvReceitas).EndInit();
            ResumeLayout(false);
            PerformLayout();
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