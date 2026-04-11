using GerenciadorDeFinanças.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace GerenciadorDeFinanças
{
    public partial class FormCadastroReceitas : Form
    {
        public FormCadastroReceitas()
        {
            InitializeComponent();

            Receitas receitas = new Receitas();

            CarregarCategorias(receitas);
            CarregarReceitas(receitas);
        }

        private void CarregarCategorias(Receitas receitas)
        {
            cmbCategoria.DataSource = receitas.ListarCategorias();
            cmbCategoria.DisplayMember = "Nome";
            cmbCategoria.ValueMember = "Id";
            cmbCategoria.SelectedIndex = -1;
        }

        private void CarregarReceitas(Receitas receitas)
        {
            dgvReceitas.DataSource = receitas.ListarReceitas();

            if (dgvReceitas.Columns["Id"] != null)
                dgvReceitas.Columns["Id"].Visible = false;

            if (dgvReceitas.Columns["Descricao"] != null)
                dgvReceitas.Columns["Descricao"].HeaderText = "Descrição";

            if (dgvReceitas.Columns["Valor"] != null)
                dgvReceitas.Columns["Valor"].DefaultCellStyle.Format = "C2";

            if (dgvReceitas.Columns["Categoria"] != null)
                dgvReceitas.Columns["Categoria"].HeaderText = "Categoria";

            if (dgvReceitas.Columns["Data"] != null)
                dgvReceitas.Columns["Data"].DefaultCellStyle.Format = "dd/MM/yyyy";

            if (dgvReceitas.Columns["Observacao"] != null)
                dgvReceitas.Columns["Observacao"].HeaderText = "Observação";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Receitas receitas = new Receitas();

            if (txtDescricao.Text.Trim() == "")
            {
                MessageBox.Show("Informe a descrição.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescricao.Focus();
                return;
            }

            double valorReceita = 0;
            try
            {
                valorReceita = Convert.ToDouble(txtValor.Text);
            }
            catch
            {
                MessageBox.Show("Informe um valor válido.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValor.Focus();
                return;
            }

            if (valorReceita <= 0)
            {
                MessageBox.Show("O valor deve ser maior que zero.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValor.Focus();
                return;
            }

            if (cmbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma categoria.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCategoria.Focus();
                return;
            }

            receitas.Descricao = txtDescricao.Text.Trim();
            receitas.Valor = valorReceita;
            receitas.Data = dtpData.Value.Date;
            receitas.CategoriaId = (int)cmbCategoria.SelectedValue;
            receitas.Observacao = txtObservacao.Text.Trim();

            if (receitas.CadastrarReceita())
            {
                MessageBox.Show("Receita salva com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparCampos();
                CarregarReceitas(receitas);
            }
            else
            {
                MessageBox.Show("Não foi possível salvar a receita.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtDescricao.Clear();
            txtValor.Clear();
            txtObservacao.Clear();
            dtpData.Value = DateTime.Today;
            cmbCategoria.SelectedIndex = -1;
            txtDescricao.Focus();
        }

        private void dgvReceitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == dgvReceitas.Columns["colExcluir"]?.Index)
            {
                Receitas receitas = new Receitas();
                int id = Convert.ToInt32(dgvReceitas.Rows[e.RowIndex].Cells["Id"].Value);

                if (MessageBox.Show("Deseja realmente excluir esta receita?",
                        "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (receitas.ExcluirReceita(id))
                        CarregarReceitas(receitas);
                    else
                        MessageBox.Show("Erro ao excluir a receita.", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}