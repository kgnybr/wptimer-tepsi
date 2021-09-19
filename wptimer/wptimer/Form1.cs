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
            Thread.Sleep(wpsleep);
            foreach (var currentNum in numList.Items)
            {
                
                SendKeys.Send("{TAB}");
                SendKeys.Send(Convert.ToString(currentNum));
                SendKeys.Send("{ENTER}");
                Thread.Sleep(500);
                SendKeys.Send(msgBox.Text);
                SendKeys.Send("{ENTER}");
                SendKeys.Send("{TAB}");
            }
            timer1.Enabled = false;
            MessageBox.Show("İşlemler tamamlandı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (numList.Items.Count > 0 && msgBox.Text.Length > 0 && stBox.Text.Length > 4 )
            {
                if ( radioC.Checked == true || radioF.Checked == true || radioO.Checked == true || gxRadio.Checked == true) {
                    timer1.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Eksik giriş", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Eksik giriş", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void addNum_Click(object sender, EventArgs e)
        {
            if (numBox.TextLength > 9)
            {
                numList.Items.Add(numBox.Text);
            }
            else
            {
                MessageBox.Show("Numara EN AZ 10 Haneli Olmalıdır", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentTime = DateTime.Now.ToString("HH:mm");
            selDate = dateTimePicker1.Value.ToString("dd/MM/yyyy") ; 
            selTime = stBox.Text;
            currentDate = DateTime.Now.ToString("dd/MM/yyyy");
            dateLbl.Text = "Sistem Zamanı: " + currentDate + " " + currentTime;
            selLbl.Text = "Mesaj Zamanı: " + selDate + " " + selTime;    
            if(currentDate == selDate && currentTime==selTime)
            {
                
                    if (radioC.Checked == true)
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

        private void button1_Click(object sender, EventArgs e)
        {
            string sFileName;
            OpenFileDialog tpsofdlog = new OpenFileDialog();
            if (tpsofdlog.ShowDialog() == DialogResult.OK)
            {
                 sFileName = tpsofdlog.FileName;
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

        private void deleteNum_Click(object sender, EventArgs e)
        {
            numList.Items.Remove(numList.SelectedItem);
        }

   

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
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
