namespace GerenciadorDeFinanças
{
    partial class FormCadastroDespesas
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
            this.panelForm = new System.Windows.Forms.Panel();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbPago = new System.Windows.Forms.ComboBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblLista = new System.Windows.Forms.Label();
            this.dgvDespesas = new System.Windows.Forms.DataGridView();
            this.colExcluir = new System.Windows.Forms.DataGridViewButtonColumn();

            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesas)).BeginInit();
            this.SuspendLayout();

            // ── Form ───────────────────────────────────────────────────────
            this.BackColor = System.Drawing.Color.FromArgb(15, 15, 13);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 680);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormCadastroDespesas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Despesas";

            // ── lblTitulo ──────────────────────────────────────────────────
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(240, 239, 232);
            this.lblTitulo.Location = new System.Drawing.Point(32, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "Nova despesa";

            // ── lblSubtitulo ───────────────────────────────────────────────
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(122, 120, 110);
            this.lblSubtitulo.Location = new System.Drawing.Point(33, 46);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Text = "Preencha os dados";

            // ── panelForm ──────────────────────────────────────────────────
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(22, 22, 20);
            this.panelForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelForm.Location = new System.Drawing.Point(32, 72);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(860, 230);

            // ── lblDescricao ───────────────────────────────────────────────
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblDescricao.ForeColor = System.Drawing.Color.FromArgb(122, 120, 110);
            this.lblDescricao.Location = new System.Drawing.Point(16, 16);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Text = "DESCRICAO";

            // ── txtDescricao ───────────────────────────────────────────────
            this.txtDescricao.BackColor = System.Drawing.Color.FromArgb(30, 30, 27);
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricao.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtDescricao.ForeColor = System.Drawing.Color.FromArgb(240, 239, 232);
            this.txtDescricao.Location = new System.Drawing.Point(16, 34);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(828, 24);

            // ── lblValor ───────────────────────────────────────────────────
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblValor.ForeColor = System.Drawing.Color.FromArgb(122, 120, 110);
            this.lblValor.Location = new System.Drawing.Point(16, 72);
            this.lblValor.Name = "lblValor";
            this.lblValor.Text = "VALOR (R$)";

            // ── txtValor ───────────────────────────────────────────────────
            this.txtValor.BackColor = System.Drawing.Color.FromArgb(30, 30, 27);
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor.Font = new System.Drawing.Font("Courier New", 10F);
            this.txtValor.ForeColor = System.Drawing.Color.FromArgb(224, 92, 92);
            this.txtValor.Location = new System.Drawing.Point(16, 90);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(200, 24);

            // ── lblData ────────────────────────────────────────────────────
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblData.ForeColor = System.Drawing.Color.FromArgb(122, 120, 110);
            this.lblData.Location = new System.Drawing.Point(228, 72);
            this.lblData.Name = "lblData";
            this.lblData.Text = "DATA";

            // ── dtpData ────────────────────────────────────────────────────
            this.dtpData.CalendarForeColor = System.Drawing.Color.FromArgb(240, 239, 232);
            this.dtpData.CalendarMonthBackground = System.Drawing.Color.FromArgb(30, 30, 27);
            this.dtpData.CalendarTitleBackColor = System.Drawing.Color.FromArgb(22, 22, 20);
            this.dtpData.CalendarTitleForeColor = System.Drawing.Color.FromArgb(200, 245, 90);
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(228, 90);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(180, 24);

            // ── lblCategoria ───────────────────────────────────────────────
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(122, 120, 110);
            this.lblCategoria.Location = new System.Drawing.Point(424, 72);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Text = "CATEGORIA";

            // ── cmbCategoria ───────────────────────────────────────────────
            this.cmbCategoria.BackColor = System.Drawing.Color.FromArgb(30, 30, 27);
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategoria.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbCategoria.ForeColor = System.Drawing.Color.FromArgb(240, 239, 232);
            this.cmbCategoria.Location = new System.Drawing.Point(424, 90);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(220, 24);

            // ── lblStatus ──────────────────────────────────────────────────
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(122, 120, 110);
            this.lblStatus.Location = new System.Drawing.Point(660, 72);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Text = "STATUS";

            // ── cmbPago ────────────────────────────────────────────────────
            this.cmbPago.BackColor = System.Drawing.Color.FromArgb(30, 30, 27);
            this.cmbPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPago.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbPago.ForeColor = System.Drawing.Color.FromArgb(240, 239, 232);
            this.cmbPago.Items.AddRange(new object[] { "Pendente", "Pago" });
            this.cmbPago.SelectedIndex = 0;
            this.cmbPago.Location = new System.Drawing.Point(660, 90);
            this.cmbPago.Name = "cmbPago";
            this.cmbPago.Size = new System.Drawing.Size(184, 24);

            // ── lblObservacao ──────────────────────────────────────────────
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblObservacao.ForeColor = System.Drawing.Color.FromArgb(122, 120, 110);
            this.lblObservacao.Location = new System.Drawing.Point(16, 130);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Text = "OBSERVACAO";

            // ── txtObservacao ──────────────────────────────────────────────
            this.txtObservacao.BackColor = System.Drawing.Color.FromArgb(30, 30, 27);
            this.txtObservacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservacao.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtObservacao.ForeColor = System.Drawing.Color.FromArgb(240, 239, 232);
            this.txtObservacao.Location = new System.Drawing.Point(16, 148);
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(828, 24);

            // ── btnCancelar ────────────────────────────────────────────────
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(30, 30, 27);
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 60, 56);
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 40, 36);
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(122, 120, 110);
            this.btnCancelar.Location = new System.Drawing.Point(648, 186);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 32);
            this.btnCancelar.Text = "Limpar";
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            // ── btnSalvar ──────────────────────────────────────────────────
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(200, 245, 90);
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(180, 220, 75);
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.ForeColor = System.Drawing.Color.FromArgb(15, 15, 13);
            this.btnSalvar.Location = new System.Drawing.Point(748, 186);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(96, 32);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);

            // adiciona ao panel depois de tudo configurado
            this.panelForm.Controls.Add(this.lblDescricao);
            this.panelForm.Controls.Add(this.txtDescricao);
            this.panelForm.Controls.Add(this.lblValor);
            this.panelForm.Controls.Add(this.txtValor);
            this.panelForm.Controls.Add(this.lblData);
            this.panelForm.Controls.Add(this.dtpData);
            this.panelForm.Controls.Add(this.lblCategoria);
            this.panelForm.Controls.Add(this.cmbCategoria);
            this.panelForm.Controls.Add(this.lblStatus);
            this.panelForm.Controls.Add(this.cmbPago);
            this.panelForm.Controls.Add(this.lblObservacao);
            this.panelForm.Controls.Add(this.txtObservacao);
            this.panelForm.Controls.Add(this.btnCancelar);
            this.panelForm.Controls.Add(this.btnSalvar);

            // ── lblLista ───────────────────────────────────────────────────
            this.lblLista.AutoSize = true;
            this.lblLista.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.lblLista.ForeColor = System.Drawing.Color.FromArgb(122, 120, 110);
            this.lblLista.Location = new System.Drawing.Point(32, 316);
            this.lblLista.Name = "lblLista";
            this.lblLista.Text = "DESPESAS CADASTRADAS";

            // ── dgvDespesas ────────────────────────────────────────────────
            this.dgvDespesas.AllowUserToAddRows = false;
            this.dgvDespesas.AllowUserToDeleteRows = false;
            this.dgvDespesas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDespesas.BackgroundColor = System.Drawing.Color.FromArgb(22, 22, 20);
            this.dgvDespesas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDespesas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDespesas.GridColor = System.Drawing.Color.FromArgb(40, 40, 36);
            this.dgvDespesas.Location = new System.Drawing.Point(32, 334);
            this.dgvDespesas.MultiSelect = false;
            this.dgvDespesas.Name = "dgvDespesas";
            this.dgvDespesas.ReadOnly = true;
            this.dgvDespesas.RowHeadersVisible = false;
            this.dgvDespesas.RowTemplate.Height = 40;
            this.dgvDespesas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDespesas.Size = new System.Drawing.Size(860, 320);
            this.dgvDespesas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDespesas_CellClick);

            this.dgvDespesas.EnableHeadersVisualStyles = false;
            this.dgvDespesas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDespesas.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(22, 22, 20);
            this.dgvDespesas.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(122, 120, 110);
            this.dgvDespesas.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.dgvDespesas.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(22, 22, 20);
            this.dgvDespesas.ColumnHeadersHeight = 32;

            this.dgvDespesas.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(22, 22, 20);
            this.dgvDespesas.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(240, 239, 232);
            this.dgvDespesas.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dgvDespesas.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(35, 35, 30);
            this.dgvDespesas.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(240, 239, 232);

            // coluna excluir
            this.colExcluir.HeaderText = "";
            this.colExcluir.Name = "colExcluir";
            this.colExcluir.Text = "x";
            this.colExcluir.UseColumnTextForButtonValue = true;
            this.colExcluir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colExcluir.Width = 40;
            this.colExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colExcluir.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(50, 22, 22);
            this.colExcluir.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(200, 80, 80);
            this.colExcluir.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.colExcluir.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvDespesas.Columns.Add(this.colExcluir);

            // ── adiciona ao Form ───────────────────────────────────────────
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.dgvDespesas);

            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDespesas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbPago;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.DataGridView dgvDespesas;
        private System.Windows.Forms.DataGridViewButtonColumn colExcluir;
    }
}