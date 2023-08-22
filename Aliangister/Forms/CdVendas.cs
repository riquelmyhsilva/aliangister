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
    public partial class CdVendas : Form
    {
        public CdVendas()
        {
            InitializeComponent();
        }

        public void limparTela()
        {
            txt_idCliente_CdVendas.Text = "";
            txt_idPeca_CdVendas.Text = "";
            txt_Quant_CdVendas.Text = "";
            maskedtxt_Data_CdVendas.Text = "";
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btn_TelaInicial_CdVendas_Click(object sender, EventArgs e)
        {

        }
        //
        // botão de cadastrar vendas
        //
        private void btn_Cadastrar_CdVendas_Click(object sender, EventArgs e)
        {
            cadastrarPecas();
        }
        private void cadastrarPecas()
        {
            if (string.IsNullOrEmpty(txt_idCliente_CdVendas.Text) ||
                string.IsNullOrEmpty(txt_idPeca_CdVendas.Text) ||
                string.IsNullOrEmpty(txt_Quant_CdVendas.Text) ||
                string.IsNullOrEmpty(maskedtxt_Data_CdVendas.Text))
            {
                MessageBox.Show("Preencha os campos todos os campos.");
                return;
            }

            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();

                    var sql = "INSERT INTO tb_vendas (id_cliente, id_peca, quant_venda, data_venda) VALUES (@id_cliente, @id_peca, @quant_venda, @data_venda)";

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@id_cliente", txt_idCliente_CdVendas.Text);
                        cmd.Parameters.AddWithValue("@id_peca", txt_idPeca_CdVendas.Text);
                        cmd.Parameters.AddWithValue("@quant_venda", txt_Quant_CdVendas.Text);
                        cmd.Parameters.AddWithValue("@data_venda", maskedtxt_Data_CdVendas.Text);

                        cmd.ExecuteNonQuery();
                    }

                    limparTela();
                    MessageBox.Show("Venda Cadastrada.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel inserir os dados.\n\n" + ex.Message);
            }

        }
        //
        // botão de exibir a tabela de vendas
        //
        private TbVendas _tbVendasForm = null;
        private void btn_vizTbVendas_CdVendas_Click(object sender, EventArgs e)
        {
            {
                if (_tbVendasForm != null && !_tbVendasForm.IsDisposed)
                {
                    _tbVendasForm.BringToFront();
                    return;
                }
                _tbVendasForm = new TbVendas();
                _tbVendasForm.Show();
            }
        }

        private void CdVendas_Load(object sender, EventArgs e)
        {

        }
    }
}
