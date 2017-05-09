using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 记账器.Class;
using 记账器;

namespace 记账器.辅助窗体
{
    public partial class FrmChkPw : Form
    {
        public FrmChkPw()
        {
            InitializeComponent();
        }

        public FrmChkPw(bool b,string str)
        {
            InitializeComponent();
            mod = b;
            UserName = str;
        }
        //false 为设定管理员密码模式
        public Boolean mod;
        public string UserName;
        private string ChkPw;
        private string code;

        private void FrmChkPw_Load(object sender, EventArgs e)
        {
            if (mod == false)
            {
                CmbName.Text = "Vincent";
                CmbName.Enabled = false;
                this.Text = "管理员密码设定";
                return;
            }
            LoadDataBase db = new LoadDataBase();
            DataView dv = new DataView();
            CmbName.Text = UserName;
            TxtPw.Focus();
            //cmbbox添加用户
            {
                string str = "select name from users";
                dv = db.RunSelectSql(str);
                if (dv.Count != 0)
                {
                    for (int i = 0; i < dv.Count; i++)
                    {
                        CmbName.Items.Add(dv[i][0]);
                    }
                }
            }
        }

        private bool ChkPws(string TheName)
        {
            LoadDataBase db = new LoadDataBase();
            DataView dv = new DataView();
            //找到用户密码
            ChkPw = "select pw from users where name='" + UserName + "'";
            dv = db.RunSelectSql(ChkPw);
            if (dv.Count != 1)
            {
                return false;
            }
            else
            {
                code = Convert.ToString(dv[0][0]);
                return true;
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (mod == false)
            {
                LoadDataBase cls = new LoadDataBase();
                cls.RunDelOrInsSQL("Insert into users values('Vincent','" + TxtPw.Text.ToString() +"','1')");
                if (TxtPw.Text == "")
                {
                    MessageBox.Show("您的管理员密码为空!");
                }
                else
                    MessageBox.Show("管理员密码设定成功!");
                //FrmMain.CurUserName = "Vincent";
                this.Close();
            }
            if(!ChkPws(UserName))
            {
                return;
            }
            if (TxtPw.Text.Trim() != code)
            {
                MessageBox.Show("密码错误！");
                FrmLogin.Access = false;
                return;
            }
            else
            {
              FrmLogin.Access = true;
              this.Close();
            }
            
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            FrmMain.OtherNewName = "";
            this.Close();
        }

        private void CmbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserName = CmbName.SelectedItem.ToString();
            if (!ChkPws(UserName))
            {
                return;
            }
            if (code == "")
            {
                TxtPw.Enabled = false;
                TxtPw.Text = "无密码";
            }
            BtnOk.Focus();
        }

        private void TxtPw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                BtnOk.Focus();
            }
        }

    }
}
