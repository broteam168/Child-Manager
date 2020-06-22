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
    public partial class Web_Log : DevExpress.XtraEditors.XtraForm
    {
        public Web_Log()
        {
            InitializeComponent();
            StreamReader rd = new StreamReader("logWeb.txt");
            string text = rd.ReadToEnd();
            rd.Close();
            if (text == "" )
            {
                MessageBox.Show("No data");
                this.Close();
            }
            else
            {
                string[] textline = text.Split('‿');
                List<Informat> lst = new List<Informat>();
                foreach (var item in textline)
                {
                    if (item != "")
                    {
                        string[] stsl = item.Split('°');
                        lst.Add(new Informat(stsl[0], stsl[1], stsl[2], stsl[3], stsl[4]));

                    }

                }
                gridControl1.DataSource = lst;
                text = "";
            }
        }
        //
        public void dataadd_datew(string date)
        {
            StreamReader rd = new StreamReader("logWeb.txt");
            string text = rd.ReadToEnd();
            rd.Close();

            if (text == "" )
            {
                MessageBox.Show("No data");
                this.Close();
            }
            else
            {
                string[] textline = text.Split('‿');
                List<Informat> lst = new List<Informat>();
                foreach (var item in textline)
                {
                    if (item != "")
                    {
                        string[] stsl = item.Split('°');
                        if (stsl[0] == date)
                        {
                            lst.Add(new Informat(stsl[0], stsl[1], stsl[2], stsl[3], stsl[4]));
                        }
                    }

                }
               
                
                gridControl1.DataSource = lst;
                text = "";
            }
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
          
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                textBox1.Text = gridView1.GetFocusedRowCellValue("description").ToString();
            }
            catch (Exception)
            {
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
                StreamReader rd = new StreamReader("logWeb.txt");
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
                    List<Informat> lst = new List<Informat>();
                    foreach (var item in textline)
                    {
                        if (item != "")
                        {
                            string[] stsl = item.Split('°');
                            lst.Add(new Informat(stsl[0], stsl[1], stsl[2], stsl[3], stsl[4]));

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
    }
    public class Informat
    {
        public Informat(string Date, string time, string user, string program, string description)
        {
            _date = Date;
            _time = time;
            _user = user;
            _program = program;
            _description = description;
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
        public string _description;
        public string description
        {
            get { return _description; }
            set { _description = value; }
        }
      


    }
}
