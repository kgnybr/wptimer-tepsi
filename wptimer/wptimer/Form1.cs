using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.OleDb;

namespace wptimer
{
    public partial class Form1 : Form

    {
        public Form1()
        {
            InitializeComponent();

        }
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        BrowserControl browserControl = new BrowserControl();
        string currentDate; //anlık tarih bilgisi burada tutulur
        string currentTime; //ankık saat bilgisi burda tutulur
        string selDate; // selected (seçilmiş) tarih burada tutulur
        string selTime; // seçilmiş saat burada tutulur
        int Move; //Borderless formda taşıma işlemleri için gereken değişkenler.
        int Mouse_X;
        int Mouse_Y;
        int wpsleep = 35000; //whatsapp web'in açılmasını bekleyen süre internet hızına göre arttırılıp azaltılabilir.
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        //Browser açıldıktan ve wp webe giriş yapıldıktan sonra mesaj gönderimini sağlayan method
        public void sendMsg()
        {
            Thread.Sleep(wpsleep); //Whatsappın açılması için wpsleep değişkenindeki değer kadar bekler. Garanti olması için değeri 35sn olarak belirledim.
            foreach (var currentNum in numList.Items) //Her bir numara için mesaj gönderme işlemini yanpan döngü.
            {
                
                SendKeys.Send("{TAB}"); //Arama kutucuğuna gelmek için tab tuşuna basar.
                SendKeys.Send(Convert.ToString(currentNum)); //currentnum yani işlemdeki numarayı yazar.
                SendKeys.Send("{ENTER}"); // enter tuşuna basarak yazdığı numara ait konuşmaya gider.
                Thread.Sleep(500);//konuşmaya girmesi için yarım saniye bekler
                SendKeys.Send(msgBox.Text); //Mesaj kutusundaki yazıyı yazar.
                SendKeys.Send("{ENTER}"); //Enter tuşuna basar ve mesajı gönderir.
                SendKeys.Send("{TAB}");//Bir sonraki numaraya hazırlanmak için tekrar tab tuşuna basar.
            }
            timer1.Enabled = false; // İşlem bir dakikadan kısa sürerse ve timer aktif olursa aynı mesajları tekrar gönderecektir bunu engellemek içni timerı pasif hale getiriyorum.
            MessageBox.Show("İşlemler tamamlandı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information); // Mesajlar gönderildikten sonra kullanıcıya haber verir.
        }

        private void startButton_Click(object sender, EventArgs e) //Başlat butonu
        {
            if (numList.Items.Count > 0 && msgBox.Text.Length > 0 && stBox.Text.Length > 4 ) //Gerekli kısımların gerekli şekilde doldurulup doldurulmadığını kontrol eder.
            {
                if ( radioC.Checked == true || radioF.Checked == true || radioO.Checked == true || gxRadio.Checked == true) // Browserların seçilip seçilmediğini kontrol eder. Seçili ise timer aktif olur ve tarih'i kontrol etmeye başlar.
                {
                    timer1.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Eksik giriş", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error); //Eksik giriş olursa hata mesajı verir.
                }
            }
            else
            {
                MessageBox.Show("Eksik giriş", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void addNum_Click(object sender, EventArgs e)
        {
            if (numBox.TextLength > 9) //Girilen numaranın uzunluğunun yeterli olup olmadığını kontrol eder.
            {
                numList.Items.Add(numBox.Text); //Numarayı listeye ekler.
            }
            else
            {
                MessageBox.Show("Numara EN AZ 10 Haneli Olmalıdır", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error); //Uzunluk yeterli olmadığı için hata verir.
            }
        }

        private void timer1_Tick(object sender, EventArgs e) //Her 100ms'de bir tarih ve saatiin seçilen tarih ve saatle eşleşip eşleşmediğini kontrol eder. Eşleşirse gerekli methodları çağırır.
        {
            currentTime = DateTime.Now.ToString("HH:mm"); // anlık saati currentTime değişkenine yazar.
            selDate = dateTimePicker1.Value.ToString("dd/MM/yyyy") ; //seçilmiş tarihi selDate değişkenine yazar.
            selTime = stBox.Text; // seçilmiş saati selTime değişkenine yazar.
            currentDate = DateTime.Now.ToString("dd/MM/yyyy"); // anlık tarihi currentDate değişkenine yazar.
            dateLbl.Text = "Sistem Zamanı: " + currentDate + " " + currentTime; //Bilgi amaçlı dateLbl isimli label'e sistem zamanını yazar.
            selLbl.Text = "Mesaj Zamanı: " + selDate + " " + selTime;    //Bigli amaçlı seçilmiş zamanı selLbl isimli label'e yazar.
            if(currentDate == selDate && currentTime==selTime)//Seçilen zamanla anlık zamanın eşleşip eşleşmediğini kontrol eder.
            {
                
                    if (radioC.Checked == true) //Hangi browserların seçili olduğunu kontrol edip buna göre işlem yapan if blokları.
                    {
                        browserControl.OChrome();
                        sendMsg();
                    }
                    if (radioO.Checked == true)
                    {
                        browserControl.OOpera();
                        sendMsg();
                    }
                    if (radioF.Checked == true)
                    {
                        browserControl.OFirefox();
                        sendMsg();
                    }
                    if(gxRadio.Checked == true)
                {
                    browserControl.OGX();
                    sendMsg();
                }

                
                
            }

        }

        private void button1_Click(object sender, EventArgs e) //Excel'den veri alınmasını sağlayan buton.
        {
            string sFileName;
            OpenFileDialog tpsofdlog = new OpenFileDialog(); //Dosya seçme penceresi açar.
            if (tpsofdlog.ShowDialog() == DialogResult.OK)
            {
                
                 sFileName = tpsofdlog.FileName;
                //Bu kısımda biraz google'den yardım aldım fazla açıklayıcı olamayacağım :).
                con = new OleDbConnection($@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = {sFileName}; Extended Properties ='Excel 12.0 xml; HDR = YES; '");
                cmd = new OleDbCommand("SELECT *FROM [nums$]", con);
                con.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    numList.Items.Add(dr["Numara"].ToString());
                }
                con.Close();
            }

            
            
            
        }

        private void deleteNum_Click(object sender, EventArgs e) //Listeden seçili olan numarayı silmeye yarayan buton.
        {
            numList.Items.Remove(numList.SelectedItem);
        }

   

        private void label1_Click(object sender, EventArgs e) //Tasarım için birkaç doknuş (biliyorum tasarımı pek hoş değil idare edin). Programı kapatmaya yarar.
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)//Programı aşağıya almaya yarar.
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_MouseEnter(object sender, EventArgs e) //Geri kalan kısım tasarım için ufak dokunuşlar fazla önemli olmadığı için üzerinde durmayacağım.
        {
            exitLbl.ForeColor = Color.Gray;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            exitLbl.ForeColor = Color.White;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            hideLbl.ForeColor = Color.Gray;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            hideLbl.ForeColor = Color.White;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Move = 1;
            Mouse_X = e.X;
            Mouse_Y = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Move == 1)
            {
                this.SetDesktopLocation(MousePosition.X - Mouse_X, MousePosition.Y - Mouse_Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Move = 0;
        }
    }
}
//Umarım beğenirsiniz.
//Kağan Aybar
