using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCC.Options_Form_Controller
{
    class SizeLog_Controller
    {
        public string GetKeystrokeSize()
        {
            string return_Keystroke = "";
            long FunMustRe_Key = 0;
            try
            {
                string dire = System.IO.Directory.GetCurrentDirectory();
                DirectoryInfo dir = new DirectoryInfo(dire);
                FileInfo[] files = dir.GetFiles("*.txt");
                foreach (var item in files)
                {
                    if (item.ToString() == "KeyStroke.txt")
                    {
                        string filepath = Path.GetFullPath(item.Name);
                        FunMustRe_Key = new System.IO.FileInfo(filepath).Length;

                    }
                }
            }
            catch
            {
            }
            if (FunMustRe_Key < 1024)
            {
                return_Keystroke = FunMustRe_Key.ToString() + " Bytes";
            }
            else if (FunMustRe_Key >= 1024)
            {
                return_Keystroke = (FunMustRe_Key / 1024).ToString() + " Kb";
            }
            else if (FunMustRe_Key >= 1048576)
            {
                return_Keystroke = (FunMustRe_Key / 1048576).ToString() + " Mb";
            }
            return return_Keystroke;
        }
        public string size_ClipBoard()
        {
            string return_ClipBoard = "";
            long FunMustRe_Key2 = 0;
            try
            {
                string dire = System.IO.Directory.GetCurrentDirectory();
                DirectoryInfo dir = new DirectoryInfo(dire);
                FileInfo[] files = dir.GetFiles("*.txt");
                foreach (var item in files)
                {
                    if (item.ToString() == "ClipBoard.txt")
                    {
                        string filepath = Path.GetFullPath(item.Name);
                        FunMustRe_Key2 = new System.IO.FileInfo(filepath).Length;

                    }
                }
            }
            catch
            {
            }
            if (FunMustRe_Key2 < 1024)
            {
                return_ClipBoard = FunMustRe_Key2.ToString() + " Bytes";
            }
            else if (FunMustRe_Key2 >= 1024)
            {
                return_ClipBoard = (FunMustRe_Key2 / 1024).ToString() + " Kb";
            }
            else if (FunMustRe_Key2 >= 1048576)
            { 
                return_ClipBoard = (FunMustRe_Key2 / 1048576).ToString() + " Mb";
            }
            return return_ClipBoard;
        }
        public string size_LogApp()
        {
            string return_LogApp = "";
            long FunMustRe_Key2 = 0;
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
                        FunMustRe_Key2 = new System.IO.FileInfo(filepath).Length;

                    }
                }
            }
            catch
            {
            }
            if (FunMustRe_Key2 < 1024)
            {
                return_LogApp = FunMustRe_Key2.ToString() + " Bytes";
            }
            else if (FunMustRe_Key2 >= 1024)
            {
                return_LogApp = (FunMustRe_Key2 / 1024).ToString() + " Kb";
            }
            else if (FunMustRe_Key2 >= 1048576)
            {
                return_LogApp = (FunMustRe_Key2 / 1048576).ToString() + " Mb";
            }
            return return_LogApp;
        }
        public string size_LogWebBroswer()
        {
            string return_Logweb = "";
            long FunMustRe_Key2 = 0;
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
                        FunMustRe_Key2 = new System.IO.FileInfo(filepath).Length;

                    }
                }
            }
            catch
            {
            }
            if (FunMustRe_Key2 < 1024)
            {
                return_Logweb = FunMustRe_Key2.ToString() + " Bytes";
            }
            else if (FunMustRe_Key2 >= 1024)
            {
                return_Logweb = (FunMustRe_Key2 / 1024).ToString() + " Kb";
            }
            else if (FunMustRe_Key2 >= 1048576)
            {
                return_Logweb = (FunMustRe_Key2 / 1048576).ToString() + " Mb";
            }
            return return_Logweb;
        }
        public string sizeWebCam()
        {
            string return_LogWebCam = "";
            long FunMustRe_Key2 = 0;
            try
            {
                string dire = System.IO.Directory.GetCurrentDirectory();
                DirectoryInfo dir = new DirectoryInfo(dire);
                FileInfo[] files = dir.GetFiles("*.png");
                foreach (var item in files)
                {
                    string[] items = item.ToString().Split('°');
                    if (items[4]== "webCam")
                    {
                        string filepath = Path.GetFullPath(item.Name);
                        FunMustRe_Key2 += new System.IO.FileInfo(filepath).Length;

                    }
                }
            }
            catch
            {
            }
            if (FunMustRe_Key2 < 1024)
            {
                return_LogWebCam = FunMustRe_Key2.ToString() + " Bytes";
            }
            else if (FunMustRe_Key2 >= 1024)
            {
                return_LogWebCam = (FunMustRe_Key2 / 1024).ToString() + " Kb";
            }
            else if (FunMustRe_Key2 >= 1048576)
            {
                return_LogWebCam = (FunMustRe_Key2 / 1048576).ToString() + " Mb";
            }
            return return_LogWebCam;
        }
        public string sizeScreenShoot()
        {
            string return_LogWebCam = "";
            long FunMustRe_Key2 = 0;
            try
            {
                string dire = System.IO.Directory.GetCurrentDirectory();
                DirectoryInfo dir = new DirectoryInfo(dire);
                FileInfo[] files = dir.GetFiles("*.png");
                foreach (var item in files)
                {
                    string[] items = item.ToString().Split('°');
                    if (items[4] == "Screenshoot")
                    {
                        string filepath = Path.GetFullPath(item.Name);
                        FunMustRe_Key2 += new System.IO.FileInfo(filepath).Length;

                    }
                }
            }
            catch
            {
            }
            if (FunMustRe_Key2 < 1024)
            {
                return_LogWebCam = FunMustRe_Key2.ToString() + " Bytes";
            }
            else if (FunMustRe_Key2 >= 1024)
            {
                return_LogWebCam = (FunMustRe_Key2 / 1024).ToString() + " Kb";
            }
            else if (FunMustRe_Key2 >= 1048576)
            {
                return_LogWebCam = (FunMustRe_Key2 / 1048576).ToString() + " Mb";
            }
            return return_LogWebCam;
        }
    }
}
