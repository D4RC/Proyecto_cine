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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            push_Base();
            btn_RegOtro.Show();
            btn_BMenu.Show();
         
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btn_Borrar_Click(object sender, EventArgs e)
        {
            limpiar(); 
        }

        private void limpiar()
        {
            foreach (TextBox C in this.Controls.OfType<TextBox>())
            {
                C.Clear();
            }

            mtbx_Cad.Clear();
            cmb_Det.ResetText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiar();
            btn_RegOtro.Hide();
        }
    }

   
}
