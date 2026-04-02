namespace GerenciadorDeFinanças
{
    public partial class FormDespesas : Form
    {
        public FormDespesas()
        {
            InitializeComponent();
            btnNovaDespesa.Click += (s, e) => new FormCadastroDespesas().ShowDialog();
        }
    }
}