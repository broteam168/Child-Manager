using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QLCC.Options_Form_Controller
{
    class Check_HotKey_form_controller
    {
        public bool check_hotkey_form(string str)
        {
            try 
            {
                string [] sparr= str.Split('+');
          foreach (var item2 in sparr)
	{
              
		 if(check_hotkey(item2)!=true)
         {
             return false;
         }
	}
            }
            catch { return false; }
        return true;
        }
        private bool check_hotkey(string key)
        {
            string[] keys = { "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "A", "S", "D", "F", "G", "H", "J", "K", "L", "Z", "X", "C", "V", "B", "N", "M", "Shift","Control","Tab","CapsLock" ,"Alt","fn"};
            foreach (var item in keys)
            {
                if (item == key)
                {
                    return true;
                }
                }
            return false;
        }
    }
}
