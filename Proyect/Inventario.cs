using System.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace Proyect
{
    public partial class Form3
    {

        public void push_Base()
        {

           
                double P_Venta = Convert.ToDouble(tbx_Pventa.Text);
                double P_Compra = Convert.ToDouble(tbx_Pcompra.Text);
                DateTime Cad = Convert.ToDateTime(mtbx_Cad.Text);
                string Prod = tbx_Prod.Text;
                string Id = tbx_Id.Text;
                string Det = cmb_Det.Text;
                int Cant = Convert.ToInt32(tbx_Cant.Text);
            
          

            /*
            try
            {
                using (SqlConnection con = new SqlConnection("Server = D-PC\\TEW_SQLEXPRESS; Database = BD_Cine; Integrated Security = True"))
                {
                    string columnas = "(Id_Producto, Producto, Detalle, Existencias, Caducidad, Precio_compra, Precio_venta)";
                    string parametros = "(@Id_Producto, @Producto, @Detalle, @Existencias, @Caducidad, @Precio_compra, @Precio_venta)";

                    SqlCommand cmd = new SqlCommand("INSERT INTO Inventario " + columnas + " VALUES " + parametros);

                    cmd.Parameters.AddWithValue("@Id_Producto", Id);
                    cmd.Parameters.AddWithValue("@Producto", Prod);
                    cmd.Parameters.AddWithValue("@Detalle", Det);
                    cmd.Parameters.AddWithValue("@Existencias", Cant);
                    cmd.Parameters.AddWithValue("@Caducidad", Cad);
                    cmd.Parameters.AddWithValue("@Precio_compra", P_Compra);
                    cmd.Parameters.AddWithValue("@Precio_venta", P_Venta);

                    cmd.Connection = con;
                    con.Open();
                    con.Close();
                }
            }
            catch(Exception exe)
            {
                throw exe;
            }
            */

            try
            {
                using (SqlConnection connection = new SqlConnection("Server = D-PC\\TEW_SQLEXPRESS; Database = BD_Cine; Integrated Security = True"))
                {
                    string columnas = "(Id_Producto, Producto, Detalle, Existencias, Caducidad, Precio_compra, Precio_venta)";
                    string parametros = "(@Id_Producto, @Producto, @Detalle, @Existencias, @Caducidad, @Precio_compra, @Precio_venta)";

                    String query = "INSERT INTO Inventario " + columnas + " VALUES " + parametros;

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Id_Producto", Id);
                        cmd.Parameters.AddWithValue("@Producto", Prod);
                        cmd.Parameters.AddWithValue("@Detalle", Det);
                        cmd.Parameters.AddWithValue("@Existencias", Cant);
                        cmd.Parameters.AddWithValue("@Caducidad", Cad);
                        cmd.Parameters.AddWithValue("@Precio_compra", P_Compra);
                        cmd.Parameters.AddWithValue("@Precio_venta", P_Venta);

                        connection.Open();
                        int result = cmd.ExecuteNonQuery();

                        // Check Error
                        if (result < 0)
                            MessageBox.Show("Error al cargar datos");
                        connection.Close();
                    }
                }
            }
            catch(Exception e)
            {
                throw e;
            }

        }
    }
}