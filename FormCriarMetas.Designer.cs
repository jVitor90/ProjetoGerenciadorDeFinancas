namespace GerenciadorDeFinanças
{
    partial class FormCriarMeta
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblValorAlvo = new System.Windows.Forms.Label();
            this.txtValorAlvo = new System.Windows.Forms.TextBox();
            this.lblPrazo = new System.Windows.Forms.Label();
            this.dtpPrazo = new System.Windows.Forms.DateTimePicker();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panelForm.SuspendLayout();
            this.SuspendLayout();

            // ── lblTitulo ──────────────────────────────────────────────
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(240, 239, 232);
            this.lblTitulo.Location = new System.Drawing.Point(32, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "Nova meta";

            // ── lblSubtitulo ───────────────────────────────────────────
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(122, 120, 110);
            this.lblSubtitulo.Location = new System.Drawing.Point(33, 48);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Text = "Defina seu objetivo";

            // ── panelForm ──────────────────────────────────────────────
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(22, 22, 20);
            this.panelForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelForm.Controls.Add(this.lblNome);
            this.panelForm.Controls.Add(this.txtNome);
            this.panelForm.Controls.Add(this.lblCategoria);
            this.panelForm.Controls.Add(this.cmbCategoria);
            this.panelForm.Controls.Add(this.lblValorAlvo);
            this.panelForm.Controls.Add(this.txtValorAlvo);
            this.panelForm.Controls.Add(this.lblPrazo);
            this.panelForm.Controls.Add(this.dtpPrazo);
            this.panelForm.Controls.Add(this.lblObservacao);
            this.panelForm.Controls.Add(this.txtObservacao);
            this.panelForm.Controls.Add(this.btnCancelar);
            this.panelForm.Controls.Add(this.btnSalvar);
            this.panelForm.Location = new System.Drawing.Point(32, 76);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(520, 370);

            // ── lblNome / txtNome ──────────────────────────────────────
            this.lblNome = CriarLabel("NOME DA META", 20, 20);
            this.txtNome = CriarTextBox(20, 38, 476, false);
            this.txtNome.Name = "txtNome";

            // ── lblCategoria / cmbCategoria ────────────────────────────
            this.lblCategoria = CriarLabel("CATEGORIA", 20, 80);
            this.cmbCategoria = CriarComboBox(20, 98, 230);
            this.cmbCategoria.Items.AddRange(new object[] {
                "Viagem", "Emergência", "Educação",
                "Moradia", "Veículo", "Investimento", "Outro" });
            this.cmbCategoria.SelectedIndex = 0;
            this.cmbCategoria.Name = "cmbCategoria";

            // ── lblValorAlvo / txtValorAlvo ────────────────────────────
            this.lblValorAlvo = CriarLabel("VALOR ALVO (R$)", 20, 140);
            this.txtValorAlvo = CriarTextBox(20, 158, 230, false);
            this.txtValorAlvo.Font = new System.Drawing.Font("Courier New", 10F);
            this.txtValorAlvo.ForeColor = System.Drawing.Color.FromArgb(200, 245, 90);
            this.txtValorAlvo.Name = "txtValorAlvo";

            // ── lblPrazo / dtpPrazo ────────────────────────────────────
            this.lblPrazo = CriarLabel("PRAZO", 266, 140);
            this.dtpPrazo.CalendarForeColor = System.Drawing.Color.FromArgb(240, 239, 232);
            this.dtpPrazo.CalendarMonthBackground = System.Drawing.Color.FromArgb(30, 30, 27);
            this.dtpPrazo.CalendarTitleBackColor = System.Drawing.Color.FromArgb(22, 22, 20);
            this.dtpPrazo.CalendarTitleForeColor = System.Drawing.Color.FromArgb(200, 245, 90);
            this.dtpPrazo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPrazo.Location = new System.Drawing.Point(266, 158);
            this.dtpPrazo.Name = "dtpPrazo";
            this.dtpPrazo.Size = new System.Drawing.Size(230, 24);

            // ── lblObservacao / txtObservacao ──────────────────────────
            this.lblObservacao = CriarLabel("OBSERVAÇÃO", 20, 200);
            this.txtObservacao = CriarTextBox(20, 218, 476, true);
            this.txtObservacao.Name = "txtObservacao";

            // ── btnCancelar ────────────────────────────────────────────
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(30, 30, 27);
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 60, 56);
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(37, 37, 33);
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(122, 120, 110);
            this.btnCancelar.Location = new System.Drawing.Point(316, 318);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 34);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;

            // ── btnSalvar ──────────────────────────────────────────────
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(200, 245, 90);
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(180, 220, 75);
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSalvar.ForeColor = System.Drawing.Color.FromArgb(15, 15, 13);
            this.btnSalvar.Location = new System.Drawing.Point(412, 318);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(88, 34);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;

            // ── Form ───────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(15, 15, 13);
            this.ClientSize = new System.Drawing.Size(584, 474);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.panelForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCriarMeta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nova Meta";

            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
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

        private System.Windows.Forms.TextBox CriarTextBox(int x, int y, int w, bool multiline)
        {
            var txt = new System.Windows.Forms.TextBox();
            txt.BackColor = System.Drawing.Color.FromArgb(30, 30, 27);
            txt.ForeColor = System.Drawing.Color.FromArgb(240, 239, 232);
            txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txt.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txt.Location = new System.Drawing.Point(x, y);
            txt.Size = new System.Drawing.Size(w, multiline ? 72 : 24);
            txt.Multiline = multiline;
            return txt;
        }

        private System.Windows.Forms.ComboBox CriarComboBox(int x, int y, int w)
        {
            var cmb = new System.Windows.Forms.ComboBox();
            cmb.BackColor = System.Drawing.Color.FromArgb(30, 30, 27);
            cmb.ForeColor = System.Drawing.Color.FromArgb(240, 239, 232);
            cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cmb.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            cmb.Location = new System.Drawing.Point(x, y);
            cmb.Size = new System.Drawing.Size(w, 24);
            return cmb;
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblValorAlvo;
        private System.Windows.Forms.TextBox txtValorAlvo;
        private System.Windows.Forms.Label lblPrazo;
        private System.Windows.Forms.DateTimePicker dtpPrazo;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
    }
}