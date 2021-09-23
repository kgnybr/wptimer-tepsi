
namespace wptimer
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.numBox = new System.Windows.Forms.TextBox();
            this.numList = new System.Windows.Forms.ListBox();
            this.addNum = new System.Windows.Forms.Button();
            this.dateLbl = new System.Windows.Forms.Label();
            this.radioC = new System.Windows.Forms.RadioButton();
            this.radioO = new System.Windows.Forms.RadioButton();
            this.radioF = new System.Windows.Forms.RadioButton();
            this.msgBox = new System.Windows.Forms.RichTextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.stBox = new System.Windows.Forms.MaskedTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.selLbl = new System.Windows.Forms.Label();
            this.gxRadio = new System.Windows.Forms.RadioButton();
            this.importButton = new System.Windows.Forms.Button();
            this.deleteNum = new System.Windows.Forms.Button();
            this.exitLbl = new System.Windows.Forms.Label();
            this.hideLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.titleLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numBox
            // 
            this.numBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.numBox.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.numBox.ForeColor = System.Drawing.Color.White;
            this.numBox.Location = new System.Drawing.Point(8, 81);
            this.numBox.Margin = new System.Windows.Forms.Padding(2);
            this.numBox.Name = "numBox";
            this.numBox.Size = new System.Drawing.Size(86, 19);
            this.numBox.TabIndex = 0;
            // 
            // numList
            // 
            this.numList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.numList.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.numList.ForeColor = System.Drawing.Color.White;
            this.numList.FormattingEnabled = true;
            this.numList.ItemHeight = 12;
            this.numList.Location = new System.Drawing.Point(169, 54);
            this.numList.Margin = new System.Windows.Forms.Padding(2);
            this.numList.Name = "numList";
            this.numList.Size = new System.Drawing.Size(91, 136);
            this.numList.TabIndex = 1;
            // 
            // addNum
            // 
            this.addNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.addNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNum.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addNum.ForeColor = System.Drawing.Color.White;
            this.addNum.Location = new System.Drawing.Point(98, 67);
            this.addNum.Margin = new System.Windows.Forms.Padding(2);
            this.addNum.Name = "addNum";
            this.addNum.Size = new System.Drawing.Size(67, 46);
            this.addNum.TabIndex = 2;
            this.addNum.Text = "Numara Ekle";
            this.addNum.UseVisualStyleBackColor = false;
            this.addNum.Click += new System.EventHandler(this.addNum_Click);
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.dateLbl.ForeColor = System.Drawing.Color.White;
            this.dateLbl.Location = new System.Drawing.Point(166, 219);
            this.dateLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(92, 14);
            this.dateLbl.TabIndex = 3;
            this.dateLbl.Text = "Sistem Zamanı:";
            // 
            // radioC
            // 
            this.radioC.AutoSize = true;
            this.radioC.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioC.ForeColor = System.Drawing.Color.White;
            this.radioC.Location = new System.Drawing.Point(8, 28);
            this.radioC.Margin = new System.Windows.Forms.Padding(2);
            this.radioC.Name = "radioC";
            this.radioC.Size = new System.Drawing.Size(62, 18);
            this.radioC.TabIndex = 4;
            this.radioC.TabStop = true;
            this.radioC.Text = "Chrome";
            this.radioC.UseVisualStyleBackColor = true;
            // 
            // radioO
            // 
            this.radioO.AutoSize = true;
            this.radioO.Font = new System.Drawing.Font("Arial", 7.8F);
            this.radioO.ForeColor = System.Drawing.Color.White;
            this.radioO.Location = new System.Drawing.Point(71, 28);
            this.radioO.Margin = new System.Windows.Forms.Padding(2);
            this.radioO.Name = "radioO";
            this.radioO.Size = new System.Drawing.Size(55, 18);
            this.radioO.TabIndex = 5;
            this.radioO.TabStop = true;
            this.radioO.Text = "Opera";
            this.radioO.UseVisualStyleBackColor = true;
            // 
            // radioF
            // 
            this.radioF.AutoSize = true;
            this.radioF.Font = new System.Drawing.Font("Arial", 7.8F);
            this.radioF.ForeColor = System.Drawing.Color.White;
            this.radioF.Location = new System.Drawing.Point(128, 28);
            this.radioF.Margin = new System.Windows.Forms.Padding(2);
            this.radioF.Name = "radioF";
            this.radioF.Size = new System.Drawing.Size(59, 18);
            this.radioF.TabIndex = 6;
            this.radioF.TabStop = true;
            this.radioF.Text = "Firefox";
            this.radioF.UseVisualStyleBackColor = true;
            // 
            // msgBox
            // 
            this.msgBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.msgBox.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.msgBox.ForeColor = System.Drawing.Color.White;
            this.msgBox.Location = new System.Drawing.Point(8, 124);
            this.msgBox.Margin = new System.Windows.Forms.Padding(2);
            this.msgBox.Name = "msgBox";
            this.msgBox.Size = new System.Drawing.Size(147, 73);
            this.msgBox.TabIndex = 7;
            this.msgBox.Text = "";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Location = new System.Drawing.Point(98, 242);
            this.startButton.Margin = new System.Windows.Forms.Padding(2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(56, 25);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "Başlat";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.Location = new System.Drawing.Point(8, 219);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(147, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // stBox
            // 
            this.stBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.stBox.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.stBox.ForeColor = System.Drawing.Color.White;
            this.stBox.Location = new System.Drawing.Point(8, 242);
            this.stBox.Margin = new System.Windows.Forms.Padding(2);
            this.stBox.Mask = "00:00";
            this.stBox.Name = "stBox";
            this.stBox.Size = new System.Drawing.Size(76, 19);
            this.stBox.TabIndex = 9;
            this.stBox.ValidatingType = typeof(System.DateTime);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // selLbl
            // 
            this.selLbl.AutoSize = true;
            this.selLbl.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.selLbl.ForeColor = System.Drawing.Color.White;
            this.selLbl.Location = new System.Drawing.Point(169, 236);
            this.selLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selLbl.Name = "selLbl";
            this.selLbl.Size = new System.Drawing.Size(86, 14);
            this.selLbl.TabIndex = 10;
            this.selLbl.Text = "Mesaj Zamanı:";
            // 
            // gxRadio
            // 
            this.gxRadio.AutoSize = true;
            this.gxRadio.Font = new System.Drawing.Font("Arial", 7.8F);
            this.gxRadio.ForeColor = System.Drawing.Color.White;
            this.gxRadio.Location = new System.Drawing.Point(186, 28);
            this.gxRadio.Margin = new System.Windows.Forms.Padding(2);
            this.gxRadio.Name = "gxRadio";
            this.gxRadio.Size = new System.Drawing.Size(70, 18);
            this.gxRadio.TabIndex = 6;
            this.gxRadio.TabStop = true;
            this.gxRadio.Text = "OperaGX";
            this.gxRadio.UseVisualStyleBackColor = true;
            // 
            // importButton
            // 
            this.importButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.importButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.importButton.ForeColor = System.Drawing.Color.White;
            this.importButton.Location = new System.Drawing.Point(264, 53);
            this.importButton.Margin = new System.Windows.Forms.Padding(2);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(76, 46);
            this.importButton.TabIndex = 12;
            this.importButton.Text = "Excel\'den Aktar";
            this.importButton.UseVisualStyleBackColor = false;
            this.importButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteNum
            // 
            this.deleteNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.deleteNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteNum.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.deleteNum.ForeColor = System.Drawing.Color.White;
            this.deleteNum.Location = new System.Drawing.Point(264, 104);
            this.deleteNum.Margin = new System.Windows.Forms.Padding(2);
            this.deleteNum.Name = "deleteNum";
            this.deleteNum.Size = new System.Drawing.Size(76, 42);
            this.deleteNum.TabIndex = 13;
            this.deleteNum.Text = "Seçiliyi Kaldır";
            this.deleteNum.UseVisualStyleBackColor = false;
            this.deleteNum.Click += new System.EventHandler(this.deleteNum_Click);
            // 
            // exitLbl
            // 
            this.exitLbl.AutoSize = true;
            this.exitLbl.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.exitLbl.ForeColor = System.Drawing.Color.White;
            this.exitLbl.Location = new System.Drawing.Point(339, 7);
            this.exitLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.exitLbl.Name = "exitLbl";
            this.exitLbl.Size = new System.Drawing.Size(14, 14);
            this.exitLbl.TabIndex = 14;
            this.exitLbl.Text = "X";
            this.exitLbl.Click += new System.EventHandler(this.label1_Click);
            this.exitLbl.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.exitLbl.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // hideLbl
            // 
            this.hideLbl.AutoSize = true;
            this.hideLbl.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.hideLbl.ForeColor = System.Drawing.Color.White;
            this.hideLbl.Location = new System.Drawing.Point(325, 7);
            this.hideLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hideLbl.Name = "hideLbl";
            this.hideLbl.Size = new System.Drawing.Size(11, 14);
            this.hideLbl.TabIndex = 15;
            this.hideLbl.Text = "-";
            this.hideLbl.Click += new System.EventHandler(this.label2_Click);
            this.hideLbl.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.hideLbl.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.panel1.Controls.Add(this.exitLbl);
            this.panel1.Controls.Add(this.hideLbl);
            this.panel1.Controls.Add(this.titleLbl);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 22);
            this.panel1.TabIndex = 16;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.titleLbl.ForeColor = System.Drawing.Color.White;
            this.titleLbl.Location = new System.Drawing.Point(2, 7);
            this.titleLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(37, 14);
            this.titleLbl.TabIndex = 3;
            this.titleLbl.Text = "Tepsi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numara:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mesajınız:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 204);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gönderliecek Tarih:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(306, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 14);
            this.label4.TabIndex = 17;
            this.label4.Text = "Gizle";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Tepsi";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(211)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(354, 268);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deleteNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.selLbl);
            this.Controls.Add(this.stBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.msgBox);
            this.Controls.Add(this.gxRadio);
            this.Controls.Add(this.radioF);
            this.Controls.Add(this.radioO);
            this.Controls.Add(this.radioC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.addNum);
            this.Controls.Add(this.numList);
            this.Controls.Add(this.numBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Tepsi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numBox;
        private System.Windows.Forms.ListBox numList;
        private System.Windows.Forms.Button addNum;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.RadioButton radioC;
        private System.Windows.Forms.RadioButton radioO;
        private System.Windows.Forms.RadioButton radioF;
        private System.Windows.Forms.RichTextBox msgBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MaskedTextBox stBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label selLbl;
        private System.Windows.Forms.RadioButton gxRadio;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.Button deleteNum;
        private System.Windows.Forms.Label exitLbl;
        private System.Windows.Forms.Label hideLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

