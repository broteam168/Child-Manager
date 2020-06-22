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
    public partial class Disble_password : Form
    {
        public Disble_password()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter password", "Message");
            }
            else 
            {
                if (textBox1.Text != DoAn_QLCC.Properties.Settings.Default.Security_pass)
                {
                    MessageBox.Show("Incorect password", "Message");
                }
                else 
                {
                    DoAn_QLCC.Properties.Settings.Default.Stop2 = true;

                    DoAn_QLCC.Properties.Settings.Default.OK_fun = true;
                    DoAn_QLCC.Properties.Settings.Default.Save();
                }
            }
        }

        private void Disble_password_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DoAn_QLCC.Properties.Settings.Default.Stop2 == false)
            {
                DoAn_QLCC.Properties.Settings.Default.Stop2 = true;
                DoAn_QLCC.Properties.Settings.Default.OK_fun = false;
                DoAn_QLCC.Properties.Settings.Default.Save();
            }
        }
    }
}
