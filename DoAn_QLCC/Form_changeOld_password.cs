using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QLCC
{
    public partial class Form_changeOld_password : Form
    {
        public Form_changeOld_password()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (textBox_newPass.Text == "" || textBox_oldPass.Text == "" || textBox_Pass_confirm.Text == "")
            {
                if (textBox_Pass_confirm.Text == "" && textBox_oldPass.Text == "" && textBox_oldPass.Text == "" && textBox_newPass.Text == "")
                {
                    MessageBox.Show("Please fill information", "Message");
                }
                else
                {
                    if (textBox_newPass.Text == "" && textBox_oldPass.Text == "")
                    {
                        MessageBox.Show("Please enter new password and old password", "Message");
                    }
                    else
                    {
                        if (textBox_oldPass.Text == "" && textBox_Pass_confirm.Text == "")
                        {
                            MessageBox.Show("Please enter old password and password confirm", "Message");
                        }
                        else
                        {
                            if (textBox_newPass.Text == "" && textBox_Pass_confirm.Text == "")
                            {
                                MessageBox.Show("Please enter new password and password confirm", "Message");
                            }
                            else
                            {
                                if (textBox_newPass.Text == "")
                                {
                                    MessageBox.Show("Please enter new password", "Message");
                                }
                                else if (textBox_oldPass.Text == "")
                                {
                                    MessageBox.Show("Please enter old password", "Message");
                                }
                                else if (textBox_Pass_confirm.Text == "")
                                {
                                    MessageBox.Show("Please enter confirm password", "Message");
                                }
                            }
                        }
                    }
                }
            }
            else 
            {
                if (DoAn_QLCC.Properties.Settings.Default.Security_pass == textBox_oldPass.Text)
                {
                    if (textBox_newPass.Text == textBox_Pass_confirm.Text)
                    {
                        DoAn_QLCC.Properties.Settings.Default.Security_pass = textBox_newPass.Text;
                        DoAn_QLCC.Properties.Settings.Default.Save();
                        MessageBox.Show("The password is saved","Information");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("PLease enter the confirm passwor correct", "Message");
                    }
                }
                else 
                {
                    MessageBox.Show("The old password is incorrect.Please enter again");
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
