using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAVWMS
{
    public partial class MainForm : Form
    {
        public Manager manager;
        public static MainForm mainForm;
        public MainForm()
        {
            mainForm = this;
            manager = new Manager();
            InitializeComponent();
        }
        
        private void 开始扫码ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 任务栏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.taskbarmeStrip.Visible = true;
        }

       
       
        /// <summary>
        /// 添加窗体至页签
        /// </summary>
        /// <param name="tabName">
        /// 从菜单栏获取的窗口名
        /// </param>
        /// <param name="myForm">
        /// 所要添加的具体窗体
        /// </param>
        private void Add_TabPage(string tabName, Form myForm, int flag = 0)
        {
            if (flag == 0)
                tabName += " X";
            if (tabControlCheckHave(this.tabControlMain, tabName))
            {
                myForm.Close();
               
                return;
            }
            else
            {
                //添加一个选项卡并且显示最近添加的选项卡
                tabControlMain.TabPages.Add(tabName);
                tabControlMain.SelectTab(tabControlMain.TabPages.Count - 1);

                myForm.FormBorderStyle = FormBorderStyle.None;
                myForm.Dock = DockStyle.Fill;
                myForm.TopLevel = false;
                myForm.Show();

                //设置控件的父容器
                myForm.Parent = tabControlMain.SelectedTab;

            }


        }
        /// <summary>
        /// 检查是否已经存在窗体所对应的页签
        /// </summary>
        /// <param name="tab">
        /// 相关选项卡页集
        /// </param>
        /// <param name="tabName">
        /// tab页签的名字
        /// </param>
        /// <returns>
        /// 返回检查状态，如果存在则返回true，不存在返回false
        /// </returns>
        private bool tabControlCheckHave(System.Windows.Forms.TabControl tab, String tabName)
        {
            for (int i = 0; i < tab.TabCount; i++)
            {
                if (tab.TabPages[i].Text == tabName)
                {
                    tab.SelectedIndex = i;
                    return true;
                }
            }
            return false;
        }

        private void 开始扫码ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form form = new CapturingData();
            ToolStripMenuItem menu = sender as ToolStripMenuItem;
            Add_TabPage(menu.Text, form);
        }

        /// <summary>
        /// tabcontrol的鼠标事件，用于关闭选项卡
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControlMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int x = e.X;
                int y = e.Y;

                Rectangle tabRect = this.tabControlMain.GetTabRect(this.tabControlMain.SelectedIndex);

                tabRect.Offset(tabRect.Width - 0x12, 2);

                tabRect.Width = 15;

                tabRect.Height = 15;

                if ((((x > tabRect.X) && (x < tabRect.Right)) && (y > tabRect.Y)) && (y < tabRect.Bottom))
                {
                    this.tabControlMain.TabPages.Remove(this.tabControlMain.SelectedTab);
                }

            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
