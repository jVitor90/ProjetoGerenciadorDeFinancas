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
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            panelForm = new Panel();
            lblNome = new Label();
            txtNome = new TextBox();
            lblCategoria = new Label();
            cmbCategoria = new ComboBox();
            lblValorAlvo = new Label();
            txtValorAlvo = new TextBox();
            lblPrazo = new Label();
            dtpPrazo = new DateTimePicker();
            lblObservacao = new Label();
            txtObservacao = new TextBox();
            btnCancelar = new Button();
            btnSalvar = new Button();
            panelForm.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F);
            lblTitulo.ForeColor = Color.FromArgb(240, 239, 232);
            lblTitulo.Location = new Point(32, 24);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(103, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Nova meta";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 8.5F);
            lblSubtitulo.ForeColor = Color.FromArgb(122, 120, 110);
            lblSubtitulo.Location = new Point(33, 48);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(108, 15);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Defina seu objetivo";
            // 
            // panelForm
            // 
            panelForm.BackColor = Color.FromArgb(22, 22, 20);
            panelForm.BorderStyle = BorderStyle.FixedSingle;
            panelForm.Controls.Add(lblNome);
            panelForm.Controls.Add(txtNome);
            panelForm.Controls.Add(lblCategoria);
            panelForm.Controls.Add(cmbCategoria);
            panelForm.Controls.Add(lblValorAlvo);
            panelForm.Controls.Add(txtValorAlvo);
            panelForm.Controls.Add(lblPrazo);
            panelForm.Controls.Add(dtpPrazo);
            panelForm.Controls.Add(lblObservacao);
            panelForm.Controls.Add(txtObservacao);
            panelForm.Controls.Add(btnCancelar);
            panelForm.Controls.Add(btnSalvar);
            panelForm.Location = new Point(32, 76);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(520, 370);
            panelForm.TabIndex = 2;
            // 
            // lblNome
            // 
            lblNome.Location = new Point(0, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(100, 23);
            lblNome.TabIndex = 0;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(0, 0);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 1;
            // 
            // lblCategoria
            // 
            lblCategoria.Location = new Point(0, 0);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(100, 23);
            lblCategoria.TabIndex = 2;
            // 
            // cmbCategoria
            // 
            cmbCategoria.Items.AddRange(new object[] { "Viagem", "Emergência", "Educação", "Moradia", "Veículo", "Investimento", "Outro" });
            cmbCategoria.Location = new Point(0, 0);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(121, 23);
            cmbCategoria.TabIndex = 3;
            // 
            // lblValorAlvo
            // 
            lblValorAlvo.Location = new Point(0, 0);
            lblValorAlvo.Name = "lblValorAlvo";
            lblValorAlvo.Size = new Size(100, 23);
            lblValorAlvo.TabIndex = 4;
            // 
            // txtValorAlvo
            // 
            txtValorAlvo.Font = new Font("Courier New", 10F);
            txtValorAlvo.ForeColor = Color.FromArgb(200, 245, 90);
            txtValorAlvo.Location = new Point(0, 0);
            txtValorAlvo.Name = "txtValorAlvo";
            txtValorAlvo.Size = new Size(100, 23);
            txtValorAlvo.TabIndex = 5;
            // 
            // lblPrazo
            // 
            lblPrazo.Location = new Point(0, 0);
            lblPrazo.Name = "lblPrazo";
            lblPrazo.Size = new Size(100, 23);
            lblPrazo.TabIndex = 6;
            // 
            // dtpPrazo
            // 
            dtpPrazo.CalendarForeColor = Color.FromArgb(240, 239, 232);
            dtpPrazo.CalendarMonthBackground = Color.FromArgb(30, 30, 27);
            dtpPrazo.CalendarTitleBackColor = Color.FromArgb(22, 22, 20);
            dtpPrazo.CalendarTitleForeColor = Color.FromArgb(200, 245, 90);
            dtpPrazo.Format = DateTimePickerFormat.Short;
            dtpPrazo.Location = new Point(266, 158);
            dtpPrazo.Name = "dtpPrazo";
            dtpPrazo.Size = new Size(230, 23);
            dtpPrazo.TabIndex = 7;
            // 
            // lblObservacao
            // 
            lblObservacao.Location = new Point(0, 0);
            lblObservacao.Name = "lblObservacao";
            lblObservacao.Size = new Size(100, 23);
            lblObservacao.TabIndex = 8;
            // 
            // txtObservacao
            // 
            txtObservacao.Location = new Point(0, 0);
            txtObservacao.Name = "txtObservacao";
            txtObservacao.Size = new Size(100, 23);
            txtObservacao.TabIndex = 9;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(30, 30, 27);
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 56);
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 37, 33);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F);
            btnCancelar.ForeColor = Color.FromArgb(122, 120, 110);
            btnCancelar.Location = new Point(316, 318);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(84, 34);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.FromArgb(200, 245, 90);
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.FlatAppearance.BorderSize = 0;
            btnSalvar.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, 220, 75);
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSalvar.ForeColor = Color.FromArgb(15, 15, 13);
            btnSalvar.Location = new Point(412, 318);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(88, 34);
            btnSalvar.TabIndex = 11;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FormCriarMeta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 13);
            ClientSize = new Size(584, 474);
            Controls.Add(lblTitulo);
            Controls.Add(lblSubtitulo);
            Controls.Add(panelForm);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCriarMeta";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nova Meta";
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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