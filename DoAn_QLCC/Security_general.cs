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
    public partial class Security_general : DevExpress.XtraEditors.XtraForm
    {
        public Security_general()
        {
            InitializeComponent();
            if (DoAn_QLCC.Properties.Settings.Default.Enable_security == true)
            {
                simpleButton1.Text = "Disble....";
                simpleButton2.Enabled = true;
                checkEdit1.Enabled = true;
                checkEdit2.Enabled = true;
                checkEdit3.Enabled = true;
                checkEdit4.Enabled = true;
                checkEdit1.Checked = DoAn_QLCC.Properties.Settings.Default.Protect_hidden_mode;
                checkEdit2.Checked = DoAn_QLCC.Properties.Settings.Default.Protect_Option_viewer;
                checkEdit3.Checked = DoAn_QLCC.Properties.Settings.Default.Protect_exit;
                checkEdit4.Checked = DoAn_QLCC.Properties.Settings.Default.Protect_log_viewer;
            }
            else 
            {
                simpleButton1.Text = "Enable....";
                simpleButton2.Enabled = false;
                checkEdit1.Enabled = false;
                checkEdit2.Enabled = false;
                checkEdit3.Enabled = false;
                checkEdit4.Enabled = false;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (DoAn_QLCC.Properties.Settings.Default.Enable_security == false)
            {
                DoAn_QLCC.Properties.Settings.Default.Enable_security = false;
                DoAn_QLCC.Properties.Settings.Default.Save();
               
                if (DoAn_QLCC.Properties.Settings.Default.First_Security == true)
                {
                    
                    Password_setting_First frm = new Password_setting_First();
                    frm.StartPosition = FormStartPosition.CenterParent;
                    frm.Show();
                    timer_checkPassFirst.Start();
                    timer_checkPassFirst.Enabled = true;
                    DoAn_QLCC.Properties.Settings.Default.Enable_security = true;
                    DoAn_QLCC.Properties.Settings.Default.Save();
                    

                }
                else
                {
                    DoAn_QLCC.Properties.Settings.Default.Enable_security = true;
                    simpleButton1.Text = "Disble....";
                    simpleButton2.Enabled = true;
                    checkEdit1.Enabled = true;
                    checkEdit2.Enabled = true;
                    checkEdit3.Enabled = true;
                    checkEdit4.Enabled = true;
                    checkEdit1.Checked = DoAn_QLCC.Properties.Settings.Default.Protect_hidden_mode;
                    checkEdit2.Checked = DoAn_QLCC.Properties.Settings.Default.Protect_Option_viewer;
                    checkEdit3.Checked = DoAn_QLCC.Properties.Settings.Default.Protect_exit;
                    checkEdit4.Checked = DoAn_QLCC.Properties.Settings.Default.Protect_log_viewer; 
                }
            }
            else
            {
                Disble_password frm = new Disble_password();
                frm.StartPosition = FormStartPosition.CenterScreen;
                timer_disble_password.Start();
                timer_disble_password.Enabled = true;
                timer_disble_password.Interval = 200;
            }
            DoAn_QLCC.Properties.Settings.Default.Save();
        }
       
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Form_changeOld_password frm = new Form_changeOld_password();
            frm.Show();
        }

        private void timer_checkPassFirst_Tick(object sender, EventArgs e)
        {
            if(DoAn_QLCC.Properties.Settings.Default.Stop==true)
            {

                timer_checkPassFirst.Stop();
                timer_checkPassFirst.Enabled = false;
                if (DoAn_QLCC.Properties.Settings.Default.first_check_use_pass == true)
                { 
                    
                    simpleButton1.Text = "Disble....";
                    simpleButton2.Enabled = true;
                    checkEdit1.Enabled = true;
                    checkEdit2.Enabled = true;
                    checkEdit3.Enabled = true;
                    checkEdit4.Enabled = true;
                    checkEdit1.Checked = DoAn_QLCC.Properties.Settings.Default.Protect_hidden_mode;
                    checkEdit2.Checked = DoAn_QLCC.Properties.Settings.Default.Protect_Option_viewer;
                    checkEdit3.Checked = DoAn_QLCC.Properties.Settings.Default.Protect_exit;
                    checkEdit4.Checked = DoAn_QLCC.Properties.Settings.Default.Protect_log_viewer; 
                    DoAn_QLCC.Properties.Settings.Default.Stop = false;
                    DoAn_QLCC.Properties.Settings.Default.Save();
          
                }
                else
                {
                    simpleButton1.Text = "Enable....";
                    simpleButton2.Enabled = false;
                    checkEdit1.Enabled = false;
                    checkEdit2.Enabled = false;
                    checkEdit3.Enabled = false;
                    checkEdit4.Enabled = false;
                    DoAn_QLCC.Properties.Settings.Default.Stop = false;
                    DoAn_QLCC.Properties.Settings.Default.Save();
                }
        }}

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked == false)
            {
                DoAn_QLCC.Properties.Settings.Default.Protect_hidden_mode = false;

            }
            else 
            {
                DoAn_QLCC.Properties.Settings.Default.Protect_hidden_mode = true;
            }
            DoAn_QLCC.Properties.Settings.Default.Save();
        }

        private void checkEdit3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit3.Checked == false)
            {
                DoAn_QLCC.Properties.Settings.Default.Protect_exit = false;

            }
            else
            {
                DoAn_QLCC.Properties.Settings.Default.Protect_exit = true;
            }
            DoAn_QLCC.Properties.Settings.Default.Save();
        }

        private void checkEdit2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit2.Checked == false)
            {
                DoAn_QLCC.Properties.Settings.Default.Protect_Option_viewer = false;

            }
            else
            {
                DoAn_QLCC.Properties.Settings.Default.Protect_Option_viewer = true;
            }
            DoAn_QLCC.Properties.Settings.Default.Save();
           
        }

        private void checkEdit4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit3.Checked == false)
            {
                DoAn_QLCC.Properties.Settings.Default.Protect_log_viewer = false;

            }
            else
            {
                DoAn_QLCC.Properties.Settings.Default.Protect_log_viewer = true;
            }
            DoAn_QLCC.Properties.Settings.Default.Save();
        }

        private void timer_disble_password_Tick(object sender, EventArgs e)
        {
            if (DoAn_QLCC.Properties.Settings.Default.Stop2 == true)
            {
                DoAn_QLCC.Properties.Settings.Default.Stop2 = false;
                DoAn_QLCC.Properties.Settings.Default.Save();
                timer_disble_password.Stop();
                timer_disble_password.Enabled = false;
                if (DoAn_QLCC.Properties.Settings.Default.OK_fun == true)
                {

                    DoAn_QLCC.Properties.Settings.Default.Enable_security = false;
                    simpleButton1.Text = "Enable....";
                    simpleButton2.Enabled = false;
                    checkEdit1.Enabled = false;
                    checkEdit2.Enabled = false;
                    checkEdit3.Enabled = false;
                    checkEdit4.Enabled = false;
                    DoAn_QLCC.Properties.Settings.Default.First_Security = true;
                  
                    DoAn_QLCC.Properties.Settings.Default.Security_pass = "";
                    DoAn_QLCC.Properties.Settings.Default.Save();
                }
            }
        }

    }
}
