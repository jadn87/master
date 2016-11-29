using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MarketerPOS
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
            Application.Run(new Login());
            System.Console.WriteLine("Se inicio la ventana principal");
        }
    }
}
