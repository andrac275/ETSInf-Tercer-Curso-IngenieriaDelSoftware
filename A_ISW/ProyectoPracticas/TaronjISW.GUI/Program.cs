using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TarongISW.GUI;
using TarongISW.Persistence;
using TarongISW.Services;

namespace TaronjISW.GUI
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ITarongISWService service = new TarongISWService(new EntityFrameworkDAL(new TarongISWDbContext("Base de dades Taronges")));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TarongISWApp(service));

        }
    }
}
