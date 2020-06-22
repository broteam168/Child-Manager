using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

namespace DoAn_QLCC
{
    public partial class Options_view : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Options_view()
        {
            InitializeComponent();
        }
        private void loadForm(XtraForm frm)
        {
            try
            {
                foreach (XtraForm f in MdiChildren)
                {
                    if (f.Name == frm.Name)
                    {
                        f.Activate();
                        return;
                    }
                }
                frm.MdiParent = this;
                frm.Show();

            }
            catch (Exception EX)
            {
                MessageBox.Show("Error" + EX.ToString(),"Message");
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Log_Options frm = new Log_Options();
            loadForm(frm);
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            Options_general frm = new Options_general();
            loadForm(frm);
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void barButtonItem3_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            Control_monitoring frm = new Control_monitoring();
            loadForm(frm);
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Security_general frm = new Security_general();
            loadForm(frm);
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            Clipboard_monitoring frm = new Clipboard_monitoring();
            loadForm(frm);
        }
    }
}