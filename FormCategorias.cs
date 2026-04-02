namespace GerenciadorDeFinanças
{
    public partial class FormCategorias : Form
    {
        public FormCategorias()
        {
            InitializeComponent();

            btnNovaCategoria.Click += (s, e) =>
            {
                panelCadastro.Visible = true;
                // empurra o grid para baixo do painel de cadastro
                dgvCategorias.Location = new System.Drawing.Point(32, 190);
                dgvCategorias.Size = new System.Drawing.Size(780, 330);
            };

            btnCancelar.Click += (s, e) =>
            {
                panelCadastro.Visible = false;
                dgvCategorias.Location = new System.Drawing.Point(32, 76);
                dgvCategorias.Size = new System.Drawing.Size(780, 440);
                txtNome.Clear();
                cmbTipo.SelectedIndex = 0;
            };

            btnSalvar.Click += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtNome.Text)) return;

                dgvCategorias.Rows.Add(txtNome.Text, cmbTipo.SelectedItem?.ToString());
                panelCadastro.Visible = false;
                dgvCategorias.Location = new System.Drawing.Point(32, 76);
                dgvCategorias.Size = new System.Drawing.Size(780, 440);
                txtNome.Clear();
                cmbTipo.SelectedIndex = 0;
            };
        }
    }
}