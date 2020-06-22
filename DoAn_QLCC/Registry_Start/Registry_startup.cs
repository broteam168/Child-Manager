using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QLCC
{
    class Registry_startup
    {
        RegistryKey registryKey = Registry.CurrentUser.OpenSubKey
               ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
        public void RegistryStartup()
        {
            try
            {
                registryKey.SetValue("Sys", Application.ExecutablePath);
            }
            catch { }
        }
        public void DisposeRegistryStartup()
        {
            try
            {
                registryKey.DeleteValue("Sys");
            }
            catch { }
        }
    }
}
