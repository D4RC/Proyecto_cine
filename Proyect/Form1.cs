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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_inicio_sesion_Click(object sender, EventArgs e)
        {
            usuario = tbx_usuario.Text;
            contraseña = tbx_password.Text;

            //Función de digestion
            tmp_source_contraseña = ASCIIEncoding.ASCII.GetBytes(contraseña);
            tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmp_source_contraseña);

            //Funcion de verificación en base de datos
            verificar();
        }

        static string ByteArrayToString(byte[] arrInput)
        {
            int i;
            StringBuilder sOutput = new StringBuilder(arrInput.Length);
            for (i = 0; i < arrInput.Length - 1; i++)
            {
                sOutput.Append(arrInput[i].ToString("X2"));
            }
            return sOutput.ToString();
        }

        private void bdGuardapassword()
        {
            try
            {
                SqlConnection conn = new SqlConnection("Server = D-PC\\TEW_SQLEXPRESS; Database = BD_Cine; Integrated Security = True");

                string source_con = tbx_password.Text;
                byte[] tmp_source_con;
                byte[] tmpHash;
                tmp_source_con = ASCIIEncoding.ASCII.GetBytes(source_con);
                tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmp_source_con);
                string push = ByteArrayToString(tmpHash);

                string Hash_Hexa = ByteArrayToString(tmpHash);
                string user = "admin";
                //string query = "INSERT INTO vdatos (datos) VALUES ('" + user + "')";
                string query ="INSERT INTO Usuarios (Usuario,Password) VALUES ('" + user + "',' hashBytes('MD5','" + source_con + "'))";

                tbx_usuario.Text = query;

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                int i = cmd.ExecuteNonQuery();
                conn.Close();
            }

            catch (Exception exe)
            {
                throw exe;
            }
        }
    }
}
