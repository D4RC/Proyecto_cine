using System;
using System.Security.Cryptography;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyect
{
    public partial class Form1
    {
        string usuario;
        string contraseña;
        byte[] tmp_source_contraseña;
        byte[] tmpHash;

        private void verificar()
        {
            using (SqlConnection con = new SqlConnection("Server = D-PC\\TEW_SQLEXPRESS; Database = BD_Cine; Integrated Security = True"))
            {
                SqlCommand cmd = new SqlCommand("select * from Usuarios where Usuario = @username and Password = @password;");
                cmd.Parameters.AddWithValue("@username", usuario);
                cmd.Parameters.AddWithValue("@password", tmpHash);
                cmd.Connection = con;
                con.Open();

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                con.Close();

                bool loginSuccessful = ((ds.Tables.Count > 0) && (ds.Tables[0].Rows.Count > 0));

                if (loginSuccessful)
                {
                    MessageBox.Show("Conectando");
                  
                    //Paso a usuario admin o consul
                    bool usuario_admin = Convert.ToBoolean(ds.Tables[0].Rows[0][2].ToString());

                    if(usuario_admin)
                    {
                        Form2 menu = new Form2();
                        menu.Show();
                        this.Hide();
                    }

                    else
                    {
                    }

         
                }
                else
                {
                    MessageBox.Show("Contraseña o Usuario incorrectos");              
                }
            }
        }
    }
}