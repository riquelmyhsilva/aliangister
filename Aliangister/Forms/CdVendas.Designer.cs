
namespace Aliangister
{
    partial class CdVendas
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
            this.maskedtxt_Data_CdVendas = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Data_CdPecas = new System.Windows.Forms.Label();
            this.btn_vizTbVendas_CdVendas = new System.Windows.Forms.Button();
            this.btn_Cadastrar_CdVendas = new System.Windows.Forms.Button();
            this.lbl_Quant_CdVendas = new System.Windows.Forms.Label();
            this.txt_Quant_CdVendas = new System.Windows.Forms.TextBox();
            this.lbl_idPeca_CdVendas = new System.Windows.Forms.Label();
            this.txt_idPeca_CdVendas = new System.Windows.Forms.TextBox();
            this.lbl_idCliente_CdVendas = new System.Windows.Forms.Label();
            this.txt_idCliente_CdVendas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // maskedtxt_Data_CdVendas
            // 
            this.maskedtxt_Data_CdVendas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedtxt_Data_CdVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedtxt_Data_CdVendas.Location = new System.Drawing.Point(376, 243);
            this.maskedtxt_Data_CdVendas.Mask = "0000-00-00";
            this.maskedtxt_Data_CdVendas.Name = "maskedtxt_Data_CdVendas";
            this.maskedtxt_Data_CdVendas.Size = new System.Drawing.Size(88, 26);
            this.maskedtxt_Data_CdVendas.TabIndex = 49;
            this.maskedtxt_Data_CdVendas.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_Data_CdPecas
            // 
            this.lbl_Data_CdPecas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Data_CdPecas.AutoSize = true;
            this.lbl_Data_CdPecas.Font = new System.Drawing.Font("Futura Bk BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Data_CdPecas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_Data_CdPecas.Location = new System.Drawing.Point(199, 240);
            this.lbl_Data_CdPecas.Name = "lbl_Data_CdPecas";
            this.lbl_Data_CdPecas.Size = new System.Drawing.Size(171, 29);
            this.lbl_Data_CdPecas.TabIndex = 48;
            this.lbl_Data_CdPecas.Text = "Data de Venda";
            // 
            // btn_vizTbVendas_CdVendas
            // 
            this.btn_vizTbVendas_CdVendas.BackColor = System.Drawing.Color.Transparent;
            this.btn_vizTbVendas_CdVendas.FlatAppearance.BorderSize = 0;
            this.btn_vizTbVendas_CdVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vizTbVendas_CdVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vizTbVendas_CdVendas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_vizTbVendas_CdVendas.Location = new System.Drawing.Point(304, 415);
            this.btn_vizTbVendas_CdVendas.Name = "btn_vizTbVendas_CdVendas";
            this.btn_vizTbVendas_CdVendas.Size = new System.Drawing.Size(240, 30);
            this.btn_vizTbVendas_CdVendas.TabIndex = 46;
            this.btn_vizTbVendas_CdVendas.Text = "Vizualizar Tabela de Vendas";
            this.btn_vizTbVendas_CdVendas.UseVisualStyleBackColor = false;
            this.btn_vizTbVendas_CdVendas.Click += new System.EventHandler(this.btn_vizTbVendas_CdVendas_Click);
            // 
            // btn_Cadastrar_CdVendas
            // 
            this.btn_Cadastrar_CdVendas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Cadastrar_CdVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cadastrar_CdVendas.Font = new System.Drawing.Font("Futura Md BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cadastrar_CdVendas.ForeColor = System.Drawing.Color.White;
            this.btn_Cadastrar_CdVendas.Location = new System.Drawing.Point(334, 365);
            this.btn_Cadastrar_CdVendas.Name = "btn_Cadastrar_CdVendas";
            this.btn_Cadastrar_CdVendas.Size = new System.Drawing.Size(180, 40);
            this.btn_Cadastrar_CdVendas.TabIndex = 45;
            this.btn_Cadastrar_CdVendas.Text = "Casdatrar";
            this.btn_Cadastrar_CdVendas.UseVisualStyleBackColor = false;
            this.btn_Cadastrar_CdVendas.Click += new System.EventHandler(this.btn_Cadastrar_CdVendas_Click);
            // 
            // lbl_Quant_CdVendas
            // 
            this.lbl_Quant_CdVendas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Quant_CdVendas.AutoSize = true;
            this.lbl_Quant_CdVendas.Font = new System.Drawing.Font("Futura Bk BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quant_CdVendas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_Quant_CdVendas.Location = new System.Drawing.Point(136, 208);
            this.lbl_Quant_CdVendas.Name = "lbl_Quant_CdVendas";
            this.lbl_Quant_CdVendas.Size = new System.Drawing.Size(234, 29);
            this.lbl_Quant_CdVendas.TabIndex = 42;
            this.lbl_Quant_CdVendas.Text = "Quantidade Vendida";
            // 
            // txt_Quant_CdVendas
            // 
            this.txt_Quant_CdVendas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Quant_CdVendas.BackColor = System.Drawing.Color.White;
            this.txt_Quant_CdVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Quant_CdVendas.ForeColor = System.Drawing.Color.Black;
            this.txt_Quant_CdVendas.Location = new System.Drawing.Point(375, 211);
            this.txt_Quant_CdVendas.MaxLength = 20;
            this.txt_Quant_CdVendas.Name = "txt_Quant_CdVendas";
            this.txt_Quant_CdVendas.Size = new System.Drawing.Size(88, 26);
            this.txt_Quant_CdVendas.TabIndex = 41;
            // 
            // lbl_idPeca_CdVendas
            // 
            this.lbl_idPeca_CdVendas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_idPeca_CdVendas.AutoSize = true;
            this.lbl_idPeca_CdVendas.Font = new System.Drawing.Font("Futura Bk BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idPeca_CdVendas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_idPeca_CdVendas.Location = new System.Drawing.Point(243, 175);
            this.lbl_idPeca_CdVendas.Name = "lbl_idPeca_CdVendas";
            this.lbl_idPeca_CdVendas.Size = new System.Drawing.Size(127, 29);
            this.lbl_idPeca_CdVendas.TabIndex = 40;
            this.lbl_idPeca_CdVendas.Text = "ID da Peça";
            // 
            // txt_idPeca_CdVendas
            // 
            this.txt_idPeca_CdVendas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_idPeca_CdVendas.BackColor = System.Drawing.Color.White;
            this.txt_idPeca_CdVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idPeca_CdVendas.ForeColor = System.Drawing.Color.Black;
            this.txt_idPeca_CdVendas.Location = new System.Drawing.Point(376, 179);
            this.txt_idPeca_CdVendas.MaxLength = 50;
            this.txt_idPeca_CdVendas.Name = "txt_idPeca_CdVendas";
            this.txt_idPeca_CdVendas.Size = new System.Drawing.Size(88, 26);
            this.txt_idPeca_CdVendas.TabIndex = 39;
            // 
            // lbl_idCliente_CdVendas
            // 
            this.lbl_idCliente_CdVendas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_idCliente_CdVendas.AutoSize = true;
            this.lbl_idCliente_CdVendas.Font = new System.Drawing.Font("Futura Bk BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idCliente_CdVendas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_idCliente_CdVendas.Location = new System.Drawing.Point(220, 143);
            this.lbl_idCliente_CdVendas.Name = "lbl_idCliente_CdVendas";
            this.lbl_idCliente_CdVendas.Size = new System.Drawing.Size(150, 29);
            this.lbl_idCliente_CdVendas.TabIndex = 37;
            this.lbl_idCliente_CdVendas.Text = "ID do Cliente";
            // 
            // txt_idCliente_CdVendas
            // 
            this.txt_idCliente_CdVendas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_idCliente_CdVendas.BackColor = System.Drawing.Color.White;
            this.txt_idCliente_CdVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idCliente_CdVendas.ForeColor = System.Drawing.Color.Black;
            this.txt_idCliente_CdVendas.Location = new System.Drawing.Point(376, 147);
            this.txt_idCliente_CdVendas.MaxLength = 50;
            this.txt_idCliente_CdVendas.Name = "txt_idCliente_CdVendas";
            this.txt_idCliente_CdVendas.Size = new System.Drawing.Size(88, 26);
            this.txt_idCliente_CdVendas.TabIndex = 36;
            // 
            // CdVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(848, 508);
            this.Controls.Add(this.maskedtxt_Data_CdVendas);
            this.Controls.Add(this.lbl_Data_CdPecas);
            this.Controls.Add(this.btn_vizTbVendas_CdVendas);
            this.Controls.Add(this.btn_Cadastrar_CdVendas);
            this.Controls.Add(this.lbl_Quant_CdVendas);
            this.Controls.Add(this.txt_Quant_CdVendas);
            this.Controls.Add(this.lbl_idPeca_CdVendas);
            this.Controls.Add(this.txt_idPeca_CdVendas);
            this.Controls.Add(this.lbl_idCliente_CdVendas);
            this.Controls.Add(this.txt_idCliente_CdVendas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CdVendas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Venda";
            this.Load += new System.EventHandler(this.CdVendas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedtxt_Data_CdVendas;
        private System.Windows.Forms.Label lbl_Data_CdPecas;
        private System.Windows.Forms.Button btn_vizTbVendas_CdVendas;
        private System.Windows.Forms.Button btn_Cadastrar_CdVendas;
        private System.Windows.Forms.Label lbl_Quant_CdVendas;
        private System.Windows.Forms.TextBox txt_Quant_CdVendas;
        private System.Windows.Forms.Label lbl_idPeca_CdVendas;
        private System.Windows.Forms.TextBox txt_idPeca_CdVendas;
        private System.Windows.Forms.Label lbl_idCliente_CdVendas;
        private System.Windows.Forms.TextBox txt_idCliente_CdVendas;
    }
}