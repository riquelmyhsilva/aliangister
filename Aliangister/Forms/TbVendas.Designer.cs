
namespace Aliangister
{
    partial class TbVendas
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
            this.datagrid_TbVendas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_TbVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid_TbVendas
            // 
            this.datagrid_TbVendas.AllowUserToAddRows = false;
            this.datagrid_TbVendas.AllowUserToDeleteRows = false;
            this.datagrid_TbVendas.AllowUserToResizeColumns = false;
            this.datagrid_TbVendas.AllowUserToResizeRows = false;
            this.datagrid_TbVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_TbVendas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagrid_TbVendas.Location = new System.Drawing.Point(0, 0);
            this.datagrid_TbVendas.Name = "datagrid_TbVendas";
            this.datagrid_TbVendas.ReadOnly = true;
            this.datagrid_TbVendas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.datagrid_TbVendas.Size = new System.Drawing.Size(800, 450);
            this.datagrid_TbVendas.TabIndex = 2;
            this.datagrid_TbVendas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_TbPecas_CellContentClick);
            // 
            // TbVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datagrid_TbVendas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TbVendas";
            this.ShowIcon = false;
            this.Text = "Tabela de Vendas";
            this.Load += new System.EventHandler(this.TbVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_TbVendas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid_TbVendas;
    }
}