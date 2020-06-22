namespace DoAn_QLCC
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.hiddenModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Timer_clpboard = new System.Windows.Forms.Timer(this.components);
            this.Timer_ScreenShoot = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Timer_Webcam = new System.Windows.Forms.Timer(this.components);
            this.videoSourcePlayer = new AForge.Controls.VideoSourcePlayer();
            this.devicesCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Timer_Record = new System.Windows.Forms.Timer(this.components);
            this.timer_Check_Cancle = new System.Windows.Forms.Timer(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.puchareisBuildingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homePageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.registerProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Program";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewLogToolStripMenuItem,
            this.toolStripMenuItem1,
            this.hiddenModeToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.puchareisBuildingToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.homePageToolStripMenuItem,
            this.toolStripMenuItem3,
            this.registerProgramToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.toolStripMenuItem4,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(191, 248);
            // 
            // viewLogToolStripMenuItem
            // 
            this.viewLogToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewLogToolStripMenuItem.Image")));
            this.viewLogToolStripMenuItem.Name = "viewLogToolStripMenuItem";
            this.viewLogToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.viewLogToolStripMenuItem.Text = "View Log...";
            this.viewLogToolStripMenuItem.Click += new System.EventHandler(this.viewLogToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(187, 6);
            // 
            // hiddenModeToolStripMenuItem
            // 
            this.hiddenModeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hiddenModeToolStripMenuItem.Image")));
            this.hiddenModeToolStripMenuItem.Name = "hiddenModeToolStripMenuItem";
            this.hiddenModeToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.hiddenModeToolStripMenuItem.Text = "Hidden Mode...";
            this.hiddenModeToolStripMenuItem.Click += new System.EventHandler(this.hiddenModeToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("optionsToolStripMenuItem.Image")));
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // Timer_clpboard
            // 
            this.Timer_clpboard.Enabled = true;
            this.Timer_clpboard.Interval = 1000;
            this.Timer_clpboard.Tick += new System.EventHandler(this.Timer_clpboard_Tick);
            // 
            // Timer_ScreenShoot
            // 
            this.Timer_ScreenShoot.Interval = 1000;
            this.Timer_ScreenShoot.Tick += new System.EventHandler(this.Timer_ScreenShoot_Tick);
            // 
            // Timer_Webcam
            // 
            this.Timer_Webcam.Interval = 1000;
            this.Timer_Webcam.Tick += new System.EventHandler(this.Timer_Webcam_Tick);
            // 
            // videoSourcePlayer
            // 
            this.videoSourcePlayer.Location = new System.Drawing.Point(-2, -1);
            this.videoSourcePlayer.Name = "videoSourcePlayer";
            this.videoSourcePlayer.Size = new System.Drawing.Size(289, 231);
            this.videoSourcePlayer.TabIndex = 1;
            this.videoSourcePlayer.Text = "videoSourcePlayer1";
            this.videoSourcePlayer.VideoSource = null;
            // 
            // devicesCombo
            // 
            this.devicesCombo.FormattingEnabled = true;
            this.devicesCombo.Location = new System.Drawing.Point(74, 236);
            this.devicesCombo.Name = "devicesCombo";
            this.devicesCombo.Size = new System.Drawing.Size(121, 21);
            this.devicesCombo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(455, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // Timer_Record
            // 
            this.Timer_Record.Interval = 1000;
            this.Timer_Record.Tick += new System.EventHandler(this.Timer_Record_Tick);
            // 
            // timer_Check_Cancle
            // 
            this.timer_Check_Cancle.Interval = 1000;
            this.timer_Check_Cancle.Tick += new System.EventHandler(this.timer_Check_Cancle_Tick);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(187, 6);
            // 
            // puchareisBuildingToolStripMenuItem
            // 
            this.puchareisBuildingToolStripMenuItem.Name = "puchareisBuildingToolStripMenuItem";
            this.puchareisBuildingToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.puchareisBuildingToolStripMenuItem.Text = "Puchase...(is building)";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // homePageToolStripMenuItem
            // 
            this.homePageToolStripMenuItem.Name = "homePageToolStripMenuItem";
            this.homePageToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.homePageToolStripMenuItem.Text = "HomePage";
            this.homePageToolStripMenuItem.Click += new System.EventHandler(this.homePageToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(187, 6);
            // 
            // registerProgramToolStripMenuItem
            // 
            this.registerProgramToolStripMenuItem.Name = "registerProgramToolStripMenuItem";
            this.registerProgramToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.registerProgramToolStripMenuItem.Text = "Register program";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(187, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 268);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.devicesCombo);
            this.Controls.Add(this.videoSourcePlayer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewLogToolStripMenuItem;
        private System.Windows.Forms.Timer Timer_clpboard;
        private System.Windows.Forms.Timer Timer_ScreenShoot;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer Timer_Webcam;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer;
        private System.Windows.Forms.ComboBox devicesCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Timer_Record;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hiddenModeToolStripMenuItem;
        private System.Windows.Forms.Timer timer_Check_Cancle;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem puchareisBuildingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homePageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem registerProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

