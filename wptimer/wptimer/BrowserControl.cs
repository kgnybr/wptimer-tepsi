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
            
            Process.Start($"C:\\Users\\{userName}\\AppData\\Local\\Programs\\Opera\\launcher.exe"); //Browserın konumunu belirtir. Eğer windows kullanıcı adı daha önceden değiştirildiyse Opera çalıştırırken sorun çıkacaktır(yaşandı:))).
            Thread.Sleep(1000);//Browserin açılması için 1sn bekler
            SendKeys.Send("^" + "t");//browser açıldığında eski sekmelere müdahale etmemek için Ctrl+t tuşlarına basarak yeni sekme açar.
            SendKeys.Send("http://web.whatsapp.com"); //Adres çubuğuna whatsapp web'in adresine girer.
            SendKeys.Send("{ENTER}"); //Girilen adrese gitmek için "Enter" tuşuna basar.
            
        }
        //Diğer kodlar diğer browserlar için aynı işlemleri yapar. Hepsi için ayrı anlatmaya gerek duymuyorum.
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
