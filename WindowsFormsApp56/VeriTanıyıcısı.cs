using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApp56
{
    class VeriTanıyıcısı
    {
        string Dizin;
        string KlasorAdi;
        string XmlVeriDosyasi;
        public VeriTanıyıcısı()
        {
            KlasorAdi = "TrainedFaces";
            XmlVeriDosyasi = "TrainedLabels.xml";
            Dizin = Application.StartupPath + "/" + KlasorAdi + "/";
        }

        public VeriTanıyıcısı(string Dizin, string KlasorAdi)
        {
            this.Dizin = Dizin + "/" + KlasorAdi + "/";
            Eğitim_Sınıfı = new VeriSınıflandırıcısı(Dizin, KlasorAdi);
        }

        public VeriTanıyıcısı(string Dizin, string KlasorAdi, string XmlVeriDosyasi)
        {
            this.Dizin = Dizin + "/" + KlasorAdi + "/";
            this.XmlVeriDosyasi = XmlVeriDosyasi;
            Eğitim_Sınıfı = new VeriSınıflandırıcısı(Dizin, KlasorAdi, XmlVeriDosyasi);
        }

        #region Arka Arkaya 10 Görüntü Yakalamak İçin
        List<Image<Gray, byte>> ResimYakala = new List<Image<Gray, byte>>();

        #endregion


        #region Eğitim Sınıflandırıcısı
        VeriSınıflandırıcısı Eğitim_Sınıfı;
        #endregion


        #region XML Veri Dosyaları
        XmlDocument Dokuman = new XmlDocument();
        #endregion

        #region Veri Kaydet
        public bool EgitilenVerileriKaydet(Image YüzDosyasi, string YüzAdi)
        {
            try
            {
                string Personelİsmi = YüzAdi;
                Random rand = new Random();
                bool DosyaYarat = true;
                string YüzAd = "İSİM_" + Personelİsmi + "_" + rand.Next().ToString() + ".jpg";
                while (DosyaYarat)
                {

                    if (!File.Exists(Dizin + YüzAd))
                    {
                        DosyaYarat = false;
                    }
                    else
                    {
                        YüzAd = "İSİM_" + Personelİsmi + "_" + rand.Next().ToString() + ".jpg";
                    }
                }


                if (Directory.Exists(Dizin))
                {
                    YüzDosyasi.Save(Dizin + YüzAd, ImageFormat.Jpeg);
                }
                else
                {
                    Directory.CreateDirectory(Dizin);
                    YüzDosyasi.Save(Dizin + YüzAd, ImageFormat.Jpeg);
                }
                if (File.Exists(Dizin + XmlVeriDosyasi))
                {
                    //File.AppendAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", NAME_PERSON.Text + "\n\r");
                    bool Yükleme = true;
                    while (Yükleme)
                    {
                        try
                        {
                            Dokuman.Load(Dizin + XmlVeriDosyasi);
                            Yükleme = false;
                        }
                        catch
                        {
                            Dokuman = null;
                            Dokuman = new XmlDocument();
                            Thread.Sleep(10);
                        }
                    }
                    XmlElement XMLkökü = Dokuman.DocumentElement;

                    XmlElement YüzVerisi = Dokuman.CreateElement("YÜZ");
                    XmlElement İsimVerisi = Dokuman.CreateElement("İSİM");
                    XmlElement DosyaVerisi = Dokuman.CreateElement("DOSYA");
                    İsimVerisi.InnerText = Personelİsmi;
                    DosyaVerisi.InnerText = YüzAd;
                    YüzVerisi.AppendChild(İsimVerisi);
                    YüzVerisi.AppendChild(DosyaVerisi);
                    XMLkökü.AppendChild(YüzVerisi);
                    Dokuman.Save(Dizin + XmlVeriDosyasi);
                }
                else
                {
                    FileStream YüzDosyaAkisi = File.OpenWrite(Dizin + XmlVeriDosyasi);
                    using (XmlWriter Yaz = XmlWriter.Create(YüzDosyaAkisi))
                    {
                        Yaz.WriteStartDocument();
                        Yaz.WriteStartElement("Eğitimi");

                        Yaz.WriteStartElement("YÜZ");
                        Yaz.WriteElementString("İSİM", Personelİsmi);
                        Yaz.WriteElementString("DOSYA", YüzAd);
                        Yaz.WriteEndElement();

                        Yaz.WriteEndElement();
                        Yaz.WriteEndDocument();
                    }
                    YüzDosyaAkisi.Close();
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        #endregion

        #region Kayıtları Verileri Sil
        public void DOSYASİL()
        {
            if (Directory.Exists(Dizin))
            {
                Directory.Delete(Dizin, true);
            }
            Directory.CreateDirectory(Dizin);
        }
        #endregion
    }
}
