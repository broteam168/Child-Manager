using DevExpress.XtraEditors;
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
    public partial class Log_View : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Log_View()
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
            catch (Exception)
            {

            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KeyStroke frm = new KeyStroke();
            loadForm(frm);
        }

        private void Log_View_Load(object sender, EventArgs e)
        {
            DoAn_QLCC.Properties.Settings.Default.Block_Keystroke = true;
            DoAn_QLCC.Properties.Settings.Default.Check_Cancel_HiddenMode = true;
        }

        private void Log_View_FormClosing(object sender, FormClosingEventArgs e)
        {
            DoAn_QLCC.Properties.Settings.Default.Block_Keystroke = false;
            DoAn_QLCC.Properties.Settings.Default.Check_Cancel_HiddenMode = false;

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
               }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Screen_Capture frm = new Screen_Capture();
            loadForm(frm);
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Web_Log frm = new Web_Log();
            loadForm(frm);
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program_Log frm = new Program_Log();
            loadForm(frm);
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            WebCam_log frm = new WebCam_log();
            loadForm(frm);
        }
    }
}
