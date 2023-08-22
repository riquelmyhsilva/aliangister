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
    public partial class ExcluirCadastro : Form
    {
        public ExcluirCadastro()
        {
            InitializeComponent();
        }
        public void limparTela()
        {
            txt_ID_ExcluirCadastro.Text = "";
        }

        //
        // metodo excluir cliente
        //

        private void ExcluirCliente()
        {

            if (string.IsNullOrEmpty(txt_ID_ExcluirCadastro.Text))
            {
                MessageBox.Show("Preencha o campo.");
                return;
            }

            try
            {
                    using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                    {
                        cn.Open();

                        var sql = "DELETE FROM tb_clientes WHERE id_cliente =(@id_cliente);";

                        using (SqlCommand cmd = new SqlCommand(sql, cn))
                        {
                            cmd.Parameters.AddWithValue("@id_cliente", txt_ID_ExcluirCadastro.Text);
                            cmd.ExecuteNonQuery();
                        }

                        limparTela();
                        MessageBox.Show("Cliente Excluído.");

                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel excluir os dados.\n\n" + ex.Message);
            }
        }

        //
        // metodo exluir peças
        //

        private void ExcluirPeca()
        {

            if (string.IsNullOrEmpty(txt_ID_ExcluirCadastro.Text))
            {
                MessageBox.Show("Preencha o campo.");
                return;
            }

            try
            {
                    using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                    {
                        cn.Open();

                        var sql = "DELETE FROM tb_pecas WHERE id_peca =(@id_peca);";

                        using (SqlCommand cmd = new SqlCommand(sql, cn))
                        {
                            cmd.Parameters.AddWithValue("@id_peca", txt_ID_ExcluirCadastro.Text);
                            cmd.ExecuteNonQuery();
                        }

                        limparTela();
                        MessageBox.Show("Peça Excluída.");

                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel excluir os dados.\n\n" + ex.Message);
            }
        }

        //
        // metodo excluir vendas
        //

        private void ExcluirVenda()
        {

            if (string.IsNullOrEmpty(txt_ID_ExcluirCadastro.Text))
            {
                MessageBox.Show("Preencha o campo.");
                return;
            }

            try
            {
                    using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                    {
                        cn.Open();

                        var sql = "DELETE FROM tb_vendas WHERE id_venda = (@id_vendas);";

                        using (SqlCommand cmd = new SqlCommand(sql, cn))
                        {
                            cmd.Parameters.AddWithValue("@id_vendas", txt_ID_ExcluirCadastro.Text);
                            cmd.ExecuteNonQuery();
                        }

                        limparTela();
                        MessageBox.Show("Venda Excluída.");

                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel excluir os dados.\n\n" + ex.Message);
            }
        }

        //
        // loud da tela
        //

        private void ExcluirCadastro_Load(object sender, EventArgs e)
        {
            txt_ID_ExcluirCadastro.Enabled = false;
            btn_vizTb_ExcluirCadastro.Visible = false;
        }

        private void txt_ID_ExcluirCadastro_TextChanged(object sender, EventArgs e)
        {

        }

        //
        // botão de excluir cadastro
        //

        private void btn_Excluir_ExcluirCadastro_Click(object sender, EventArgs e)
        {

            if ((radioBtn_Clientes_ExcluirCadastro.Checked == true) || (radioBtn_Venda_ExcluirCadastro.Checked == true) || (radioBtn_Peca_ExcluirCadastro.Checked == true))
            {
                if (radioBtn_Clientes_ExcluirCadastro.Checked == true)
                {
                    ExcluirCliente();
                }

                if (radioBtn_Peca_ExcluirCadastro.Checked == true)
                {
                    ExcluirPeca();
                }

                if (radioBtn_Venda_ExcluirCadastro.Checked == true)
                {
                    ExcluirVenda();
                }
            }

            else
            {
                MessageBox.Show("Por favor, selecione uma opção de exclusão.");
            }

        }

        //
        // radio button pecas
        //

        private void radioBtn_Peca_ExcluirCadastro_CheckedChanged(object sender, EventArgs e)
        {
            txt_ID_ExcluirCadastro.Enabled = true;
            btn_vizTb_ExcluirCadastro.Visible = true;
            btn_vizTb_ExcluirCadastro.Text = "Vizualiar Tabela de Peças";

        }

        //
        // radio button clientes
        //

        private void radioBtn_Clientes_ExcluirCadastro_CheckedChanged(object sender, EventArgs e)
        {
            txt_ID_ExcluirCadastro.Enabled = true;
            btn_vizTb_ExcluirCadastro.Visible = true;
            btn_vizTb_ExcluirCadastro.Text = "Vizualiar Tabela de Clientes";
        }

        //
        // radio button venda
        //

        private void radioBtn_Venda_ExcluirCadastro_CheckedChanged(object sender, EventArgs e)
        {
            txt_ID_ExcluirCadastro.Enabled = true;
            btn_vizTb_ExcluirCadastro.Visible = true;
            btn_vizTb_ExcluirCadastro.Text = "Vizualiar Tabela de Vendas";
        }

        //
        // botão de vizualizar as tabelas
        //

        private TbClientes _tbClientesForm = null;
        private TbPecas _tbPecasForm = null;
        private TbVendas _tbVendasForm = null;


        private void btn_vizTb_ExcluirCadastro_Click(object sender, EventArgs e)
        {

            if (radioBtn_Clientes_ExcluirCadastro.Checked == true)
            {

                {
                    if (_tbClientesForm != null && !_tbClientesForm.IsDisposed)
                    {
                        _tbClientesForm.BringToFront();
                        return;
                    }
                    _tbClientesForm = new TbClientes();
                    _tbClientesForm.Show();
                }
            }

            if (radioBtn_Peca_ExcluirCadastro.Checked == true)
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

            if (radioBtn_Venda_ExcluirCadastro.Checked == true)
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
        }
    }
}
