using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 记账器.Class;
using System.IO;

namespace 记账器.辅助窗体
{
    public partial class FrmMsgUser : Form
    {
        public FrmMsgUser()
        {
            InitializeComponent();
        }

        private string[] UserName;
        private string SelectUser = "";
        //判断是否有密码保护
        private int[] LK;

        private void ShowAllUser()
        {
            lst.Items.Clear();
            LoadDataBase db = new LoadDataBase();
            DataView dv = new DataView();
            DataView dvMsg = new DataView();
            dvMsg = db.RunSelectSql("select Name,pw from users where IsMsg=1");
            dv = db.RunSelectSql("select Name,pw,IsMsg from users");
            UserName = new string[Convert.ToInt32(dv.Count)];
            LK = new int[Convert.ToInt32(dv.Count)];
            for (int i = 0; i < dv.Count; i++)
            {
                UserName[i] = dv[i][0].ToString();
                if (dv[i]["IsMsg"].ToString() == "1")
                {
                    string s = dv[i][0].ToString() + "                                    ";
                    s = s.Insert(30, "管理员账户");
                    lst.Items.Add(s);
                    LK[i] = 1;
                    continue;
                }
                if (dv[i]["pw"].ToString() != "")
                {
                    string s = dv[i][0].ToString() + "                                    ";
                    s = s.Insert(30, "密码保护");
                    lst.Items.Add(s);
                    LK[i] = 1;
                }
                else
                {
                    lst.Items.Add(dv[i][0]);
                    LK[i] = 0;
                }
            }
        }

        private void FrmMsgUser_Load(object sender, EventArgs e)
        {
            ShowAllUser();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (SelectUser == "")
            {
                return;
            }
            if (SelectUser == "Vincent")
            {
                return;
            }
            LoadDataBase db = new LoadDataBase();
            try
            {
                db.RunDelOrInsSQL("drop table " + SelectUser);
            }
            catch
            { }
            try
            {
                db.RunDelOrInsSQL("delete from users where Name='" + SelectUser + "'");
            }
            catch
            { }
            MessageBox.Show("删除用户 " + SelectUser + "  信息成功！","ok");
            ShowAllUser();
        }

        private void lst_SelectedIndexChanged(object sender, EventArgs e)
        {
            //用户选中空白，返回操作
            if (lst.SelectedIndex == -1)
                return;
            SelectUser = UserName[lst.SelectedIndex];
            if (SelectUser == "Vincent")
                BtnDel.Enabled = false;
            else
                BtnDel.Enabled = true;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FrmNewUser frm = new FrmNewUser();
            frm.ShowDialog();
            ShowAllUser();
        }
    }
}
