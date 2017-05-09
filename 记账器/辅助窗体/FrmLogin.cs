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
using 记账器.辅助窗体;

namespace 记账器.辅助窗体
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private string[] UserName;
        private string SelectUser="";
        private int SelectID;
        //检查用户是否进入成功，无密码默认成功
        public static bool Access = false;

        //判断是否有密码保护
        private int[] LK;

        private void SetAutoLoad(string str)
        {
            string ItemLocation = Application.StartupPath + @"\Item.ini";
            FileStream fTemp = new FileStream(ItemLocation, FileMode.Truncate);
            StreamWriter sw = new StreamWriter(fTemp);
            sw.WriteLine("Use=1<u>");
            sw.WriteLine("DefaultUser=" + str + "<d>");
            sw.Close();
            fTemp.Close();
        }

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
                    Access = true;
                }
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            ShowAllUser();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            FrmNewUser frm = new FrmNewUser();
            frm.ShowDialog();
            this.Close();
        }

        private void lst_SelectedIndexChanged(object sender, EventArgs e)
        {
            //用户选择空白地方，返回操作
            if (lst.SelectedIndex == -1)
                return;
            SelectUser = UserName[lst.SelectedIndex];
            SelectID = lst.SelectedIndex;
        }

        public void load()
        {
            if (SelectUser == "")
            {
                return;
            }

            if (LK[SelectID] == 1)
            {
                FrmChkPw frmChk = new FrmChkPw(true, SelectUser);
                this.Hide();
                frmChk.ShowDialog();
                if (Chk.CheckState == CheckState.Checked && Access)
                {
                    FrmMain.OtherNewName = SelectUser;
                    SetAutoLoad(SelectUser);
                }
                else if (Access)
                {
                    this.Close();
                }
            }
            else
            {
                FrmMain.OtherNewName = SelectUser;
                this.Close();
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            load();
        }

        private void lst_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            load();
        }
    }
}
