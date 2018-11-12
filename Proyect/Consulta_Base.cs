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
    public partial class Consulta_Base : Form
    {
        DataTable datos = new DataTable();

        public Consulta_Base()
        {
            InitializeComponent();
            PullData();
            
        }

      

        private void cmb_Sel_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_Sel.ForeColor = Color.LightGray;



        }

        private void cmb_Sel_Enter(object sender, EventArgs e)
        {
            if (cmb_Sel.Text == "PRODUCTO/ID")
            {
                cmb_Sel.Text = "";
                cmb_Sel.ForeColor = Color.LightGray;
            }

        }

        private void cmb_Sel_Leave(object sender, EventArgs e)
        {
            if (cmb_Sel.Text == "")
            {
                cmb_Sel.Text = "PRODUCTO/ID";
                cmb_Sel.ForeColor = Color.DimGray;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

  

        private void rbtn_Prod_CheckedChanged(object sender, EventArgs e)
        {
            cmb_Sel.DataSource = datos;
            cmb_Sel.DisplayMember = "Producto";

            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            foreach(DataRow row in datos.Rows)
            {
                auto.Add(row["Producto"].ToString());
            }
            cmb_Sel.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmb_Sel.AutoCompleteCustomSource = auto;

        }

        private void rbtn_Id_CheckedChanged(object sender, EventArgs e)
        {
            cmb_Sel.DataSource = datos;
            cmb_Sel.DisplayMember = "ID_Producto";

            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            foreach (DataRow row in datos.Rows)
            {
                auto.Add(row["ID_Producto"].ToString());
            }
            cmb_Sel.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmb_Sel.AutoCompleteCustomSource = auto;

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
    }
}
