using GerenciadorDeFinanças.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace GerenciadorDeFinanças
{
    public partial class FormCadastroDespesas : Form
    {
        public FormCadastroDespesas()
        {
            InitializeComponent();

            Despesas despesas = new Despesas();

            CarregarCategorias(despesas);
            CarregarDespesas(despesas);
        }

        private void CarregarCategorias(Despesas despesas)
        {
            cmbCategoria.DataSource = despesas.ListarCategorias();
            cmbCategoria.DisplayMember = "Nome";
            cmbCategoria.ValueMember = "Id";
            cmbCategoria.SelectedIndex = -1;
        }

        private void CarregarDespesas(Despesas despesas)
        {
            dgvDespesas.DataSource = despesas.ListarDespesas();

            if (dgvDespesas.Columns["Id"] != null)
                dgvDespesas.Columns["Id"].Visible = false;

            if (dgvDespesas.Columns["Descricao"] != null)
                dgvDespesas.Columns["Descricao"].HeaderText = "Descrição";

            if (dgvDespesas.Columns["Valor"] != null)
                dgvDespesas.Columns["Valor"].DefaultCellStyle.Format = "C2";

            if (dgvDespesas.Columns["Categoria"] != null)
                dgvDespesas.Columns["Categoria"].HeaderText = "Categoria";

            if (dgvDespesas.Columns["Data"] != null)
                dgvDespesas.Columns["Data"].DefaultCellStyle.Format = "dd/MM/yyyy";

            if (dgvDespesas.Columns["Pago"] != null)
                dgvDespesas.Columns["Pago"].HeaderText = "Status";

            if (dgvDespesas.Columns["Observacao"] != null)
                dgvDespesas.Columns["Observacao"].HeaderText = "Observação";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Despesas despesas = new Despesas();

            if (txtDescricao.Text.Trim() == "")
            {
                MessageBox.Show("Informe a descrição.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescricao.Focus();
                return;
            }

            double valorDespesa = 0;
            try
            {
                valorDespesa = Convert.ToDouble(txtValor.Text);
            }
            catch
            {
                MessageBox.Show("Informe um valor válido.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValor.Focus();
                return;
            }

            if (valorDespesa <= 0)
            {
                MessageBox.Show("O valor deve ser maior que zero.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValor.Focus();
                return;
            }

            if (cmbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma categoria.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCategoria.Focus();
                return;
            }

            despesas.Descricao = txtDescricao.Text.Trim();
            despesas.Valor = valorDespesa;
            despesas.Data = dtpData.Value.Date;
            despesas.CategoriaId = (int)cmbCategoria.SelectedValue;
            despesas.Pago = cmbPago.SelectedIndex; // 0 = Pendente, 1 = Pago
            despesas.Observacao = txtObservacao.Text.Trim();

            if (despesas.CadastrarDespesa())
            {
                MessageBox.Show("Despesa salva com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparCampos();
                CarregarDespesas(despesas);
            }
            else
            {
                MessageBox.Show("Não foi possível salvar a despesa.", "Erro",
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
            cmbPago.SelectedIndex = 0;
            txtDescricao.Focus();
        }

        private void dgvDespesas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == dgvDespesas.Columns["colExcluir"]?.Index)
            {
                Despesas despesas = new Despesas();
                int id = Convert.ToInt32(dgvDespesas.Rows[e.RowIndex].Cells["Id"].Value);

                if (MessageBox.Show("Deseja realmente excluir esta despesa?",
                        "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (despesas.ExcluirDespesa(id))
                        CarregarDespesas(despesas);
                    else
                        MessageBox.Show("Erro ao excluir a despesa.", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}