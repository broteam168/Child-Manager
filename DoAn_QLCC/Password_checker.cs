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
    public partial class Password_checker : Form
    {
        private string _message;
        public Password_checker()
        {
            InitializeComponent();
        }
        public Password_checker(string Message) : this()
        {
            _message = Message;
       }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter login information", "Message");
            }
            else 
            {
                if (textBox1.Text == DoAn_QLCC.Properties.Settings.Default.Security_pass)
                {
                    if (_message == "logview")
                    {
                        Log_View frm = new Log_View();
                        frm.Show();
                    }
                    if (_message == "hiddenmode")
                    {
                        HiddenMode_Form frm = new HiddenMode_Form();
                        frm.Show();
                    }
                    if (_message == "optionview")
                    {
                        Options_view frm = new Options_view();
                        frm.Show();
                    }
                    if (_message == "exit")
                    {
                        try
                        {
                            Environment.Exit(1);
                        }
                        catch { Application.Exit(); }
                    }
                    this.Close();   
                }
                else 
                {
                    MessageBox.Show("Incorrect password", "Message");
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Password_checker_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
