using GerenciadorDeFinanças.Model;

namespace GerenciadorDeFinanças
{
    public partial class FormCategorias : Form
    {
        public FormCategorias()
        {
            InitializeComponent();
            AtualizarDGV();
            Model.Categorias categorias = new Model.Categorias();

            btnNovaCategoria.Click += (s, e) =>
            {
                panelCadastro.Visible = true;
                // empurra o grid para baixo do painel de cadastro
                dgvCategorias.Location = new System.Drawing.Point(32, 190);
                dgvCategorias.Size = new System.Drawing.Size(780, 330);
            };
        }
        public void AtualizarDGV()
        {
            Model.Categorias categorias = new Model.Categorias();
            dgvCategorias.DataSource = categorias.ListarCategorias();

        }

        private void btnNovaCategoria_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Length <= 0)
            {
                MessageBox.Show("Nome não informado");
            }
            else if (cmbTipo.SelectedIndex <= 0)
            {
                MessageBox.Show("Tipo não informado");
            }
            else
            {
                Model.Categorias categorias = new Model.Categorias();
                categorias.Nome = txtNome.Text;
                categorias.Tipo = cmbTipo.Text;

                DialogResult cadastrar = MessageBox.Show("Tem certeza que deseja cadastrar?", "Erro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (cadastrar == DialogResult.Yes)
                {
                    if (categorias.CadastrarCategorias())
                    {
                        MessageBox.Show("Cadastrado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNome.Clear();
                        cmbTipo.SelectedIndex = -1;
                        AtualizarDGV();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao cadastrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}