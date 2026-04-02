namespace GerenciadorDeFinanças
{
    partial class Form1
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
            panelSidebar = new Panel();
            lblLogo = new Label();
            lblLogoSub = new Label();
            panelNavTop = new Panel();
            lblConfigGrupo = new Label();
            btnCategorias = new Button();
            btnMetas = new Button();
            btnRelatorios = new Button();
            panelSidebarFooter = new Panel();
            lblSaldoLabel = new Label();
            lblSaldoValor = new Label();
            btnDashboard = new Button();
            btnReceitas = new Button();
            btnDespesas = new Button();
            panelConteudo = new Panel();
            panelSidebar.SuspendLayout();
            panelSidebarFooter.SuspendLayout();
            SuspendLayout();

            // panelSidebar
            panelSidebar.BackColor = Color.FromArgb(22, 22, 20);
            panelSidebar.Controls.Add(lblLogo);
            panelSidebar.Controls.Add(lblLogoSub);
            panelSidebar.Controls.Add(panelNavTop);
            panelSidebar.Controls.Add(lblConfigGrupo);
            panelSidebar.Controls.Add(btnCategorias);
            panelSidebar.Controls.Add(btnMetas);
            panelSidebar.Controls.Add(btnRelatorios);
            panelSidebar.Controls.Add(btnDashboard);
            panelSidebar.Controls.Add(btnReceitas);
            panelSidebar.Controls.Add(btnDespesas);
            panelSidebar.Controls.Add(panelSidebarFooter);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(220, 650);
            panelSidebar.TabIndex = 1;

            // lblLogo
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Courier New", 14F, FontStyle.Bold);
            lblLogo.ForeColor = Color.FromArgb(200, 245, 90);
            lblLogo.Location = new Point(22, 26);
            lblLogo.Name = "lblLogo";
            lblLogo.Text = "financy";

            // lblLogoSub
            lblLogoSub.AutoSize = true;
            lblLogoSub.Font = new Font("Segoe UI", 7F);
            lblLogoSub.ForeColor = Color.FromArgb(122, 120, 110);
            lblLogoSub.Location = new Point(23, 48);
            lblLogoSub.Name = "lblLogoSub";
            lblLogoSub.Text = "GERENCIADOR";

            // panelNavTop
            panelNavTop.BackColor = Color.FromArgb(38, 38, 34);
            panelNavTop.Location = new Point(0, 70);
            panelNavTop.Name = "panelNavTop";
            panelNavTop.Size = new Size(220, 1);

            // btnDashboard
            btnDashboard.BackColor = Color.FromArgb(22, 22, 20);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 27);
            btnDashboard.Font = new Font("Segoe UI", 9.5F);
            btnDashboard.ForeColor = Color.FromArgb(122, 120, 110);
            btnDashboard.Location = new Point(0, 82);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(220, 34);
            btnDashboard.Text = "    Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Cursor = Cursors.Hand;

            // btnReceitas
            btnReceitas.BackColor = Color.FromArgb(22, 22, 20);
            btnReceitas.FlatStyle = FlatStyle.Flat;
            btnReceitas.FlatAppearance.BorderSize = 0;
            btnReceitas.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 27);
            btnReceitas.Font = new Font("Segoe UI", 9.5F);
            btnReceitas.ForeColor = Color.FromArgb(122, 120, 110);
            btnReceitas.Location = new Point(0, 118);
            btnReceitas.Name = "btnReceitas";
            btnReceitas.Size = new Size(220, 34);
            btnReceitas.Text = "    Receitas";
            btnReceitas.TextAlign = ContentAlignment.MiddleLeft;
            btnReceitas.Cursor = Cursors.Hand;
            btnReceitas.Click += btnReceitas_Click;

            // btnDespesas
            btnDespesas.BackColor = Color.FromArgb(22, 22, 20);
            btnDespesas.FlatStyle = FlatStyle.Flat;
            btnDespesas.FlatAppearance.BorderSize = 0;
            btnDespesas.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 27);
            btnDespesas.Font = new Font("Segoe UI", 9.5F);
            btnDespesas.ForeColor = Color.FromArgb(122, 120, 110);
            btnDespesas.Location = new Point(0, 154);
            btnDespesas.Name = "btnDespesas";
            btnDespesas.Size = new Size(220, 34);
            btnDespesas.Text = "    Despesas";
            btnDespesas.TextAlign = ContentAlignment.MiddleLeft;
            btnDespesas.Cursor = Cursors.Hand;
            btnDespesas.Click += btnDespesas_Click;

            // lblConfigGrupo
            lblConfigGrupo.AutoSize = true;
            lblConfigGrupo.Font = new Font("Segoe UI", 7F);
            lblConfigGrupo.ForeColor = Color.FromArgb(122, 120, 110);
            lblConfigGrupo.Location = new Point(22, 204);
            lblConfigGrupo.Name = "lblConfigGrupo";
            lblConfigGrupo.Text = "CONFIG";

            // btnCategorias
            btnCategorias.BackColor = Color.FromArgb(22, 22, 20);
            btnCategorias.FlatStyle = FlatStyle.Flat;
            btnCategorias.FlatAppearance.BorderSize = 0;
            btnCategorias.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 27);
            btnCategorias.Font = new Font("Segoe UI", 9.5F);
            btnCategorias.ForeColor = Color.FromArgb(122, 120, 110);
            btnCategorias.Location = new Point(0, 220);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(220, 34);
            btnCategorias.Text = "    Categorias";
            btnCategorias.TextAlign = ContentAlignment.MiddleLeft;
            btnCategorias.Cursor = Cursors.Hand;
            btnCategorias.Click += btnCategorias_Click;

            // btnMetas
            btnMetas.BackColor = Color.FromArgb(22, 22, 20);
            btnMetas.FlatStyle = FlatStyle.Flat;
            btnMetas.FlatAppearance.BorderSize = 0;
            btnMetas.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 27);
            btnMetas.Font = new Font("Segoe UI", 9.5F);
            btnMetas.ForeColor = Color.FromArgb(122, 120, 110);
            btnMetas.Location = new Point(0, 256);
            btnMetas.Name = "btnMetas";
            btnMetas.Size = new Size(220, 34);
            btnMetas.Text = "    Metas";
            btnMetas.TextAlign = ContentAlignment.MiddleLeft;
            btnMetas.Cursor = Cursors.Hand;
            btnMetas.Click += btnMetas_Click;

            // btnRelatorios
            btnRelatorios.BackColor = Color.FromArgb(22, 22, 20);
            btnRelatorios.FlatStyle = FlatStyle.Flat;
            btnRelatorios.FlatAppearance.BorderSize = 0;
            btnRelatorios.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 27);
            btnRelatorios.Font = new Font("Segoe UI", 9.5F);
            btnRelatorios.ForeColor = Color.FromArgb(122, 120, 110);
            btnRelatorios.Location = new Point(0, 292);
            btnRelatorios.Name = "btnRelatorios";
            btnRelatorios.Size = new Size(220, 34);
            btnRelatorios.Text = "    Relatórios";
            btnRelatorios.TextAlign = ContentAlignment.MiddleLeft;
            btnRelatorios.Cursor = Cursors.Hand;
            btnRelatorios.Click += btnRelatorios_Click;

            // panelSidebarFooter
            panelSidebarFooter.BackColor = Color.FromArgb(22, 22, 20);
            panelSidebarFooter.Controls.Add(lblSaldoLabel);
            panelSidebarFooter.Controls.Add(lblSaldoValor);
            panelSidebarFooter.Dock = DockStyle.Bottom;
            panelSidebarFooter.Location = new Point(0, 570);
            panelSidebarFooter.Name = "panelSidebarFooter";
            panelSidebarFooter.Padding = new Padding(0, 1, 0, 0);
            panelSidebarFooter.Size = new Size(220, 80);

            // lblSaldoLabel
            lblSaldoLabel.AutoSize = true;
            lblSaldoLabel.Font = new Font("Segoe UI", 7.5F);
            lblSaldoLabel.ForeColor = Color.FromArgb(122, 120, 110);
            lblSaldoLabel.Location = new Point(22, 12);
            lblSaldoLabel.Name = "lblSaldoLabel";
            lblSaldoLabel.Text = "SALDO ATUAL";

            // lblSaldoValor
            lblSaldoValor.AutoSize = true;
            lblSaldoValor.Font = new Font("Courier New", 13F, FontStyle.Bold);
            lblSaldoValor.ForeColor = Color.FromArgb(200, 245, 90);
            lblSaldoValor.Location = new Point(20, 32);
            lblSaldoValor.Name = "lblSaldoValor";
            lblSaldoValor.Text = "R$ 0,00";

            // panelConteudo
            panelConteudo.BackColor = Color.FromArgb(15, 15, 13);
            panelConteudo.Dock = DockStyle.Fill;
            panelConteudo.Location = new Point(220, 0);
            panelConteudo.Name = "panelConteudo";
            panelConteudo.Size = new Size(980, 650);

            // Form1
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 13);
            ClientSize = new Size(1200, 650);
            Controls.Add(panelConteudo);
            Controls.Add(panelSidebar);
            Font = new Font("Segoe UI", 9F);
            MinimumSize = new Size(1000, 550);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Financy — Gerenciador Financeiro";
            Load += Form1_Load;

            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            panelSidebarFooter.ResumeLayout(false);
            panelSidebarFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblLogoSub;
        private System.Windows.Forms.Panel panelNavTop;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnReceitas;
        private System.Windows.Forms.Button btnDespesas;
        private System.Windows.Forms.Label lblConfigGrupo;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnMetas;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.Panel panelSidebarFooter;
        private System.Windows.Forms.Label lblSaldoLabel;
        private System.Windows.Forms.Label lblSaldoValor;
        private System.Windows.Forms.Panel panelConteudo;
    }
}