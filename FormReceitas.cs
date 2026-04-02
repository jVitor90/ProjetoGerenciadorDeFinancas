namespace GerenciadorDeFinanças
{
    public partial class FormReceitas : Form
    {
        public FormReceitas()
        {
            InitializeComponent();
            btnNovaReceita.Click += (s, e) => new FormCadastroReceitas().ShowDialog();
        }
    }
}