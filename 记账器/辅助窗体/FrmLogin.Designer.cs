namespace 记账器.辅助窗体
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.lst = new System.Windows.Forms.ListBox();
            this.Chk = new System.Windows.Forms.CheckBox();
            this.BtnLoad = new System.Windows.Forms.Button();
            this.BtnNew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst
            // 
            this.lst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lst.FormattingEnabled = true;
            this.lst.ItemHeight = 12;
            this.lst.Location = new System.Drawing.Point(0, 1);
            this.lst.Name = "lst";
            this.lst.Size = new System.Drawing.Size(253, 124);
            this.lst.TabIndex = 0;
            this.lst.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lst_MouseDoubleClick);
            this.lst.SelectedIndexChanged += new System.EventHandler(this.lst_SelectedIndexChanged);
            // 
            // Chk
            // 
            this.Chk.AutoSize = true;
            this.Chk.BackgroundImage = global::记账器.Properties.Resources.groupbox背景;
            this.Chk.Checked = true;
            this.Chk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Chk.Location = new System.Drawing.Point(108, 171);
            this.Chk.Name = "Chk";
            this.Chk.Size = new System.Drawing.Size(102, 16);
            this.Chk.TabIndex = 1;
            this.Chk.Text = "下次自动登录/";
            this.Chk.UseVisualStyleBackColor = true;
            // 
            // BtnLoad
            // 
            this.BtnLoad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnLoad.BackgroundImage")));
            this.BtnLoad.Location = new System.Drawing.Point(6, 127);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(75, 23);
            this.BtnLoad.TabIndex = 2;
            this.BtnLoad.Text = "登录";
            this.BtnLoad.UseVisualStyleBackColor = true;
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnNew.BackgroundImage")));
            this.BtnNew.Location = new System.Drawing.Point(165, 127);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 23);
            this.BtnNew.TabIndex = 3;
            this.BtnNew.Text = "新建用户";
            this.BtnNew.UseVisualStyleBackColor = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::记账器.Properties.Resources.groupbox背景;
            this.ClientSize = new System.Drawing.Size(252, 190);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.BtnLoad);
            this.Controls.Add(this.Chk);
            this.Controls.Add(this.lst);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择用户登录的账户";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst;
        private System.Windows.Forms.CheckBox Chk;
        private System.Windows.Forms.Button BtnLoad;
        private System.Windows.Forms.Button BtnNew;
    }
}