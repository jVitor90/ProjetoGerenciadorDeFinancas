namespace GerenciadorDeFinanças
{
    public partial class FormMetas : Form
    {
        public FormMetas()
        {
            InitializeComponent();

            btnNovaMeta.Click += (s, e) =>
            {
                using var form = new FormCriarMeta();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // TODO: recarregar lista do banco
                    // Por enquanto adiciona direto no grid como demonstração
                    dgvMetas.Rows.Add(
                        form.NomeMeta,
                        form.CategoriaMeta,
                        form.ValorAlvo.ToString("C2"),
                        "R$ 0,00",
                        "0%",
                        form.PrazoMeta.ToShortDateString()
                    );
                }
            };

            dgvMetas.CellClick += (s, e) =>
            {
                if (e.ColumnIndex == colExcluir.Index && e.RowIndex >= 0)
                {
                    var confirm = MessageBox.Show(
                        "Excluir esta meta?", "Confirmar",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirm == DialogResult.Yes)
                        dgvMetas.Rows.RemoveAt(e.RowIndex);
                }
            };
        }
    }
}