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
    public partial class Password_setting_First : Form
    {
       
        public Password_setting_First()
        {
            InitializeComponent();
        }
        
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DoAn_QLCC.Properties.Settings.Default.first_check_use_pass  = false;
            DoAn_QLCC.Properties.Settings.Default.Stop = true;
            DoAn_QLCC.Properties.Settings.Default.Save();
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (textBox_pass.Text == "" || textBox_confirm.Text == "")
            {
                if (textBox_pass.Text == "" && textBox_confirm.Text == "")
                {
                    MessageBox.Show("Please fill Password and Confirm Password", "Message");
                }
                else
                {
                    if (textBox_pass.Text == "")
                    {
                        MessageBox.Show("Please fill Password", "Message");
                    }
                    else
                    {
                        MessageBox.Show("Please fill Confirm password", "Message");
                    }
                }
            }
            else 
            {
                if (textBox_pass.Text != textBox_confirm.Text)
                {
                    MessageBox.Show("The password is not coincident with password confirm", "Message");
                }
                else
                {
                    try
                    {
                        DoAn_QLCC.Properties.Settings.Default.Security_pass = textBox_pass.Text;
                        DoAn_QLCC.Properties.Settings.Default.first_check_use_pass = true;
                        DoAn_QLCC.Properties.Settings.Default.Stop = true;
                        DoAn_QLCC.Properties.Settings.Default.Save();
                        this.Close();
                    }
                    catch 
                    {
                        MessageBox.Show("A error is occured", "Error");
                    }
                }
            }

        }

        private void Password_setting_First_FormClosing(object sender, FormClosingEventArgs e)
        {
             DoAn_QLCC.Properties.Settings.Default.Stop = true;
            DoAn_QLCC.Properties.Settings.Default.Save();
       
         
        }

        
    }
}
