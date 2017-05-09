namespace 记账器.辅助窗体
{
    partial class FrmChkPw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChkPw));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPw = new System.Windows.Forms.TextBox();
            this.CmbName = new System.Windows.Forms.ComboBox();
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(8, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "密码：";
            // 
            // TxtPw
            // 
            this.TxtPw.Location = new System.Drawing.Point(82, 38);
            this.TxtPw.Name = "TxtPw";
            this.TxtPw.PasswordChar = '*';
            this.TxtPw.Size = new System.Drawing.Size(121, 21);
            this.TxtPw.TabIndex = 1;
            this.TxtPw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPw_KeyPress);
            // 
            // CmbName
            // 
            this.CmbName.FormattingEnabled = true;
            this.CmbName.Location = new System.Drawing.Point(82, 12);
            this.CmbName.Name = "CmbName";
            this.CmbName.Size = new System.Drawing.Size(121, 20);
            this.CmbName.TabIndex = 3;
            this.CmbName.SelectedIndexChanged += new System.EventHandler(this.CmbName_SelectedIndexChanged);
            // 
            // BtnOk
            // 
            this.BtnOk.BackgroundImage = global::记账器.Properties.Resources.groupbox背景;
            this.BtnOk.Location = new System.Drawing.Point(19, 72);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(69, 23);
            this.BtnOk.TabIndex = 2;
            this.BtnOk.Text = "登录";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackgroundImage = global::记账器.Properties.Resources.groupbox背景;
            this.BtnCancel.Location = new System.Drawing.Point(127, 72);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(69, 23);
            this.BtnCancel.TabIndex = 4;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // FrmChkPw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::记账器.Properties.Resources.groupbox背景;
            this.ClientSize = new System.Drawing.Size(217, 101);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.CmbName);
            this.Controls.Add(this.TxtPw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmChkPw";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户登录";
            this.Load += new System.EventHandler(this.FrmChkPw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPw;
        private System.Windows.Forms.ComboBox CmbName;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Button BtnCancel;
    }
}