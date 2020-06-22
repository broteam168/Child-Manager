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
    public partial class ClearLog_form : Form
    {
        Options_Form_Controller.ClearLog_Controller Cls;
        Options_Form_Controller.Empty_Recyclebin Emre;
        public ClearLog_form()
        {
            InitializeComponent();
            Cls = new Options_Form_Controller.ClearLog_Controller();
            Emre = new Options_Form_Controller.Empty_Recyclebin();
            
        }
        

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           Cls.clearText_Keystrokes();
           Cls.clearlog_Clipboard();
            Cls.clearlog_LogApp();
            Cls.clearlog_LogWeb();
            Cls.clear_LogScreen();
            Cls.clear_LogWebCam(); 
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                Cls.clearText_Keystrokes();
            }
            catch(Exception)
            {
            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            try
            {
                Cls.clearlog_LogWeb();
            }
            catch
            {
            }
            }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            try
            {
                Cls.clearlog_LogApp();
            }
            catch
            {
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                Cls.clearlog_Clipboard();
            }
            catch
            {
            }
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            try
            {
                Cls.clear_LogScreen();
            }
            catch
            {
            }
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            try
            {
                Cls.clear_LogWebCam();
            }
            catch
            {
            }
        }

        private void ClearLog_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Emre.emptyRecycleBin();
            }
            catch
            {
            }
        }
    }
}
