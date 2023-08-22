using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aliangister
{
    public partial class TelaInicial : Form
    {

        private Form activeForm;
        private Button currentButton;

        public TelaInicial()
        {
            InitializeComponent();
            btnCloseChildForm.Visible = false;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //
        // botão tela de cadastro de clientes
        //
        private void btn_CdCliente_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CdClientes(), sender);
        }
        //
        // botão tela de cadastro de peças
        //
        private void btn_CdPeca_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CdPecas(), sender);

        }
        //
        // botão tela de cadastro de vendas
        //
        private void btn_CdVenda_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CdVendas(), sender);

        }
        //
        // botão de excluir cadastro
        //
        private void btnExcluirCadastro_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ExcluirCadastro(), sender);
        }
        //
        // botão de fechar formulario
        //
        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        //
        // metodos
        //

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.White;
                    currentButton.ForeColor = Color.FromArgb(255, 128, 0);
                    btnCloseChildForm.Visible = true;

                }
            }
        }

         private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(255, 128, 0);
                    previousBtn.ForeColor = Color.White;
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel_corSolida.Controls.Add(childForm);
            this.panel_corSolida.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbl_nomePagina.Text = childForm.Text;
        }

        private void Reset()
        {
            DisableButton();
            lbl_nomePagina.Text = "Tela Inicial";
            currentButton = null;
            btnCloseChildForm.Visible = false;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_nomePagina_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
