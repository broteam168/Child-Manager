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
    public partial class KeyStroke : DevExpress.XtraEditors.XtraForm
    {
       
        public KeyStroke()
        {
            InitializeComponent();

            try
            {
                StreamReader rd = new StreamReader("KeyStroke.txt");
                string text = rd.ReadToEnd();
                rd.Close();
                StreamReader rd2 = new StreamReader("ClipBoard.txt");
                string str = rd2.ReadToEnd();

                if (text == "" & str == "")
                {
                    MessageBox.Show("No data");
                    this.Close();
                }
                else
                {
                    string[] textline = text.Split('‿');
                    string[] clipline = str.Split('‿');
                    List<Inform> lst = new List<Inform>();
                    foreach (var item in textline)
                    {
                        if (item != "")
                        {
                            string[] stsl = item.Split('°');
                            lst.Add(new Inform(stsl[0], stsl[1], stsl[2], stsl[3], stsl[4], stsl[5]));

                        }

                    }
                    foreach (var item2 in clipline)
                    {
                        if (item2 != "")
                        {
                            string[] clipsl = item2.Split('°');
                            lst.Add(new Inform(clipsl[0], clipsl[1], clipsl[2], clipsl[3], clipsl[4], clipsl[5]));
                        }
                    }
                    gridControl1.DataSource = lst;
                    text = "";
                }
            }
            catch
            {
            }
        }
        private static string[] textline2;

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked == true)
            {
                StreamReader rd = new StreamReader("KeyStroke.txt");
                string text = rd.ReadToEnd();
                rd.Close();
                StreamReader rd2 = new StreamReader("ClipBoard.txt");
                string str = rd2.ReadToEnd();

                if (text == "" & str == "")
                {
                    MessageBox.Show("No data");
                    this.Close();
                }
                else
                {
                    string[] textline2 = text.Split('‿');
                    string[] clipline = str.Split('‿');
                    List<Inform> lst = new List<Inform>();
                    foreach (var item in textline2)
                    {
                        if (item != "")
                        {
                            string[] stsl = item.Split('°');
                            lst.Add(new Inform(stsl[0], stsl[1], stsl[2], stsl[3], stsl[4], stsl[5]));

                        }

                    }
                    foreach (var item2 in clipline)
                    {
                        if (item2 != "")
                        {
                            string[] clipsl = item2.Split('°');
                            lst.Add(new Inform(clipsl[0], clipsl[1], clipsl[2], clipsl[3], clipsl[4], clipsl[5]));
                        }
                    }
                    gridControl1.DataSource = lst;
                    text = "";
                }


            }
            else
            {
                dataadd_date(monthCalendar1.SelectionStart.ToLongDateString());
            }
            
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            dataadd_date(monthCalendar1.SelectionStart.ToLongDateString());
        }
        public void dataadd_date(string date)
        {
            StreamReader rd = new StreamReader("KeyStroke.txt");
            string text = rd.ReadToEnd();
            rd.Close();
            StreamReader rd2 = new StreamReader("ClipBoard.txt");
            string str = rd2.ReadToEnd();

            if (text == "" & str == "")
            {
                MessageBox.Show("No data");
                this.Close();
            }
            else
            {
                string[] textline = text.Split('‿');
                string[] clipline = str.Split('‿');
                List<Inform> lst = new List<Inform>();
                foreach (var item in textline)
                {
                    if (item != "")
                    {
                        string[] stsl = item.Split('°');
                        if (stsl[0] == date)
                        {
                            lst.Add(new Inform(stsl[0], stsl[1], stsl[2], stsl[3], stsl[4], stsl[5]));
                        }
                    }

                }
                foreach (var item2 in clipline)
                {
                    if (item2 != "")
                    {
                        string[] clipsl = item2.Split('°');
                        if (clipsl[0] == date)
                        {
                            lst.Add(new Inform(clipsl[0], clipsl[1], clipsl[2], clipsl[3], clipsl[4], clipsl[5]));
                        }
                    }
                }
                gridControl1.DataSource = lst;
                text = "";
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                labelControl3.Text = gridView1.GetFocusedRowCellValue("kind").ToString();
                textBox1.Text = gridView1.GetFocusedRowCellValue("keystroke").ToString();
            }
            catch (Exception)
            {
                labelControl3.Text ="";
                textBox1.Text = "";
            }
            }
    }
    public class Inform
    {
        public Inform(string Date, string time, string user, string program, string keystroke, string kind)
        {
            _date = Date;
            _time = time;
            _user = user;
            _program = program;
            _keystroke = keystroke;
            _kind = kind;
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
        public string _keystroke;
        public string keystroke
        {
            get { return _keystroke; }
            set { _keystroke = value; }
        }
        public string _kind;
        public string kind
        {
            get { return _kind; }
            set { _kind = value; }
        }



    }
}
