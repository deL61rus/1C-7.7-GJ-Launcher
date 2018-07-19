namespace _1C_7._7_GJ_Launcher
{
    partial class SettingsControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsControl));
            this.btnEditBasePath = new System.Windows.Forms.Button();
            this.btnEditexePath = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCANCELSetting = new System.Windows.Forms.Button();
            this.btnOKSetting = new System.Windows.Forms.Button();
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tbDBPath = new System.Windows.Forms.TextBox();
            this.tbEXEPath = new System.Windows.Forms.TextBox();
            this.btnHandEditBasePath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEditBasePath
            // 
            this.btnEditBasePath.FlatAppearance.BorderSize = 0;
            this.btnEditBasePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditBasePath.Image = ((System.Drawing.Image)(resources.GetObject("btnEditBasePath.Image")));
            this.btnEditBasePath.Location = new System.Drawing.Point(161, 77);
            this.btnEditBasePath.Name = "btnEditBasePath";
            this.btnEditBasePath.Size = new System.Drawing.Size(30, 30);
            this.btnEditBasePath.TabIndex = 18;
            this.btnEditBasePath.UseVisualStyleBackColor = true;
            this.btnEditBasePath.Click += new System.EventHandler(this.btnEditBasePath_Click);
            // 
            // btnEditexePath
            // 
            this.btnEditexePath.FlatAppearance.BorderSize = 0;
            this.btnEditexePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditexePath.Image = ((System.Drawing.Image)(resources.GetObject("btnEditexePath.Image")));
            this.btnEditexePath.Location = new System.Drawing.Point(161, 11);
            this.btnEditexePath.Name = "btnEditexePath";
            this.btnEditexePath.Size = new System.Drawing.Size(30, 30);
            this.btnEditexePath.TabIndex = 19;
            this.btnEditexePath.UseVisualStyleBackColor = true;
            this.btnEditexePath.Click += new System.EventHandler(this.btnEditexePath_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(34, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Путь к базе:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(16, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Путь к exe 1C:";
            // 
            // btnCANCELSetting
            // 
            this.btnCANCELSetting.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCANCELSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCANCELSetting.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCANCELSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnCANCELSetting.Image")));
            this.btnCANCELSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCANCELSetting.Location = new System.Drawing.Point(119, 162);
            this.btnCANCELSetting.Name = "btnCANCELSetting";
            this.btnCANCELSetting.Size = new System.Drawing.Size(120, 45);
            this.btnCANCELSetting.TabIndex = 14;
            this.btnCANCELSetting.Text = "Отмена";
            this.btnCANCELSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCANCELSetting.UseVisualStyleBackColor = true;
            this.btnCANCELSetting.Click += new System.EventHandler(this.btnCANCELSetting_Click);
            // 
            // btnOKSetting
            // 
            this.btnOKSetting.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnOKSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOKSetting.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOKSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnOKSetting.Image")));
            this.btnOKSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOKSetting.Location = new System.Drawing.Point(252, 162);
            this.btnOKSetting.Name = "btnOKSetting";
            this.btnOKSetting.Size = new System.Drawing.Size(120, 45);
            this.btnOKSetting.TabIndex = 15;
            this.btnOKSetting.Text = "OK";
            this.btnOKSetting.UseVisualStyleBackColor = true;
            this.btnOKSetting.Click += new System.EventHandler(this.btnOKSetting_Click);
            // 
            // folderDialog
            // 
            this.folderDialog.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // tbDBPath
            // 
            this.tbDBPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDBPath.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDBPath.Location = new System.Drawing.Point(20, 113);
            this.tbDBPath.Name = "tbDBPath";
            this.tbDBPath.ReadOnly = true;
            this.tbDBPath.Size = new System.Drawing.Size(352, 18);
            this.tbDBPath.TabIndex = 16;
            this.tbDBPath.Text = global::_1C_7._7_GJ_Launcher.Properties.Settings.Default.basePath;
            // 
            // tbEXEPath
            // 
            this.tbEXEPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEXEPath.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEXEPath.Location = new System.Drawing.Point(20, 41);
            this.tbEXEPath.Name = "tbEXEPath";
            this.tbEXEPath.ReadOnly = true;
            this.tbEXEPath.Size = new System.Drawing.Size(352, 18);
            this.tbEXEPath.TabIndex = 17;
            this.tbEXEPath.Text = global::_1C_7._7_GJ_Launcher.Properties.Settings.Default.exePath;
            // 
            // btnHandEditBasePath
            // 
            this.btnHandEditBasePath.FlatAppearance.BorderSize = 0;
            this.btnHandEditBasePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHandEditBasePath.Image = ((System.Drawing.Image)(resources.GetObject("btnHandEditBasePath.Image")));
            this.btnHandEditBasePath.Location = new System.Drawing.Point(197, 79);
            this.btnHandEditBasePath.Name = "btnHandEditBasePath";
            this.btnHandEditBasePath.Size = new System.Drawing.Size(30, 30);
            this.btnHandEditBasePath.TabIndex = 18;
            this.btnHandEditBasePath.UseVisualStyleBackColor = true;
            this.btnHandEditBasePath.Click += new System.EventHandler(this.btnHandEditBasePath_Click);
            // 
            // SettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnHandEditBasePath);
            this.Controls.Add(this.btnEditBasePath);
            this.Controls.Add(this.btnEditexePath);
            this.Controls.Add(this.tbDBPath);
            this.Controls.Add(this.tbEXEPath);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCANCELSetting);
            this.Controls.Add(this.btnOKSetting);
            this.Name = "SettingsControl";
            this.Size = new System.Drawing.Size(389, 219);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditBasePath;
        private System.Windows.Forms.Button btnEditexePath;
        private System.Windows.Forms.TextBox tbDBPath;
        private System.Windows.Forms.TextBox tbEXEPath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCANCELSetting;
        private System.Windows.Forms.Button btnOKSetting;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnHandEditBasePath;
    }
}
