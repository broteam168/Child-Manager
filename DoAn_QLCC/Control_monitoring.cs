using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DoAn_QLCC
{
    public partial class Control_monitoring : DevExpress.XtraEditors.XtraForm
    {
        public Control_monitoring()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            string seclect_item = imageListBoxControl1.SelectedItem.ToString();
            if (seclect_item == "Keystroke logging")
            {
                try
                {
                    DoAn_QLCC.Properties.Settings.Default.Enable_keystroke = true;
                    MessageBox.Show("Change completed", "Message");
                }
                catch 
                {
                    MessageBox.Show("Error", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (seclect_item == "Clipboard logging")
            {
                try
                {
                    DoAn_QLCC.Properties.Settings.Default.Enable_clipboard = true; MessageBox.Show("Change completed", "Message");
                }
                catch
                {
                    MessageBox.Show("Error", "error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            if (seclect_item == "Web app logging")
            {
                try
                {
                    DoAn_QLCC.Properties.Settings.Default.Enable_LogApp = true; MessageBox.Show("Change completed", "Message");
                }
                catch 
                {
                    MessageBox.Show("Error", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
                }
            }
            if (seclect_item == "Application logging")
            {
                try 
                {
                    DoAn_QLCC.Properties.Settings.Default.Enable_LogWeb = true;
                    MessageBox.Show("Change completed", "Message");

                }
                catch
                {
                    MessageBox.Show("Error", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            if (seclect_item == "Screenshoot logging")
            {
                try
                {
                    DoAn_QLCC.Properties.Settings.Default.Enable_Screenshoot = true;
                    MessageBox.Show("Change completed", "Message");

                }
                catch
                {
                    MessageBox.Show("Error", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            if (seclect_item == "Webcam logging")
            {
                  try{
                    DoAn_QLCC.Properties.Settings.Default.Enable_Webcam = true;
                    MessageBox.Show("Change completed", "Message");

                }
                catch
                {
                    MessageBox.Show("Error", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void Control_monitoring_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string seclect_item = imageListBoxControl1.SelectedItem.ToString();
            if (seclect_item == "Keystroke logging")
            {
                try
                {
                    DoAn_QLCC.Properties.Settings.Default.Enable_keystroke = false;
                    MessageBox.Show("Change completed", "Message");
                }
                catch
                {
                    MessageBox.Show("Error", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (seclect_item == "Clipboard logging")
            {
                try
                {
                    DoAn_QLCC.Properties.Settings.Default.Enable_clipboard = false; MessageBox.Show("Change completed", "Message");
                }
                catch
                {
                    MessageBox.Show("Error", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (seclect_item == "Web app logging")
            {
                try
                {
                    DoAn_QLCC.Properties.Settings.Default.Enable_LogApp = false; MessageBox.Show("Change completed", "Message");
                }
                catch
                {
                    MessageBox.Show("Error", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            if (seclect_item == "Application logging")
            {
                try
                {
                    DoAn_QLCC.Properties.Settings.Default.Enable_LogWeb = false;
                    MessageBox.Show("Change completed", "Message");

                }
                catch
                {
                    MessageBox.Show("Error", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            if (seclect_item == "Screenshoot logging")
            {
                try
                {
                    DoAn_QLCC.Properties.Settings.Default.Enable_Screenshoot = false;
                    MessageBox.Show("Change completed", "Message");

                }
                catch
                {
                    MessageBox.Show("Error", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            if (seclect_item == "Webcam logging")
            {
                try
                {
                    DoAn_QLCC.Properties.Settings.Default.Enable_Webcam = false;
                    MessageBox.Show("Change completed", "Message");

                }
                catch
                {
                    MessageBox.Show("Error", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                DoAn_QLCC.Properties.Settings.Default.Save();
                MessageBox.Show("Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Error", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            
            }
        }

    }
}