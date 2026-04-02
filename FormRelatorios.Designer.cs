namespace GerenciadorDeFinanças
{
    partial class FormRelatorios
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
            this.panelFiltros = new System.Windows.Forms.Panel();
            this.lblMes = new System.Windows.Forms.Label();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.panelCards = new System.Windows.Forms.Panel();
            this.panelReceitas = new System.Windows.Forms.Panel();
            this.lblCardReceitas = new System.Windows.Forms.Label();
            this.lblValorReceitas = new System.Windows.Forms.Label();
            this.panelDespesas = new System.Windows.Forms.Panel();
            this.lblCardDespesas = new System.Windows.Forms.Label();
            this.lblValorDespesas = new System.Windows.Forms.Label();
            this.panelSaldo = new System.Windows.Forms.Panel();
            this.lblCardSaldo = new System.Windows.Forms.Label();
            this.lblValorSaldo = new System.Windows.Forms.Label();
            this.dgvRelatorio = new System.Windows.Forms.DataGridView();
            this.colDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).BeginInit();
            this.panelFiltros.SuspendLayout();
            this.panelCards.SuspendLayout();
            this.panelReceitas.SuspendLayout();
            this.panelDespesas.SuspendLayout();
            this.panelSaldo.SuspendLayout();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(240, 239, 232);
            this.lblTitulo.Location = new System.Drawing.Point(32, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "Relatórios";

            // lblSubtitulo
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(122, 120, 110);
            this.lblSubtitulo.Location = new System.Drawing.Point(33, 48);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Text = "Visão consolidada";

            // panelFiltros
            this.panelFiltros.BackColor = System.Drawing.Color.FromArgb(22, 22, 20);
            this.panelFiltros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFiltros.Controls.Add(this.lblMes);
            this.panelFiltros.Controls.Add(this.cmbMes);
            this.panelFiltros.Controls.Add(this.lblAno);
            this.panelFiltros.Controls.Add(this.txtAno);
            this.panelFiltros.Controls.Add(this.btnFiltrar);
            this.panelFiltros.Location = new System.Drawing.Point(32, 76);
            this.panelFiltros.Name = "panelFiltros";
            this.panelFiltros.Size = new System.Drawing.Size(836, 68);

            this.lblMes = CriarLabel("MÊS", 16, 8);
            this.cmbMes.BackColor = System.Drawing.Color.FromArgb(30, 30, 27);
            this.cmbMes.ForeColor = System.Drawing.Color.FromArgb(240, 239, 232);
            this.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbMes.Items.AddRange(new object[] {
                "Todos","Janeiro","Fevereiro","Março","Abril","Maio","Junho",
                "Julho","Agosto","Setembro","Outubro","Novembro","Dezembro" });
            this.cmbMes.SelectedIndex = 0;
            this.cmbMes.Location = new System.Drawing.Point(16, 28);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(160, 24);

            this.lblAno = CriarLabel("ANO", 196, 8);
            this.txtAno.BackColor = System.Drawing.Color.FromArgb(30, 30, 27);
            this.txtAno.ForeColor = System.Drawing.Color.FromArgb(240, 239, 232);
            this.txtAno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAno.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAno.Location = new System.Drawing.Point(196, 28);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(80, 24);
            this.txtAno.Text = System.DateTime.Now.Year.ToString();

            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(200, 245, 90);
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(180, 220, 75);
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFiltrar.ForeColor = System.Drawing.Color.FromArgb(15, 15, 13);
            this.btnFiltrar.Location = new System.Drawing.Point(292, 26);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(96, 30);
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            // this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);

            // panelCards
            this.panelCards.Controls.Add(this.panelReceitas);
            this.panelCards.Controls.Add(this.panelDespesas);
            this.panelCards.Controls.Add(this.panelSaldo);
            this.panelCards.BackColor = System.Drawing.Color.FromArgb(15, 15, 13);
            this.panelCards.Location = new System.Drawing.Point(32, 160);
            this.panelCards.Name = "panelCards";
            this.panelCards.Size = new System.Drawing.Size(836, 84);

            // panelReceitas
            this.panelReceitas.BackColor = System.Drawing.Color.FromArgb(22, 22, 20);
            this.panelReceitas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelReceitas.Controls.Add(this.lblCardReceitas);
            this.panelReceitas.Controls.Add(this.lblValorReceitas);
            this.panelReceitas.Location = new System.Drawing.Point(0, 0);
            this.panelReceitas.Size = new System.Drawing.Size(268, 80);

            this.lblCardReceitas.AutoSize = true;
            this.lblCardReceitas.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblCardReceitas.ForeColor = System.Drawing.Color.FromArgb(122, 120, 110);
            this.lblCardReceitas.Location = new System.Drawing.Point(16, 14);
            this.lblCardReceitas.Text = "RECEITAS";

            this.lblValorReceitas.AutoSize = true;
            this.lblValorReceitas.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold);
            this.lblValorReceitas.ForeColor = System.Drawing.Color.FromArgb(200, 245, 90);
            this.lblValorReceitas.Location = new System.Drawing.Point(16, 34);
            this.lblValorReceitas.Name = "lblValorReceitas";
            this.lblValorReceitas.Text = "R$ 0,00";

            // panelDespesas
            this.panelDespesas.BackColor = System.Drawing.Color.FromArgb(22, 22, 20);
            this.panelDespesas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDespesas.Controls.Add(this.lblCardDespesas);
            this.panelDespesas.Controls.Add(this.lblValorDespesas);
            this.panelDespesas.Location = new System.Drawing.Point(284, 0);
            this.panelDespesas.Size = new System.Drawing.Size(268, 80);

            this.lblCardDespesas.AutoSize = true;
            this.lblCardDespesas.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblCardDespesas.ForeColor = System.Drawing.Color.FromArgb(122, 120, 110);
            this.lblCardDespesas.Location = new System.Drawing.Point(16, 14);
            this.lblCardDespesas.Text = "DESPESAS";

            this.lblValorDespesas.AutoSize = true;
            this.lblValorDespesas.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold);
            this.lblValorDespesas.ForeColor = System.Drawing.Color.FromArgb(224, 92, 92);
            this.lblValorDespesas.Location = new System.Drawing.Point(16, 34);
            this.lblValorDespesas.Name = "lblValorDespesas";
            this.lblValorDespesas.Text = "R$ 0,00";

            // panelSaldo
            this.panelSaldo.BackColor = System.Drawing.Color.FromArgb(22, 22, 20);
            this.panelSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSaldo.Controls.Add(this.lblCardSaldo);
            this.panelSaldo.Controls.Add(this.lblValorSaldo);
            this.panelSaldo.Location = new System.Drawing.Point(568, 0);
            this.panelSaldo.Size = new System.Drawing.Size(268, 80);

            this.lblCardSaldo.AutoSize = true;
            this.lblCardSaldo.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblCardSaldo.ForeColor = System.Drawing.Color.FromArgb(122, 120, 110);
            this.lblCardSaldo.Location = new System.Drawing.Point(16, 14);
            this.lblCardSaldo.Text = "SALDO";

            this.lblValorSaldo.AutoSize = true;
            this.lblValorSaldo.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold);
            this.lblValorSaldo.ForeColor = System.Drawing.Color.FromArgb(92, 168, 224);
            this.lblValorSaldo.Location = new System.Drawing.Point(16, 34);
            this.lblValorSaldo.Name = "lblValorSaldo";
            this.lblValorSaldo.Text = "R$ 0,00";

            // dgvRelatorio
            this.dgvRelatorio.AllowUserToAddRows = false;
            this.dgvRelatorio.AllowUserToDeleteRows = false;
            this.dgvRelatorio.BackgroundColor = System.Drawing.Color.FromArgb(22, 22, 20);
            this.dgvRelatorio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvRelatorio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRelatorio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvRelatorio.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(22, 22, 20);
            this.dgvRelatorio.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.dgvRelatorio.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(122, 120, 110);
            this.dgvRelatorio.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(22, 22, 20);
            this.dgvRelatorio.ColumnHeadersHeight = 40;
            this.dgvRelatorio.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(22, 22, 20);
            this.dgvRelatorio.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvRelatorio.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(240, 239, 232);
            this.dgvRelatorio.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(37, 37, 33);
            this.dgvRelatorio.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(200, 245, 90);
            this.dgvRelatorio.EnableHeadersVisualStyles = false;
            this.dgvRelatorio.GridColor = System.Drawing.Color.FromArgb(38, 38, 34);
            this.dgvRelatorio.Location = new System.Drawing.Point(32, 258);
            this.dgvRelatorio.MultiSelect = false;
            this.dgvRelatorio.Name = "dgvRelatorio";
            this.dgvRelatorio.ReadOnly = true;
            this.dgvRelatorio.RowHeadersVisible = false;
            this.dgvRelatorio.RowTemplate.Height = 42;
            this.dgvRelatorio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRelatorio.Size = new System.Drawing.Size(836, 340);
            this.dgvRelatorio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colDescricao, this.colCategoria, this.colData, this.colTipo, this.colValor });

            this.colDescricao.HeaderText = "DESCRIÇÃO";
            this.colDescricao.Name = "colDescricao";
            this.colDescricao.DataPropertyName = "Descricao";
            this.colDescricao.Width = 240;

            this.colCategoria.HeaderText = "CATEGORIA";
            this.colCategoria.Name = "colCategoria";
            this.colCategoria.DataPropertyName = "Categoria";
            this.colCategoria.Width = 180;

            this.colData.HeaderText = "DATA";
            this.colData.Name = "colData";
            this.colData.DataPropertyName = "Data";
            this.colData.Width = 110;

            this.colTipo.HeaderText = "TIPO";
            this.colTipo.Name = "colTipo";
            this.colTipo.DataPropertyName = "Tipo";
            this.colTipo.Width = 100;

            this.colValor.HeaderText = "VALOR";
            this.colValor.Name = "colValor";
            this.colValor.DataPropertyName = "Valor";
            this.colValor.DefaultCellStyle.Font = new System.Drawing.Font("Courier New", 9F);
            this.colValor.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colValor.Width = 120;

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(15, 15, 13);
            this.ClientSize = new System.Drawing.Size(900, 620);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.panelFiltros);
            this.Controls.Add(this.panelCards);
            this.Controls.Add(this.dgvRelatorio);
            this.Name = "FormRelatorios";
            this.Text = "Relatórios";

            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).EndInit();
            this.panelFiltros.ResumeLayout(false);
            this.panelFiltros.PerformLayout();
            this.panelCards.ResumeLayout(false);
            this.panelReceitas.ResumeLayout(false);
            this.panelReceitas.PerformLayout();
            this.panelDespesas.ResumeLayout(false);
            this.panelDespesas.PerformLayout();
            this.panelSaldo.ResumeLayout(false);
            this.panelSaldo.PerformLayout();
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
        private System.Windows.Forms.Panel panelFiltros;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Panel panelCards;
        private System.Windows.Forms.Panel panelReceitas;
        private System.Windows.Forms.Label lblCardReceitas;
        private System.Windows.Forms.Label lblValorReceitas;
        private System.Windows.Forms.Panel panelDespesas;
        private System.Windows.Forms.Label lblCardDespesas;
        private System.Windows.Forms.Label lblValorDespesas;
        private System.Windows.Forms.Panel panelSaldo;
        private System.Windows.Forms.Label lblCardSaldo;
        private System.Windows.Forms.Label lblValorSaldo;
        private System.Windows.Forms.DataGridView dgvRelatorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
    }
}