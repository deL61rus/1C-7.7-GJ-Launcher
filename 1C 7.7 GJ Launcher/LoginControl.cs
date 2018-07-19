using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1C_7._7_GJ_Launcher
{
    public partial class LoginControl : UserControl
    {
        private static LoginControl _instance;
        public static LoginControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LoginControl();
                return _instance;
            }
        }       
        
        public LoginControl()
        {
            InitializeComponent();
        }
       
    }
}
