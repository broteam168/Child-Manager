using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QLCC
{
    public partial class Log_Options : DevExpress.XtraEditors.XtraForm
    {
        Options_Form_Controller.SizeLog_Controller Cls;
        public Log_Options()
        {
            InitializeComponent();
            Cls = new Options_Form_Controller.SizeLog_Controller();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Log_View frm = new Log_View();
            frm.Show();
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            ClearLog_form frm = new ClearLog_form();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }
       
        private void Log_Options_Load(object sender, EventArgs e)
        {
            label_KeystrokeSize.Text = Cls.GetKeystrokeSize();
            Label_ClipBoard_Size.Text = Cls.size_ClipBoard();
            Label_Size_App.Text = Cls.size_LogApp();
            Label_Web_Size.Text = Cls.size_LogWebBroswer();
            label_size_WebCam.Text = Cls.sizeWebCam();
            label_Size_screenShoots.Text = Cls.sizeScreenShoot();
            simpleButton3.Text = DoAn_QLCC.Properties.Settings.Default.Simbutton3_text;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        { if (DoAn_QLCC.Properties.Settings.Default.Strop_Logging_All == false)
          {
                DoAn_QLCC.Properties.Settings.Default.Strop_Logging_All = true;
                simpleButton3.Text = "Enable logging";
                DoAn_QLCC.Properties.Settings.Default.Simbutton3_text = "Enable logging";
          }
          else
          {
                DoAn_QLCC.Properties.Settings.Default.Strop_Logging_All = false;
                simpleButton3.Text = "Stop logging";
                DoAn_QLCC.Properties.Settings.Default.Simbutton3_text = "Disble logging";
            }
            DoAn_QLCC.Properties.Settings.Default.Save();
        }

        private void Label_Web_Size_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
