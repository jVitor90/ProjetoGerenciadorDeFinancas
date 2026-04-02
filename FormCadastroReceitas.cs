namespace GerenciadorDeFinanças
{
    public partial class FormCadastroReceitas : Form
    {
        public FormCadastroReceitas()
        {
            InitializeComponent();
            btnCancelar.Click += (s, e) => this.Close();
            btnSalvar.Click += (s, e) =>
            {
                // Validação mínima
                if (string.IsNullOrWhiteSpace(txtDescricao.Text) ||
                    string.IsNullOrWhiteSpace(txtValor.Text))
                {
                    MessageBox.Show("Preencha ao menos Descrição e Valor.",
                        "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // TODO: salvar no banco de dados
                this.Close();
            };
        }
    }
}