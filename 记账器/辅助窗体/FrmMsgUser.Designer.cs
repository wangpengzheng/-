namespace 记账器.辅助窗体
{
    partial class FrmMsgUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMsgUser));
            this.lst = new System.Windows.Forms.ListBox();
            this.BtnDel = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst
            // 
            this.lst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lst.FormattingEnabled = true;
            this.lst.ItemHeight = 12;
            this.lst.Location = new System.Drawing.Point(0, 0);
            this.lst.Name = "lst";
            this.lst.Size = new System.Drawing.Size(250, 124);
            this.lst.TabIndex = 1;
            this.lst.SelectedIndexChanged += new System.EventHandler(this.lst_SelectedIndexChanged);
            // 
            // BtnDel
            // 
            this.BtnDel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDel.BackgroundImage")));
            this.BtnDel.Location = new System.Drawing.Point(12, 133);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(99, 22);
            this.BtnDel.TabIndex = 2;
            this.BtnDel.Text = "删除选中用户";
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAdd.BackgroundImage")));
            this.BtnAdd.Location = new System.Drawing.Point(141, 133);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(98, 22);
            this.BtnAdd.TabIndex = 3;
            this.BtnAdd.Text = "添加新用户";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // FrmMsgUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(251, 164);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.lst);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMsgUser";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户管理平台";
            this.Load += new System.EventHandler(this.FrmMsgUser_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lst;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.Button BtnAdd;
    }
}