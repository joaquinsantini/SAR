using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAR
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            int rol;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            rol = ObtenerRol();
            Application.Run(new MenuPrincipal(rol));
        }

        static int ObtenerRol()
        {
            string usuario = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            int rol;

            // 0 es Administrador y 1 es Usuario
            if (usuario == "ps juan" || usuario == "ps pablo")
            {
                rol = 0;
            }
            else
            {
                rol = 1;
            }

            return rol;
        }
    }
}
