using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SAVWMS
{
    public partial class CapturingData : Form
    {
        public CapturingData()
        {
            InitializeComponent();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            MainForm.mainForm.manager.cloudnet.Send(MainForm.mainForm.manager.cloudnet.UpdateIPList());
            cmbaddress.Items.Clear();
            cmbaddress.Text = "";
            Thread.Sleep(100);
            foreach (IPList a in MainForm.mainForm.manager.getiplist)
            {
                if (a.ID != null)
                {
                    cmbaddress.Items.Add(a.IP);
                }
            }
        }

        private void btnconnect_Click(object sender, EventArgs e)
        {
            if (btnconnect.Text == "连接")
            {
                MainForm.mainForm.manager.cloudnet.Send(DeviceID());
                //不要收获体积了。。。
                //MainForm.mainForm.manager.cloudnet.Send(MainForm.mainForm.manager.cloudnet.CreatCodeToPackage(Codemode.monitor));

                Thread.Sleep(1000);


                btnconnect.Text = "断开";
                
            }
            else if (btnconnect.Text == "断开")
            {
                MainForm.mainForm.manager.cloudnet.Send(MainForm.mainForm.manager.cloudnet.CreatCodeToPackage(Codemode.release));

                btnconnect.Text = "连接";

            }
        }

        Package DeviceID()
        {
            Package package = new Package();
            package.message = Messagetype.codeus;
            package.data = Encoding.UTF8.GetBytes(btnconnect.Text);
            return package;
        }
    }
}
