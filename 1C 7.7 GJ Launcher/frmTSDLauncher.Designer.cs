namespace _1C_7._7_GJ_Launcher
{
    partial class frmTSDLauncher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTSDLauncher));
            this.btn_logoff = new System.Windows.Forms.Button();
            this.btn_start1c = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_logoff
            // 
            this.btn_logoff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_logoff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(188)))));
            this.btn_logoff.FlatAppearance.BorderSize = 0;
            this.btn_logoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logoff.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_logoff.Image = ((System.Drawing.Image)(resources.GetObject("btn_logoff.Image")));
            this.btn_logoff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logoff.Location = new System.Drawing.Point(0, 308);
            this.btn_logoff.Name = "btn_logoff";
            this.btn_logoff.Size = new System.Drawing.Size(304, 84);
            this.btn_logoff.TabIndex = 1;
            this.btn_logoff.Text = "Завершение работы";
            this.btn_logoff.UseVisualStyleBackColor = false;
            this.btn_logoff.Click += new System.EventHandler(this.btn_logoff_Click);
            // 
            // btn_start1c
            // 
            this.btn_start1c.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_start1c.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(170)))));
            this.btn_start1c.FlatAppearance.BorderSize = 0;
            this.btn_start1c.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start1c.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_start1c.Image = ((System.Drawing.Image)(resources.GetObject("btn_start1c.Image")));
            this.btn_start1c.Location = new System.Drawing.Point(0, -2);
            this.btn_start1c.Name = "btn_start1c";
            this.btn_start1c.Size = new System.Drawing.Size(304, 306);
            this.btn_start1c.TabIndex = 1;
            this.btn_start1c.Text = "Запуск 1С 7.7";
            this.btn_start1c.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_start1c.UseVisualStyleBackColor = false;
            this.btn_start1c.Click += new System.EventHandler(this.btn_start1c_Click);
            // 
            // frmTSDLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(304, 391);
            this.Controls.Add(this.btn_start1c);
            this.Controls.Add(this.btn_logoff);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTSDLauncher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1C 7.7 TSD Launcher";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTSDLauncher_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_logoff;
        private System.Windows.Forms.Button btn_start1c;
    }
}