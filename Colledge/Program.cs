using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colledge
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Autorization au = new Autorization(Autorization.ActiveUser);
            Application.Run(au);
            if (Autorization.ActiveUser > 0) Application.Run(new Menu());
        }
    }
}
