using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1C_7._7_GJ_Launcher
{
    public partial class LauncherMainForm : Form
    {
        LoginControl loginControl = new LoginControl();
        SettingsControl settingsControl = new SettingsControl();
        
        public LauncherMainForm()
        {
            InitializeComponent();
        }

        #region перетягивание формы
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        private void LauncherMainForm_Load(object sender, EventArgs e)
        {
            loginControl.Parent = panelControls;
            settingsControl.Parent = panelControls;
            panelControls.Controls.Add(loginControl); 
            loginControl.Dock = DockStyle.Fill; //LoginControl
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            panelControls.Controls.Remove(loginControl);
            //panelControls.Controls.Add(settingsControl);
            //settingsControl.Dock = DockStyle.Fill;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); //Выход
        }

        private void panelControls_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (loginControl.Visible == false)
            {
                panelControls.Controls.Add(settingsControl);
                settingsControl.Dock = DockStyle.Fill;
                if (settingsControl.Visible == false)
                {
                    panelControls.Controls.Add(loginControl);
                    loginControl.Dock = DockStyle.Fill;
                }
            }
        }
    }
}
