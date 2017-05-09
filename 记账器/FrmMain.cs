using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using 记账器.Class;
using 记账器.辅助窗体;
using Microsoft.VisualBasic;
using System.Data.OleDb;

namespace 记账器
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        public FrmMain(string strName)
        {
            InitializeComponent();
            CurUserName = strName;
        }
        //数据库位置
        public static string DataBaseLoc;
        //模式选择 1为记账模式 0 为查询模式 2为修改模式
        public int Mod=1;
        //当前用户名
        public string CurUserName="";
        //默认登录的用户名（无需密码）
        public static string DefaultUser;
        //用于控制查询记录的位置
        LookControl lc;
        ReNewOldText Rnot;
        //文档加密类
        EnCode Cod;

        public static string OtherNewName="";
        public static string ItemLocation;


        //新建用户时需对数据库的操作
        public void CreateTable()
        {
            LoadDataBase cls = new LoadDataBase();
            try
            {
                cls.RunDelOrInsSQL("create table users(Name varchar(20) primary key,pw varchar(20),IsMsg int)");
                cls.RunDelOrInsSQL("create table Vincent(Item varchar(20),Attribute varChar(15),MyTime varchar(11),UseMoney varchar(15),About varchar(100),primary key(Item,Attribute,MyTime,UseMoney))");
                cls.RunDelOrInsSQL("create table Md5(Data varchar(50)");
            }
            catch(Exception ex)
            { 
                MessageBox.Show(Convert.ToString(ex));
            }
            MessageBox.Show("初次使用请设定管理员密码！");
            FrmChkPw frm = new FrmChkPw();
            frm.mod = false;
            frm.ShowDialog();
            if (CurUserName != "Vincent")
            {
                Application.Exit();
            }
        }

        //检查数据库及数据文件中的内容
        public void ChkDataBase()
        {
            DataBaseLoc = Application.StartupPath + @"\DataBase.mdb";
            ItemLocation = Application.StartupPath + @"\Item.ini";
            Cod = new EnCode();
            if (File.Exists(DataBaseLoc) == false)
            {
                MessageBox.Show("找不到数据库！重新安装本程序以解决问题。", "丢失数据库");
                Application.Exit();
            }
            if (File.Exists(ItemLocation) == false)
            {
                CreateTable();
                FileStream fs = new FileStream(ItemLocation, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(Cod.SetCode("Use=0<u>"));
                sw.Write(Cod.SetCode("DefaultUser=Vincent<d>"));
                sw.Close();
                fs.Close();
            }
            else
                {
                FileStream fsR = new FileStream(ItemLocation, FileMode.Open); 
                StreamReader sr = new StreamReader(fsR);
                String str=sr.ReadToEnd();
                //处理设置文件为空的情况
                if (str == "")
                {
                    sr.Close();
                    fsR.Close();
                    //FileStream fTemp = new FileStream(ItemLocation, FileMode.Truncate);
                    //StreamWriter sw = new StreamWriter(fTemp);
                    //sw.WriteLine("Use=1<u>");
                    //sw.WriteLine("DefaultUser=Vincent<d>");
                    //sw.Close();
                    //fTemp.Close();

                    //FileStream fsR1 = new FileStream(ItemLocation, FileMode.Open);
                    //StreamReader sr1 = new StreamReader(fsR1);
                    //str = sr1.ReadToEnd();
                    //sr1.Close();
                    //fsR1.Close();
                }
                sr.Close();
                fsR.Close();
                string T1, T2;
                T1 = str.Substring(4,1);
                T2 = str.Substring(str.IndexOf("DefaultUser=") + 12, str.IndexOf("<d>") - str.IndexOf("DefaultUser=") -12);
                if (T1 == "0")
                {
                    CurUserName = "Vincent";
                    DefaultUser = "Vincent";
                    FileStream fTemp = new FileStream(ItemLocation, FileMode.Truncate);
                    StreamWriter sw = new StreamWriter(fTemp);
                    sw.WriteLine("Use=1<u>");
                    sw.WriteLine("DefaultUser=Vincent<d>");
                    fTemp.Close();
                    sw.Close();
                }
                else
                {
                    if (T2 == "")
                    {
                        FrmLogin frm = new FrmLogin();
                        frm.ShowDialog();
                        if (OtherNewName != "")
                        {
                            CurUserName = OtherNewName;
                        }
                        LoadSet(1);
                    }
                    else
                    {
                        CurUserName = T2;
                        DefaultUser = T2;
                    }
                }
            }

     //       FrmLogin frm = new FrmLogin();
      //      frm.ShowDialog();

        }

        //重置本程序中的内容
        public void Reset()
        {
            Dtp.Value = DateTime.Now.Date;
            TxtWhat.Text = "";
            TxtHowMuch.Text = "";
            TxtAbout.Text = "";
            CmbWhat.Text = "";
            CmbWhich.Text = "";
            lblNum.Text = "";
            lblMessage.Text = "";
        }

        //3模式间转换需要初始化的内容
        public void WriteMod()
        {
            Reset();
            this.Text = "记账器      当前用户：" + CurUserName + "       当前模式：记账模式";
            CmbWhat.Visible = false;
            TxtWhat.Visible = true;
            CmbWhich.Enabled = true;
            CmbWhat.Enabled = true;
            BtnOK.Visible = true;
            BtnOK.Text = "记账吧~";
            {
                lblMessage.Text = "";
                lblNum.Text = "";
                BtnNew.Visible = false;
                lblMessage.Visible = false;
                lblNum.Visible = false;
                BtnFirst.Visible = false;
                BtnNext.Visible = false;
                BtnLast.Visible = false;
                BtnPre.Visible = false;
                BtnDel.Visible = false;
            }
        }

        public void ReadMod()
        {
            Reset();
            this.Text = "记账器      当前用户：" + CurUserName + "       当前模式：查询模式";
            CmbWhat.Visible = true;
            TxtWhat.Visible = false;
            CmbWhich.Enabled = true;
            CmbWhat.Enabled = true;
            BtnOK.Visible = false;
            {
                lblMessage.Text = "";
                lblNum.Text = "";
                BtnNew.Visible = true;
                lblMessage.Visible = true;
                lblNum.Visible = true;
                BtnFirst.Visible = true;
                BtnNext.Visible = true;
                BtnLast.Visible = true;
                BtnPre.Visible = true;
                BtnDel.Visible = false;
            }

        }

        public void ReNewMod()
        {
            Reset();
            this.Text = "记账器        当前用户：" + CurUserName + "       当前模式：修改模式";
            CmbWhat.Visible = true;
            TxtWhat.Visible = false;
            CmbWhich.Enabled = true;
            CmbWhat.Enabled = true;
            BtnOK.Visible = true;
            BtnOK.Text = "我错了~";
            {
                lblMessage.Text = "";
                lblNum.Text = "";
                BtnNew.Visible = true;
                lblMessage.Visible = true;
                lblNum.Visible = true;
                BtnFirst.Visible = true;
                BtnNext.Visible = true;
                BtnLast.Visible = true;
                BtnPre.Visible = true;
                //Btndel在选中正确项时有效
                BtnDel.Visible = true;
                BtnDel.Enabled = false;
            }
        }

        //显示窗体前需要做的工作，包括载入用户信息。默认模式的自动选择
        public void LoadSet(int i)
        {
            if (i == 1)
                WriteMod();
            else
                if (i == 0)
                    ReadMod();
                else
                    ReNewMod();
            //MessageBox.Show(Dtp.Value.Date.ToString("yyyy-MM-dd"));
            if (CurUserName == "Vincent")
                管理用户ToolStripMenuItem.Enabled = true;
            else
                管理用户ToolStripMenuItem.Enabled = false;
        }

        //导入该用户的数据，方便用户输入
        public void LoadUserData(string username)
        {
            if (username == "")
                return;
            string strItem = "select distinct Item from " + CurUserName;
            string strAttribute = "select distinct Attribute from " + CurUserName;
            DataView dvI = new DataView();
            DataView dvA = new DataView();
            LoadDataBase db = new LoadDataBase();
            dvI = db.RunSelectSql(strItem);
            dvA = db.RunSelectSql(strAttribute);
            TxtWhat.AutoCompleteCustomSource.Clear();
            CmbWhich.Items.Clear();
            CmbWhich.AutoCompleteCustomSource.Clear();
            CmbWhat.Items.Clear();
            CmbWhat.AutoCompleteCustomSource.Clear();
            ////所有文本框置空
            //TxtAbout.Text = "";
            //CmbWhat.Text = "";
            //CmbWhich.Text = "";
            //TxtHowMuch.Text = "";
            //TxtWhat.Text = "";
            for (int i = 0; i < dvI.Count; i++)
            {
                if (Mod == 1)
                {
                    TxtWhat.AutoCompleteCustomSource.Add(Convert.ToString(dvI[i][0]));
                }
                else
                {
                    CmbWhat.AutoCompleteCustomSource.Add(Convert.ToString(dvI[i][0]));
                    CmbWhat.Items.Add(Convert.ToString(dvI[i][0]));
                }
            }
            for (int j = 0; j < dvA.Count; j++)
            {
                CmbWhich.AutoCompleteCustomSource.Add(Convert.ToString(dvA[j][0]));
                CmbWhich.Items.Add(Convert.ToString(dvA[j][0]));
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ChkDataBase();
            LoadSet(Mod);
            LoadUserData(CurUserName);
            Reset();
        }

        private void 浏览数据库文件位置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", Application.StartupPath);
        }

        private void 查询模式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mod = 0;
            LoadSet(Mod);
            LoadUserData(CurUserName);
            Reset();
        }

        private void 记账模式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mod = 1;
            LoadSet(Mod);
            LoadUserData(CurUserName);
            Reset();
        }

        private void 修改模式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mod = 2;
            LoadSet(Mod);
            LoadUserData(CurUserName);
            Reset();
        }

        private void 关于本作品ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.ShowDialog();
        }

        private void 查看帮助文档ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + "\\不要读我.txt") == false)
            {
                MessageBox.Show("文件丢失！重新安装本程序以解决问题~");
                return;
            }
            System.Diagnostics.Process.Start(Application.StartupPath + "\\不要读我.txt");
        }

        private void 跟换账户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin frm = new FrmLogin();
            frm.ShowDialog();
            this.Show();
            if (OtherNewName != "")
            {
                CurUserName = OtherNewName;
            }
            Reset();
            LoadSet(1);
            LoadUserData(CurUserName);
        }

        private void 创建新用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmNewUser frm = new FrmNewUser();
            frm.ShowDialog();
            this.Show();
            if (OtherNewName != "")
            {
                CurUserName = OtherNewName;
            }
            Reset();
            LoadSet(1);
            LoadUserData(CurUserName);
        }

        private void 退出本程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 管理用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMsgUser frm = new FrmMsgUser();
            frm.ShowDialog();
            ////多管理员时启用
            //try
            //{
            //    LoadUserData(CurUserName);
            //    Reset();
            //}
            //catch
            //{
            //    MessageBox.Show("您的用户已被管理员删除！", "悲剧了~");
            //    this.Close();
            //}
        }

        SetLoadWindows kaiji;
        private void 开机自启本程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kaiji = new SetLoadWindows(true);
        }

        private void 取消程序开机自启ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kaiji = new SetLoadWindows(false);
        }

        //根据模式的不同选择按本键之后的动作，包括添加和修改两项功能
        private void BtnOK_Click(object sender, EventArgs e)
        {
            // try
            //{

            if (TxtHowMuch.Text.Trim() == "" & TxtWhat.Text.Trim() == "" & CmbWhich.Text.Trim() == "")
            {
                MessageBox.Show("消费内容、类型、金额均必填！", "插入有误");
                return;
            }
            LoadDataBase db = new LoadDataBase();
            DataView dv = new DataView();
            string strChk = "select * from " + CurUserName + " where Item='" + TxtWhat.Text +
                "' and Attribute='" + CmbWhich.Text + "' and MyTime='" + Dtp.Value.ToString("yyyy-MM-dd") + "' and UseMoney='" + TxtHowMuch.Text + "'";
            dv = db.RunSelectSql(strChk);
            if (Mod == 1)
            {
                if (dv.Count != 0)
                {
                    if (MessageBox.Show("您的数据库中已有本次消费信息，是否用此次的信息替代已有项？", "检查到重复项", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        db.RunDelOrInsSQL("delete * from " + CurUserName + " where Item='" + TxtWhat.Text +
                            "' and Attribute='" + CmbWhich.Text + "' and MyTime='" + Dtp.Value.ToString("yyyy-MM-dd") + "' and UseMoney='" + TxtHowMuch.Text + "'");
                    }
                    else
                        return;
                }
                string strInsert = "Insert into " + CurUserName + " values('" + TxtWhat.Text + "','" + CmbWhich.Text +
                     "','" + Dtp.Value.ToString("yyyy-MM-dd") + "','" + TxtHowMuch.Text + "','" + TxtAbout.Text + "')";
                db.RunDelOrInsSQL(strInsert);
                MessageBox.Show("成功插入信息！", "ok");
                LoadUserData(CurUserName);
                Reset();
            }
            //在其他模式下允许用户进行修改的操作
            else
            {
                ////为类载入修改后的值以供比较
                Rnot.loadNewData(Dtp.Value.ToString("yyyy-MM-dd"), CmbWhat.Text, CmbWhich.Text, TxtHowMuch.Text, TxtAbout.Text);
                if (Rnot.Update()=="0")
                {
                    MessageBox.Show("更新成功！");
                    Reset();
                    return;
                }
                else if (Rnot.Update() == "1")
                {
                    MessageBox.Show("不存在需要更改的记录");
                    return;
                }
                else if (Rnot.Update() == "2")
                {
                    MessageBox.Show("已存在要更改的记录");
                    return;
                }
                else if (Rnot.Update() == "3")
                {
                    MessageBox.Show("未作任何更改");
                    return;
                }
                else
                {
                    MessageBox.Show(Rnot.Update(),"Error");
                    return;
                }
            }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(Convert.ToString(ex));
            //   TxtAbout.Text = "Insert into " + CurUserName + " values('" + TxtWhat.Text + "','" + CmbWhich.Text +
            //       "','" + Dtp.Value.ToString("yyyy-MM-dd") + "','" + TxtHowMuch.Text + "','" + TxtAbout.Text + "')";
            // }
        }

        //一下两个函数控制用户输入得价格为数字
        private void TxtHowMuch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
                return;
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                return;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                BtnOK.Focus();
                return;
            }
            TxtHowMuch.Text = "";
        }

        //方便用户输入快捷键代码
        private void CmbWhat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                CmbWhich.Focus();
            }
        }

        private void CmbWhich_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                TxtHowMuch.Focus();
            }
        }

        private void TxtHowMuch_Leave(object sender, EventArgs e)
        {
            if (TxtHowMuch.Text.Trim() == "")
                return;
            try
            {
                Convert.ToDouble(TxtHowMuch.Text);
            }
            catch
            {
                MessageBox.Show("请输入正确的数字！");
                TxtHowMuch.Text = "";
                return;
            }
        }

        //需要一个判定有效函数，在HasEverSelected为true并有正确项被选中时有效
        private void BtnDel_Click(object sender, EventArgs e)
        {
            LoadDataBase db = new LoadDataBase();
            DataView dv = new DataView();
            dv = db.RunSelectSql("select * from " + CurUserName + " where Item='" + CmbWhat.Text + "' and Attribute='" + 
                CmbWhich.Text + "' and MyTime='" + Dtp.Value.ToString("yyyy-MM-dd") + "' and UseMoney='" + TxtHowMuch.Text +"'");
            if (dv.Count != 0)
            {
                if (MessageBox.Show("是否删除此条信息？", "确定删除？", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    db.RunDelOrInsSQL("delete * from " + CurUserName + " where Item='" + CmbWhat.Text +
                       "' and Attribute='" + CmbWhich.Text + "' and MyTime='" + Dtp.Value.ToString("yyyy-MM-dd") + "' and UseMoney='" + TxtHowMuch.Text + "'");
                    MessageBox.Show("删除成功！");
                    LoadUserData(CurUserName);
                    Reset();
                    return;
                }
                else
                    return;
            }
            if (MessageBox.Show("没有符合条件的信息!是否添加此信息到数据库中？", "未找到相关信息", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    db.RunDelOrInsSQL("Insert into " + CurUserName + " values('" + CmbWhat.Text + "','" + CmbWhich.Text +
                        "','" + Dtp.Value.ToString("yyyy-MM-dd") + "','" + TxtHowMuch.Text + "','" + TxtAbout.Text + "')");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            LoadUserData(CurUserName);
            Reset();
        }
        //两个combbox是否有一个选中
        private bool HadEverSelected_What = false;
        private bool HadEverSelected_Whitch=false;

        //控制查询显示
        private void CmbWhat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ChkFromDate)
                return;
            if (HadEverSelected_Whitch == false)
            {
                //修改另一个cmbbox中选择内容
                if (CurUserName == "")
                    return;
                string strAttribute = "select distinct Attribute from " + CurUserName + " where Item='" + CmbWhat.Text + "'";
                DataView dvA = new DataView();
                LoadDataBase db = new LoadDataBase();
                dvA = db.RunSelectSql(strAttribute);
                CmbWhich.Items.Clear();
                CmbWhich.AutoCompleteCustomSource.Clear();
                for (int j = 0; j < dvA.Count; j++)
                {
                    CmbWhich.AutoCompleteCustomSource.Add(Convert.ToString(dvA[j][0]));
                    CmbWhich.Items.Add(Convert.ToString(dvA[j][0]));
                }
                HadEverSelected_What = true;
                TxtAbout.Text = "";
            }
            else
            {
                //选中类容，显示金额和符合条件的条目
                LoadDataBase db = new LoadDataBase();
                DataView dv = new DataView();
                string ShowMoneyStr = "select MyTime,UseMoney,About from " + CurUserName + " where Item='" + CmbWhat.Text + "' and Attribute='" + CmbWhich.Text + "'";
                int Mt;
                dv = db.RunSelectSql(ShowMoneyStr);
                Mt = dv.Count;
                //初始化显示内容的类
                lc = new LookControl(dv,Mt, 1);
                //初始化修改需要的类,把初始数据放入数据中
                Rnot = new ReNewOldText(CurUserName, Dtp.Value.ToString("yyyy-MM-dd"), CmbWhat.Text, CmbWhich.Text, TxtHowMuch.Text, TxtAbout.Text);
                //设置显示内容
                lc.GoAhead();
                ShowT();
                BtnDel.Enabled = true;
                HadEverSelected_What = false;
                HadEverSelected_Whitch = false;
            }
        }

        private void CmbWhich_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ChkFromDate)
                return;
            //查询模式下返回操作
            if (Mod == 1)
                return;
            if (HadEverSelected_What == false)
            {
                //修改另一个cmbbox中选择内容
                if (CurUserName == "")
                    return;
                string strItem = "select distinct Item from " + CurUserName + " where Attribute='" + CmbWhich.Text + "'";
                DataView dvI = new DataView();
                LoadDataBase db = new LoadDataBase();
                dvI = db.RunSelectSql(strItem);
                TxtWhat.AutoCompleteCustomSource.Clear();
                CmbWhat.Items.Clear();
                CmbWhat.AutoCompleteCustomSource.Clear();
                for (int i = 0; i < dvI.Count; i++)
                {
                    if (Mod == 1)
                    {
                        TxtWhat.AutoCompleteCustomSource.Add(Convert.ToString(dvI[i][0]));
                    }
                    else
                    {
                        CmbWhat.AutoCompleteCustomSource.Add(Convert.ToString(dvI[i][0]));
                        CmbWhat.Items.Add(Convert.ToString(dvI[i][0]));
                    }
                }
                HadEverSelected_Whitch = true;
                TxtAbout.Text = "";
            }
            else
            {
                //选中类容，显示金额和符合条件的条目
                LoadDataBase db = new LoadDataBase();
                DataView dv = new DataView();
                string ShowMoneyStr = "select MyTime,UseMoney,About  from " + CurUserName + " where Item='" + CmbWhat.Text + "' and Attribute='" + CmbWhich.Text + "'";
                int Mt;
                dv = db.RunSelectSql(ShowMoneyStr);
                Mt = dv.Count;
                //初始化显示内容的类
                lc = new LookControl(dv,Mt, 1);
                //初始化修改需要的类,把初始数据放入数据中
                Rnot = new ReNewOldText(CurUserName, Dtp.Value.ToString("yyyy-MM-dd"), CmbWhat.Text, CmbWhich.Text,TxtHowMuch.Text, TxtAbout.Text);
                //设置显示内容
                lc.GoAhead();
                ShowT();
                BtnDel.Enabled = true;
                HadEverSelected_Whitch = false;
                HadEverSelected_What = false;
            }
            //很奇怪为啥自己选中并更新之后文本框没有选中的值
        }

        //用于判断检索的类型
        private bool ChkFromDate = false;

        private void BtnNew_Click(object sender, EventArgs e)
        {
            LoadUserData(CurUserName);
            Reset();
            ChkFromDate = false;
            CmbWhich.Enabled = true;
            CmbWhat.Enabled = true;
            BtnDel.Enabled = false;
        }

        private void Dtp_CloseUp(object sender, EventArgs e)
        {
            if (Mod == 1)
                return;
            else if (Mod == 2)
                BtnDel.Enabled = true;
            ChkFromDate = true;
            CmbWhich.Enabled = false;
            CmbWhat.Enabled = false;
            DataView dv = new DataView();
            LoadDataBase db = new LoadDataBase();
            string strDate = "select Item,Attribute,UseMoney,About from " + CurUserName + " where MyTime='" + Dtp.Value.ToString("yyyy-MM-dd") + "'";
            dv = db.RunSelectSql(strDate);
            if (dv.Count == 0)
            {
                lblMessage.Text = "没有找到相关信息！";
                CmbWhat.Text = "";
                CmbWhich.Text = "";
                lblNum.Text = "";
                TxtHowMuch.Text = "";
                TxtAbout.Text = "";
            }
            else
            {
                int Mt = dv.Count;
                lc = new LookControl(dv, Mt, 1);
                lc.GoAhead(true);
                ShowT(true);
            }
            //初始化修改需要的类,把初始数据放入数据中
            Rnot = new ReNewOldText(CurUserName, Dtp.Value.ToString("yyyy-MM-dd"), CmbWhat.Text, CmbWhich.Text, TxtHowMuch.Text, TxtAbout.Text);
            TxtAbout.Text = strDate;
        }

        //窗体淡出效果
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        { 
            for (int i = 100; i >0; i--)
            {
                this.Opacity =i / 100.0;
                System.Threading.Thread.Sleep(10);
            }
            //Application.Exit();
        }

        //重载
        private void ShowT(bool FromDate)
        {
            TxtHowMuch.Text = lc.LKMoney;
            TxtAbout.Text = lc.LKAbout;
            CmbWhat.Text  = lc.LKWhat;
            CmbWhich.Text  = lc.LKWhith;
            lblMessage.Text = "符合条件的有 " + lc.Mount + "条信息";
            lblNum.Text = "当前浏览：第" + lc.place + "条";
        }
        //控制输出
        private void ShowT()
        {
            TxtHowMuch.Text = lc.LKMoney;
            TxtAbout.Text = lc.LKAbout;
            Dtp.Value = DateTime.Parse(lc.LKDate);
            lblMessage.Text = "符合条件的有 " + lc.Mount + "条信息";
            lblNum.Text = "当前浏览：第" + lc.place + "条";
        }

        //控制查询时游标的位置
        private void BtnFirst_Click(object sender, EventArgs e)
        {
            if (ChkFromDate)
            {
                lc.GoAhead(true);
                ShowT(true);
                return;
            }
            lc.GoAhead();
            //控制显示
            ShowT();
        }

        private void BtnPre_Click(object sender, EventArgs e)
        {
            if (ChkFromDate)
            {
                if (lc.GoPre(true))
                {
                    ShowT(true);
                }
                return;
            }
            if (lc.GoPre())
            {
                //控制显示
                ShowT();
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (ChkFromDate)
            {
                if (lc.GoNext(true))
                {
                    ShowT(true);
                }
                return;
            }
            if (lc.GoNext())
            {
                //控制显示
                ShowT();
            }
        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            if (ChkFromDate)
            {
                lc.GoLast(true);
                ShowT(true);
                return;
            }
            lc.GoLast();
            //控制显示
            ShowT();
        }

        private void 导出为wordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 导出为ExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }




 


        



    }
}
