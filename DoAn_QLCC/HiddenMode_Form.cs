using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QLCC
{
    public partial class HiddenMode_Form : Form
    {
        private bool _message=true;
        public HiddenMode_Form()
        {
            InitializeComponent();
        }
        public HiddenMode_Form(bool Message): this()
        {
            _message = Message;
           }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_message == true)
            {
                DoAn_QLCC.Properties.Settings.Default.Check_Cancel_HiddenMode = true;
                DoAn_QLCC.Properties.Settings.Default.CancelorOK_Hiddenmode = true;
                DoAn_QLCC.Properties.Settings.Default.Save();
                this.Close();

            }
            else
            {
                DoAn_QLCC.Properties.Settings.Default.Check_Cancel_HiddenMode = true;
                DoAn_QLCC.Properties.Settings.Default.CancelorOK_Hiddenmode = true;
                DoAn_QLCC.Properties.Settings.Default.Save();
                this.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_message == true)
            {
                DoAn_QLCC.Properties.Settings.Default.Check_Cancel_HiddenMode = true;
                DoAn_QLCC.Properties.Settings.Default.CancelorOK_Hiddenmode = false;
                DoAn_QLCC.Properties.Settings.Default.Save();
                this.Close();
            }
            else
            {
                DoAn_QLCC.Properties.Settings.Default.Check_Cancel_HiddenMode = true;
                DoAn_QLCC.Properties.Settings.Default.CancelorOK_Hiddenmode = true;
                DoAn_QLCC.Properties.Settings.Default.Save();
                this.Close();
            }
        }

        private void HiddenMode_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            
                if (checkBox1.Checked == true)
                {
                    DoAn_QLCC.Properties.Settings.Default.CheckShowMessage_Again = false;
                    DoAn_QLCC.Properties.Settings.Default.Save();

               
            }
            
        }
    }
}
