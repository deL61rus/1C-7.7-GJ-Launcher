namespace _1C_7._7_GJ_Launcher
{
    partial class LoginControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginControl));
            this.lblPathDB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbExclusiveMode = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbUser1c = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart1c = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPathDB
            // 
            this.lblPathDB.AutoSize = true;
            this.lblPathDB.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::_1C_7._7_GJ_Launcher.Properties.Settings.Default, "basePath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblPathDB.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPathDB.Location = new System.Drawing.Point(171, 12);
            this.lblPathDB.Name = "lblPathDB";
            this.lblPathDB.Size = new System.Drawing.Size(85, 22);
            this.lblPathDB.TabIndex = 16;
            this.lblPathDB.Text = global::_1C_7._7_GJ_Launcher.Properties.Settings.Default.basePath;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(44, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 10, 3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Путь к базе:";
            // 
            // cbExclusiveMode
            // 
            this.cbExclusiveMode.AutoSize = true;
            this.cbExclusiveMode.Checked = global::_1C_7._7_GJ_Launcher.Properties.Settings.Default.ExclusiveMode;
            this.cbExclusiveMode.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::_1C_7._7_GJ_Launcher.Properties.Settings.Default, "ExclusiveMode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbExclusiveMode.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.cbExclusiveMode.FlatAppearance.BorderSize = 0;
            this.cbExclusiveMode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbExclusiveMode.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbExclusiveMode.Location = new System.Drawing.Point(18, 171);
            this.cbExclusiveMode.Name = "cbExclusiveMode";
            this.cbExclusiveMode.Size = new System.Drawing.Size(152, 27);
            this.cbExclusiveMode.TabIndex = 14;
            this.cbExclusiveMode.Text = "Монопольно";
            this.cbExclusiveMode.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(80, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Пароль:";
            // 
            // cbUser1c
            // 
            this.cbUser1c.BackColor = System.Drawing.SystemColors.Window;
            this.cbUser1c.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUser1c.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbUser1c.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbUser1c.FormattingEnabled = true;
            this.cbUser1c.Items.AddRange(new object[] {
            "ОператорККМ",
            "Кладовщик",
            "Администратор",
            "TSD"});
            this.cbUser1c.Location = new System.Drawing.Point(171, 56);
            this.cbUser1c.Name = "cbUser1c";
            this.cbUser1c.Size = new System.Drawing.Size(199, 30);
            this.cbUser1c.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 10, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Пользователь:";
            // 
            // btnStart1c
            // 
            this.btnStart1c.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnStart1c.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart1c.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart1c.Image = ((System.Drawing.Image)(resources.GetObject("btnStart1c.Image")));
            this.btnStart1c.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStart1c.Location = new System.Drawing.Point(250, 161);
            this.btnStart1c.Name = "btnStart1c";
            this.btnStart1c.Size = new System.Drawing.Size(120, 45);
            this.btnStart1c.TabIndex = 10;
            this.btnStart1c.Text = "OK";
            this.btnStart1c.UseVisualStyleBackColor = true;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.SystemColors.Window;
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPassword.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPassword.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbPassword.Location = new System.Drawing.Point(171, 103);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '•';
            this.tbPassword.Size = new System.Drawing.Size(199, 30);
            this.tbPassword.TabIndex = 9;
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPathDB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbExclusiveMode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbUser1c);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart1c);
            this.Controls.Add(this.tbPassword);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(389, 219);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPathDB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbExclusiveMode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbUser1c;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart1c;
        private System.Windows.Forms.TextBox tbPassword;
    }
}
