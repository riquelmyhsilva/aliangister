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
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }
        //
        // botão tela de cadastro de clientes
        //
        private void btn_CdCliente_Click(object sender, EventArgs e)
        {

            CdClientes nextForm = new CdClientes();
            nextForm.Show();
            Hide();
        }
        //
        // botão tela de cadastro de peças
        //
        private void btn_CdPeca_Click(object sender, EventArgs e)
        {
            CdPecas nextForm = new CdPecas();
            nextForm.Show();
            Hide();
        }
        private void label_Aliangister_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {

        }


    }
}
