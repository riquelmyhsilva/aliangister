
namespace Aliangister
{
    partial class TelaInicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.label_Aliangister = new System.Windows.Forms.Label();
            this.btn_CdCliente = new System.Windows.Forms.Button();
            this.btn_CdPeca = new System.Windows.Forms.Button();
            this.btn_CdVenda = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnExcluirCadastro = new System.Windows.Forms.Button();
            this.panelAliangister = new System.Windows.Forms.Panel();
            this.panelNome = new System.Windows.Forms.Panel();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.lbl_nomePagina = new System.Windows.Forms.Label();
            this.panel_corSolida = new System.Windows.Forms.Panel();
            this.lbl_logo = new System.Windows.Forms.Label();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelAliangister.SuspendLayout();
            this.panelNome.SuspendLayout();
            this.panel_corSolida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Aliangister
            // 
            this.label_Aliangister.AutoEllipsis = true;
            this.label_Aliangister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label_Aliangister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Aliangister.Font = new System.Drawing.Font("Futura Md BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Aliangister.ForeColor = System.Drawing.Color.White;
            this.label_Aliangister.Location = new System.Drawing.Point(0, 0);
            this.label_Aliangister.Name = "label_Aliangister";
            this.label_Aliangister.Size = new System.Drawing.Size(200, 64);
            this.label_Aliangister.TabIndex = 0;
            this.label_Aliangister.Text = "Aliangister";
            this.label_Aliangister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Aliangister.Click += new System.EventHandler(this.label_Aliangister_Click);
            // 
            // btn_CdCliente
            // 
            this.btn_CdCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_CdCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_CdCliente.FlatAppearance.BorderSize = 0;
            this.btn_CdCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CdCliente.Font = new System.Drawing.Font("Futura Md BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CdCliente.ForeColor = System.Drawing.Color.White;
            this.btn_CdCliente.Location = new System.Drawing.Point(0, 64);
            this.btn_CdCliente.Name = "btn_CdCliente";
            this.btn_CdCliente.Size = new System.Drawing.Size(200, 64);
            this.btn_CdCliente.TabIndex = 1;
            this.btn_CdCliente.Text = "Casdatrar Cliente";
            this.btn_CdCliente.UseVisualStyleBackColor = false;
            this.btn_CdCliente.Click += new System.EventHandler(this.btn_CdCliente_Click);
            // 
            // btn_CdPeca
            // 
            this.btn_CdPeca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_CdPeca.FlatAppearance.BorderSize = 0;
            this.btn_CdPeca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CdPeca.Font = new System.Drawing.Font("Futura Md BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CdPeca.ForeColor = System.Drawing.Color.White;
            this.btn_CdPeca.Location = new System.Drawing.Point(0, 128);
            this.btn_CdPeca.Name = "btn_CdPeca";
            this.btn_CdPeca.Size = new System.Drawing.Size(200, 64);
            this.btn_CdPeca.TabIndex = 2;
            this.btn_CdPeca.Text = "Casdatrar Peça";
            this.btn_CdPeca.UseVisualStyleBackColor = false;
            this.btn_CdPeca.Click += new System.EventHandler(this.btn_CdPeca_Click);
            // 
            // btn_CdVenda
            // 
            this.btn_CdVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_CdVenda.FlatAppearance.BorderSize = 0;
            this.btn_CdVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CdVenda.Font = new System.Drawing.Font("Futura Md BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CdVenda.ForeColor = System.Drawing.Color.White;
            this.btn_CdVenda.Location = new System.Drawing.Point(0, 192);
            this.btn_CdVenda.Name = "btn_CdVenda";
            this.btn_CdVenda.Size = new System.Drawing.Size(200, 64);
            this.btn_CdVenda.TabIndex = 3;
            this.btn_CdVenda.Text = "Casdatrar Venda";
            this.btn_CdVenda.UseVisualStyleBackColor = false;
            this.btn_CdVenda.Click += new System.EventHandler(this.btn_CdVenda_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelMenu.Controls.Add(this.btnExcluirCadastro);
            this.panelMenu.Controls.Add(this.btn_CdPeca);
            this.panelMenu.Controls.Add(this.btn_CdCliente);
            this.panelMenu.Controls.Add(this.panelAliangister);
            this.panelMenu.Controls.Add(this.btn_CdVenda);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 611);
            this.panelMenu.TabIndex = 5;
            // 
            // btnExcluirCadastro
            // 
            this.btnExcluirCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnExcluirCadastro.FlatAppearance.BorderSize = 0;
            this.btnExcluirCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirCadastro.Font = new System.Drawing.Font("Futura Md BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirCadastro.ForeColor = System.Drawing.Color.White;
            this.btnExcluirCadastro.Location = new System.Drawing.Point(0, 256);
            this.btnExcluirCadastro.Name = "btnExcluirCadastro";
            this.btnExcluirCadastro.Size = new System.Drawing.Size(200, 64);
            this.btnExcluirCadastro.TabIndex = 4;
            this.btnExcluirCadastro.Text = "Excluir Cadastro";
            this.btnExcluirCadastro.UseVisualStyleBackColor = false;
            this.btnExcluirCadastro.Click += new System.EventHandler(this.btnExcluirCadastro_Click);
            // 
            // panelAliangister
            // 
            this.panelAliangister.Controls.Add(this.label_Aliangister);
            this.panelAliangister.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAliangister.Location = new System.Drawing.Point(0, 0);
            this.panelAliangister.Name = "panelAliangister";
            this.panelAliangister.Size = new System.Drawing.Size(200, 64);
            this.panelAliangister.TabIndex = 0;
            // 
            // panelNome
            // 
            this.panelNome.Controls.Add(this.btnCloseChildForm);
            this.panelNome.Controls.Add(this.lbl_nomePagina);
            this.panelNome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNome.Location = new System.Drawing.Point(200, 0);
            this.panelNome.Name = "panelNome";
            this.panelNome.Size = new System.Drawing.Size(864, 64);
            this.panelNome.TabIndex = 6;
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.AutoSize = true;
            this.btnCloseChildForm.BackColor = System.Drawing.Color.White;
            this.btnCloseChildForm.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.ForeColor = System.Drawing.Color.Transparent;
            this.btnCloseChildForm.Image = global::Aliangister.Properties.Resources.cbcb6cf6_370d_4da4_9f26_c8e8fdbc0e89;
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCloseChildForm.Size = new System.Drawing.Size(64, 64);
            this.btnCloseChildForm.TabIndex = 16;
            this.btnCloseChildForm.UseVisualStyleBackColor = false;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // lbl_nomePagina
            // 
            this.lbl_nomePagina.AutoEllipsis = true;
            this.lbl_nomePagina.BackColor = System.Drawing.Color.White;
            this.lbl_nomePagina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_nomePagina.Font = new System.Drawing.Font("Futura Md BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomePagina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_nomePagina.Location = new System.Drawing.Point(0, 0);
            this.lbl_nomePagina.Name = "lbl_nomePagina";
            this.lbl_nomePagina.Size = new System.Drawing.Size(864, 64);
            this.lbl_nomePagina.TabIndex = 1;
            this.lbl_nomePagina.Text = "Tela Inicial";
            this.lbl_nomePagina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_nomePagina.Click += new System.EventHandler(this.lbl_nomePagina_Click);
            // 
            // panel_corSolida
            // 
            this.panel_corSolida.Controls.Add(this.lbl_logo);
            this.panel_corSolida.Controls.Add(this.pictureBox_logo);
            this.panel_corSolida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_corSolida.Location = new System.Drawing.Point(200, 64);
            this.panel_corSolida.Name = "panel_corSolida";
            this.panel_corSolida.Size = new System.Drawing.Size(864, 547);
            this.panel_corSolida.TabIndex = 7;
            this.panel_corSolida.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // lbl_logo
            // 
            this.lbl_logo.AutoEllipsis = true;
            this.lbl_logo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_logo.Font = new System.Drawing.Font("Futura Md BT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_logo.Location = new System.Drawing.Point(303, 233);
            this.lbl_logo.Name = "lbl_logo";
            this.lbl_logo.Size = new System.Drawing.Size(261, 64);
            this.lbl_logo.TabIndex = 1;
            this.lbl_logo.Text = "Aliangister";
            this.lbl_logo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_logo.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Image = global::Aliangister.Properties.Resources._008cacde_1d8f_4bc1_b150_000a96ba17bd;
            this.pictureBox_logo.Location = new System.Drawing.Point(0, 128);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(864, 102);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_logo.TabIndex = 2;
            this.pictureBox_logo.TabStop = false;
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 611);
            this.Controls.Add(this.panel_corSolida);
            this.Controls.Add(this.panelNome);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1080, 650);
            this.MinimumSize = new System.Drawing.Size(1080, 650);
            this.Name = "TelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aliangister";
            this.Load += new System.EventHandler(this.TelaInicial_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelAliangister.ResumeLayout(false);
            this.panelNome.ResumeLayout(false);
            this.panelNome.PerformLayout();
            this.panel_corSolida.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Aliangister;
        private System.Windows.Forms.Button btn_CdCliente;
        private System.Windows.Forms.Button btn_CdPeca;
        private System.Windows.Forms.Button btn_CdVenda;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelAliangister;
        private System.Windows.Forms.Panel panelNome;
        private System.Windows.Forms.Label lbl_nomePagina;
        private System.Windows.Forms.Panel panel_corSolida;
        private System.Windows.Forms.Label lbl_logo;
        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Button btnExcluirCadastro;
    }
}