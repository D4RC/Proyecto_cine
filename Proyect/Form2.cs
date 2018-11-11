using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyect
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pbtn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbtn_Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_menu1_Click(object sender, EventArgs e)
        {
            panel_Inventario.Visible = true;
        }

        private void btn_Inv_Alta_Click(object sender, EventArgs e)
        {
            Form3 AInv = new Form3();
            AInv.Show();
            
        }
    }
}
