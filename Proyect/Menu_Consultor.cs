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
    public partial class Menu_Consultor : Form
    {
        public Menu_Consultor()
        {
            InitializeComponent();
        }

        private void Menu_Consultor_Load(object sender, EventArgs e)
        {

        }

        private void btn_menu1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(pnl_Menu.Width == 164)
            {
                pnl_Menu.Width = 51;

            }
            else
            {
                pnl_Menu.Width = 164;
            }
        }
    }
}
