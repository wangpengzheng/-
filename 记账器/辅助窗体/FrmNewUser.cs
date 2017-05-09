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
    public partial class FrmNewUser : Form
    {
        public FrmNewUser()
        {
            InitializeComponent();
        }

        //用于清空配置信息中默认登录用户
        private void ClearDefaultUser()
        {
            string ItemLocation = Application.StartupPath + @"\Item.ini";
            FileStream fTemp = new FileStream(ItemLocation, FileMode.Truncate);
            StreamWriter sw = new StreamWriter(fTemp);
            sw.WriteLine("Use=1<u>");
            sw.WriteLine("DefaultUser=<d>");
            sw.Close();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                return;
            LoadDataBase db = new LoadDataBase();
            db.RunDelOrInsSQL("Insert into users values('" + textBox1.Text.Trim() + "','" + textBox2.Text.Trim() + "','0')");
            db.RunDelOrInsSQL("create table " + textBox1.Text.Trim() +
                "(Item varchar(20),Attribute varChar(15),MyTime varchar(11),UseMoney varchar(11),About varchar(100),primary key(Item,Attribute,MyTime,UseMoney))");
            if (textBox2.Text == "")
            {
                MessageBox.Show("添加新用户 " + textBox1.Text.Trim() + " 成功！您未设置密码。","成功");
            }
            else
                MessageBox.Show("添加新用户 " + textBox1.Text.Trim() + " 成功！您的密码为： " + textBox2.Text, "成功");
            FrmMain.OtherNewName = textBox1.Text;
            this.Close();
        }


        private void textBox1_Leave(object sender, EventArgs e)
        {
            LoadDataBase db = new LoadDataBase();
            DataView dv = new DataView();
            dv = db.RunSelectSql("select * from users where Name='" + textBox1.Text + "'");
            if (dv.Count != 0)
            {
                MessageBox.Show("已存在的用户名！", "错误！");
                textBox1.Text = "";
                textBox1.Focus();
            }
        }

        private void FrmNewUser_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                BtnInsert.Focus();
            }
        }
    }
}
