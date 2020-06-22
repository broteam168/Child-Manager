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
    public partial class Program_Log : DevExpress.XtraEditors.XtraForm
    { public Program_Log()
        {
            InitializeComponent();
            StreamReader rd = new StreamReader("logApp.txt");
            string text = rd.ReadToEnd();
            rd.Close();
            if (text == "")
            {
                MessageBox.Show("No data");
                this.Close();
            }
            else
            {
                string[] textline = text.Split('‿');
                List<Informa> lst = new List<Informa>();
                foreach (var item in textline)
                {
                    if (item != "")
                    {
                        string[] stsl = item.Split('°');
                        lst.Add(new Informa(stsl[0], stsl[1], stsl[2], stsl[3], stsl[4]));

                    }

                }
                gridControl1.DataSource = lst;
                text = "";
            }
        }
        //
        public void dataadd_datew(string date)
        {
            StreamReader rd = new StreamReader("logApp.txt");
            string text = rd.ReadToEnd();
            rd.Close();

            if (text == "")
            {
                MessageBox.Show("No data");
                this.Close();
            }
            else
            {
                string[] textline = text.Split('‿');
                List<Informa> lst = new List<Informa>();
                foreach (var item in textline)
                {
                    if (item != "")
                    {
                        string[] stsl = item.Split('°');
                        if (stsl[0] == date)
                        {
                            lst.Add(new Informa(stsl[0], stsl[1], stsl[2], stsl[3], stsl[4]));
                        }
                    }

                }


                gridControl1.DataSource = lst;
                text = "";
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            dataadd_datew(monthCalendar1.SelectionStart.ToLongDateString());
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked == true)
            {
                StreamReader rd = new StreamReader("logApp.txt");
                string text = rd.ReadToEnd();
                rd.Close();
                if (text == "")
                {
                    MessageBox.Show("No data");
                    
                }
                else
                {
                    string[] textline = text.Split('‿');
                    List<Informa> lst = new List<Informa>();
                    foreach (var item in textline)
                    {
                        if (item != "")
                        {
                            string[] stsl = item.Split('°');
                            lst.Add(new Informa(stsl[0], stsl[1], stsl[2], stsl[3], stsl[4]));

                        }

                    }
                    gridControl1.DataSource = lst;
                    text = "";
                }


            }
            else
            {
                dataadd_datew(monthCalendar1.SelectionStart.ToLongDateString());
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            try
            {
                textBox1.Text = gridView1.GetFocusedRowCellValue("title").ToString();
            }
            catch (Exception)
            {
            }
        }
    }
    public class Informa
    {
        public Informa(string Date, string time, string user, string program, string title)
        {
            _date = Date;
            _time = time;
            _user = user;
            _program = program;
            _title = title;
            
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
        public string _title;
        public string title
        {
            get { return _title; }
            set { _title = value; }
        }



    }
}
