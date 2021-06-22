using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Imaging;

namespace WindowsFormsApp56
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }
        
        SqlConnection yol = new SqlConnection("Server=tcp:94.123.228.214,1433;Initial Catalog = YüzTanima;Integrated Security = SSPI;");
        SqlDataAdapter veriokut;
        SqlCommand veridoldur;
        DataSet verial;
        VeriTanıyıcısı Tanıma = new VeriTanıyıcısı("bin\\", "Facess", "yuz.xml");
        VeriSınıflandırıcısı Sınıflandır = new VeriSınıflandırıcısı("bin\\", "Facess", "yuz.xml");
        //  void kontrolet()
        //  {
        //    veriokut = new SqlDataAdapter("Select *From YetkiliKayit", yol);
        //    verial = new DataSet();
        //    yol.Open();
        //    veriokut.Fill(verial, "YetkiliKayit");
        //    yol.Close();
        //}

        void temizleyönelt()
        {
            //txtresimyol.Text = "";
            //TXT_NO.Text = "";
            //TXT_AD.Text = "";
            //TXT_SOYAD.Text = "";
            //TXT_NO.Focus();
        }
        void kayıtekle()
        {
            SqlCommand KOMUTVER = new SqlCommand("insert into kayit (yetkili_no,yetkili_ad,yetkili_soyad,yetkili_resimyol,yetkili_kaydedilentarih) values (@p1,@p2,@p3,@p4,@p5)");
            yol.Open();
            KOMUTVER.Connection = yol;
            KOMUTVER.Parameters.AddWithValue("@p1", TXT_NO.Text);
            KOMUTVER.Parameters.AddWithValue("@p2", TXT_AD.Text);
            KOMUTVER.Parameters.AddWithValue("@p3", TXT_SOYAD.Text);
            KOMUTVER.Parameters.AddWithValue("@p4", txtresimyol.Text);
            KOMUTVER.Parameters.AddWithValue("@p5", DateTime.Now);
            KOMUTVER.ExecuteNonQuery();
            yol.Close();
        }
        void RESİMYOL()
        {
            Bitmap bit = new Bitmap(KameradakiSonYuz.Image, 900, 650);
            string kayıt_yeri = @"bin\\Facess\\yuz.xml";
            bit.Save(kayıt_yeri);
            txtresimyol.Text = @"bin\\Facess\\yuz.xml";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Capture kamera = new Capture();
            kamera.Start();
            kamera.ImageGrabbed += (a, b) =>
            {
                var resim = kamera.RetrieveBgrFrame();
                if (resim!=null)
                {
                    var grayimage = resim.Convert<Gray, byte>();
                    HaarCascade yuzbilgi = new HaarCascade("haarcascade_frontalface_alt2.xml");
                    HaarCascade gozbilgi = new HaarCascade("haarcascade_eye.xml");
                    MCvAvgComp[][] Yuzler = grayimage.DetectHaarCascade(yuzbilgi, 1.2, 5, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(15, 15));
                    MCvAvgComp[][] Gozler = grayimage.DetectHaarCascade(gozbilgi, 1.2, 5, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(4, 4));
                    MCvFont yuzdeger = new MCvFont(FONT.CV_FONT_HERSHEY_COMPLEX, 0.5, 0.5);
                    foreach (MCvAvgComp yuz in Yuzler[0])
                    {
                        foreach (var goz in Gozler[0])
                        {
                            var songoruntu = grayimage.Copy(goz.rect).Convert<Gray, byte>().Resize(100, 100, INTER.CV_INTER_CUBIC);
                            KameradakiSonYuz.Image = songoruntu.ToBitmap();
                            resim.Draw(goz.rect, new Bgr(Color.Red), 2);
                            songoruntu = grayimage.Copy(yuz.rect).Convert<Gray, byte>().Resize(100, 100, INTER.CV_INTER_CUBIC);
                            KameradakiSonYuz.Image = songoruntu.ToBitmap();
                            
                        if (Sınıflandır != null)
                            if (Sınıflandır.eğit)
                            {
                                string isim = Sınıflandır.Yüz_Tanımı(songoruntu);
                                int Eslesme_Degeri = (int)Sınıflandır.Egitim_Mesafesi_Al;
                                resim.Draw( /*TXT_NO.Text+" Numarali "+*/isim/*+" "+TXT_SOYAD.Text+" Adli Ogrenci "*/, ref yuzdeger, new Point(yuz.rect.X - 2, yuz.rect.Y - 2), new Bgr(Color.Red));
                                    CekılenFotograf.Image = resim.ToBitmap();
                            }
                            else
                            {
                                CekılenFotograf.Image = resim.ToBitmap();
                                resim.Draw( /*TXT_NO.Text+" Numarali "+*/"Tanimsiz Kisi"/*+" "+TXT_SOYAD.Text+" Adli Ogrenci "*/, ref yuzdeger, new Point(yuz.rect.X - 2, yuz.rect.Y - 2), new Bgr(Color.Red));
                            }
                            resim.Draw(yuz.rect , new Bgr(Color.Red), 2);                    
                        }
                    }
                    pictureBox1.Image = resim.ToBitmap();
                    //if (KameradakiSonYuz.Image != null)
                    //{
                    //    Bitmap bl = new Bitmap(KameradakiSonYuz.Image);
                    //    BitmapData data = bl.LockBits(new Rectangle(0, 0, bl.Width, bl.Height),
                    //    ImageLockMode.ReadOnly, bl.PixelFormat);  // make sure you check the pixel format as you will be looking directly at memory
                    //    unsafe
                    //    {
                    //        for (int y = 0; y < data.Height; ++y)
                    //        {
                    //            byte* pRow = (byte*)data.Scan0 + y * data.Stride;
                    //            for (int x = 0; x < data.Width; ++x)
                    //            {
                    //                byte r = pRow[2];
                    //                byte g = pRow[1];
                    //                byte bs = pRow[0];
                    //                //pRow += 3;
                    //            }
                    //        }
                    //    }
                    //    bl.UnlockBits(data);
                    //}
                }
                };
        }
        private async void YüzKaydet_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                if (TXT_NO.Text != "" && TXT_SOYAD.Text != "")
                {
                    for (int i = 0; i < 20; i++)
                    {
                        if (!Tanıma.EgitilenVerileriKaydet(KameradakiSonYuz.Image, TXT_AD.Text)) MessageBox.Show("Hata", "Profil alınırken beklenmeyen bir hata oluştu.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        double sayi = 0.100000;
                        Thread.Sleep(Convert.ToInt32(sayi));
                        lblEgitilenAdet.Text = (i + 1) + " adet profil.";
                    }
                    
                    Tanıma = null;
                    Sınıflandır = null;
                    Tanıma = new VeriTanıyıcısı("bin\\", "Facess", "yuz.xml");
                    Sınıflandır = new VeriSınıflandırıcısı("bin\\", "Facess", "yuz.xml");
                    RESİMYOL();
                    kayıtekle();
                    temizleyönelt();
                    lblEgitilenAdet.Text = 0.ToString() ;
                }
                else
                {
                    MessageBox.Show("Lütfen Tüm Alanları Doldurun!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            });
            
        }
        private void YUZ_SIL_Click(object sender, EventArgs e)
        {
            Tanıma.DOSYASİL();
        }
    }
}
