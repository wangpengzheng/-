using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace 记账器
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        //public FrmMain MyMainfrm = new FrmMain();

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}
