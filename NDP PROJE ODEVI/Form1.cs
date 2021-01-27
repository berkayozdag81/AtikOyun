/***********************************************************************************************************
 *                                                                                                        **
 *                              ADI:BERKAY                                                                **
 *                              SOYADI:ÖZDAĞ                                                              **
 *                              NUMARA:B191210051                                                         **
 *                              DERS:NESNEYE DAYALI PROGRAMA                                              **                                                                                                                
 *                              ÖĞRETMEN:SİNAN İLYAS                                                      **    
 *                              ÖDEV:PROJE ÖDEVİ                                                                          **
 ***********************************************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NDP_PROJE_ODEVI
{
    public partial class Form1 : Form
    {
        CamKutusu camKutusu;         //Burada atık kutularından birer tane nesne tanımlaması yaptım.
        OrganikAtikKutusu organikAtikKutusu;
        MetalKutusu metalKutusu;
        KagitKutusu kagitKutusu;

        List<Image> resimler = new List<Image>();//Fotoğrafları atıcağım list in tanımlamasını yaptım.

        Dergi Dergi = new Dergi();  //Burada her bir atıktan birer tane nesne oluşturdum.
        CamSise Sise = new CamSise();
        Salatalik Salata = new Salatalik();
        KolaKutusu Kola = new KolaKutusu();
        SalcaKutusu Salca = new SalcaKutusu();
        Domates Domates = new Domates();
        Gazete Gazete = new Gazete();
        Bardak Bardak = new Bardak();

        Random deger = new Random();  //Resimleri list ten rastgele çağırmak için random tipli bir değer dğişken tanımladım
        private int rastgele;
        private int puan;
        public Form1()
        {
            InitializeComponent();
        }

        int saniye = 60; //zaman değişken.
        private void yeniOyunButton_Click(object sender, EventArgs e)
        {
            timer1.Start();

            camBosaltButton.Enabled = true;   //yeni oyun butonuna basıldığında diğer butonları aktif hale getirdim.
            camButton.Enabled = true;
            kagitBosaltButton.Enabled = true;
            kagitButton.Enabled = true;
            organikAtikButton.Enabled = true;
            organikAtikBosaltButton.Enabled = true;
            metalBosaltButton.Enabled = true;
            metalButton.Enabled = true;

            resimler.Add(Sise.Image);  //her atık nesnesinin resmini resim list in içine ekledim.
            resimler.Add(Dergi.Image);
            resimler.Add(Domates.Image);
            resimler.Add(Salata.Image);
            resimler.Add(Bardak.Image);
            resimler.Add(Gazete.Image);
            resimler.Add(Salca.Image);
            resimler.Add(Kola.Image);

            camKutusu = new CamKutusu(); 
            organikAtikKutusu = new OrganikAtikKutusu();
            metalKutusu = new MetalKutusu();
            kagitKutusu = new KagitKutusu();

            ResimDegis();  // oyuna başlandığında picturbox a resim atanması için rastgele resim atayan fonksiyonumu çağırdım.
        }

       
        private void ResimDegis()//picturebox a rastgele resim atayan fonksiyon.
        {
            rastgele = deger.Next(0, resimler.Count);
            atikPictureBox.Image = resimler[rastgele];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;  //60 saniye zamanı tutan sayac.
            saniye = saniye - 1;
            sureLabel.Text = saniye.ToString();

            if (saniye==0) //saniye sıfıra geldiğinde yani oyun süresi dolduğunda oyun butonlarının pasif hale getiren if yapısı.
            {
                timer1.Stop();
                sureLabel.Text = "0";
                camBosaltButton.Enabled = false;
                camButton.Enabled = false;
                kagitBosaltButton.Enabled = false;
                kagitButton.Enabled = false;
                organikAtikButton.Enabled = false;
                organikAtikBosaltButton.Enabled = false;
                metalBosaltButton.Enabled = false;
                metalButton.Enabled = false;
                yeniOyunButton.Enabled = false;
            }
        }
        private void cikisButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void kagitBosaltButton_Click(object sender, EventArgs e)
        {
            if (kagitKutusu.Bosalt())//kağıt kutusu dolduğunda boşlatmayı sağlayan buton ve if yapısı.dolduğunda listbox ve progresbar ögelerini sıfırlar.
            {
                kagitAtikListBox.Items.Clear();
                kagitAtikProgressBar.Value = 0;
            }
        }

        private void kagitButton_Click(object sender, EventArgs e)
        {
            var dergi = new Dergi();
            var gazete = new Gazete();

            if (rastgele == 1)//rastgele değeri 1 e yani derginin resim indexine eşitse kağıtlistbox a ve progressbar a derginin özelliklerini ekler.
            {
                if (kagitKutusu.Ekle(dergi))
                {
                    kagitAtikListBox.Items.Add(dergi.Ad + " - " + dergi.Hacim);
                    kagitAtikProgressBar.Value = kagitKutusu.DolulukOrani;
                    puan += dergi.Hacim;
                    puanLabel.Text = puan.ToString();
                    ResimDegis();
                }
            }

            else if (rastgele == 5)//rastgele değeri 5 e yani gazetenin resim indexine eşitse kağıtlistbox a ve progressbar a gazetenin özelliklerini ekler.
            {
                if(kagitKutusu.Ekle(gazete))
                {
                    kagitAtikListBox.Items.Add(gazete.Ad + " - " + gazete.Hacim);
                    kagitAtikProgressBar.Value = kagitKutusu.DolulukOrani;
                    puan += gazete.Hacim;
                    puanLabel.Text = puan.ToString();
                    ResimDegis();
                }
            }
        }

        private void organikAtikButton_Click(object sender, EventArgs e)
        {
            var domates = new Domates();
            var salatalik = new Salatalik();

            if (rastgele == 2)//rastgele değeri 2 ye yani domatesin resim indexine eşitse organikAtiklistbox a ve progressbar a domatesin özelliklerini ekler.
            {
                if(organikAtikKutusu.Ekle(domates))
                {
                    organikAtikListBox.Items.Add(domates.Ad + " - " + domates.Hacim);
                    organikAtikProgressBar.Value = organikAtikKutusu.DolulukOrani;
                    puan += domates.Hacim;
                    puanLabel.Text = puan.ToString();
                    ResimDegis();
                }       
            }
            else if(rastgele == 3)//rastgele değeri 3 e yani salatalık resim indexine eşitse organikAtiklistbox a ve progressbar a salatalığın özelliklerini ekler.
            {
                if (organikAtikKutusu.Ekle(salatalik))
                {
                    organikAtikListBox.Items.Add(salatalik.Ad + " - " + salatalik.Hacim);
                    organikAtikProgressBar.Value = organikAtikKutusu.DolulukOrani;
                    puan += salatalik.Hacim;
                    puanLabel.Text = puan.ToString();
                    ResimDegis();
                }
            }
        }

        private void organikAtikBosaltButton_Click(object sender, EventArgs e)
        {
            if (organikAtikKutusu.Bosalt())//Organik atık kutusu dolduğunda boşlatmayı sağlayan buton ve if yapısı.Organik atık kutusu dolduğunda listbox ve progresbar ögelerini sıfırlar.
            {
                organikAtikListBox.Items.Clear();
                organikAtikProgressBar.Value = 0;
            }
        }

        private void camButton_Click(object sender, EventArgs e)
        {
            var sise = new CamSise();
            var bardak = new Bardak();

            if (rastgele == 0)
            { 
                if (camKutusu.Ekle(sise))//rastgele değeri 0 a  yani şişenin resim indexine eşitse camAtiklistbox a ve progressbar a şişenin özelliklerini ekler.
                {
                    camAtikListBox.Items.Add(sise.Ad + " - " + sise.Hacim);
                    camAtikProgressBar.Value = camKutusu.DolulukOrani;
                    puan += sise.Hacim;
                    puanLabel.Text = puan.ToString();
                    ResimDegis();
                }
            }
            else if (rastgele == 4)//rastgele değeri 4 e yani bardağın resim indexine eşitse camAtiklistbox a ve progressbar a bardağın özelliklerini ekler.
            {
                if (camKutusu.Ekle(bardak))
                {
                    camAtikListBox.Items.Add(bardak.Ad + " - " + bardak.Hacim);
                    camAtikProgressBar.Value = camKutusu.DolulukOrani;
                    puan += bardak.Hacim;
                    puanLabel.Text = puan.ToString();
                    ResimDegis();
                }
            }
        }

        private void camBosaltButton_Click(object sender, EventArgs e)
        {
            if (camKutusu.Bosalt())//cam kutusu dolduğunda boşlatmayı sağlayan buton ve if yapısı.Cam kutusu dolduğunda listbox ve progresbar ögelerini sıfırlar.
            {
                camAtikListBox.Items.Clear();
                camAtikProgressBar.Value = 0;
            }
        }

        private void metalButton_Click(object sender, EventArgs e)
        {
            var kolaKutusu = new KolaKutusu();
            var salcaKutusu = new SalcaKutusu();

            if (rastgele == 7)//rastgele değeri 7 ye yani kolaKutusu resim indexine eşitse metalAtiklistbox a ve progressbar a kolaKutusunun özelliklerini ekler.
            {
                if (metalKutusu.Ekle(kolaKutusu))
                {
                  metalAtikListBox.Items.Add(kolaKutusu.Ad + " - " + kolaKutusu.Hacim);
                  metalAtikProgressBar.Value = metalKutusu.DolulukOrani;
                  puan += kolaKutusu.Hacim;
                  puanLabel.Text = puan.ToString();
                  ResimDegis();
                }
            }

           else if (rastgele == 6)//rastgele değeri 6 ya yani salça kutusunun resim indexine eşitse metalAtiklistbox a ve progressbar a salça kutusunun özelliklerini ekler.
            {
                if (metalKutusu.Ekle(salcaKutusu))
                {
                    metalAtikListBox.Items.Add(salcaKutusu.Ad + " - " + salcaKutusu.Hacim);
                    metalAtikProgressBar.Value = metalKutusu.DolulukOrani;
                    puan += salcaKutusu.Hacim;
                    puanLabel.Text = puan.ToString();
                    ResimDegis();
                }
            }
        }
        private void metalBosaltButton_Click(object sender, EventArgs e)
        {
            if (metalKutusu.Bosalt())//metal kutusu dolduğunda boşlatmayı sağlayan buton ve if yapısı. metal kutusu dolduğunda listbox ve progresbar ögelerini sıfırlar.
            {
                metalAtikListBox.Items.Clear();
                metalAtikProgressBar.Value = 0;
            }
        }
    }
}
