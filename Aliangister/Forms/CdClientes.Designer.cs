
namespace Aliangister
{
    partial class CdClientes
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
            this.txt_Nome_CdClientes = new System.Windows.Forms.TextBox();
            this.lbl_Nome_CdClientes = new System.Windows.Forms.Label();
            this.lbl_Email_CdClientes = new System.Windows.Forms.Label();
            this.txt_Email_CdClientes = new System.Windows.Forms.TextBox();
            this.lbl_Telefone_CdClientes = new System.Windows.Forms.Label();
            this.lbl_Empresa_CdClientes = new System.Windows.Forms.Label();
            this.txt_Empresa_CdClientes = new System.Windows.Forms.TextBox();
            this.btn_Cadastrar_CdCliente = new System.Windows.Forms.Button();
            this.btn_vizTbClientes_CdClientes = new System.Windows.Forms.Button();
            this.txt_Telefone_CdClientes = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txt_Nome_CdClientes
            // 
            this.txt_Nome_CdClientes.BackColor = System.Drawing.Color.White;
            this.txt_Nome_CdClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nome_CdClientes.ForeColor = System.Drawing.Color.Black;
            this.txt_Nome_CdClientes.Location = new System.Drawing.Point(321, 147);
            this.txt_Nome_CdClientes.MaxLength = 50;
            this.txt_Nome_CdClientes.Name = "txt_Nome_CdClientes";
            this.txt_Nome_CdClientes.Size = new System.Drawing.Size(206, 26);
            this.txt_Nome_CdClientes.TabIndex = 3;
            this.txt_Nome_CdClientes.TextChanged += new System.EventHandler(this.txt_Nome_CdClientes_TextChanged);
            // 
            // lbl_Nome_CdClientes
            // 
            this.lbl_Nome_CdClientes.AutoSize = true;
            this.lbl_Nome_CdClientes.Font = new System.Drawing.Font("Futura Bk BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nome_CdClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_Nome_CdClientes.Location = new System.Drawing.Point(237, 144);
            this.lbl_Nome_CdClientes.Name = "lbl_Nome_CdClientes";
            this.lbl_Nome_CdClientes.Size = new System.Drawing.Size(78, 29);
            this.lbl_Nome_CdClientes.TabIndex = 4;
            this.lbl_Nome_CdClientes.Text = "Nome";
            this.lbl_Nome_CdClientes.Click += new System.EventHandler(this.lbl_Nome_CdClientes_Click);
            // 
            // lbl_Email_CdClientes
            // 
            this.lbl_Email_CdClientes.AutoSize = true;
            this.lbl_Email_CdClientes.Font = new System.Drawing.Font("Futura Bk BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Email_CdClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_Email_CdClientes.Location = new System.Drawing.Point(243, 177);
            this.lbl_Email_CdClientes.Name = "lbl_Email_CdClientes";
            this.lbl_Email_CdClientes.Size = new System.Drawing.Size(72, 29);
            this.lbl_Email_CdClientes.TabIndex = 7;
            this.lbl_Email_CdClientes.Text = "Email";
            // 
            // txt_Email_CdClientes
            // 
            this.txt_Email_CdClientes.BackColor = System.Drawing.Color.White;
            this.txt_Email_CdClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email_CdClientes.ForeColor = System.Drawing.Color.Black;
            this.txt_Email_CdClientes.Location = new System.Drawing.Point(321, 179);
            this.txt_Email_CdClientes.MaxLength = 50;
            this.txt_Email_CdClientes.Name = "txt_Email_CdClientes";
            this.txt_Email_CdClientes.Size = new System.Drawing.Size(206, 26);
            this.txt_Email_CdClientes.TabIndex = 6;
            // 
            // lbl_Telefone_CdClientes
            // 
            this.lbl_Telefone_CdClientes.AutoSize = true;
            this.lbl_Telefone_CdClientes.Font = new System.Drawing.Font("Futura Bk BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Telefone_CdClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_Telefone_CdClientes.Location = new System.Drawing.Point(214, 209);
            this.lbl_Telefone_CdClientes.Name = "lbl_Telefone_CdClientes";
            this.lbl_Telefone_CdClientes.Size = new System.Drawing.Size(101, 29);
            this.lbl_Telefone_CdClientes.TabIndex = 9;
            this.lbl_Telefone_CdClientes.Text = "Telefone";
            // 
            // lbl_Empresa_CdClientes
            // 
            this.lbl_Empresa_CdClientes.AutoSize = true;
            this.lbl_Empresa_CdClientes.Font = new System.Drawing.Font("Futura Bk BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Empresa_CdClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_Empresa_CdClientes.Location = new System.Drawing.Point(211, 241);
            this.lbl_Empresa_CdClientes.Name = "lbl_Empresa_CdClientes";
            this.lbl_Empresa_CdClientes.Size = new System.Drawing.Size(104, 29);
            this.lbl_Empresa_CdClientes.TabIndex = 11;
            this.lbl_Empresa_CdClientes.Text = "Empresa";
            // 
            // txt_Empresa_CdClientes
            // 
            this.txt_Empresa_CdClientes.BackColor = System.Drawing.Color.White;
            this.txt_Empresa_CdClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Empresa_CdClientes.ForeColor = System.Drawing.Color.Black;
            this.txt_Empresa_CdClientes.Location = new System.Drawing.Point(321, 243);
            this.txt_Empresa_CdClientes.MaxLength = 40;
            this.txt_Empresa_CdClientes.Name = "txt_Empresa_CdClientes";
            this.txt_Empresa_CdClientes.Size = new System.Drawing.Size(206, 26);
            this.txt_Empresa_CdClientes.TabIndex = 10;
            // 
            // btn_Cadastrar_CdCliente
            // 
            this.btn_Cadastrar_CdCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Cadastrar_CdCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cadastrar_CdCliente.Font = new System.Drawing.Font("Futura Md BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cadastrar_CdCliente.ForeColor = System.Drawing.Color.White;
            this.btn_Cadastrar_CdCliente.Location = new System.Drawing.Point(334, 365);
            this.btn_Cadastrar_CdCliente.Name = "btn_Cadastrar_CdCliente";
            this.btn_Cadastrar_CdCliente.Size = new System.Drawing.Size(180, 40);
            this.btn_Cadastrar_CdCliente.TabIndex = 12;
            this.btn_Cadastrar_CdCliente.Text = "Casdatrar";
            this.btn_Cadastrar_CdCliente.UseVisualStyleBackColor = false;
            this.btn_Cadastrar_CdCliente.Click += new System.EventHandler(this.btn_Cadastrar_CdCliente_Click);
            // 
            // btn_vizTbClientes_CdClientes
            // 
            this.btn_vizTbClientes_CdClientes.BackColor = System.Drawing.Color.Transparent;
            this.btn_vizTbClientes_CdClientes.FlatAppearance.BorderSize = 0;
            this.btn_vizTbClientes_CdClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vizTbClientes_CdClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vizTbClientes_CdClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_vizTbClientes_CdClientes.Location = new System.Drawing.Point(304, 415);
            this.btn_vizTbClientes_CdClientes.Name = "btn_vizTbClientes_CdClientes";
            this.btn_vizTbClientes_CdClientes.Size = new System.Drawing.Size(240, 30);
            this.btn_vizTbClientes_CdClientes.TabIndex = 14;
            this.btn_vizTbClientes_CdClientes.Text = "Vizualizar Tabela de Clientes";
            this.btn_vizTbClientes_CdClientes.UseVisualStyleBackColor = false;
            this.btn_vizTbClientes_CdClientes.Click += new System.EventHandler(this.btn_vizTbClientes_CdClientes_Click);
            // 
            // txt_Telefone_CdClientes
            // 
            this.txt_Telefone_CdClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Telefone_CdClientes.Location = new System.Drawing.Point(321, 211);
            this.txt_Telefone_CdClientes.Mask = "(99) 0000-0000";
            this.txt_Telefone_CdClientes.Name = "txt_Telefone_CdClientes";
            this.txt_Telefone_CdClientes.Size = new System.Drawing.Size(116, 26);
            this.txt_Telefone_CdClientes.TabIndex = 15;
            // 
            // CdClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(848, 508);
            this.Controls.Add(this.txt_Telefone_CdClientes);
            this.Controls.Add(this.btn_vizTbClientes_CdClientes);
            this.Controls.Add(this.btn_Cadastrar_CdCliente);
            this.Controls.Add(this.lbl_Empresa_CdClientes);
            this.Controls.Add(this.txt_Empresa_CdClientes);
            this.Controls.Add(this.lbl_Telefone_CdClientes);
            this.Controls.Add(this.lbl_Email_CdClientes);
            this.Controls.Add(this.txt_Email_CdClientes);
            this.Controls.Add(this.lbl_Nome_CdClientes);
            this.Controls.Add(this.txt_Nome_CdClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CdClientes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Cliente";
            this.Load += new System.EventHandler(this.CdClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Nome_CdClientes;
        private System.Windows.Forms.Label lbl_Nome_CdClientes;
        private System.Windows.Forms.Label lbl_Email_CdClientes;
        private System.Windows.Forms.TextBox txt_Email_CdClientes;
        private System.Windows.Forms.Label lbl_Telefone_CdClientes;
        private System.Windows.Forms.Label lbl_Empresa_CdClientes;
        private System.Windows.Forms.TextBox txt_Empresa_CdClientes;
        private System.Windows.Forms.Button btn_Cadastrar_CdCliente;
        private System.Windows.Forms.Button btn_vizTbClientes_CdClientes;
        private System.Windows.Forms.MaskedTextBox txt_Telefone_CdClientes;
    }
}