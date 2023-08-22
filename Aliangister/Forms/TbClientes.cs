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
    public partial class TbClientes : Form
    {
        public TbClientes()
        {
            InitializeComponent();
        }

        private void TbClientes_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();

                    var sqlQuery = "SELECT * FROM tb_clientes";

                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using(DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            datagrid_TbClientes.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void datagrid_TbClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
