namespace DoAn_QLCC
{
    partial class Control_monitoring
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control_monitoring));
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageListBoxControl1 = new DevExpress.XtraEditors.ImageListBoxControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageListBoxControl1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "tải xuống (1).jpg");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "obysvsdgcytugiosikwz.png");
            this.imageList1.Images.SetKeyName(1, "clipboard_paste.png");
            this.imageList1.Images.SetKeyName(2, "images (2).png");
            this.imageList1.Images.SetKeyName(3, "tải xuống (3).jpg");
            this.imageList1.Images.SetKeyName(4, "tải xuống (3).png");
            this.imageList1.Images.SetKeyName(5, "tải xuống (4).png");
            // 
            // imageListBoxControl1
            // 
            this.imageListBoxControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageListBoxControl1.Appearance.Options.UseFont = true;
            this.imageListBoxControl1.ImageList = this.imageList1;
            this.imageListBoxControl1.ItemHeight = 38;
            this.imageListBoxControl1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageListBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageListBoxItem(null, "Keystroke logging", 0),
            new DevExpress.XtraEditors.Controls.ImageListBoxItem(null, "Clipboard logging", 1),
            new DevExpress.XtraEditors.Controls.ImageListBoxItem(null, "Web app logging", 2),
            new DevExpress.XtraEditors.Controls.ImageListBoxItem(null, "Application logging", 3),
            new DevExpress.XtraEditors.Controls.ImageListBoxItem(null, "Screenshoot logging", 4),
            new DevExpress.XtraEditors.Controls.ImageListBoxItem(null, "Webcam logging", 5)});
            this.imageListBoxControl1.Location = new System.Drawing.Point(85, 20);
            this.imageListBoxControl1.Name = "imageListBoxControl1";
            this.imageListBoxControl1.Size = new System.Drawing.Size(447, 309);
            this.imageListBoxControl1.TabIndex = 1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(620, 151);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(173, 52);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Disble";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(620, 54);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(173, 52);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "Enable";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(-1, -1);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(877, 31);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Control";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.simpleButton3);
            this.panel1.Controls.Add(this.imageListBoxControl1);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Location = new System.Drawing.Point(-1, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 442);
            this.panel1.TabIndex = 5;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(620, 255);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(173, 52);
            this.simpleButton3.TabIndex = 4;
            this.simpleButton3.Text = "Save";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // Control_monitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 474);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelControl1);
            this.Name = "Control_monitoring";
            this.Text = "Control_monitoring";
            this.Load += new System.EventHandler(this.Control_monitoring_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageListBoxControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.ImageCollection imageCollection1;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.ImageListBoxControl imageListBoxControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
    }
}