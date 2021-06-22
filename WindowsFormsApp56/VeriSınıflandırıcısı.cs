using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace WindowsFormsApp56
{
    class VeriSınıflandırıcısı : IDisposable
    {
        string Dizin;
        string KlasorAdi;
        string XmlVeriDosyasi;
        public VeriSınıflandırıcısı(string Dizin, string KlasorAdi)
        {
            this.Dizin = Dizin + KlasorAdi;
            TerimKriteri = new MCvTermCriteria(ContTrain, 0.001);
            eğitilmiş = EgitilenVerileriYukle(this.Dizin);
        }
        public VeriSınıflandırıcısı(string Dizin, string KlasorAdi, string XmlVeriDosyasi)
        {
            this.Dizin = Dizin + KlasorAdi;
            this.XmlVeriDosyasi = XmlVeriDosyasi;
            TerimKriteri = new MCvTermCriteria(ContTrain, 0.001);
            eğitilmiş = EgitilenVerileriYukle(this.Dizin);
        }
        #region Variables
        MCvTermCriteria TerimKriteri;
        EigenObjectRecognizer Taniyici;
        List<Image<Gray, byte>> Egitilmis_Resim = new List<Image<Gray, byte>>();
        List<string> İsim_listesi = new List<string>(); 
        int ContTrain, NumaraEtiketi;
        float EgitimMesafesi = 0;
        string EgitimEtiketi;
        int EgitimEsigi = 0;

        string hata;
        bool eğitilmiş = false;

        #endregion

        #region Constructors
        public VeriSınıflandırıcısı()
        {
            KlasorAdi = "TrainedFaces";
            Dizin = Application.StartupPath + "\\" + KlasorAdi;
            XmlVeriDosyasi = "TrainedLabels.xml";

            TerimKriteri = new MCvTermCriteria(ContTrain, 0.001);
            eğitilmiş = EgitilenVerileriYukle(Dizin);
        }
        public VeriSınıflandırıcısı(string EgitilenDosya)
        {
            TerimKriteri = new MCvTermCriteria(ContTrain, 0.001);
            eğitilmiş = EgitilenVerileriYukle(EgitilenDosya);
        }
        #endregion
        #region Public
        public bool eğit
        {
            get { return eğitilmiş; }
        }
        public string Yüz_Tanımı(Image<Gray, byte> Giris_Resmi, int EgitimEsiği = -1)
        {
            if (eğitilmiş)
            {
                EigenObjectRecognizer.RecognitionResult Tanınan_Kisi = Taniyici.Recognize(Giris_Resmi);
                if (Tanınan_Kisi == null)
                {
                    EgitimEtiketi = "Tanimsiz";
                    EgitimMesafesi = 0;
                    return EgitimEtiketi;
                }
                else
                {
                    EgitimEtiketi = Tanınan_Kisi.Label;
                    EgitimMesafesi = Tanınan_Kisi.Distance;
                    if (EgitimEsiği > -1) EgitimEsiği = EgitimEsiği;
                    if (EgitimMesafesi > EgitimEsiği) return EgitimEtiketi;
                    else return "Tanimsiz";
                }

            }
            else return "Tanımsız";
        }
        public int EgitimEsigiAl
        {
            set
            {
                EgitimEsigi = value;
            }
        }
        public string EgitimEtiketiAl
        {
            get
            {
                return EgitimEtiketi;
            }
        }
        public float Egitim_Mesafesi_Al
        {
            get
            {
                return EgitimMesafesi;
            }
        }
        public string Hata_Uyarısı
        {
            get { return hata; }
        }
        public void Egitilen_Verileri_Kaydet(string Dosyaad)
        {
            StringBuilder sb = new StringBuilder();
            (new XmlSerializer(typeof(EigenObjectRecognizer))).Serialize(new StringWriter(sb), Taniyici);
            XmlDocument XmlDokuman = new XmlDocument();
            XmlDokuman.LoadXml(sb.ToString());
            XmlDokuman.Save(Dosyaad);
        }
        public void Egitilen_Verileri_Yukle(string DOSYAADİ)
        {
            FileStream EigenFS = File.OpenRead(DOSYAADİ);
            long Eflength = EigenFS.Length;
            byte[] xmlEBs = new byte[Eflength];
            EigenFS.Read(xmlEBs, 0, (int)Eflength);
            EigenFS.Close();
            MemoryStream xStream = new MemoryStream(xmlEBs);
            Taniyici = (EigenObjectRecognizer)(new XmlSerializer(typeof(EigenObjectRecognizer))).Deserialize(xStream);
            eğitilmiş = true;         
        }
        public void Dispose()
        {
            Taniyici = null;
            Egitilmis_Resim = null;
            İsim_listesi = null;
            hata = null;
            GC.Collect();
        }
        #endregion
        #region Private
        private bool EgitilenVerileriYukle(string Klasor_Konumu)
        {
            if (File.Exists(Klasor_Konumu + "\\" + XmlVeriDosyasi))
            {
                try
                {
                    İsim_listesi.Clear();
                    Egitilmis_Resim.Clear();
                    FileStream Dosya_Akisi = File.OpenRead(Klasor_Konumu + "\\" + XmlVeriDosyasi);
                    long DosyaUzunlugu = Dosya_Akisi.Length;
                    byte[] xmlbiti = new byte[DosyaUzunlugu];
                    Dosya_Akisi.Read(xmlbiti, 0, (int)DosyaUzunlugu);
                    Dosya_Akisi.Close();
                    MemoryStream xmlakisi = new MemoryStream(xmlbiti);
                    using (XmlReader xmlokuyucusu = XmlTextReader.Create(xmlakisi))
                    {
                        while (xmlokuyucusu.Read())
                        {
                            if (xmlokuyucusu.IsStartElement())
                            {
                                switch (xmlokuyucusu.Name)
                                {
                                    case "İSİM":
                                        if (xmlokuyucusu.Read())
                                        {
                                            İsim_listesi.Add(xmlokuyucusu.Value.Trim());
                                            NumaraEtiketi += 1;
                                        }
                                        break;
                                    case "DOSYA":
                                        if (xmlokuyucusu.Read())
                                        {
                                            Egitilmis_Resim.Add(new Image<Gray, byte>(Dizin + "\\" + xmlokuyucusu.Value.Trim()));
                                        }
                                        break;
                                }
                            }
                        }
                    }
                    ContTrain = NumaraEtiketi;
                    if (Egitilmis_Resim.ToArray().Length != 0)
                    {
                        Taniyici = new EigenObjectRecognizer(Egitilmis_Resim.ToArray(),
                        İsim_listesi.ToArray(), 5000, ref TerimKriteri);
                        return true;
                    }
                    else return false;
                }
                catch (Exception ex)
                {
                    hata = ex.ToString();
                    return false;
                }
            }
            else return false;
        }

        #endregion
    }
}
