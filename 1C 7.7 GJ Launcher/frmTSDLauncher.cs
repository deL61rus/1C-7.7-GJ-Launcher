using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1C_7._7_GJ_Launcher
{
    public partial class frmTSDLauncher : Form
    {
        public frmTSDLauncher()
        {
            InitializeComponent();
        }

        private void frmTSDLauncher_Load(object sender, EventArgs e)
        {
            btn_start1c.BackgroundImageLayout = ImageLayout.Zoom;
            btn_logoff.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void btn_logoff_Click(object sender, EventArgs e)
        {
            NativeExtensions.ExitWindowsEx(0U, 0U);
        }

        private void btn_start1c_Click(object sender, EventArgs e)
        {
            this.Hide();
            Process.Start(new ProcessStartInfo("C:\\Program Files\\1Cv77\\BIN\\1cv7.exe", "ENTERPRISE /D D:\\ARM\\ /N tsd /P сканер")
            {
                UseShellExecute = false
            }).WaitForExit();

            this.Visible = true;
        }
    }
}
