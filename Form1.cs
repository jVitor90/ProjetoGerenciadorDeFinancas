namespace GerenciadorDeFinanças
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void btnReceitas_Click(object sender, EventArgs e)
        {
            new FormReceitas().ShowDialog();
        }

        private void btnDespesas_Click(object sender, EventArgs e)
        {
            new FormDespesas().ShowDialog();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
            => new FormCategorias().ShowDialog();

        private void btnMetas_Click(object sender, EventArgs e)
            => new FormMetas().ShowDialog();

        private void btnRelatorios_Click(object sender, EventArgs e)
            => new FormRelatorios().ShowDialog();
    }
}