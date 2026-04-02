namespace GerenciadorDeFinanças
{
    partial class FormCadastroReceitas
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
            this.lblObservacao = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panelForm.SuspendLayout();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(240, 239, 232);
            this.lblTitulo.Location = new System.Drawing.Point(32, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "Nova receita";

            // lblSubtitulo
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(122, 120, 110);
            this.lblSubtitulo.Location = new System.Drawing.Point(33, 48);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Text = "Preencha os dados";

            // panelForm
            this.panelForm.BackColor = System.Drawing.Color.FromArgb(22, 22, 20);
            this.panelForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelForm.Controls.Add(this.lblDescricao);
            this.panelForm.Controls.Add(this.txtDescricao);
            this.panelForm.Controls.Add(this.lblValor);
            this.panelForm.Controls.Add(this.txtValor);
            this.panelForm.Controls.Add(this.lblData);
            this.panelForm.Controls.Add(this.dtpData);
            this.panelForm.Controls.Add(this.lblCategoria);
            this.panelForm.Controls.Add(this.cmbCategoria);
            this.panelForm.Controls.Add(this.lblObservacao);
            this.panelForm.Controls.Add(this.txtObservacao);
            this.panelForm.Controls.Add(this.btnCancelar);
            this.panelForm.Controls.Add(this.btnSalvar);
            this.panelForm.Location = new System.Drawing.Point(32, 76);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(560, 380);

            // lblDescricao
            this.lblDescricao = CriarLabel("DESCRIÇÃO", 20, 20);
            this.txtDescricao = CriarTextBox(20, 38, 516, false);
            this.txtDescricao.Name = "txtDescricao";

            // lblValor
            this.lblValor = CriarLabel("VALOR (R$)", 20, 80);
            this.txtValor = CriarTextBox(20, 98, 240, false);
            this.txtValor.Font = new System.Drawing.Font("Courier New", 10F);
            this.txtValor.ForeColor = System.Drawing.Color.FromArgb(200, 245, 90);
            this.txtValor.Name = "txtValor";

            // lblData
            this.lblData = CriarLabel("DATA", 276, 80);
            this.dtpData.CalendarForeColor = System.Drawing.Color.FromArgb(240, 239, 232);
            this.dtpData.CalendarMonthBackground = System.Drawing.Color.FromArgb(30, 30, 27);
            this.dtpData.CalendarTitleBackColor = System.Drawing.Color.FromArgb(22, 22, 20);
            this.dtpData.CalendarTitleForeColor = System.Drawing.Color.FromArgb(200, 245, 90);
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(276, 98);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(260, 23);

            // lblCategoria
            this.lblCategoria = CriarLabel("CATEGORIA", 20, 140);
            this.cmbCategoria = CriarComboBox(20, 158, 516);
            this.cmbCategoria.Name = "cmbCategoria";

            // lblObservacao
            this.lblObservacao = CriarLabel("OBSERVAÇÃO", 20, 200);
            this.txtObservacao = CriarTextBox(20, 218, 516, true);
            this.txtObservacao.Name = "txtObservacao";

            // btnCancelar
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(30, 30, 27);
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 60, 56);
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(37, 37, 33);
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(122, 120, 110);
            this.btnCancelar.Location = new System.Drawing.Point(356, 322);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 34);
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
            this.btnSalvar.Location = new System.Drawing.Point(452, 322);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(88, 34);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            // this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(15, 15, 13);
            this.ClientSize = new System.Drawing.Size(624, 490);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.panelForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormCadastroReceitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nova Receita";

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
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
    }
}