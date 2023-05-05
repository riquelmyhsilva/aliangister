using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aliangister
{
    public partial class CdClientes : Form
    {
        public CdClientes()
        {
            InitializeComponent();
        }

        public void limparTela()
        {
            txt_Nome_CdClientes.Text = "";
            txt_Email_CdClientes.Text = "";
            txt_Telefone_CdClientes.Text = "";
            txt_Empresa_CdClientes.Text = "";
        }

        //
        // botão para a tela inicial
        //

        private void btn_TelaInicial_Click(object sender, EventArgs e)
        {
            TelaInicial nextForm = new TelaInicial();
            nextForm.Show();
            Hide();
        }

        //
        // botão de cadastrar clientes
        //

        private void btn_Cadastrar_CdCliente_Click(object sender, EventArgs e)
        {
            cadastrarCliente();
        }

        private void cadastrarCliente()
        {
            if (string.IsNullOrEmpty(txt_Nome_CdClientes.Text) ||
                string.IsNullOrEmpty(txt_Email_CdClientes.Text) ||
                string.IsNullOrEmpty(txt_Telefone_CdClientes.Text) ||
                string.IsNullOrEmpty(txt_Empresa_CdClientes.Text))
            {
                lbl_ToStrSta_CdClientes.Text = "Preencha os campos obrigatorios.";
                status_BarStatus_CdClientes.Refresh();
                return;
            }

            try 
            {
                using(SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();

                    var sql = "INSERT INTO tb_clientes (nome_cliente, email_cliente, telefone_cliente, empresa_cliente) VALUES (@nome_cliente, @email_cliente, @telefone_cliente, @empresa_cliente)";

                    using(SqlCommand cmd = new SqlCommand(sql,cn))
                    {
                        cmd.Parameters.AddWithValue("@nome_cliente", txt_Nome_CdClientes.Text);
                        cmd.Parameters.AddWithValue("@email_cliente", txt_Email_CdClientes.Text);
                        cmd.Parameters.AddWithValue("@telefone_cliente", txt_Telefone_CdClientes.Text);
                        cmd.Parameters.AddWithValue("@empresa_cliente", txt_Empresa_CdClientes.Text);
                        cmd.ExecuteNonQuery();
                    }

                    limparTela();
                    lbl_ToStrSta_CdClientes.Text = "Cliente Cadastrado";
                    status_BarStatus_CdClientes.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel inserir os dados.\n\n" + ex.Message);
            }

        }
        //
        // botão de vizualizar tabela clientes
        //
        private TbClientes _tbClientesForm = null;

        private void btn_vizTbClientes_CdClientes_Click(object sender, EventArgs e)
        {
            // Se a janela TbClientes já está aberta, não faz nada
            if (_tbClientesForm != null && !_tbClientesForm.IsDisposed)
            {
                _tbClientesForm.BringToFront();
                return;
            }

            // Se a janela TbClientes não está aberta, cria uma nova instância e mostra
            _tbClientesForm = new TbClientes();
            _tbClientesForm.Show();
        }

        private void label_Aliangister_Click(object sender, EventArgs e)
        {

        }

        private void txt_Nome_CdClientes_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Nome_CdClientes_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Cadastar_Clientes_Click(object sender, EventArgs e)
        {

        }
        //
        // carregar tela
        //
        private void CdClientes_Load(object sender, EventArgs e)
        {
            lbl_BarStatus_CdClientes.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
