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
    public partial class ModInv : Form
    {
        DataTable datos = new DataTable();
        string producto;


        public ModInv()
        {
            InitializeComponent();
            PullData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataUpdate();
        }

        private void rbtn_Prod_CheckedChanged(object sender, EventArgs e)
        {
            cmb_Sel.DataSource = datos;
            cmb_Sel.DisplayMember = "Producto";
        }

        private void rbtn_Id_CheckedChanged(object sender, EventArgs e)
        {
            cmb_Sel.DataSource = datos;
            cmb_Sel.DisplayMember = "Id_Producto";
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
                da.Fill(datos);
                conn.Close();
                da.Dispose();
            }
        }

        public void DataUpdate()
        {
            using (SqlConnection conn = new SqlConnection("Server = D-PC\\TEW_SQLEXPRESS; Database = BD_Cine; Integrated Security = True"))
            {
                string Ex, PC, PV, Ca, De;
                Ex = tbx_Cant.Text;
                PC = tbx_Cant.Text;
                PV = tbx_Pventa.Text;
                Ca = mtbx_Cad.Text;
                De = cmb_Det.Text;
 

                string query = "UPDATE Inventario SET Existencias = '"+Ex+"', Precio_venta = '"+PV+"', Precio_compra = '"+PC+"', Caducidad = '"+Ca+"', Detalle = '"+De+"' WHERE Producto = '"+producto+"'";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                int result = cmd.ExecuteNonQuery();
                if (result < 0)
                    MessageBox.Show("Error al actualizar datos");


                conn.Close();
            }

        }

        private void cmb_Sel_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow aux = datos.Rows[cmb_Sel.SelectedIndex];

            tbx_Cant.Text = aux["Existencias"].ToString();
            tbx_Pcompra.Text = aux["Precio_compra"].ToString();
            tbx_Pventa.Text = aux["Precio_venta"].ToString();
            mtbx_Cad.Text = aux["Caducidad"].ToString();
            cmb_Det.Text = aux["Detalle"].ToString();

            producto = aux["Producto"].ToString();
        }


    }
}
