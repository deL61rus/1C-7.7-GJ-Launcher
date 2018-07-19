using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;



namespace _1C_7._7_GJ_Launcher
{
    public partial class SettingsControl : UserControl
    {
        public string PathExeFile;
        public string PathDB;
        public string RegTree1CLauncher = @"SOFTWARE\1cGJLauncher";

        public SettingsControl()
        {
            InitializeComponent();
        }

        private void btnOKSetting_Click(object sender, EventArgs e) //нажатие OK
        {
            //настройки пути к 1cv7.exe           
            Properties.Settings.Default.exePath = PathExeFile;

            #region настройка пути к базе 1С

            if (!string.IsNullOrEmpty(tbDBPath.Text))
            {
                PathDB = tbDBPath.Text;
                Properties.Settings.Default.basePath = PathDB;
                btnOKSetting.Focus();
            }
            else
            {
                MessageBox.Show("Ты че дебил? Не указан путь к базе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Properties.Settings.Default.basePath = PathDB;
            #endregion

            Properties.Settings.Default.Save();
            tbDBPath.ReadOnly = true;
            this.Visible = false;
        }

        private void btnCANCELSetting_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        #region выбор файла запуска 1с
        private void Choise1cEXEFile()
        {
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
            openFileDialog.Filter = "1cv7.exe | *.exe";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog.FileName.Contains("1cv7.exe") || openFileDialog.FileName.Contains("1cv7s.exe"))
                {
                    PathExeFile = openFileDialog.FileName;
                    tbEXEPath.Text = PathExeFile;
                }
            }
            btnEditexePath.Focus();
        }
        #endregion

        #region выбор пути к базе 1с
        private void ChoiseDBPath()
        {
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                PathDB = folderDialog.SelectedPath;
                tbDBPath.Text = PathDB;
            }
            btnOKSetting.Focus();
        }

        #endregion

        private void btnEditexePath_Click(object sender, EventArgs e)
        {
            Choise1cEXEFile();
        }
              
        private void btnEditBasePath_Click(object sender, EventArgs e)
        {
            ChoiseDBPath();
        }

        private void btnHandEditBasePath_Click(object sender, EventArgs e)
        {
            tbDBPath.ReadOnly = false;
        }

    }
}
