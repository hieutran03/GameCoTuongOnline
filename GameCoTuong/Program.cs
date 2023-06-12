using CoTuongLAN.CoTuong;
using CoTuongLAN.ProgramConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoTuongLAN
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CoTuongLAN.Menu());
            if (CoTuongLAN.Menu.isClosed == true && CoTuongLAN.Menu.isServer == true)
            {
                Application.Run(new CoTuongLAN.Option());

            }
            if (CoTuongLAN.Option.isClosed == true || (CoTuongLAN.Menu.isClosed == true && CoTuongLAN.Menu.isServer == false))
            {
                Application.Run(new CoTuongLAN.CuongTuongLAN());
            }
        }
    }
}