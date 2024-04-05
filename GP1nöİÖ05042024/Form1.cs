using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GP1nöİÖ05042024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Right;
            //aşağıdaki formu oluşturup textboxlara girilen sayıları toplayıp sonucu textboxa yazan kodu 
            //buton clikck olayına yazınız
            label1.Text = "1. Sayı:";
            label2.Text = "2. SAyı:";
            label3.Text = "SONUÇ:";
            textBox2.TextAlign = HorizontalAlignment.Right;
            textBox3.TextAlign = HorizontalAlignment.Right;
            button1.Text = "Topla";
            button2.Text = "ÇIKIŞ";
            textBox4.Multiline = true;
            textBox4.ScrollBars = ScrollBars.Both;
            textBox1.PasswordChar = '*';

            //soru:textboxa girilen değerlerin büyükharf olarak girilmesini sağlayan kodu yazınız
            textBox2.CharacterCasing = CharacterCasing.Upper;
            //txt boyutlarını değiştiriniz
            textBox2.Width = 200;
            textBox2.Height = 50;
            textBox2.Visible = false;
            textBox1.Enabled = false;
            textBox3.MaxLength = 11;
            textBox4.TabIndex = 0;
            textBox3.TabIndex = 9;
            textBox3.Cursor=Cursors.Hand;
            //txt yazı tipini arial, yazı boyutunu 11 ve yazıyı italic yapınız
            textBox4.Font = new Font("Arial",11,FontStyle.Italic);
            //butona basınca merhaba <textboxtaki değer> i messagebox ile veren kodu yazınız. textbox boş ise,
            //Textboxa değer giriniz yazacak olan.


            /*Uygulama:Textboxın yazı rengini kırmızı, yazı tipini arial, yazı boyutunu 11 yapan ve 
             * butona basınca adınızı textboxta gösteren kodu yazınız.
             * 5 dk. Uygulamayı yapınız.         
             */
            //Uygulama: textboxa girilen değeri butona basmadan senkronize bir şekilde labela yazdıran kodu yazınız

            /*ÖDEV:Uygulama:Textboxlara Kullanıcı adını=admin ve şifresini=1 olarak giren kullanıcılar için butona 
             * tıklayınca ikinci formu açan, yanlış girildiğinde labela yanlış mesajı veren kodu yazınız. 
             */
            //pictureBox1.Image = Image.FromFile("resim1.jpg");
            //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            //pictureBox1.ImageLocation = "resim1.jpg";
            //pictureBox1.BackgroundImage = Image.FromFile("resim1.jpg");
            pictureBox1.BackColor = Color.Bisque;
            //button
            //uygulama: kod ile dinamik buton oluşturunuz, form1Load olayında çalıştırınız

            dinamikbutonolustur();//dinamk butonu formda çalıştırdık
            //buton7 ye basınca toplam metodunu çalıştırınız. Topla metodu iki değişkeni toplayıp sonuculabela yazdırıyor
            //button3.PerformClick();
            
        }
        public void topla()
        {
            int x = 613, y = 8372;
            label4.Text = (x + y).ToString();
        }

        public void dinamikbutonolustur()//button tasarımı yap:
        {
            //buton oluştur
            Button button7 = new Button();
            //butonun propertylerini set etme
            button7.Width = 200;
            button7.Height = 50;
            button7.BackColor = Color.Beige;
            button7.BackgroundImage = Image.FromFile("resim1.jpg");
            button7.ForeColor=Color.Black;
            button7.Location = new Point(100, 200);
            button7.Text = "YeniButon";
            button7.FlatStyle = FlatStyle.Popup;
            button7.Name = "button7";       
            //butonu forma ekle
            Controls.Add(button7);
            //buttonun olaylarını ekle//
            button7.Click += new EventHandler(button7_Click);//butona olay ekle.
        }

        private void button7_Click(object sender, EventArgs e)//olay burada
        {
            MessageBox.Show("Yeni dinamik butona tkladınız");
            topla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(textBox1.Text);
            int s2= Convert.ToInt32(textBox2.Text);
            textBox3.Text = (s1 + s2).ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult secim = MessageBox.Show("Eminmisiniz","Kapatılıyor",MessageBoxButtons.YesNo);
            if (secim==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//e.keycode keydown olayı olayı gerçekleşirken hangi tuşa basıldığını tutar.
            {
                MessageBox.Show(textBox4.Text);
            } 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string gelen = textBox5.Text;
            if (gelen=="")
            {
                MessageBox.Show("Değer gir");
            }
            else
            {
                MessageBox.Show("Merhaba "+gelen);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hiç birşey yapmayan buton");
        }
    }
}
