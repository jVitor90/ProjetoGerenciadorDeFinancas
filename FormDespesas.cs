using GerenciadorDeFinanças.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GerenciadorDeFinanças
{
    public partial class FormDespesas : Form
    {
        private int _idEditando = -1;

        public FormDespesas()
        {
            InitializeComponent();
            dgvDespesas.CellFormatting += dgvDespesas_CellFormatting;
            CarregarDespesas();
        }

        private void CarregarDespesas()
        {
            pnlEditar.Visible = false;
            _idEditando = -1;

            Despesas despesas = new Despesas();
            dgvDespesas.DataSource = despesas.ListarDespesas();

            if (dgvDespesas.Columns["Id"] != null)
                dgvDespesas.Columns["Id"].Visible = false;

            if (dgvDespesas.Columns["Pago"] != null)
                dgvDespesas.Columns["Pago"].Visible = false;

            if (dgvDespesas.Columns["Descricao"] != null)
            {
                dgvDespesas.Columns["Descricao"].HeaderText = "DESCRIÇÃO";
                dgvDespesas.Columns["Descricao"].Width = 180;
            }

            if (dgvDespesas.Columns["Categoria"] != null)
            {
                dgvDespesas.Columns["Categoria"].HeaderText = "CATEGORIA";
                dgvDespesas.Columns["Categoria"].Width = 120;
            }

            if (dgvDespesas.Columns["Data"] != null)
            {
                dgvDespesas.Columns["Data"].HeaderText = "DATA";
                dgvDespesas.Columns["Data"].Width = 90;
                dgvDespesas.Columns["Data"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }

            if (dgvDespesas.Columns["Valor"] != null)
            {
                dgvDespesas.Columns["Valor"].HeaderText = "VALOR";
                dgvDespesas.Columns["Valor"].Width = 100;
                dgvDespesas.Columns["Valor"].DefaultCellStyle.Format = "C2";
                dgvDespesas.Columns["Valor"].DefaultCellStyle.Font = new Font("Courier New", 8.5F);
                dgvDespesas.Columns["Valor"].DefaultCellStyle.ForeColor = Color.FromArgb(224, 92, 92);
                dgvDespesas.Columns["Valor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (dgvDespesas.Columns["Observacao"] != null)
            {
                dgvDespesas.Columns["Observacao"].HeaderText = "OBSERVAÇÃO";
                dgvDespesas.Columns["Observacao"].Width = 130;
            }

            SetDisplayIndex("Descricao", 0);
            SetDisplayIndex("Categoria", 1);
            SetDisplayIndex("Data", 2);
            SetDisplayIndex("Valor", 3);
            SetDisplayIndex("colStatus", 4);
            SetDisplayIndex("colEditar", 5);
            SetDisplayIndex("colAcoes", 6);
            SetDisplayIndex("Observacao", 7);
        }

        private void SetDisplayIndex(string colName, int index)
        {
            if (dgvDespesas.Columns[colName] != null)
                dgvDespesas.Columns[colName].DisplayIndex = index;
        }

        // Chamado pelo WinForms célula a célula no momento do render — nunca falha
        private void dgvDespesas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvDespesas.Columns[e.ColumnIndex].Name != "colStatus") return;

            var row = dgvDespesas.Rows[e.RowIndex];
            if (row.IsNewRow) return;

            int pago = 0;
            if (row.DataBoundItem is System.Data.DataRowView drv)
            {
                try { pago = Convert.ToInt32(drv.Row["Pago"]); } catch { pago = 0; }
            }

            if (pago == 1)
            {
                e.Value = "Pago";
                e.CellStyle.ForeColor = Color.FromArgb(200, 245, 90);
                e.CellStyle.BackColor = Color.FromArgb(24, 34, 14);
                e.CellStyle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            }
            else
            {
                e.Value = "Pendente";
                e.CellStyle.ForeColor = Color.FromArgb(220, 160, 60);
                e.CellStyle.BackColor = Color.FromArgb(34, 26, 12);
                e.CellStyle.Font = new Font("Segoe UI", 8.5F);
            }

            e.FormattingApplied = true;
        }

        private void btnNovaDespesa_Click(object sender, EventArgs e)
        {
            new FormCadastroDespesas().ShowDialog();
            CarregarDespesas();
        }

        private void dgvDespesas_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void dgvDespesas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string colName = dgvDespesas.Columns[e.ColumnIndex].Name;
            int id = Convert.ToInt32(dgvDespesas.Rows[e.RowIndex].Cells["Id"].Value);

            if (colName == "colEditar")
            {
                int pagoAtual = 0;
                if (dgvDespesas.Rows[e.RowIndex].DataBoundItem is System.Data.DataRowView drv)
                {
                    try { pagoAtual = Convert.ToInt32(drv.Row["Pago"]); } catch { pagoAtual = 0; }
                }

                _idEditando = id;
                cmbStatusEditar.SelectedIndex = pagoAtual;

                Rectangle celRect = dgvDespesas.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                int px = dgvDespesas.Left + celRect.Right - pnlEditar.Width;
                int py = dgvDespesas.Top + celRect.Bottom + 2;

                if (px < 8) px = 8;
                if (px + pnlEditar.Width > ClientSize.Width - 8)
                    px = ClientSize.Width - pnlEditar.Width - 8;

                pnlEditar.Location = new Point(px, py);
                pnlEditar.Visible = true;
                pnlEditar.BringToFront();
                cmbStatusEditar.Focus();
                return;
            }

            if (colName == "colAcoes")
            {
                pnlEditar.Visible = false;
                _idEditando = -1;

                Despesas despesas = new Despesas();

                if (MessageBox.Show("Deseja realmente excluir esta despesa?",
                        "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (despesas.ExcluirDespesa(id))
                        CarregarDespesas();
                    else
                        MessageBox.Show("Erro ao excluir a despesa.", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSalvarStatus_Click(object sender, EventArgs e)
        {
            if (_idEditando < 0) return;

            int novoStatus = cmbStatusEditar.SelectedIndex; // 0 = Pendente, 1 = Pago

            Despesas despesas = new Despesas();
            if (despesas.AlterarStatus(_idEditando, novoStatus))
            {
                // Atualiza o DataRow — CellFormatting lê isso no próximo Refresh
                foreach (DataGridViewRow row in dgvDespesas.Rows)
                {
                    if (row.IsNewRow) continue;
                    if (row.DataBoundItem is System.Data.DataRowView drv)
                    {
                        if (Convert.ToInt32(drv.Row["Id"]) == _idEditando)
                        {
                            drv.Row["Pago"] = novoStatus;
                            break;
                        }
                    }
                }
                dgvDespesas.Refresh();
                pnlEditar.Visible = false;
                _idEditando = -1;
            }
            else
            {
                MessageBox.Show("Erro ao alterar o status.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFecharEditar_Click(object sender, EventArgs e)
        {
            pnlEditar.Visible = false;
            _idEditando = -1;
        }
    }
}