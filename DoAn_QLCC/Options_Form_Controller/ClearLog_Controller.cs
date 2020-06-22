using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QLCC.Options_Form_Controller
{
    class ClearLog_Controller
    {
        public void clearText_Keystrokes()
        {
            try
            {
                string dire = System.IO.Directory.GetCurrentDirectory();
                DirectoryInfo dir = new DirectoryInfo(dire);
                FileInfo[] files = dir.GetFiles("*.txt");
                foreach (var item in files)
                {

                    Console.WriteLine(item);
                    if (item.ToString() == "KeyStroke.txt")
                    {
                        Console.WriteLine(item);
                        string filepath = Path.GetFullPath(item.Name);
                        File.WriteAllText(filepath, String.Empty);
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("There is a error when delete file KeyStroke.Error:" + Ex);
            }
        }
        public void clearlog_Clipboard()
        {
            try
            {
                string dire = System.IO.Directory.GetCurrentDirectory();
                DirectoryInfo dir = new DirectoryInfo(dire);
                FileInfo[] files = dir.GetFiles("*.txt");
                foreach (var item in files)
                {

                    if (item.ToString() == "ClipBoard.txt")
                    {
                        Console.WriteLine(item);
                        string filepath = Path.GetFullPath(item.Name);
                        File.WriteAllText(filepath, String.Empty);
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("There is a error when delete file ClipBoard.Error:" + Ex);
            }
        }
        public void clearlog_LogApp()
        {
            try
            {
                string dire = System.IO.Directory.GetCurrentDirectory();
                DirectoryInfo dir = new DirectoryInfo(dire);
                FileInfo[] files = dir.GetFiles("*.txt");
                foreach (var item in files)
                {

                    if (item.ToString() == "logApp.txt")
                    {
                        
                        string filepath = Path.GetFullPath(item.Name);
                        File.WriteAllText(filepath, String.Empty);
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("There is a error when delete file LogApp.Error:" + Ex);
            }
        }
        public void clearlog_LogWeb()
        {
            try
            {
                string dire = System.IO.Directory.GetCurrentDirectory();
                DirectoryInfo dir = new DirectoryInfo(dire);
                FileInfo[] files = dir.GetFiles("*.txt");
                foreach (var item in files)
                {

                    if (item.ToString() == "logWeb.txt")
                    {
                        
                        string filepath = Path.GetFullPath(item.Name);
                        File.WriteAllText(filepath, String.Empty);
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("There is a error when delete file logWeb.Error:" + Ex);
            }
        }
        public void clear_LogScreen()
        {
            try
            {
                string dire = System.IO.Directory.GetCurrentDirectory();
                DirectoryInfo dir = new DirectoryInfo(dire);
                FileInfo[] files = dir.GetFiles("*.png");
                foreach (var item in files)
                {
                    string[] it1 = item.ToString().Split('°');
                    if (it1[4] == "Screenshoot")
                    {
                        string filepath = Path.GetFullPath(item.Name);
                        File.Delete(filepath);
                    }
                }
            }
            catch (Exception Ex)
            {
            }
        }
        public void clear_LogWebCam()
        {
            try
            {
                string dire = System.IO.Directory.GetCurrentDirectory();
                DirectoryInfo dir = new DirectoryInfo(dire);
                FileInfo[] files = dir.GetFiles("*.png");
                foreach (var item in files)
                {
                    string[] it1 = item.ToString().Split('°');
                    if (it1[4] == "webCam")
                    {
                        string filepath = Path.GetFullPath(item.Name);
                        File.Delete(filepath);

                    }
                }
            }
            catch (Exception Ex)
            {
            }
        }
    }
}
