namespace GerenciadorDeFinanças
{
    public partial class FormCriarMeta : Form
    {
        // Propriedades públicas lidas por FormMetas após DialogResult.OK
        public string NomeMeta { get; private set; } = string.Empty;
        public string CategoriaMeta { get; private set; } = string.Empty;
        public decimal ValorAlvo { get; private set; }
        public DateTime PrazoMeta { get; private set; }

        public FormCriarMeta()
        {
            InitializeComponent();

            btnCancelar.Click += (s, e) =>
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            };

            btnSalvar.Click += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtNome.Text))
                {
                    MessageBox.Show("Informe o nome da meta.",
                        "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(
                        txtValorAlvo.Text.Replace("R$", "").Replace(".", "").Replace(",", ".").Trim(),
                        System.Globalization.NumberStyles.Any,
                        System.Globalization.CultureInfo.InvariantCulture,
                        out decimal valor) || valor <= 0)
                {
                    MessageBox.Show("Informe um valor alvo válido.",
                        "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                NomeMeta = txtNome.Text.Trim();
                CategoriaMeta = cmbCategoria.SelectedItem?.ToString() ?? "-";
                ValorAlvo = valor;
                PrazoMeta = dtpPrazo.Value;

                this.DialogResult = DialogResult.OK;
                this.Close();
            };
        }
    }
}