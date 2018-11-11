using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyect
{
    public partial class BajaInv : Form
    {
        private DataTable TablaDatos = new DataTable();
        int celda;

        public BajaInv()
        {
            InitializeComponent();
            PullData();
           
        }

        public void PullData()
        {
            using (SqlConnection conn = new SqlConnection("Server = D-PC\\TEW_SQLEXPRESS; Database = BD_Cine; Integrated Security = True"))
            {
                string query = "select * from Inventario";
                
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                // create data adapter
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                // this will query your database and return the result to your datatable
                da.Fill(TablaDatos);
                conn.Close();
                da.Dispose();
            }
        }




        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void rbtn_Prod_CheckedChanged(object sender, EventArgs e)
        {
            cmb_Sel.DataSource = TablaDatos;
            cmb_Sel.DisplayMember = "Producto";
            celda = 1;
        }

        private void rbtn_Id_CheckedChanged(object sender, EventArgs e)
        {
            cmb_Sel.DataSource = TablaDatos;
            cmb_Sel.DisplayMember = "Id_Producto";
            celda = 0;
        }

        private void cmb_Sel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string busqueda = cmb_Sel.Text;
            DataTable aux = TablaDatos.Clone();
            aux.ImportRow(TablaDatos.Rows[cmb_Sel.SelectedIndex]);

            dgrid_Datos.DataSource = aux;
           
 

         

            /*
            for (int u = 0; u < dgrid_Datos.RowCount; u++)
            {
                if (dgrid_Datos.Rows[u].Cells[0].Value.ToString() == busqueda)
                {
                    dgrid_Datos.Rows[u].Visible = true;
                }
                else
                {
                    this.dgrid_Datos.CurrentCell = null;
                    dgrid_Datos.Rows[u].Visible = false;
                }
            }
            */

            // (dgrid_Datos.DataSource as DataTable).DefaultView.RowFilter = string.Format("Field = '{0}'", TablaDatos);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

