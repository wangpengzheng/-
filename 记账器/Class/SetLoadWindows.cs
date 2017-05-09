using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

namespace 记账器.Class
{
    class SetLoadWindows
    {
        public string StrName;
        private string StrNewName;
        private RegistryKey Reg;

        public SetLoadWindows(bool OnORoff)
        {
            StrName = Application.ExecutablePath;
            StrNewName = StrName.Substring(StrName.LastIndexOf("//") + 1);
            if (OnORoff == true)
            {
                if (CheckIf())
                { MessageBox.Show("程序已经开机自启了！"); }
                else
                    SetOn();
            }
            else
            {
                if (!CheckIf())
                {
                    MessageBox.Show("程序已不能开机自启动！");
                }
                else
                    SetOff();
            }
        }

        private bool CheckIf()
        {
            
            Reg=Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\run",true);
            if (Reg == null)
                Reg.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\run");
            bool b=false;
            foreach (string name in Reg.GetValueNames())
            {
                if (name == "记账器")
                    b = true;
            }
            return b;
        }

        private void SetOn()
        {
            try
            {
                Reg.SetValue("记账器", StrName);
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.ToString());
               return;
            }
            MessageBox.Show("程序已经可以开机自启动了~！~");
        }

        private void SetOff()
        {
            try
            {
                Reg.DeleteValue("记账器", false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
            MessageBox.Show("ok!");
        }
    }
}
