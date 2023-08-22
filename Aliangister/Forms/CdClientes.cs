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

        private Form activeTbForm;

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
                MessageBox.Show("Preencha todos os campos.");
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
                    MessageBox.Show("Cliente Cadastrado.");

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

        /*public void OpenTbForm(Form TbForm)
        {

            activeTbForm = TbForm;

            if (activeTbForm != null && !activeTbForm.IsDisposed)
            {
                activeTbForm.BringToFront();
                return;
            }
            activeTbForm = new TbClientes();
            activeTbForm.Show();

        }*/
        private TbClientes _tbClientesForm = null;

        private void btn_vizTbClientes_CdClientes_Click(object sender, EventArgs e)
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

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {

        }

        private void txt_Telefone_CdClientes_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
