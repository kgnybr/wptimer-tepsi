using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading;

namespace wptimer
{
    
    class BrowserControl
    {
        //Browserların ve browserlarda whatsapp webin açılmasını sağlayan methodlar.
        public void OOpera()
        {
            string userName = Environment.UserName;
            
            Process.Start($"C:\\Users\\{userName}\\AppData\\Local\\Programs\\Opera\\launcher.exe");
            Thread.Sleep(1000);
            SendKeys.Send("^" + "t");
            SendKeys.Send("http://web.whatsapp.com");
            SendKeys.Send("{ENTER}");
            
        }
        public void OChrome()
        {
            
            Process.Start("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe");
            Thread.Sleep(1000);
            SendKeys.Send("^" + "t");
            SendKeys.Send("http://web.whatsapp.com");
            SendKeys.Send("{ENTER}");
            

        }
        public void OFirefox()
        {
            Process.Start("C:\\Program Files\\Mozilla Firefox\\firefox.exe");
            Thread.Sleep(1500);
            SendKeys.Send("^" + "t");
            SendKeys.Send("http://web.whatsapp.com");
            SendKeys.Send("{ENTER}");
        }
        public void OGX()
        {
            string userName = Environment.UserName;
            Process.Start($"C:\\Users\\{userName}\\AppData\\Local\\Programs\\Opera GX\\launcher.exe");
            Thread.Sleep(1500);
            SendKeys.Send("^" + "t");
            SendKeys.Send("http://web.whatsapp.com");
            SendKeys.Send("{ENTER}");
        }
    }
}
