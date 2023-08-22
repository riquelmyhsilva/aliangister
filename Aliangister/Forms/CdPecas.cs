using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aliangister
{
    public partial class CdPecas : Form
    {
        public CdPecas()
        {
            InitializeComponent();
        }
        public void limparTela()
        {
            txt_Tipo_CdPecas.Text = "";
            txt_Material_CdPecas.Text = "";
            txt_Quant_CdPecas.Text = "";
            txt_ValorUnit_CdPecas.Text = "";
            txt_ValorTotal_CdPecas.Text = "";
            maskedtxt_Data_CdPecas.Text = "";

        }

        private void txt_Quant_CdPecas_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_TelaInicial_CdPecas_Click(object sender, EventArgs e)
        {
            TelaInicial nextForm = new TelaInicial();
            nextForm.Show();
            Hide();
        }
        //
        // botão de cadastrar peças
        //
        private void btn_Cadastrar_CdPecas_Click(object sender, EventArgs e)
        {
            cadastrarPecas();
        }
        private void cadastrarPecas()
        {
            if (string.IsNullOrEmpty(txt_Tipo_CdPecas.Text) ||
                string.IsNullOrEmpty(txt_Material_CdPecas.Text) ||
                string.IsNullOrEmpty(txt_Quant_CdPecas.Text) ||
                string.IsNullOrEmpty(txt_ValorUnit_CdPecas.Text) ||
                string.IsNullOrEmpty(txt_ValorTotal_CdPecas.Text) ||
                string.IsNullOrEmpty(maskedtxt_Data_CdPecas.Text))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();

                    var sql = "INSERT INTO tb_pecas (tipo_peca, material_peca, quant_peca, valor_unit_peca, valor_total_peca, data_peca) VALUES (@tipo_peca, @material_peca, @quant_peca, @valor_unit_peca, @valor_total_peca, @data_peca)";

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@tipo_peca", txt_Tipo_CdPecas.Text);
                        cmd.Parameters.AddWithValue("@material_peca", txt_Material_CdPecas.Text);
                        cmd.Parameters.AddWithValue("@quant_peca", txt_Quant_CdPecas.Text);
                        cmd.Parameters.AddWithValue("@valor_unit_peca", txt_ValorUnit_CdPecas.Text);
                        cmd.Parameters.AddWithValue("@valor_total_peca", txt_ValorTotal_CdPecas.Text);
                        cmd.Parameters.AddWithValue("@data_peca", maskedtxt_Data_CdPecas.Text);

                        cmd.ExecuteNonQuery();
                    }

                    limparTela();
                    MessageBox.Show("Peça Cadastrada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel inserir os dados.\n\n" + ex.Message);
            }

        }
        //
        // botão de exibir a tabela de peças
        //
        private TbPecas _tbPecasForm = null;
        private void btn_vizTbPecas_CdPecas_Click(object sender, EventArgs e)
        {
            {
                if (_tbPecasForm != null && !_tbPecasForm.IsDisposed)
                {
                    _tbPecasForm.BringToFront();
                    return;
                }
                _tbPecasForm = new TbPecas();
                _tbPecasForm.Show();
            }
        }

        private void txt_Tipo_CdPecas_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Material_CdPecas_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        //
        // carregar tela
        //
        private void CdPecas_Load(object sender, EventArgs e)
        {

        }
    }
}
