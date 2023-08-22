
namespace Aliangister
{
    partial class TbPecas
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
            this.datagrid_TbPecas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_TbPecas)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid_TbPecas
            // 
            this.datagrid_TbPecas.AllowUserToAddRows = false;
            this.datagrid_TbPecas.AllowUserToDeleteRows = false;
            this.datagrid_TbPecas.AllowUserToResizeColumns = false;
            this.datagrid_TbPecas.AllowUserToResizeRows = false;
            this.datagrid_TbPecas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_TbPecas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagrid_TbPecas.Location = new System.Drawing.Point(0, 0);
            this.datagrid_TbPecas.Name = "datagrid_TbPecas";
            this.datagrid_TbPecas.ReadOnly = true;
            this.datagrid_TbPecas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.datagrid_TbPecas.Size = new System.Drawing.Size(755, 549);
            this.datagrid_TbPecas.TabIndex = 1;
            this.datagrid_TbPecas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_TbPecas_CellContentClick);
            // 
            // TbPecas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(755, 549);
            this.Controls.Add(this.datagrid_TbPecas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TbPecas";
            this.ShowIcon = false;
            this.Text = "Tabela de Peças";
            this.Load += new System.EventHandler(this.TbPecas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_TbPecas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid_TbPecas;
    }
}