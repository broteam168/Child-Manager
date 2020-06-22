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
using SmartHotKey;

namespace DoAn_QLCC
{
    public partial class Options_general : DevExpress.XtraEditors.XtraForm
    {
        
        public Options_general()
        {
            InitializeComponent();
      
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(textBox1, "Please fill with this form:key + key + key"); 
            checkEdit1.Checked = DoAn_QLCC.Properties.Settings.Default.State_checkbox_startup;
            checkEdit2.Checked = DoAn_QLCC.Properties.Settings.Default.State_warning_text;
            textBox2.Text = DoAn_QLCC.Properties.Settings.Default.Hot_Key;
            dateEdit1.DateTime = DateTime.Parse( DoAn_QLCC.Properties.Settings.Default.Self_destruct_date );
            textBox3.Text = System.IO.Directory.GetCurrentDirectory();
            textBox3.Enabled = false;
            if (DoAn_QLCC.Properties.Settings.Default.State_warning_text == true)
            {
                textBox1.Text = DoAn_QLCC.Properties.Settings.Default.Warning_text; textBox1.Enabled = true;
                simpleButton1.Enabled = true;
                labelControl1.Enabled = true;
            }
            else 
            {
                textBox1.Enabled = false;
                simpleButton1.Enabled = false;
                labelControl1.Enabled = false;
            }
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            Registry_startup rg = new Registry_startup();
            if (checkEdit1.Checked == true)
            {
                DoAn_QLCC.Properties.Settings.Default.State_checkbox_startup = false;
                rg.DisposeRegistryStartup();
            }
            else 
            {
                DoAn_QLCC.Properties.Settings.Default.State_checkbox_startup = true;
                rg.RegistryStartup();
            }
            DoAn_QLCC.Properties.Settings.Default.Save();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != DoAn_QLCC.Properties.Settings.Default.Warning_text)
            {
                if (textBox1.Text != "")
                {
                    try
                    {
                        DoAn_QLCC.Properties.Settings.Default.Warning_text = textBox1.Text;
                        DoAn_QLCC.Properties.Settings.Default.Save();
                        MessageBox.Show("Saved", "Message");
                    }
                    catch (Exception EX)
                    {
                        MessageBox.Show("Error:" + EX, "error");
                    }
                }
                else
                {
                    MessageBox.Show("The textbox is null.Please fill in.", "Warning");
                }
            }
            else 
            {
                MessageBox.Show("The value is saved", "Message");
            }
        }

        private void Options_general_Load(object sender, EventArgs e)
        {

        }

        private void checkEdit2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit2.Checked == false)
            {
                DoAn_QLCC.Properties.Settings.Default.State_warning_text = true;
                DoAn_QLCC.Properties.Settings.Default.Save(); textBox1.Enabled = false;
                simpleButton1.Enabled = false;
                labelControl1.Enabled = false;
            }
            else
            {
                DoAn_QLCC.Properties.Settings.Default.State_warning_text = false;
                DoAn_QLCC.Properties.Settings.Default.Save();
                textBox1.Text = DoAn_QLCC.Properties.Settings.Default.Warning_text;
                textBox1.Enabled = true;
                simpleButton1.Enabled = true;
                labelControl1.Enabled = true;
            }
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void textEdit1_MouseClick(object sender, MouseEventArgs e)
        {

        }
     
        private void textEdit1_KeyDown(object sender, KeyEventArgs e)
        {
           
            
                 
            
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {if(textBox2.Text!="")
        {
            Options_Form_Controller.Check_HotKey_form_controller check = new Options_Form_Controller.Check_HotKey_form_controller();
            if(check.check_hotkey_form(textBox2.Text))
            {try{
             DoAn_QLCC.Properties.Settings.Default.Hot_Key=textBox2.Text;
                DoAn_QLCC.Properties.Settings.Default.Save();
                MessageBox.Show("The hot key is saved","Message");
            }
                catch
            {
                    MessageBox.Show("error","Error");
                }
            }
        }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {   DateTime dt = DateTime.Now;
        if (dt.Date.ToShortDateString() == dateEdit1.DateTime.ToShortDateString())
        {
            Options_Form_Controller.ClearLog_Controller cls = new Options_Form_Controller.ClearLog_Controller();
            cls.clear_LogScreen();
            cls.clearText_Keystrokes();
            cls.clearlog_Clipboard();
            cls.clearlog_LogApp();
            cls.clearlog_LogWeb();
            cls.clear_LogWebCam();
        }
        else
        {
            try
            {
                DoAn_QLCC.Properties.Settings.Default.Self_destruct_date = dateEdit1.DateTime.ToShortDateString();
                DoAn_QLCC.Properties.Settings.Default.Save();
                MessageBox.Show("Saved", "Message");
            }
            catch { MessageBox.Show("Error", "error"); }
        }
             
        }
      
    }
}