namespace 记账器
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.BtnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Dtp = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.浏览数据库文件位置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出本用户资料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出为wordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出为ExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.取消程序开机自启ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开机自启本程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出本程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.记账模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.报表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显示报表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.跟换账户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.创建新用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看帮助文档ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于本作品ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtWhat = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtAbout = new System.Windows.Forms.TextBox();
            this.CmbWhich = new System.Windows.Forms.ComboBox();
            this.TxtHowMuch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbWhat = new System.Windows.Forms.ComboBox();
            this.BtnFirst = new System.Windows.Forms.Button();
            this.BtnPre = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnLast = new System.Windows.Forms.Button();
            this.BtnDel = new System.Windows.Forms.Button();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.NfI = new System.Windows.Forms.NotifyIcon(this.components);
            this.BtnNew = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnOK
            // 
            this.BtnOK.BackgroundImage = global::记账器.Properties.Resources.label_背景;
            resources.ApplyResources(this.BtnOK, "BtnOK");
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // Dtp
            // 
            resources.ApplyResources(this.Dtp, "Dtp");
            this.Dtp.Name = "Dtp";
            this.Dtp.Value = new System.DateTime(2010, 9, 9, 0, 0, 0, 0);
            this.Dtp.CloseUp += new System.EventHandler(this.Dtp_CloseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::记账器.Properties.Resources.菜单栏背景;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.报表ToolStripMenuItem,
            this.用户管理ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.浏览数据库文件位置ToolStripMenuItem,
            this.导出本用户资料ToolStripMenuItem,
            this.取消程序开机自启ToolStripMenuItem,
            this.开机自启本程序ToolStripMenuItem,
            this.退出本程序ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            resources.ApplyResources(this.文件ToolStripMenuItem, "文件ToolStripMenuItem");
            // 
            // 浏览数据库文件位置ToolStripMenuItem
            // 
            this.浏览数据库文件位置ToolStripMenuItem.Name = "浏览数据库文件位置ToolStripMenuItem";
            resources.ApplyResources(this.浏览数据库文件位置ToolStripMenuItem, "浏览数据库文件位置ToolStripMenuItem");
            this.浏览数据库文件位置ToolStripMenuItem.Click += new System.EventHandler(this.浏览数据库文件位置ToolStripMenuItem_Click);
            // 
            // 导出本用户资料ToolStripMenuItem
            // 
            this.导出本用户资料ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导出为wordToolStripMenuItem,
            this.导出为ExcelToolStripMenuItem});
            this.导出本用户资料ToolStripMenuItem.Name = "导出本用户资料ToolStripMenuItem";
            resources.ApplyResources(this.导出本用户资料ToolStripMenuItem, "导出本用户资料ToolStripMenuItem");
            // 
            // 导出为wordToolStripMenuItem
            // 
            this.导出为wordToolStripMenuItem.Name = "导出为wordToolStripMenuItem";
            resources.ApplyResources(this.导出为wordToolStripMenuItem, "导出为wordToolStripMenuItem");
            this.导出为wordToolStripMenuItem.Click += new System.EventHandler(this.导出为wordToolStripMenuItem_Click);
            // 
            // 导出为ExcelToolStripMenuItem
            // 
            this.导出为ExcelToolStripMenuItem.Name = "导出为ExcelToolStripMenuItem";
            resources.ApplyResources(this.导出为ExcelToolStripMenuItem, "导出为ExcelToolStripMenuItem");
            this.导出为ExcelToolStripMenuItem.Click += new System.EventHandler(this.导出为ExcelToolStripMenuItem_Click);
            // 
            // 取消程序开机自启ToolStripMenuItem
            // 
            this.取消程序开机自启ToolStripMenuItem.Name = "取消程序开机自启ToolStripMenuItem";
            resources.ApplyResources(this.取消程序开机自启ToolStripMenuItem, "取消程序开机自启ToolStripMenuItem");
            this.取消程序开机自启ToolStripMenuItem.Click += new System.EventHandler(this.取消程序开机自启ToolStripMenuItem_Click);
            // 
            // 开机自启本程序ToolStripMenuItem
            // 
            this.开机自启本程序ToolStripMenuItem.Name = "开机自启本程序ToolStripMenuItem";
            resources.ApplyResources(this.开机自启本程序ToolStripMenuItem, "开机自启本程序ToolStripMenuItem");
            this.开机自启本程序ToolStripMenuItem.Click += new System.EventHandler(this.开机自启本程序ToolStripMenuItem_Click);
            // 
            // 退出本程序ToolStripMenuItem
            // 
            this.退出本程序ToolStripMenuItem.Name = "退出本程序ToolStripMenuItem";
            resources.ApplyResources(this.退出本程序ToolStripMenuItem, "退出本程序ToolStripMenuItem");
            this.退出本程序ToolStripMenuItem.Click += new System.EventHandler(this.退出本程序ToolStripMenuItem_Click);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询模式ToolStripMenuItem,
            this.记账模式ToolStripMenuItem,
            this.修改模式ToolStripMenuItem});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            resources.ApplyResources(this.编辑ToolStripMenuItem, "编辑ToolStripMenuItem");
            // 
            // 查询模式ToolStripMenuItem
            // 
            this.查询模式ToolStripMenuItem.Name = "查询模式ToolStripMenuItem";
            resources.ApplyResources(this.查询模式ToolStripMenuItem, "查询模式ToolStripMenuItem");
            this.查询模式ToolStripMenuItem.Click += new System.EventHandler(this.查询模式ToolStripMenuItem_Click);
            // 
            // 记账模式ToolStripMenuItem
            // 
            this.记账模式ToolStripMenuItem.Name = "记账模式ToolStripMenuItem";
            resources.ApplyResources(this.记账模式ToolStripMenuItem, "记账模式ToolStripMenuItem");
            this.记账模式ToolStripMenuItem.Click += new System.EventHandler(this.记账模式ToolStripMenuItem_Click);
            // 
            // 修改模式ToolStripMenuItem
            // 
            this.修改模式ToolStripMenuItem.Name = "修改模式ToolStripMenuItem";
            resources.ApplyResources(this.修改模式ToolStripMenuItem, "修改模式ToolStripMenuItem");
            this.修改模式ToolStripMenuItem.Click += new System.EventHandler(this.修改模式ToolStripMenuItem_Click);
            // 
            // 报表ToolStripMenuItem
            // 
            this.报表ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示报表ToolStripMenuItem});
            this.报表ToolStripMenuItem.Name = "报表ToolStripMenuItem";
            resources.ApplyResources(this.报表ToolStripMenuItem, "报表ToolStripMenuItem");
            // 
            // 显示报表ToolStripMenuItem
            // 
            this.显示报表ToolStripMenuItem.Name = "显示报表ToolStripMenuItem";
            resources.ApplyResources(this.显示报表ToolStripMenuItem, "显示报表ToolStripMenuItem");
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.跟换账户ToolStripMenuItem,
            this.创建新用户ToolStripMenuItem,
            this.管理用户ToolStripMenuItem});
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            resources.ApplyResources(this.用户管理ToolStripMenuItem, "用户管理ToolStripMenuItem");
            // 
            // 跟换账户ToolStripMenuItem
            // 
            this.跟换账户ToolStripMenuItem.Name = "跟换账户ToolStripMenuItem";
            resources.ApplyResources(this.跟换账户ToolStripMenuItem, "跟换账户ToolStripMenuItem");
            this.跟换账户ToolStripMenuItem.Click += new System.EventHandler(this.跟换账户ToolStripMenuItem_Click);
            // 
            // 创建新用户ToolStripMenuItem
            // 
            this.创建新用户ToolStripMenuItem.Name = "创建新用户ToolStripMenuItem";
            resources.ApplyResources(this.创建新用户ToolStripMenuItem, "创建新用户ToolStripMenuItem");
            this.创建新用户ToolStripMenuItem.Click += new System.EventHandler(this.创建新用户ToolStripMenuItem_Click);
            // 
            // 管理用户ToolStripMenuItem
            // 
            this.管理用户ToolStripMenuItem.Name = "管理用户ToolStripMenuItem";
            resources.ApplyResources(this.管理用户ToolStripMenuItem, "管理用户ToolStripMenuItem");
            this.管理用户ToolStripMenuItem.Click += new System.EventHandler(this.管理用户ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看帮助文档ToolStripMenuItem,
            this.关于本作品ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            resources.ApplyResources(this.帮助ToolStripMenuItem, "帮助ToolStripMenuItem");
            // 
            // 查看帮助文档ToolStripMenuItem
            // 
            this.查看帮助文档ToolStripMenuItem.Name = "查看帮助文档ToolStripMenuItem";
            resources.ApplyResources(this.查看帮助文档ToolStripMenuItem, "查看帮助文档ToolStripMenuItem");
            this.查看帮助文档ToolStripMenuItem.Click += new System.EventHandler(this.查看帮助文档ToolStripMenuItem_Click);
            // 
            // 关于本作品ToolStripMenuItem
            // 
            this.关于本作品ToolStripMenuItem.Name = "关于本作品ToolStripMenuItem";
            resources.ApplyResources(this.关于本作品ToolStripMenuItem, "关于本作品ToolStripMenuItem");
            this.关于本作品ToolStripMenuItem.Click += new System.EventHandler(this.关于本作品ToolStripMenuItem_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // TxtWhat
            // 
            this.TxtWhat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TxtWhat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            resources.ApplyResources(this.TxtWhat, "TxtWhat");
            this.TxtWhat.Name = "TxtWhat";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::记账器.Properties.Resources.groupbox背景;
            this.groupBox1.Controls.Add(this.TxtAbout);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // TxtAbout
            // 
            resources.ApplyResources(this.TxtAbout, "TxtAbout");
            this.TxtAbout.Name = "TxtAbout";
            // 
            // CmbWhich
            // 
            this.CmbWhich.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbWhich.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CmbWhich.FormattingEnabled = true;
            resources.ApplyResources(this.CmbWhich, "CmbWhich");
            this.CmbWhich.Name = "CmbWhich";
            this.CmbWhich.SelectedIndexChanged += new System.EventHandler(this.CmbWhich_SelectedIndexChanged);
            this.CmbWhich.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbWhich_KeyPress);
            // 
            // TxtHowMuch
            // 
            resources.ApplyResources(this.TxtHowMuch, "TxtHowMuch");
            this.TxtHowMuch.Name = "TxtHowMuch";
            this.TxtHowMuch.Leave += new System.EventHandler(this.TxtHowMuch_Leave);
            this.TxtHowMuch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtHowMuch_KeyPress);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Image = global::记账器.Properties.Resources.label_背景;
            this.label5.Name = "label5";
            // 
            // CmbWhat
            // 
            this.CmbWhat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbWhat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.CmbWhat.FormattingEnabled = true;
            resources.ApplyResources(this.CmbWhat, "CmbWhat");
            this.CmbWhat.Name = "CmbWhat";
            this.CmbWhat.SelectedIndexChanged += new System.EventHandler(this.CmbWhat_SelectedIndexChanged);
            this.CmbWhat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbWhat_KeyPress);
            // 
            // BtnFirst
            // 
            resources.ApplyResources(this.BtnFirst, "BtnFirst");
            this.BtnFirst.Name = "BtnFirst";
            this.BtnFirst.UseVisualStyleBackColor = true;
            this.BtnFirst.Click += new System.EventHandler(this.BtnFirst_Click);
            // 
            // BtnPre
            // 
            resources.ApplyResources(this.BtnPre, "BtnPre");
            this.BtnPre.Name = "BtnPre";
            this.BtnPre.UseVisualStyleBackColor = true;
            this.BtnPre.Click += new System.EventHandler(this.BtnPre_Click);
            // 
            // BtnNext
            // 
            resources.ApplyResources(this.BtnNext, "BtnNext");
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnLast
            // 
            resources.ApplyResources(this.BtnLast, "BtnLast");
            this.BtnLast.Name = "BtnLast";
            this.BtnLast.UseVisualStyleBackColor = true;
            this.BtnLast.Click += new System.EventHandler(this.BtnLast_Click);
            // 
            // BtnDel
            // 
            this.BtnDel.Image = global::记账器.Properties.Resources.groupbox背景;
            resources.ApplyResources(this.BtnDel, "BtnDel");
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // lblNum
            // 
            resources.ApplyResources(this.lblNum, "lblNum");
            this.lblNum.ForeColor = System.Drawing.Color.Red;
            this.lblNum.Name = "lblNum";
            // 
            // lblMessage
            // 
            resources.ApplyResources(this.lblMessage, "lblMessage");
            this.lblMessage.ForeColor = System.Drawing.Color.Blue;
            this.lblMessage.Image = global::记账器.Properties.Resources.groupbox背景;
            this.lblMessage.Name = "lblMessage";
            // 
            // NfI
            // 
            resources.ApplyResources(this.NfI, "NfI");
            // 
            // BtnNew
            // 
            this.BtnNew.Image = global::记账器.Properties.Resources.groupbox背景;
            resources.ApplyResources(this.BtnNew, "BtnNew");
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // FrmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::记账器.Properties.Resources.记账器_背景;
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.BtnLast);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnPre);
            this.Controls.Add(this.BtnFirst);
            this.Controls.Add(this.CmbWhat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtHowMuch);
            this.Controls.Add(this.CmbWhich);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtWhat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Dtp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Opacity = 0.9;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Dtp;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtWhat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtAbout;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 浏览数据库文件位置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 记账模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 创建新用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管理用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看帮助文档ToolStripMenuItem;
        private System.Windows.Forms.ComboBox CmbWhich;
        private System.Windows.Forms.TextBox TxtHowMuch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbWhat;
        private System.Windows.Forms.ToolStripMenuItem 跟换账户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于本作品ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 报表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 显示报表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改模式ToolStripMenuItem;
        private System.Windows.Forms.Button BtnFirst;
        private System.Windows.Forms.Button BtnPre;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnLast;
        private System.Windows.Forms.ToolStripMenuItem 退出本程序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开机自启本程序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 取消程序开机自启ToolStripMenuItem;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.ToolStripMenuItem 导出本用户资料ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出为wordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出为ExcelToolStripMenuItem;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.NotifyIcon NfI;
        private System.Windows.Forms.Button BtnNew;
    }
}

