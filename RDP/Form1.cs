using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            axMsRdpClient6NotSafeForScripting1.Server = "192.168.0.105";
            axMsRdpClient6NotSafeForScripting1.UserName = "Administor";
            //axMsRdpClient6NotSafeForScripting1.AdvancedSettings2.ClearTextPassword = "pass@123";
            axMsRdpClient6NotSafeForScripting1.AdvancedSettings7.EnableCredSspSupport = true;

            axMsRdpClient6NotSafeForScripting1.ColorDepth = 16;
            axMsRdpClient6NotSafeForScripting1.DesktopHeight = 720;
            axMsRdpClient6NotSafeForScripting1.DesktopWidth = 1024;
            axMsRdpClient6NotSafeForScripting1.Connect();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if(axMsRdpClient6NotSafeForScripting1.Connected.ToString() == "1")
            {
                axMsRdpClient6NotSafeForScripting1.Disconnect();
            }
        }
    }
}
