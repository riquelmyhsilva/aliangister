
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
            this.label_Aliangister = new System.Windows.Forms.Label();
            this.btn_CdCliente = new System.Windows.Forms.Button();
            this.btn_CdPeca = new System.Windows.Forms.Button();
            this.btn_CdVenda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Aliangister
            // 
            this.label_Aliangister.AutoSize = true;
            this.label_Aliangister.BackColor = System.Drawing.Color.Transparent;
            this.label_Aliangister.Font = new System.Drawing.Font("Futura Md BT", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Aliangister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label_Aliangister.Location = new System.Drawing.Point(12, 9);
            this.label_Aliangister.Name = "label_Aliangister";
            this.label_Aliangister.Size = new System.Drawing.Size(229, 51);
            this.label_Aliangister.TabIndex = 0;
            this.label_Aliangister.Text = "Aliangister";
            this.label_Aliangister.Click += new System.EventHandler(this.label_Aliangister_Click);
            // 
            // btn_CdCliente
            // 
            this.btn_CdCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_CdCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CdCliente.Font = new System.Drawing.Font("Futura Md BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CdCliente.ForeColor = System.Drawing.Color.White;
            this.btn_CdCliente.Location = new System.Drawing.Point(409, 201);
            this.btn_CdCliente.Name = "btn_CdCliente";
            this.btn_CdCliente.Size = new System.Drawing.Size(232, 64);
            this.btn_CdCliente.TabIndex = 1;
            this.btn_CdCliente.Text = "Casdatrar Cliente";
            this.btn_CdCliente.UseVisualStyleBackColor = false;
            this.btn_CdCliente.Click += new System.EventHandler(this.btn_CdCliente_Click);
            // 
            // btn_CdPeca
            // 
            this.btn_CdPeca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_CdPeca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CdPeca.Font = new System.Drawing.Font("Futura Md BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CdPeca.ForeColor = System.Drawing.Color.White;
            this.btn_CdPeca.Location = new System.Drawing.Point(409, 271);
            this.btn_CdPeca.Name = "btn_CdPeca";
            this.btn_CdPeca.Size = new System.Drawing.Size(232, 64);
            this.btn_CdPeca.TabIndex = 2;
            this.btn_CdPeca.Text = "Casdatrar Peça";
            this.btn_CdPeca.UseVisualStyleBackColor = false;
            this.btn_CdPeca.Click += new System.EventHandler(this.btn_CdPeca_Click);
            // 
            // btn_CdVenda
            // 
            this.btn_CdVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_CdVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CdVenda.Font = new System.Drawing.Font("Futura Md BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CdVenda.ForeColor = System.Drawing.Color.White;
            this.btn_CdVenda.Location = new System.Drawing.Point(409, 341);
            this.btn_CdVenda.Name = "btn_CdVenda";
            this.btn_CdVenda.Size = new System.Drawing.Size(232, 64);
            this.btn_CdVenda.TabIndex = 3;
            this.btn_CdVenda.Text = "Casdatrar Venda";
            this.btn_CdVenda.UseVisualStyleBackColor = false;
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 611);
            this.Controls.Add(this.btn_CdVenda);
            this.Controls.Add(this.btn_CdPeca);
            this.Controls.Add(this.btn_CdCliente);
            this.Controls.Add(this.label_Aliangister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1080, 650);
            this.MinimumSize = new System.Drawing.Size(1080, 650);
            this.Name = "TelaInicial";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Inicial";
            this.Load += new System.EventHandler(this.TelaInicial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Aliangister;
        private System.Windows.Forms.Button btn_CdCliente;
        private System.Windows.Forms.Button btn_CdPeca;
        private System.Windows.Forms.Button btn_CdVenda;
    }
}