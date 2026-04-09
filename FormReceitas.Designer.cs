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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(22, 22, 20);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 7.5F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(122, 120, 110);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(22, 22, 20);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvReceitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvReceitas.ColumnHeadersHeight = 40;
            dgvReceitas.Columns.AddRange(new DataGridViewColumn[] { colDescricao, colCategoria, colData, colObservacao, colValor, colAcoes });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(22, 22, 20);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(240, 239, 232);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(37, 37, 33);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(200, 245, 90);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvReceitas.DefaultCellStyle = dataGridViewCellStyle4;
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
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Font = new Font("Courier New", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(200, 245, 90);
            colValor.DefaultCellStyle = dataGridViewCellStyle2;
            colValor.HeaderText = "VALOR";
            colValor.Name = "colValor";
            colValor.ReadOnly = true;
            colValor.Width = 120;
            // 
            // colAcoes
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(37, 37, 33);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(122, 120, 110);
            colAcoes.DefaultCellStyle = dataGridViewCellStyle3;
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