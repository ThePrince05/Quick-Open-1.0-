namespace Quick_Open__1._0_
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel_main = new System.Windows.Forms.Panel();
            this.btn_close = new FontAwesome.Sharp.IconPictureBox();
            this.panel_border = new System.Windows.Forms.Panel();
            this.lbl_startUp = new System.Windows.Forms.Label();
            this.txt_directory = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_quickOpen = new System.Windows.Forms.Label();
            this.lbl_main = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            this.panel_border.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(231)))), ((int)(((byte)(240)))));
            this.panel_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_main.Controls.Add(this.btn_close);
            this.panel_main.Controls.Add(this.panel_border);
            this.panel_main.Controls.Add(this.txt_directory);
            this.panel_main.Controls.Add(this.btn_save);
            this.panel_main.Controls.Add(this.lbl_quickOpen);
            this.panel_main.Controls.Add(this.lbl_main);
            this.panel_main.Location = new System.Drawing.Point(3, 3);
            this.panel_main.Margin = new System.Windows.Forms.Padding(0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(635, 235);
            this.panel_main.TabIndex = 1;
            this.panel_main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_main_MouseDown);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(231)))), ((int)(((byte)(240)))));
            this.btn_close.ForeColor = System.Drawing.Color.Black;
            this.btn_close.IconChar = FontAwesome.Sharp.IconChar.CircleXmark;
            this.btn_close.IconColor = System.Drawing.Color.Black;
            this.btn_close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_close.IconSize = 49;
            this.btn_close.Location = new System.Drawing.Point(581, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btn_close.Size = new System.Drawing.Size(49, 50);
            this.btn_close.TabIndex = 6;
            this.btn_close.TabStop = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            this.btn_close.MouseLeave += new System.EventHandler(this.btn_close_MouseLeave);
            this.btn_close.MouseHover += new System.EventHandler(this.btn_close_MouseHover);
            // 
            // panel_border
            // 
            this.panel_border.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_border.Controls.Add(this.lbl_startUp);
            this.panel_border.Location = new System.Drawing.Point(542, 169);
            this.panel_border.Name = "panel_border";
            this.panel_border.Size = new System.Drawing.Size(83, 46);
            this.panel_border.TabIndex = 5;
            // 
            // lbl_startUp
            // 
            this.lbl_startUp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_startUp.AutoSize = true;
            this.lbl_startUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_startUp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.lbl_startUp.Location = new System.Drawing.Point(4, 4);
            this.lbl_startUp.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_startUp.Name = "lbl_startUp";
            this.lbl_startUp.Size = new System.Drawing.Size(73, 36);
            this.lbl_startUp.TabIndex = 4;
            this.lbl_startUp.Text = "Start-up \r\nSettings\r\n";
            this.lbl_startUp.Click += new System.EventHandler(this.lbl_startUp_Click);
            this.lbl_startUp.MouseLeave += new System.EventHandler(this.lbl_startUp_MouseLeave);
            this.lbl_startUp.MouseHover += new System.EventHandler(this.lbl_startUp_MouseHover);
            // 
            // txt_directory
            // 
            this.txt_directory.BackColor = System.Drawing.Color.White;
            this.txt_directory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_directory.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.txt_directory.Location = new System.Drawing.Point(84, 90);
            this.txt_directory.Name = "txt_directory";
            this.txt_directory.ReadOnly = true;
            this.txt_directory.Size = new System.Drawing.Size(469, 34);
            this.txt_directory.TabIndex = 3;
            this.txt_directory.Click += new System.EventHandler(this.txt_directory_Click);
            this.txt_directory.TextChanged += new System.EventHandler(this.txt_directory_TextChanged);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_save.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.btn_save.Location = new System.Drawing.Point(233, 141);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(163, 41);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_quickOpen
            // 
            this.lbl_quickOpen.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quickOpen.Location = new System.Drawing.Point(6, 5);
            this.lbl_quickOpen.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_quickOpen.Name = "lbl_quickOpen";
            this.lbl_quickOpen.Size = new System.Drawing.Size(97, 21);
            this.lbl_quickOpen.TabIndex = 1;
            this.lbl_quickOpen.Text = "Quick Open";
            this.lbl_quickOpen.Click += new System.EventHandler(this.lbl_quickOpen_Click);
            this.lbl_quickOpen.MouseLeave += new System.EventHandler(this.lbl_quickOpen_MouseLeave);
            this.lbl_quickOpen.MouseHover += new System.EventHandler(this.lbl_quickOpen_MouseHover);
            // 
            // lbl_main
            // 
            this.lbl_main.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Underline);
            this.lbl_main.Location = new System.Drawing.Point(75, 55);
            this.lbl_main.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_main.Name = "lbl_main";
            this.lbl_main.Size = new System.Drawing.Size(413, 32);
            this.lbl_main.TabIndex = 0;
            this.lbl_main.Text = "Select Application Directory";
            this.lbl_main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_main_MouseDown);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Quick Open";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(640, 240);
            this.Controls.Add(this.panel_main);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quick Open";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            this.panel_border.ResumeLayout(false);
            this.panel_border.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_main;
        private FontAwesome.Sharp.IconPictureBox btn_close;
        private System.Windows.Forms.Panel panel_border;
        private System.Windows.Forms.Label lbl_startUp;
        private System.Windows.Forms.TextBox txt_directory;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_quickOpen;
        private System.Windows.Forms.Label lbl_main;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

