using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TrainingManagement
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
            Application.Run(new frmLogin());
            //Application.Run(new frmQuanTri("Hùng", "1"));
            //Application.Run(new frmQuanLy("Phát", "2"));
            //Application.Run(new frmGiaoVien("Giang", "3"));
        }
    }
}
