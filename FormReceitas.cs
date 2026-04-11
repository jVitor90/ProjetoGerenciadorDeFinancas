using GerenciadorDeFinanças.Model;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GerenciadorDeFinanças
{
    public partial class FormReceitas : Form
    {
        public FormReceitas()
        {
            InitializeComponent();
            CarregarReceitas();

            btnNovaReceita.Click += BtnNovaReceita_Click;
            dgvReceitas.CellClick += dgvReceitas_CellClick;
        }

        private void BtnNovaReceita_Click(object sender, EventArgs e)
        {
            new FormCadastroReceitas().ShowDialog();
            CarregarReceitas();
        }

        private void CarregarReceitas()
        {
            Receitas receitas = new Receitas();
            dgvReceitas.DataSource = receitas.ListarReceitas();

            if (dgvReceitas.Columns["Id"] != null)
                dgvReceitas.Columns["Id"].Visible = false;

            if (dgvReceitas.Columns["Descricao"] != null)
            {
                dgvReceitas.Columns["Descricao"].HeaderText = "DESCRIÇÃO";
                dgvReceitas.Columns["Descricao"].Width = 220;
            }

            if (dgvReceitas.Columns["Valor"] != null)
            {
                dgvReceitas.Columns["Valor"].DefaultCellStyle.Format = "C2";
                dgvReceitas.Columns["Valor"].DefaultCellStyle.Font = new Font("Courier New", 9F);
                dgvReceitas.Columns["Valor"].DefaultCellStyle.ForeColor = Color.FromArgb(200, 245, 90);
                dgvReceitas.Columns["Valor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvReceitas.Columns["Valor"].HeaderText = "VALOR";
                dgvReceitas.Columns["Valor"].Width = 120;
            }

            if (dgvReceitas.Columns["Categoria"] != null)
            {
                dgvReceitas.Columns["Categoria"].HeaderText = "CATEGORIA";
                dgvReceitas.Columns["Categoria"].Width = 160;
            }

            if (dgvReceitas.Columns["Data"] != null)
            {
                dgvReceitas.Columns["Data"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvReceitas.Columns["Data"].HeaderText = "DATA";
                dgvReceitas.Columns["Data"].Width = 110;
            }

            if (dgvReceitas.Columns["Observacao"] != null)
            {
                dgvReceitas.Columns["Observacao"].HeaderText = "OBSERVAÇÃO";
                dgvReceitas.Columns["Observacao"].Width = 200;
            }

            if (dgvReceitas.Columns["colAcoes"] != null)
                dgvReceitas.Columns["colAcoes"].DisplayIndex = dgvReceitas.Columns.Count - 1;
        }

        private void dgvReceitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvReceitas.Columns[e.ColumnIndex].Name == "colAcoes")
            {
                Receitas receitas = new Receitas();
                int id = Convert.ToInt32(dgvReceitas.Rows[e.RowIndex].Cells["Id"].Value);

                if (MessageBox.Show("Deseja realmente excluir esta receita?",
                        "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (receitas.ExcluirReceita(id))
                        CarregarReceitas();
                    else
                        MessageBox.Show("Erro ao excluir a receita.", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}