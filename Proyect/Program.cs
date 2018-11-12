using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proyect
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Form1());
            // Application.Run(new Form2());
            // Application.Run(new Form3());
            // Application.Run(new BajaInv());
             Application.Run(new ModInv());
            // Application.Run(new Menu_Consultor());
            // Application.Run(new Consulta_Base());
        }
    }
}
