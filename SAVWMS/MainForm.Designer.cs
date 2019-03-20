namespace SAVWMS
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.taskbarmeStrip = new System.Windows.Forms.MenuStrip();
            this.开始扫码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开始扫码ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbarmeStrip = new System.Windows.Forms.MenuStrip();
            this.menubarmeStrip = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.视图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.任务栏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.格式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.测试ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.检查更新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.taskbarmeStrip.SuspendLayout();
            this.menubarmeStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // taskbarmeStrip
            // 
            this.taskbarmeStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.taskbarmeStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.taskbarmeStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始扫码ToolStripMenuItem});
            this.taskbarmeStrip.Location = new System.Drawing.Point(0, 52);
            this.taskbarmeStrip.Name = "taskbarmeStrip";
            this.taskbarmeStrip.Size = new System.Drawing.Size(102, 590);
            this.taskbarmeStrip.TabIndex = 0;
            this.taskbarmeStrip.Text = "Thetaskbar";
            // 
            // 开始扫码ToolStripMenuItem
            // 
            this.开始扫码ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始扫码ToolStripMenuItem1});
            this.开始扫码ToolStripMenuItem.Name = "开始扫码ToolStripMenuItem";
            this.开始扫码ToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.开始扫码ToolStripMenuItem.Text = "选择开启项";
            this.开始扫码ToolStripMenuItem.Click += new System.EventHandler(this.开始扫码ToolStripMenuItem_Click);
            // 
            // 开始扫码ToolStripMenuItem1
            // 
            this.开始扫码ToolStripMenuItem1.Name = "开始扫码ToolStripMenuItem1";
            this.开始扫码ToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.开始扫码ToolStripMenuItem1.Text = "开始扫码";
            this.开始扫码ToolStripMenuItem1.Click += new System.EventHandler(this.开始扫码ToolStripMenuItem1_Click);
            // 
            // toolbarmeStrip
            // 
            this.toolbarmeStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolbarmeStrip.Location = new System.Drawing.Point(0, 28);
            this.toolbarmeStrip.Name = "toolbarmeStrip";
            this.toolbarmeStrip.Size = new System.Drawing.Size(1223, 24);
            this.toolbarmeStrip.TabIndex = 1;
            this.toolbarmeStrip.Text = "Thetoolbar";
            // 
            // menubarmeStrip
            // 
            this.menubarmeStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menubarmeStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.视图ToolStripMenuItem,
            this.格式ToolStripMenuItem,
            this.测试ToolStripMenuItem,
            this.关于ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menubarmeStrip.Location = new System.Drawing.Point(0, 0);
            this.menubarmeStrip.Name = "menubarmeStrip";
            this.menubarmeStrip.Size = new System.Drawing.Size(1223, 28);
            this.menubarmeStrip.TabIndex = 3;
            this.menubarmeStrip.Text = "Themenubar";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // 视图ToolStripMenuItem
            // 
            this.视图ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.任务栏ToolStripMenuItem});
            this.视图ToolStripMenuItem.Name = "视图ToolStripMenuItem";
            this.视图ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.视图ToolStripMenuItem.Text = "视图";
            // 
            // 任务栏ToolStripMenuItem
            // 
            this.任务栏ToolStripMenuItem.Name = "任务栏ToolStripMenuItem";
            this.任务栏ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.任务栏ToolStripMenuItem.Text = "任务栏";
            this.任务栏ToolStripMenuItem.Click += new System.EventHandler(this.任务栏ToolStripMenuItem_Click);
            // 
            // 格式ToolStripMenuItem
            // 
            this.格式ToolStripMenuItem.Name = "格式ToolStripMenuItem";
            this.格式ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.格式ToolStripMenuItem.Text = "格式";
            // 
            // 测试ToolStripMenuItem
            // 
            this.测试ToolStripMenuItem.Name = "测试ToolStripMenuItem";
            this.测试ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.测试ToolStripMenuItem.Text = "测试";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.检查更新ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 检查更新ToolStripMenuItem
            // 
            this.检查更新ToolStripMenuItem.Name = "检查更新ToolStripMenuItem";
            this.检查更新ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.检查更新ToolStripMenuItem.Text = "检查更新";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(102, 52);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1121, 590);
            this.tabControlMain.TabIndex = 4;
            this.tabControlMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tabControlMain_MouseDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 642);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.taskbarmeStrip);
            this.Controls.Add(this.toolbarmeStrip);
            this.Controls.Add(this.menubarmeStrip);
            this.Name = "MainForm";
            this.Text = "体积重量测量及扫码系统";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.taskbarmeStrip.ResumeLayout(false);
            this.taskbarmeStrip.PerformLayout();
            this.menubarmeStrip.ResumeLayout(false);
            this.menubarmeStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem 开始扫码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开始扫码ToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip toolbarmeStrip;
        private System.Windows.Forms.MenuStrip menubarmeStrip;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 视图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 任务栏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 格式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 测试ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 检查更新ToolStripMenuItem;
        public System.Windows.Forms.MenuStrip taskbarmeStrip;
        private System.Windows.Forms.TabControl tabControlMain;
    }
}

