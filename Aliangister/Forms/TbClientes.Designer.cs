
namespace Aliangister
{
    partial class TbClientes
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
            this.datagrid_TbClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_TbClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid_TbClientes
            // 
            this.datagrid_TbClientes.AllowUserToAddRows = false;
            this.datagrid_TbClientes.AllowUserToDeleteRows = false;
            this.datagrid_TbClientes.AllowUserToResizeColumns = false;
            this.datagrid_TbClientes.AllowUserToResizeRows = false;
            this.datagrid_TbClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_TbClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagrid_TbClientes.Location = new System.Drawing.Point(0, 0);
            this.datagrid_TbClientes.Name = "datagrid_TbClientes";
            this.datagrid_TbClientes.ReadOnly = true;
            this.datagrid_TbClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.datagrid_TbClientes.Size = new System.Drawing.Size(618, 611);
            this.datagrid_TbClientes.TabIndex = 0;
            this.datagrid_TbClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_TbClientes_CellContentClick);
            // 
            // TbClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(618, 611);
            this.Controls.Add(this.datagrid_TbClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TbClientes";
            this.ShowIcon = false;
            this.Text = "Tabela de Clientes";
            this.Load += new System.EventHandler(this.TbClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_TbClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid_TbClientes;
    }
}