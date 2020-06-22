using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QLCC
{
    public partial class WebCam_log : DevExpress.XtraEditors.XtraForm
    {
        public WebCam_log()
        {
            InitializeComponent();
        }

        private void WebCam_log_Load(object sender, EventArgs e)
        {
            try
            {
                string dire = System.IO.Directory.GetCurrentDirectory();
                DirectoryInfo dir = new DirectoryInfo(dire);
                FileInfo[] files2 = dir.GetFiles("*.png");
                string[] array2 = new string[files2.Length];
                for (int i = 0; i < files2.Length; i++)
                {
                    array2[i] = Path.GetFullPath(files2[i].Name);
                }
                List<Informations> lst = new List<Informations>();
                foreach (var item in array2)
                {
                    string name = Path.GetFileName(item);
                    string[] it1 = name.Split('°');
                    if (it1[4] == "webCam")
                    {
                        string applica = it1[3] + ".exe";
                        lst.Add(new Informations(it1[0], it1[1], it1[2], applica, item));
                    }
                }
                gridControl1.DataSource = lst;
                chophep = true;
            }
            catch (Exception)
            {
                MessageBox.Show("no data"); chophep = false;

            }
        }
        public void adddats(string date2)
        {
            try
            {
                string dire = System.IO.Directory.GetCurrentDirectory();
                DirectoryInfo dir = new DirectoryInfo(dire);
                FileInfo[] files2 = dir.GetFiles("*.png");
                string[] array2 = new string[files2.Length];
                for (int i = 0; i < files2.Length; i++)
                {
                    array2[i] = Path.GetFullPath(files2[i].Name);
                }
                List<Informations> lst = new List<Informations>();
                foreach (var item in array2)
                {
                    string name = Path.GetFileName(item);
                    string[] it1 = name.Split('°');
                    string applica = it1[3] + ".exe";
                    if (it1[4] == "webCam")
                    {
                        if (it1[0] == date2)
                        {
                            lst.Add(new Informations(it1[0], it1[1], it1[2], applica, item));
                        }
                    }
                }
                gridControl1.DataSource = lst;
                chophep = false;
            }
            catch (Exception)
            {
                MessageBox.Show("no data"); chophep = false;
            }
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked == false)
            {
                adddats(DateTime.Now.Date.ToLongDateString());
            }
            else
            {
                string dire = System.IO.Directory.GetCurrentDirectory();
                DirectoryInfo dir = new DirectoryInfo(dire);
                FileInfo[] files2 = dir.GetFiles("*.png");
                string[] array2 = new string[files2.Length];
                for (int i = 0; i < files2.Length; i++)
                {
                    array2[i] = Path.GetFullPath(files2[i].Name);
                }
                List<Informations> lst = new List<Informations>();
                foreach (var item in array2)
                {
                    string name = Path.GetFileName(item);
                    string[] it1 = name.Split('°');
                    if (it1[4] == "webCam")
                    {
                        string applica = it1[3] + ".exe";
                        lst.Add(new Informations(it1[0], it1[1], it1[2], applica, item));
                    }
                }
                gridControl1.DataSource = lst;
                chophep = false;
            }
        }
        private bool chophep = false;

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (chophep == true)
            {
                string dd = gridView1.GetFocusedRowCellValue("DuongDan").ToString();
                image_view imf = new image_view();
                Image img = Image.FromFile(dd);
                imf.Text = "IMAGE Web Cam :))";
                imf.Size = img.Size;
                imf.StartPosition = FormStartPosition.CenterScreen;
                imf.BackgroundImage = img;
                imf.ShowDialog();


            }
            else
            {
                chophep = true;
            }
        }
    }
    public class Informations
    {
        public Informations(string Date, string time, string user, string program, string DuongDan)
        {
            _date = Date;
            _time = time;
            _user = user;
            _program = program;
            _DuongDan = DuongDan;
        }
        public string _date;
        public string Date
        {
            get { return _date; }
            set { _date = value; }
        }
        public string _time;
        public string time
        {
            get { return _time; }
            set { _time = value; }
        }
        private string _user;
        public string User
        {
            get { return _user; }
            set { _user = value; }
        }
        public string _program;
        public string program
        {
            get { return _program; }
            set { _program = value; }
        }
        public string _DuongDan;
        public string DuongDan
        {
            get { return _DuongDan; }
            set { _DuongDan = value; }
        }


    }
}
