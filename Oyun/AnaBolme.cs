using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oyun

{
    public class AnaBolme
    {
        #region string
        public static string isim { get; set; }
        public string İsim
        {
            get
            {
                return isim;
            }
            set
            {
                isim = value;
            }
        }
        public static string meslek { get; set; }
        public string Meslek
        {
            get
            {
                return meslek;
            }
            set
            {
                meslek = value;
            }
        }
        #endregion

        #region özellik
        public static int damage { get; set; }
        public int Damage
        {
            get
            {
                return damage;
            }
            set
            {
                damage = value;
            }
        }
        public static int health { get; set; }
        public int Health
        {
            get
            {
                return health;
            }
            set
            {
                health = value;
            }
        }
        public static int mHealth { get; set; }
        public int MHealth
        {
            get
            {
                return mHealth;
            }
            set
            {
                mHealth = value;
            }
        }
        public static int archer { get; set; }
        public int Archer
        {
            get
            {
                return archer;
            }
            set
            {
                archer = value;
            }
        }
        public static int guess { get; set; }
        public int Guess
        {
            get
            {
                return guess;
            }
            set
            {
                guess = value;
            }
        }
        public static int magic { get; set; }
        public int Magic
        {
            get
            {
                return magic;
            }
            set
            {
                magic = value;
            }
        }
        public static int speed { get; set; }
        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }
        public static int stamina { get; set; }
        public int Stamina
        {
            get
            {
                return stamina;
            }
            set
            {
                stamina = value;
            }
        }
        public static int mStamina { get; set; }
        public int MStamina
        {
            get
            {
                return mStamina;
            }
            set
            {
                mStamina = value;
            }
        }
        public static int steal { get; set; }
        public int Steal
        {
            get
            {
                return steal;
            }
            set
            {
                steal = value;
            }
        }
        public static int hide { get; set; }
        public int Hide
        {
            get
            {
                return hide;
            }
            set
            {
                hide = value;
            }
        }
        public static int defance { get; set; }
        public int Defance
        {
            get
            {
                return defance;
            }
            set
            {
                defance = value;
            }
        }
        public static int experience { get; set; }
        public int Experience
        {
            get
            {
                return experience;
            }
            set
            {
                experience = value;
            }
        }
        public static int mExperience { get; set; }
        public int MExperience
        {
            get
            {
                return mExperience;
            }
            set
            {
                mExperience = value;
            }
        }
        public static int level { get; set; }
        public int Level
        {
            get
            {
                return level;
            }
            set
            {
                level = value;
            }
        }
        #endregion

        #region Not Özellik
        public static int gold { get; set; }
        public int Gold
        {
            get
            {
                return gold;
            }
            set
            {
                gold = value;
            }
        }
        public static int honor { get; set; }
        public int Honor
        {
            get
            {
                return honor;
            }
            set
            {
                honor = value;
            }
        }
        #endregion

        /*public static int  { get; set; }
        public int 
        {
            get
            {
                return ;
            }
            set
            {
                 = value;
            }
        }*/

        #region item
        #region Silah
        public static int KusanmaSilahID { get; set; }
        public int kusanmaSilahID
        {
            get
            {
                return KusanmaSilahID;
            }
            set
            {
                KusanmaSilahID = value;
            }
        }
        public static int KusanmaSilah { get; set; }
        public int kusanmaSilah
        {
            get
            {
                return KusanmaSilah;
            }
            set
            {
                KusanmaSilah = value;
            }
        }

        public int silahİtemID { get; set; }
        public string silahİtemİsim { get; set; }
        public bool silahİtemKullanılma { get; set; }
        public int silahİtemSayi { get; set; }
        public int silahDegisecekDeger { get; set; }
        public int silahFiyat { get; set; }

        public static List<AnaBolme> İtemSilah = new List<AnaBolme>()
        {
            new AnaBolme(){silahİtemID=0, silahİtemSayi=0,silahİtemKullanılma=false,silahİtemİsim="Kısa Kılıç",silahDegisecekDeger=20,silahFiyat=40 },
            new AnaBolme(){silahİtemID=1, silahİtemSayi=0,silahİtemKullanılma=false,silahİtemİsim="Uzun Kılıç",silahDegisecekDeger=30,silahFiyat=60 },
            new AnaBolme(){silahİtemID=2, silahİtemSayi=0,silahİtemKullanılma=false,silahİtemİsim="Tek Elli Ağır Kılıç",silahDegisecekDeger=40,silahFiyat=80 },
            new AnaBolme(){silahİtemID=3, silahİtemSayi=0,silahİtemKullanılma=false,silahİtemİsim="Çift Elli Ağır Kılıç",silahDegisecekDeger=50,silahFiyat=100 },
            new AnaBolme(){silahİtemID=4, silahİtemSayi=0,silahİtemKullanılma=false,silahİtemİsim="Ekmek Bıçağı",silahDegisecekDeger=10,silahFiyat=15 },
            new AnaBolme(){silahİtemID=5, silahİtemSayi=0,silahİtemKullanılma=false,silahİtemİsim="Hançer",silahDegisecekDeger=15,silahFiyat=20 },

            new AnaBolme(){silahİtemID=6, silahİtemSayi=0,silahİtemKullanılma=false,silahİtemİsim="Kısa Balta",silahDegisecekDeger=30,silahFiyat=60 },
            new AnaBolme(){silahİtemID=7, silahİtemSayi=0,silahİtemKullanılma=false,silahİtemİsim="Uzun Balta",silahDegisecekDeger=50,silahFiyat=100 },
            new AnaBolme(){silahİtemID=8, silahİtemSayi=0,silahİtemKullanılma=false,silahİtemİsim="Tek Elli Ağır Balta",silahDegisecekDeger=70,silahFiyat=140 },
            new AnaBolme(){silahİtemID=9, silahİtemSayi=0,silahİtemKullanılma=false,silahİtemİsim="Çift Elli Ağır Balta",silahDegisecekDeger=90,silahFiyat=180 },

            new AnaBolme(){silahİtemID=10, silahİtemSayi=0,silahİtemKullanılma=false,silahİtemİsim="Uzun Mızrak",silahDegisecekDeger=40,silahFiyat=80 },
            new AnaBolme(){silahİtemID=11, silahİtemSayi=0,silahİtemKullanılma=false,silahİtemİsim="Üç Başlı Mızrak",silahDegisecekDeger=60,silahFiyat=120 },
            new AnaBolme(){silahİtemID=12, silahİtemSayi=0,silahİtemKullanılma=false,silahİtemİsim="Uzun Kargı",silahDegisecekDeger=80,silahFiyat=160 },
            new AnaBolme(){silahİtemID=13, silahİtemSayi=0,silahİtemKullanılma=false,silahİtemİsim="Baltalı Kargı",silahDegisecekDeger=100,silahFiyat=200 },
            new AnaBolme(){silahİtemID=14, silahİtemSayi=1,silahİtemKullanılma=true,silahİtemİsim="Yumruklar",silahDegisecekDeger=0 },
        };

        public void SilahİtemKusanma(int ID)
        {
            ID--;
            int sinir = İtemSilah.Count;
            if (ID <= sinir)
            {
                if (İtemSilah[ID].silahİtemSayi > 0)
                {
                    İtemSilah[kusanmaSilahID].silahİtemKullanılma = false;
                    damage -= kusanmaSilah;
                    kusanmaSilah = İtemSilah[ID].silahDegisecekDeger;
                    damage += kusanmaSilah;
                    İtemSilah[ID].silahİtemKullanılma = true;
                    kusanmaSilahID = ID;
                }
                else
                {   
                    Console.Write("malesef sizde bu eşya bulunmadığından kuşanamasınız\n");
                }
            }
            else
            {
                Console.WriteLine("Böyle bir item yoktur");
            }

        }

        public void SilahİtemSatınalma(int ID)
        {
            ID--;
            int sinir = İtemSilah.Count - 1;
            if (ID < sinir)
            {
                if (İtemSilah[ID].silahFiyat < Gold)
                {
                    İtemSilah[ID].silahİtemSayi++;
                    Gold -= İtemSilah[ID].silahFiyat;
                    Console.WriteLine("Kuşanmak ister misin?\n[1]Evet, kuşan\n[2]Hayır, Kuşanma\nNe yapmak istiyorsun : ");
                    int silahSecim = Convert.ToInt32(Console.ReadLine());
                    if (silahSecim == 1)
                    {
                        ID++;
                        SilahİtemKusanma(ID);
                    }
                    else { }
                    Console.WriteLine("{0} : {1}", İtemSilah[ID].silahİtemİsim, İtemSilah[ID].silahİtemSayi);
                }
                else
                {
                    Console.WriteLine("{0} isimli itemi almak için paranız yetmemektedir.", İtemSilah[ID].silahİtemİsim);
                }
            }
            else
            {
                Console.WriteLine("Böyle bir item yoktur");
            }

        }

        #endregion
        #region Yay
        public static int KusanmaYayID { get; set; }
        public int kusanmaYayID
        {
            get
            {
                return KusanmaYayID;
            }
            set
            {
                KusanmaYayID = value;
            }
        }
        public static int KusanmaYay { get; set; }
        public int kusanmaYay
        {
            get
            {
                return KusanmaYay;
            }
            set
            {
                KusanmaYay = value;
            }
        }

        public static int KusanmaOkID { get; set; }
        public int kusanmaOkID
        {
            get
            {
                return KusanmaOkID;
            }
            set
            {
                KusanmaOkID = value;
            }
        }
        public static int KusanmaOk { get; set; }
        public int kusanmaOk
        {
            get
            {
                return KusanmaOk;
            }
            set
            {
                KusanmaOk = value;
            }
        }

        public int yayİtemID { get; set; }
        public string yayİtemİsim { get; set; }
        public bool yayİtemKullanılma { get; set; }
        public int yayİtemSayi { get; set; }
        public int yayDegisecekDeger { get; set; }
        public int yayFiyat { get; set; }

        public int okİtemID { get; set; }
        public string okİtemİsim { get; set; }
        public bool okİtemKullanılma { get; set; }
        public int okİtemSayi { get; set; }
        public int okDegisecekDeger { get; set; }
        public int okFiyat { get; set; }

        public static List<AnaBolme> İtemYay = new List<AnaBolme>()
        {
            new AnaBolme(){yayİtemID=0, yayİtemSayi=0,yayİtemKullanılma=false,yayİtemİsim="Kısa Yay",yayDegisecekDeger=20,yayFiyat=40 },
            new AnaBolme(){yayİtemID=1, yayİtemSayi=0,yayİtemKullanılma=false,yayİtemİsim="Uzun Yay",yayDegisecekDeger=30,yayFiyat=60 },
            new AnaBolme(){yayİtemID=2, yayİtemSayi=0,yayİtemKullanılma=false,yayİtemİsim="Crossbow",yayDegisecekDeger=50,yayFiyat=100 },
            new AnaBolme(){yayİtemID=3, yayİtemSayi=1,yayİtemKullanılma=true,yayİtemİsim="Yaysız",yayDegisecekDeger=0 },
        };

        public static List<AnaBolme> İtemOk = new List<AnaBolme>()
        {
            new AnaBolme(){okİtemID=0, okİtemSayi=0,okİtemKullanılma=false,okİtemİsim="Tahta Ok",okDegisecekDeger=2,okFiyat=4 },
            new AnaBolme(){okİtemID=1, okİtemSayi=0,okİtemKullanılma=false,okİtemİsim="Taş Ok",okDegisecekDeger=4,okFiyat=8 },
            new AnaBolme(){okİtemID=2, okİtemSayi=1,okİtemKullanılma=true,okİtemİsim="Oksuz",okDegisecekDeger=0 },
        };

        public void YayİtemKusanma(int ID)
        {
            ID--;
            int sinir = İtemYay.Count;
            if (ID <= sinir)
            {
                if (İtemYay[ID].yayİtemSayi > 0)
                {
                    İtemYay[kusanmaYayID].yayİtemKullanılma = false;
                    archer -= kusanmaYay;
                    kusanmaYay = İtemYay[ID].yayDegisecekDeger;
                    archer += kusanmaYay;
                    İtemYay[ID].yayİtemKullanılma = true;
                    kusanmaYayID = ID;
                }
                else
                {
                    Console.Write("malesef sizde bu eşya bulunmadığından kuşanamasınız\n");
                }
            }
            else
            {
                Console.WriteLine("Böyle bir item yoktur");
            }
        }

        public void OkİtemKusanma(int ID)
        {
            ID--;
            int sinir = İtemOk.Count;
            if (ID <= sinir)
            {
                if (İtemOk[ID].okİtemSayi > 0)
                {
                    İtemOk[kusanmaOkID].okİtemKullanılma = false;
                    damage -= kusanmaOk;
                    kusanmaOk = İtemOk[ID].okDegisecekDeger;
                    damage += kusanmaOk;
                    İtemOk[ID].okİtemKullanılma = true;
                    kusanmaOkID = ID;
                }
                else
                {
                    Console.Write("malesef sizde bu eşya bulunmadığından kuşanamasınız\n");
                }
            }
            else
            {
                Console.WriteLine("Böyle bir item yoktur");
            }
        }

        public void YayİtemSatınalma(int ID)
        {
            ID--;
            int sinir = İtemYay.Count - 1;
            if (ID < sinir)
            {
                if (İtemYay[ID].yayFiyat < Gold)
                {
                    İtemYay[ID].yayİtemSayi++;
                    Gold -= İtemYay[ID].yayFiyat;
                    Console.WriteLine("Kuşanmak ister misin?\n[1]Evet, kuşan\n[2]Hayır, Kuşanma\nNe yapmak istiyorsun : ");
                    int Secim = Convert.ToInt32(Console.ReadLine());
                    if (Secim == 1)
                    {
                        ID++;
                        YayİtemKusanma(ID);
                    }
                    else { }
                    Console.WriteLine("{0} : {1}", İtemYay[ID].yayİtemİsim, İtemYay[ID].yayİtemSayi);
                }
                else
                {
                    Console.WriteLine("{0} isimli itemi almak için paranız yetmemektedir.", İtemYay[ID].yayİtemİsim);
                }
            }
            else
            {
                Console.WriteLine("Böyle bir item yoktur");
            }
        }

        public void OkİtemSatınalma(int ID)
        {
            ID--;
            int sinir = İtemOk.Count - 1;
            if (ID < sinir)
            {
                Console.Write("Kaç adet ok almak istersin : ");
                int tane = Convert.ToInt32(Console.ReadLine());
                if (tane * (İtemOk[ID].okFiyat) < Gold)
                {
                    İtemOk[ID].okİtemSayi += tane;
                    Gold -= tane * (İtemOk[ID].okFiyat);
                    Console.WriteLine("Kuşanmak ister misin?\n[1]Evet, kuşan\n[2]Hayır, Kuşanma\nNe yapmak istiyorsun : ");
                    int Secim = Convert.ToInt32(Console.ReadLine());
                    if (Secim == 1)
                    {
                        ID++;
                        OkİtemKusanma(ID);
                    }
                    else { }
                    Console.WriteLine("{0} : {1}", İtemOk[ID].okİtemİsim, İtemOk[ID].okİtemSayi);
                }
                else
                {
                    Console.WriteLine("{0} isimli itemi almak için paranız yetmemektedir.", İtemOk[ID].okİtemİsim);
                }
            }
            else
            {
                Console.WriteLine("Böyle bir item yoktur");
            }
        }

        #endregion
        #region Kalkan
        public static int KusanmaKalkanID { get; set; }
        public int kusanmaKalkanID
        {
            get
            {
                return KusanmaKalkanID;
            }
            set
            {
                KusanmaKalkanID = value;
            }
        }
        public static int KusanmaKalkan { get; set; }
        public int kusanmaKalkan
        {
            get
            {
                return KusanmaKalkan;
            }
            set
            {
                KusanmaKalkan = value;
            }
        }

        public int kalkanİtemID { get; set; }
        public string kalkanİtemİsim { get; set; }
        public bool kalkanİtemKullanılma { get; set; }
        public int kalkanİtemSayi { get; set; }
        public int kalkanDegisecekDeger { get; set; }
        public int kalkanFiyat { get; set; }

        public static List<AnaBolme> İtemKalkan = new List<AnaBolme>()
        {
            new AnaBolme(){kalkanİtemID=0, kalkanİtemSayi=0,kalkanİtemKullanılma=false,kalkanİtemİsim="Klasik Yuvarlak Kalkan",kalkanDegisecekDeger=20,kalkanFiyat=40 },
            new AnaBolme(){kalkanİtemID=1, kalkanİtemSayi=0,kalkanİtemKullanılma=false,kalkanİtemİsim="Klasik Uzun Kalkan",kalkanDegisecekDeger=30,kalkanFiyat=60 },
            new AnaBolme(){kalkanİtemID=2, kalkanİtemSayi=0,kalkanİtemKullanılma=false,kalkanİtemİsim="Büyük Yuvarlak Kalkan",kalkanDegisecekDeger=50,kalkanFiyat=100 },
            new AnaBolme(){kalkanİtemID=3, kalkanİtemSayi=0,kalkanİtemKullanılma=false,kalkanİtemİsim="Dayanıklı Yuvarlak Kalkan",kalkanDegisecekDeger=70,kalkanFiyat=140 },
            new AnaBolme(){kalkanİtemID=4, kalkanİtemSayi=1,kalkanİtemKullanılma=true,kalkanİtemİsim="Kalkansız",kalkanDegisecekDeger=0 }
        };

        public void KalkanİtemKusanma(int ID)
        {
            ID--;
            int sinir = İtemKalkan.Count;
            if (ID <= sinir)
            {
                if (İtemKalkan[ID].kalkanİtemSayi > 0)
                {
                    İtemKalkan[kusanmaKalkanID].kalkanİtemKullanılma = false;
                    defance -= kusanmaKalkan;
                    kusanmaKalkan = İtemKalkan[ID].kalkanDegisecekDeger;
                    defance += kusanmaKalkan;
                    İtemKalkan[ID].kalkanİtemKullanılma = true;
                    kusanmaKalkanID = ID;
                }
                else
                {
                    Console.Write("malesef sizde bu eşya bulunmadığından kuşanamasınız\n");
                }
            }
            else
            {
                Console.Write("malesef sizde bu eşya bulunmadığından kuşanamasınız\n");
            }
        }

        public void KalkanİtemSatınalma(int ID)
        {
            ID--;
            int sinir = İtemKalkan.Count - 1;
            if (ID < sinir)
            {
                if (İtemKalkan[ID].kalkanFiyat < Gold)
                {
                    İtemKalkan[ID].kalkanİtemSayi++;
                    Gold -= İtemKalkan[ID].kalkanFiyat;
                    Console.WriteLine("Kuşanmak ister misin?\n[1]Evet, kuşan\n[2]Hayır, Kuşanma\nNe yapmak istiyorsun : ");
                    int Secim = Convert.ToInt32(Console.ReadLine());
                    if (Secim == 1)
                    {
                        ID++;
                        KalkanİtemKusanma(ID);
                    }
                    else { }
                    Console.WriteLine("{0} : {1}", İtemKalkan[ID].kalkanİtemİsim, İtemKalkan[ID].kalkanİtemSayi);
                }
                else
                {
                    Console.WriteLine("{0} isimli itemi almak için paranız yetmemektedir.", İtemKalkan[ID].kalkanİtemİsim);
                }
            }
            else
            {
                Console.WriteLine("Böyle bir item yoktur");
            }
        }
        #endregion
        #region Migfer
        public static int KusanmaMigferID { get; set; }
        public int kusanmaMigferID
        {
            get
            {
                return KusanmaMigferID;
            }
            set
            {
                KusanmaMigferID = value;
            }
        }
        public static int KusanmaMigfer { get; set; }
        public int kusanmaMigfer
        {
            get
            {
                return KusanmaMigfer;
            }
            set
            {
                KusanmaMigfer = value;
            }
        }

        public int migferİtemID { get; set; }
        public string migferİtemİsim { get; set; }
        public bool migferİtemKullanılma { get; set; }
        public int migferİtemSayi { get; set; }
        public int migferDegisecekDeger { get; set; }
        public int migferFiyat { get; set; }

        public static List<AnaBolme> İtemMigfer = new List<AnaBolme>()
        {
            new AnaBolme(){migferİtemID=0, migferİtemSayi=0,migferİtemKullanılma=false,migferİtemİsim="Eskimiş Miğfer",migferDegisecekDeger=10,migferFiyat=20 },
            new AnaBolme(){migferİtemID=1, migferİtemSayi=0,migferİtemKullanılma=false,migferİtemİsim="Klasik Miğfer",migferDegisecekDeger=15,migferFiyat=30 },
            new AnaBolme(){migferİtemID=2, migferİtemSayi=0,migferİtemKullanılma=false,migferİtemİsim="Kaliteli Miğfer",migferDegisecekDeger=20,migferFiyat=40 },
            new AnaBolme(){migferİtemID=3, migferİtemSayi=0,migferİtemKullanılma=false,migferİtemİsim="Dayanıklı Miğfer",migferDegisecekDeger=25,migferFiyat=50 },
            new AnaBolme(){migferİtemID=4, migferİtemSayi=1,migferİtemKullanılma=true,migferİtemİsim="Miğfersiz",migferDegisecekDeger=0 },
        };

        public void MigferİtemKusanma(int ID)
        {
            ID--;
            int sinir = İtemMigfer.Count;
            if (ID <= sinir)
            {
                if (İtemMigfer[ID].migferİtemSayi > 0)
                {
                    İtemMigfer[kusanmaMigferID].migferİtemKullanılma = false;
                    defance -= kusanmaMigfer;
                    kusanmaMigfer = İtemMigfer[ID].migferDegisecekDeger;
                    defance += kusanmaMigfer;
                    İtemMigfer[ID].migferİtemKullanılma = true;
                    kusanmaMigferID = ID;
                }
                else
                {
                    Console.Write("malesef sizde bu eşya bulunmadığından kuşanamasınız\n");
                }
            }
            else
            {
                Console.WriteLine("Böyle bir item yoktur");
            }
        }

        public void MigferİtemSatınalma(int ID)
        {
            ID--;
            int sinir = İtemMigfer.Count - 1;
            if (ID < sinir)
            {
                if (İtemMigfer[ID].migferFiyat < Gold)
                {
                    İtemMigfer[ID].migferİtemSayi++;
                    Gold -= İtemMigfer[ID].migferFiyat;
                    Console.WriteLine("Kuşanmak ister misin?\n[1]Evet, kuşan\n[2]Hayır, Kuşanma\nNe yapmak istiyorsun : ");
                    int Secim = Convert.ToInt32(Console.ReadLine());
                    if (Secim == 1)
                    {
                        ID++;
                        MigferİtemKusanma(ID);
                    }
                    else { }
                    Console.WriteLine("{0} : {1}", İtemMigfer[ID].migferİtemİsim, İtemMigfer[ID].migferİtemSayi);
                }
                else
                {
                    Console.WriteLine("{0} isimli itemi almak için paranız yetmemektedir.", İtemMigfer[ID].migferİtemİsim);
                }
            }
            else
            {
                Console.WriteLine("Böyle bir item yoktur");
            }
        }

        #endregion
        #region Govde Zirhi
        public static int KusanmaGZirhiID { get; set; }
        public int kusanmaGZirhiID
        {
            get
            {
                return KusanmaGZirhiID;
            }
            set
            {
                KusanmaGZirhiID = value;
            }
        }
        public static int KusanmaGZirhi { get; set; }
        public int kusanmaGZirhi
        {
            get
            {
                return KusanmaGZirhi;
            }
            set
            {
                KusanmaGZirhi = value;
            }
        }

        public int gZirhiİtemID { get; set; }
        public string gZirhiİtemİsim { get; set; }
        public bool gZirhiİtemKullanılma { get; set; }
        public int gZirhiİtemSayi { get; set; }
        public int gZirhiDegisecekDeger { get; set; }
        public int gZirhiFiyat { get; set; }

        public static List<AnaBolme> İtemGZirhi = new List<AnaBolme>()
        {
            new AnaBolme(){gZirhiİtemID=0, gZirhiİtemSayi=0,gZirhiİtemKullanılma=false,gZirhiİtemİsim="Hasarlı Gövde Zırhı",gZirhiDegisecekDeger=30,gZirhiFiyat=60 },
            new AnaBolme(){gZirhiİtemID=1, gZirhiİtemSayi=0,gZirhiİtemKullanılma=false,gZirhiİtemİsim="Klasik Gövde Zırhı",gZirhiDegisecekDeger=40,gZirhiFiyat=80 },
            new AnaBolme(){gZirhiİtemID=2, gZirhiİtemSayi=0,gZirhiİtemKullanılma=false,gZirhiİtemİsim="Kaliteli Gövde Zırhı",gZirhiDegisecekDeger=50,gZirhiFiyat=100 },
            new AnaBolme(){gZirhiİtemID=3, gZirhiİtemSayi=0,gZirhiİtemKullanılma=false,gZirhiİtemİsim="Dayanıklı Gövde Zırhı",gZirhiDegisecekDeger=60,gZirhiFiyat=120 },
            new AnaBolme(){gZirhiİtemID=4, gZirhiİtemSayi=1,gZirhiİtemKullanılma=true,gZirhiİtemİsim="Gövde Zırhsız",gZirhiDegisecekDeger=0 },
        };

        public void GZirhiİtemKusanma(int ID)
        {
            ID--;
            int sinir = İtemMigfer.Count;
            if (ID <= sinir)
            {
                if (İtemGZirhi[ID].gZirhiİtemSayi > 0)
                {
                    İtemGZirhi[kusanmaGZirhiID].gZirhiİtemKullanılma = false;
                    defance -= kusanmaGZirhi;
                    kusanmaGZirhi = İtemGZirhi[ID].gZirhiDegisecekDeger;
                    defance += kusanmaGZirhi;
                    İtemGZirhi[ID].gZirhiİtemKullanılma = true;
                    kusanmaGZirhiID = ID;
                }
                else
                {
                    Console.Write("malesef sizde bu eşya bulunmadığından kuşanamasınız\n");
                }
            }
            else
            {
                Console.WriteLine("Böyle bir item yoktur");
            }
        }

        public void GZirhiİtemSatınalma(int ID)
        {
            ID--;
            int sinir = İtemGZirhi.Count - 1;
            if (ID < sinir)
            {
                if (İtemGZirhi[ID].gZirhiFiyat < Gold)
                {
                    İtemGZirhi[ID].gZirhiİtemSayi++;
                    Gold -= İtemGZirhi[ID].gZirhiFiyat;
                    Console.WriteLine("Kuşanmak ister misin?\n[1]Evet, kuşan\n[2]Hayır, Kuşanma\nNe yapmak istiyorsun : ");
                    int Secim = Convert.ToInt32(Console.ReadLine());
                    if (Secim == 1)
                    {
                        ID++;
                        GZirhiİtemKusanma(ID);
                    }
                    else { }
                    Console.WriteLine("{0} : {1}", İtemGZirhi[ID].gZirhiİtemİsim, İtemGZirhi[ID].gZirhiİtemSayi);
                }
                else
                {
                    Console.WriteLine("{0} isimli itemi almak için paranız yetmemektedir.", İtemGZirhi[ID].gZirhiİtemİsim);
                }
            }
            else
            {
                Console.WriteLine("Böyle bir item yoktur");
            }
        }

        #endregion
        #region Bacak Zirhi
        public static int KusanmaBZirhiID { get; set; }
        public int kusanmaBZirhiID
        {
            get
            {
                return KusanmaBZirhiID;
            }
            set
            {
                KusanmaBZirhiID = value;
            }
        }
        public static string KusanmaBZirhiİsim { get; set; }
        public string kusanmaBZirhiİsim
        {
            get
            {
                return KusanmaBZirhiİsim;
            }
            set
            {
                KusanmaBZirhiİsim = value;
            }
        }
        public static int KusanmaBZirhi { get; set; }
        public int kusanmaBZirhi
        {
            get
            {
                return KusanmaBZirhi;
            }
            set
            {
                KusanmaBZirhi = value;
            }
        }


        public int bZirhiİtemID { get; set; }
        public string bZirhiİtemİsim { get; set; }
        public bool bZirhiİtemKullanılma { get; set; }
        public int bZirhiİtemSayi { get; set; }
        public int bZirhiDegisecekDeger { get; set; }
        public int bZirhiFiyat { get; set; }

        public static List<AnaBolme> İtemBZirhi = new List<AnaBolme>()
        {
            new AnaBolme(){bZirhiİtemID=0, bZirhiİtemSayi=0,bZirhiİtemKullanılma=false,bZirhiİtemİsim="Parçalanmış Bacak Zırhı",bZirhiDegisecekDeger=5,bZirhiFiyat=10 },
            new AnaBolme(){bZirhiİtemID=1, bZirhiİtemSayi=0,bZirhiİtemKullanılma=false,bZirhiİtemİsim="Klasik Bacak Zırhı",bZirhiDegisecekDeger=10,bZirhiFiyat=20 },
            new AnaBolme(){bZirhiİtemID=2, bZirhiİtemSayi=0,bZirhiİtemKullanılma=false,bZirhiİtemİsim="Kaliteli Bacak Zırhı",bZirhiDegisecekDeger=15,bZirhiFiyat=30 },
            new AnaBolme(){bZirhiİtemID=3, bZirhiİtemSayi=0,bZirhiİtemKullanılma=false,bZirhiİtemİsim="Dayanıklı Bacak Zırhı",bZirhiDegisecekDeger=20,bZirhiFiyat=40 },
            new AnaBolme(){bZirhiİtemID=4, bZirhiİtemSayi=1,bZirhiİtemKullanılma=true,bZirhiİtemİsim="Bacak Zırhsız",bZirhiDegisecekDeger=0 },

        };

        public void BZirhiİtemKusanma(int ID)
        {
            ID--;
            int sinir = İtemBZirhi.Count;
            if (ID <= sinir)
            {
                if (İtemBZirhi[ID].bZirhiİtemSayi > 0)
                {
                    İtemBZirhi[kusanmaBZirhiID].bZirhiİtemKullanılma = false;
                    damage -= kusanmaBZirhi;
                    kusanmaBZirhi = İtemBZirhi[ID].bZirhiDegisecekDeger;
                    damage += kusanmaBZirhi;
                    kusanmaBZirhiİsim = İtemBZirhi[ID].bZirhiİtemİsim;
                    İtemBZirhi[ID].bZirhiİtemKullanılma = true;
                    kusanmaBZirhiID = ID;
                }
                else
                {
                    Console.Write("malesef sizde bu eşya bulunmadığından kuşanamasınız\n");
                }
            }
            else
            {
                Console.WriteLine("Böyle bir item yoktur");
            }
        }

        public void BZirhiİtemSatınalma(int ID)
        {
            ID--;
            int sinir = İtemBZirhi.Count - 1;
            if (ID < sinir)
            {
                if (İtemBZirhi[ID].bZirhiFiyat < Gold)
                {
                    İtemBZirhi[ID].bZirhiİtemSayi++;
                    Gold -= İtemBZirhi[ID].bZirhiFiyat;
                    Console.WriteLine("Kuşanmak ister misin?\n[1]Evet, kuşan\n[2]Hayır, Kuşanma\nNe yapmak istiyorsun : ");
                    int Secim = Convert.ToInt32(Console.ReadLine());
                    if (Secim == 1)
                    {
                        ID++;
                        BZirhiİtemKusanma(ID);
                    }
                    else { }
                    Console.WriteLine("{0} : {1}", İtemBZirhi[ID].bZirhiİtemİsim, İtemBZirhi[ID].bZirhiİtemSayi);
                }
                else
                {
                    Console.WriteLine("{0} isimli itemi almak için paranız yetmemektedir.", İtemBZirhi[ID].bZirhiİtemİsim);
                }
            }
            else
            {
                Console.WriteLine("Böyle bir item yoktur");
            }
        }

        #endregion
        #region Kol Zirhi
        public static int KusanmaKZirhiID { get; set; }
        public int kusanmaKZirhiID
        {
            get
            {
                return KusanmaKZirhiID;
            }
            set
            {
                KusanmaKZirhiID = value;
            }
        }
        public static string KusanmaKZirhiİsim { get; set; }
        public string kusanmaKZirhiİsim
        {
            get
            {
                return KusanmaKZirhiİsim;
            }
            set
            {
                KusanmaKZirhiİsim = value;
            }
        }
        public static int KusanmaKZirhi { get; set; }
        public int kusanmaKZirhi
        {
            get
            {
                return KusanmaKZirhi;
            }
            set
            {
                KusanmaKZirhi = value;
            }
        }

        public int kZirhiİtemID { get; set; }
        public string kZirhiİtemİsim { get; set; }
        public bool kZirhiİtemKullanılma { get; set; }
        public int kZirhiİtemSayi { get; set; }
        public int kZirhiDegisecekDeger { get; set; }
        public int kZirhiFiyat { get; set; }

        public static List<AnaBolme> İtemKZirhi = new List<AnaBolme>()
        {
            new AnaBolme(){kZirhiİtemID=0, kZirhiİtemSayi=0,kZirhiİtemKullanılma=false,kZirhiİtemİsim="Paslanmış Kol Zırhı",kZirhiDegisecekDeger=5,kZirhiFiyat=10 },
            new AnaBolme(){kZirhiİtemID=1, kZirhiİtemSayi=0,kZirhiİtemKullanılma=false,kZirhiİtemİsim="Klasik Kol Zırhı",kZirhiDegisecekDeger=10,kZirhiFiyat=20 },
            new AnaBolme(){kZirhiİtemID=2, kZirhiİtemSayi=0,kZirhiİtemKullanılma=false,kZirhiİtemİsim="Kaliteli Kol Zırhı",kZirhiDegisecekDeger=15,kZirhiFiyat=30 },
            new AnaBolme(){kZirhiİtemID=3, kZirhiİtemSayi=0,kZirhiİtemKullanılma=false,kZirhiİtemİsim="Sağlam Kol Zırhı",kZirhiDegisecekDeger=20,kZirhiFiyat=40 },
            new AnaBolme(){kZirhiİtemID=4, kZirhiİtemSayi=1,kZirhiİtemKullanılma=true,kZirhiİtemİsim="Kol Zırhsız",kZirhiDegisecekDeger=0 },

        };

        public void KZirhiİtemKusanma(int ID)
        {
            ID--;
            int sinir = İtemKZirhi.Count;
            if (ID <= sinir)
            {
                if (İtemKZirhi[ID].kZirhiİtemSayi > 0)
                {
                    İtemKZirhi[kusanmaKZirhiID].kZirhiİtemKullanılma = false;
                    defance -= kusanmaKZirhi;
                    kusanmaKZirhi = İtemKZirhi[ID].kZirhiDegisecekDeger;
                    damage += kusanmaKZirhi;
                    kusanmaKZirhiİsim = İtemKZirhi[ID].kZirhiİtemİsim;
                    İtemKZirhi[ID].kZirhiİtemKullanılma = true;
                    kusanmaKZirhiID = ID;
                }
                else
                {
                    Console.Write("malesef sizde bu eşya bulunmadığından kuşanamasınız\n");
                }
            }
            else
            {
                Console.Write("malesef sizde bu eşya bulunmadığından kuşanamasınız\n");
            }
        }

        public void KZirhiİtemSatınalma(int ID)
        {
            ID--;
            int sinir = İtemKZirhi.Count - 1;
            if (ID < sinir)
            {
                if (İtemKZirhi[ID].kZirhiFiyat < Gold)
                {
                    İtemKZirhi[ID].kZirhiİtemSayi++;
                    Gold -= İtemKZirhi[ID].kZirhiFiyat;
                    Console.WriteLine("Kuşanmak ister misin?\n[1]Evet, kuşan\n[2]Hayır, Kuşanma\nNe yapmak istiyorsun : ");
                    int Secim = Convert.ToInt32(Console.ReadLine());
                    if (Secim == 1)
                    {
                        ID++;
                        KZirhiİtemKusanma(ID);
                    }
                    else { }
                    Console.WriteLine("{0} : {1}", İtemKZirhi[ID].kZirhiİtemİsim, İtemKZirhi[ID].kZirhiİtemSayi);
                }
                else
                {
                    Console.WriteLine("{0} isimli itemi almak için paranız yetmemektedir.", İtemKZirhi[ID].kZirhiİtemİsim);
                }
            }
            else
            {
                Console.WriteLine("Böyle bir item yoktur");
            }
        }

        #endregion
        #region Eldiven
        public static int KusanmaEldivenID { get; set; }
        public int kusanmaEldivenID
        {
            get
            {
                return KusanmaEldivenID;
            }
            set
            {
                KusanmaEldivenID = value;
            }
        }
        public static string KusanmaEldivenİsim { get; set; }
        public string kusanmaEldivenİsim
        {
            get
            {
                return KusanmaEldivenİsim;
            }
            set
            {
                KusanmaEldivenİsim = value;
            }
        }
        public static int KusanmaEldiven { get; set; }
        public int kusanmaEldiven
        {
            get
            {
                return KusanmaEldiven;
            }
            set
            {
                KusanmaEldiven = value;
            }
        }

        public int eldivenİtemID { get; set; }
        public string eldivenİtemİsim { get; set; }
        public bool eldivenİtemKullanılma { get; set; }
        public int eldivenİtemSayi { get; set; }
        public int eldivenDegisecekDeger { get; set; }
        public int eldivenFiyat { get; set; }

        public static List<AnaBolme> İtemEldiven = new List<AnaBolme>()
        {
            new AnaBolme(){eldivenİtemID=0, eldivenİtemSayi=0,eldivenİtemKullanılma=false,eldivenİtemİsim="Yün Eldiven",eldivenDegisecekDeger=5,eldivenFiyat=10 },
            new AnaBolme(){eldivenİtemID=1, eldivenİtemSayi=0,eldivenİtemKullanılma=false,eldivenİtemİsim="Deri Eldiven",eldivenDegisecekDeger=10,eldivenFiyat=20 },
            new AnaBolme(){eldivenİtemID=2, eldivenİtemSayi=0,eldivenİtemKullanılma=false,eldivenİtemİsim="Kaliteli Eldiven",eldivenDegisecekDeger=15,eldivenFiyat=30 },
            new AnaBolme(){eldivenİtemID=3, eldivenİtemSayi=0,eldivenİtemKullanılma=false,eldivenİtemİsim="Ağır Eldiven",eldivenDegisecekDeger=20,eldivenFiyat=40 },
            new AnaBolme(){eldivenİtemID=4, eldivenİtemSayi=1,eldivenİtemKullanılma=true,eldivenİtemİsim="Eldivensiz",eldivenDegisecekDeger=0 },
        };

        public void EldivenİtemKusanma(int ID)
        {
            ID--;
            int sinir = İtemEldiven.Count;
            if (ID <= sinir)
            {
                if (İtemEldiven[ID].eldivenİtemSayi > 0)
                {
                    İtemEldiven[kusanmaEldivenID].eldivenİtemKullanılma = false;
                    damage -= kusanmaEldiven;
                    kusanmaEldiven = İtemEldiven[ID].eldivenDegisecekDeger;
                    damage += kusanmaEldiven;
                    kusanmaEldivenİsim = İtemEldiven[ID].eldivenİtemİsim;
                    İtemEldiven[ID].eldivenİtemKullanılma = true;
                    kusanmaEldivenID = ID;
                }
                else
                {
                    Console.Write("malesef sizde bu eşya bulunmadığından kuşanamasınız\n");
                }
            }
            else
            {
                Console.WriteLine("Böyle bir item yoktur");
            }
        }

        public void EldivenİtemSatınalma(int ID)
        {
            ID--;
            int sinir = İtemEldiven.Count - 1;
            if (ID < sinir)
            {
                if (İtemEldiven[ID].eldivenFiyat < Gold)
                {
                    İtemEldiven[ID].eldivenİtemSayi++;
                    Gold -= İtemEldiven[ID].eldivenFiyat;
                    Console.WriteLine("Kuşanmak ister misin?\n[1]Evet, kuşan\n[2]Hayır, Kuşanma\nNe yapmak istiyorsun : ");
                    int Secim = Convert.ToInt32(Console.ReadLine());
                    if (Secim == 1)
                    {
                        ID++;
                        EldivenİtemKusanma(ID);
                    }
                    else { }
                    Console.WriteLine("{0} : {1}", İtemEldiven[ID].eldivenİtemİsim, İtemEldiven[ID].eldivenİtemSayi);
                }
                else
                {
                    Console.WriteLine("{0} isimli itemi almak için paranız yetmemektedir.", İtemEldiven[ID].eldivenİtemİsim);
                }
            }
            else
            {
                Console.WriteLine("Böyle bir item yoktur");
            }
        }

        #endregion
        #region Bot
        public static int KusanmaBotID { get; set; }
        public int kusanmaBotID
        {
            get
            {
                return KusanmaBotID;
            }
            set
            {
                KusanmaBotID = value;
            }
        }
        public static string KusanmaBotİsim { get; set; }
        public string kusanmaBotİsim
        {
            get
            {
                return KusanmaBotİsim;
            }
            set
            {
                KusanmaBotİsim = value;
            }
        }
        public static int KusanmaBot { get; set; }
        public int kusanmaBot
        {
            get
            {
                return KusanmaBot;
            }
            set
            {
                KusanmaBot = value;
            }
        }

        public int botİtemID { get; set; }
        public string botİtemİsim { get; set; }
        public bool botİtemKullanılma { get; set; }
        public int botİtemSayi { get; set; }
        public int botDegisecekDeger { get; set; }
        public int botFiyat { get; set; }

        public static List<AnaBolme> İtemBot = new List<AnaBolme>()
        {
            new AnaBolme(){botİtemID=0, botİtemSayi=0,botİtemKullanılma=false,botİtemİsim="Yün Bot",botDegisecekDeger=10,botFiyat=20 },
            new AnaBolme(){botİtemID=1, botİtemSayi=0,botİtemKullanılma=false,botİtemİsim="Klasik Bot",botDegisecekDeger=15,botFiyat=30 },
            new AnaBolme(){botİtemID=2, botİtemSayi=0,botİtemKullanılma=false,botİtemİsim="Sağlam Bot",botDegisecekDeger=20,botFiyat=40 },
            new AnaBolme(){botİtemID=3, botİtemSayi=0,botİtemKullanılma=false,botİtemİsim="Dayanıklı Bot",botDegisecekDeger=25,botFiyat=50 },
            new AnaBolme(){botİtemID=4, botİtemSayi=1,botİtemKullanılma=true,botİtemİsim="botsuz",botDegisecekDeger=0},
        };

        public void BotİtemKusanma(int ID)
        {
            ID--;
            int sinir = İtemBot.Count;
            if (ID <= sinir)
            {
                if (İtemBot[ID].botİtemSayi > 0)
                {
                    İtemBot[kusanmaBotID].botİtemKullanılma = false;
                    damage -= kusanmaBot;
                    kusanmaBot = İtemBot[ID].botDegisecekDeger;
                    damage += kusanmaBot;
                    kusanmaBotİsim = İtemBot[ID].botİtemİsim;
                    İtemBot[ID].botİtemKullanılma = true;
                    kusanmaBotID = ID;
                }
                else
                {
                    Console.Write("malesef sizde bu eşya bulunmadığından kuşanamasınız\n");
                }
            }
            else
            {
                Console.WriteLine("Böyle bir item yoktur");
            }
        }

        public void BotİtemSatınalma(int ID)
        {
            ID--;
            int sinir = İtemBot.Count - 1;
            if (ID < sinir)
            {
                if (İtemBot[ID].botFiyat < Gold)
                {
                    İtemBot[ID].botİtemSayi++;
                    Gold -= İtemBot[ID].botFiyat;
                    Console.WriteLine("Kuşanmak ister misin?\n[1]Evet, kuşan\n[2]Hayır, Kuşanma\nNe yapmak istiyorsun : ");
                    int Secim = Convert.ToInt32(Console.ReadLine());
                    if (Secim == 1)
                    {
                        ID++;
                        BotİtemKusanma(ID);
                    }
                    else { }
                    Console.WriteLine("{0} : {1}", İtemBot[ID].botİtemİsim, İtemBot[ID].botİtemSayi);
                }
                else
                {
                    Console.WriteLine("{0} isimli itemi almak için paranız yetmemektedir.", İtemBot[ID].botİtemİsim);
                }
            }
            else
            {
                Console.WriteLine("Böyle bir item yoktur");
            }
        }

        #endregion
        #region Kolye
        public static int KusanmaKolyeID { get; set; }
        public int kusanmaKolyeID
        {
            get
            {
                return KusanmaKolyeID;
            }
            set
            {
                KusanmaKolyeID = value;
            }
        }
        public static int KusanmaKolye { get; set; }
        public int kusanmaKolye
        {
            get
            {
                return KusanmaKolye;
            }
            set
            {
                KusanmaKolye = value;
            }
        }

        public int kolyeİtemID { get; set; }
        public string kolyeİtemİsim { get; set; }
        public bool kolyeİtemKullanılma { get; set; }
        public int kolyeİtemSayi { get; set; }
        public int kolyeDegisecekDeger { get; set; }
        public int kolyeFiyat { get; set; }

        public static List<AnaBolme> İtemKolye = new List<AnaBolme>()
        {
            new AnaBolme(){kolyeİtemID=0, kolyeİtemSayi=0,kolyeİtemKullanılma=false,kolyeİtemİsim="Bronz Kolye",kolyeFiyat=50 },
            new AnaBolme(){kolyeİtemID=1, kolyeİtemSayi=0,kolyeİtemKullanılma=false,kolyeİtemİsim="Altın Kolye",kolyeFiyat=100 },
            new AnaBolme(){kolyeİtemID=2, kolyeİtemSayi=0,kolyeİtemKullanılma=false,kolyeİtemİsim="Elmas Kolye",kolyeFiyat=200 },
            new AnaBolme(){kolyeİtemID=3, kolyeİtemSayi=1,kolyeİtemKullanılma=true,kolyeİtemİsim="Kolyesiz" },

        };

        public void KolyeİtemKusanma(int ID)
        {
            ID--;
            int sinir = İtemKolye.Count;
            if (ID <= sinir)
            {
                if (İtemKolye[ID].kolyeİtemSayi > 0)
                {
                    İtemKolye[kusanmaKolyeID].kolyeİtemKullanılma = false;
                    //damage -= kusanma;
                    //kusanma = İtemKolye[ID].kolyeDegisecekDeger;
                    //damage += kusanma;
                    İtemKolye[ID].kolyeİtemKullanılma = true;
                    kusanmaKolyeID = ID;
                }
                else
                {
                    Console.Write("malesef sizde bu eşya bulunmadığından kuşanamasınız\n");
                }
            }
            else
            {
                Console.Write("malesef sizde bu eşya bulunmadığından kuşanamasınız\n");
            }
        }

        public void KolyeİtemSatınalma(int ID)
        {
            ID--;
            int sinir = İtemKolye.Count - 1;
            if (ID < sinir)
            {
                if (İtemKolye[ID].kolyeFiyat < Gold)
                {
                    İtemKolye[ID].kolyeİtemSayi++;
                    Gold -= İtemKolye[ID].kolyeFiyat;
                    Console.WriteLine("Kuşanmak ister misin?\n[1]Evet, kuşan\n[2]Hayır, Kuşanma\nNe yapmak istiyorsun : ");
                    int Secim = Convert.ToInt32(Console.ReadLine());
                    if (Secim == 1)
                    {
                        ID++;
                        KolyeİtemKusanma(ID);
                    }
                    else { }
                    Console.WriteLine("{0} : {1}", İtemKolye[ID].kolyeİtemİsim, İtemKolye[ID].kolyeİtemSayi);
                }
                else
                {
                    Console.WriteLine("{0} isimli itemi almak için paranız yetmemektedir.", İtemKolye[ID].kolyeİtemİsim);
                }
            }
            else
            {
                Console.WriteLine("Böyle bir item yoktur");
            }
        }

        #endregion
        #region Bilezik
        public static int KusanmaBilezikID { get; set; }
        public int kusanmaBilezikID
        {
            get
            {
                return KusanmaBilezikID;
            }
            set
            {
                KusanmaBilezikID = value;
            }
        }
        public static int KusanmaBilezik { get; set; }
        public int kusanmaBilezik
        {
            get
            {
                return KusanmaBilezik;
            }
            set
            {
                KusanmaBilezik = value;
            }
        }

        public int bilezikİtemID { get; set; }
        public string bilezikİtemİsim { get; set; }
        public bool bilezikİtemKullanılma { get; set; }
        public int bilezikİtemSayi { get; set; }
        public int bilezikDegisecekDeger { get; set; }
        public int bilezikFiyat { get; set; }

        public static List<AnaBolme> İtemBilezik = new List<AnaBolme>() {
        new AnaBolme() { bilezikİtemID = 0, bilezikİtemSayi = 0,bilezikİtemKullanılma = false,bilezikİtemİsim = "Bronz Bileklik",bilezikFiyat=50 },
        new AnaBolme() { bilezikİtemID = 1, bilezikİtemSayi = 0,bilezikİtemKullanılma = false,bilezikİtemİsim = "Altın Bileklik",bilezikFiyat=100 },
        new AnaBolme() { bilezikİtemID = 2, bilezikİtemSayi = 0,bilezikİtemKullanılma = false,bilezikİtemİsim = "Elmas Bileklik",bilezikFiyat=200 },
        new AnaBolme() { bilezikİtemID = 3, bilezikİtemSayi = 1,bilezikİtemKullanılma = true,bilezikİtemİsim = "Bİlekliksiz" },
        };

        public void BilezikİtemKusanma(int ID)
        {
            ID--;
            int sinir = İtemBilezik.Count;
            if (ID <= sinir)
            {
                if (İtemBilezik[ID].bilezikİtemSayi > 0)
                {
                    İtemBilezik[kusanmaBilezikID].bilezikİtemKullanılma = false;
                    //damage -= kusanma;
                    //kusanma = İtemBilezik[ID].bilezikDegisecekDeger;
                    //damage += kusanma;
                    İtemBilezik[ID].bilezikİtemKullanılma = true;
                    kusanmaBilezikID = ID;
                }
                else
                {
                    Console.Write("malesef sizde bu eşya bulunmadığından kuşanamasınız\n");
                }
            }
            else
            {
                Console.WriteLine("Böyle bir item yoktur");
            }
        }

        public void BİlezikİtemSatınalma(int ID)
        {
            ID--;
            int sinir = İtemBilezik.Count - 1;
            if (ID < sinir)
            {
                if (İtemBilezik[ID].bilezikFiyat < Gold)
                {
                    İtemBilezik[ID].bilezikİtemSayi++;
                    Gold -= İtemBilezik[ID].bilezikFiyat;
                    Console.WriteLine("Kuşanmak ister misin?\n[1]Evet, kuşan\n[2]Hayır, Kuşanma\nNe yapmak istiyorsun : ");
                    int Secim = Convert.ToInt32(Console.ReadLine());
                    if (Secim == 1)
                    {
                        ID++;
                        BilezikİtemKusanma(ID);
                    }
                    else { }
                    Console.WriteLine("{0} : {1}", İtemBilezik[ID].bilezikİtemİsim, İtemBilezik[ID].bilezikİtemSayi);
                }
                else
                {
                    Console.WriteLine("{0} isimli itemi almak için paranız yetmemektedir.", İtemBilezik[ID].bilezikİtemİsim);
                }
            }
            else
            {
                Console.WriteLine("Böyle bir item yoktur");
            }
        }

        #endregion
        #region Yuzuk
        public static int KusanmaYuzukID { get; set; }
        public int kusanmaYuzukID
        {
            get
            {
                return KusanmaYuzukID;
            }
            set
            {
                KusanmaYuzukID = value;
            }
        }
        public static int KusanmaYuzuk { get; set; }
        public int kusanmaYuzuk
        {
            get
            {
                return KusanmaYuzuk;
            }
            set
            {
                KusanmaYuzuk = value;
            }
        }

        public int yuzukİtemID { get; set; }
        public string yuzukİtemİsim { get; set; }
        public bool yuzukİtemKullanılma { get; set; }
        public int yuzukİtemSayi { get; set; }
        public int yuzukDegisecekDeger { get; set; }
        public int yuzukFiyat { get; set; }

        public static List<AnaBolme> İtemYuzuk = new List<AnaBolme>()
        {
            new AnaBolme(){yuzukİtemID=0, yuzukİtemSayi=0,yuzukİtemKullanılma=false,yuzukİtemİsim="Bronz Yüzük",yuzukFiyat=50 },
            new AnaBolme(){yuzukİtemID=1, yuzukİtemSayi=0,yuzukİtemKullanılma=false,yuzukİtemİsim="Altın Yüzük",yuzukFiyat=100 },
            new AnaBolme(){yuzukİtemID=2, yuzukİtemSayi=0,yuzukİtemKullanılma=false,yuzukİtemİsim="Elmas Yüzük",yuzukFiyat=200 },
            new AnaBolme(){yuzukİtemID=3, yuzukİtemSayi=1,yuzukİtemKullanılma=true,yuzukİtemİsim="yüzüksüz"},
        };

        public void YuzukİtemKusanma(int ID)
        {
            ID--;
            int sinir = İtemYuzuk.Count;
            if (ID <= sinir)
            {
                if (İtemYuzuk[ID].yuzukİtemSayi > 0)
                {
                    İtemYuzuk[kusanmaYuzukID].yuzukİtemKullanılma = false;
                    //damage -= kusanma;
                    //kusanma = İtemYuzuk[ID].yuzukDegisecekDeger;
                    //damage += kusanma;
                    İtemYuzuk[ID].yuzukİtemKullanılma = true;
                    kusanmaYuzukID = ID;
                }
                else
                {
                    Console.Write("malesef sizde bu eşya bulunmadığından kuşanamasınız\n");
                }
            }
            else
            {
                Console.WriteLine("Böyle bir item yoktur");
            }
        }

        public void YuzukİtemSatınalma(int ID)
        {
            ID--;
            int sinir = İtemYuzuk.Count - 1;
            if (ID < sinir)
            {
                if (İtemYuzuk[ID].yuzukFiyat < Gold)
                {
                    İtemYuzuk[ID].yuzukİtemSayi++;
                    Gold -= İtemYuzuk[ID].yuzukFiyat;
                    Console.WriteLine("Kuşanmak ister misin?\n[1]Evet, kuşan\n[2]Hayır, Kuşanma\nNe yapmak istiyorsun : ");
                    int Secim = Convert.ToInt32(Console.ReadLine());
                    if (Secim == 1)
                    {
                        ID++;
                        YuzukİtemKusanma(ID);
                    }
                    else { }
                    Console.WriteLine("{0} : {1}", İtemYuzuk[ID].yuzukİtemİsim, İtemYuzuk[ID].yuzukİtemSayi);
                }
                else
                {
                    Console.WriteLine("{0} isimli itemi almak için paranız yetmemektedir.", İtemYuzuk[ID].yuzukİtemİsim);
                }
            }
            else
            {
                Console.WriteLine("Böyle bir item yoktur");
            }
        }

        #endregion
        #region Kupe
        public static int KusanmaKupeID { get; set; }
        public int kusanmaKupeID
        {
            get
            {
                return KusanmaKupeID;
            }
            set
            {
                KusanmaKupeID = value;
            }
        }
        public static int KusanmaKupe { get; set; }
        public int kusanmaKupe
        {
            get
            {
                return KusanmaKupe;
            }
            set
            {
                KusanmaKupe = value;
            }
        }

        public int kupeİtemID { get; set; }
        public string kupeİtemİsim { get; set; }
        public bool kupeİtemKullanılma { get; set; }
        public int kupeİtemSayi { get; set; }
        public int kupeDegisecekDeger { get; set; }
        public int kupeFiyat { get; set; }

        public static List<AnaBolme> İtemKupe = new List<AnaBolme>()
        {
            new AnaBolme(){kupeİtemID=0, kupeİtemSayi=0,kupeİtemKullanılma=false,kupeİtemİsim="Bronz Küpe",kupeFiyat=50},
            new AnaBolme(){kupeİtemID=1, kupeİtemSayi=0,kupeİtemKullanılma=false,kupeİtemİsim="Altın Küpe",kupeFiyat=100 },
            new AnaBolme(){kupeİtemID=2, kupeİtemSayi=0,kupeİtemKullanılma=false,kupeİtemİsim="Elmas Küpe",kupeFiyat=200 },
            new AnaBolme(){kupeİtemID=3, kupeİtemSayi=1,kupeİtemKullanılma=true,kupeİtemİsim="Küpesiz"},
        };

        public void KupeİtemKusanma(int ID)
        {
            ID--;
            int sinir = İtemKupe.Count;
            if (ID <= sinir)
            {
                if (İtemKupe[ID].kupeİtemSayi > 0)
                {
                    İtemKupe[kusanmaKupeID].kupeİtemKullanılma = false;
                    //damage -= kusanma;
                    //kusanma = İtemKupe[ID].kupeDegisecekDeger;
                    //damage += kusanma;
                    İtemKupe[ID].kupeİtemKullanılma = true;
                    kusanmaKupeID = ID;
                }
                else
                {
                    Console.Write("malesef sizde bu eşya bulunmadığından kuşanamasınız\n");
                }
            }
            else
            {
                Console.WriteLine("Böyle bir item yoktur");
            }
        }

        public void KupeİtemSatınalma(int ID)
        {
            ID--;
            int sinir = İtemKupe.Count - 1;
            if (ID < sinir)
            {
                if (İtemKupe[ID].kupeFiyat < Gold)
                {
                    İtemKupe[ID].kupeİtemSayi++;
                    Gold -= İtemKupe[ID].kupeFiyat;
                    Console.WriteLine("Kuşanmak ister misin?\n[1]Evet, kuşan\n[2]Hayır, Kuşanma\nNe yapmak istiyorsun : ");
                    int Secim = Convert.ToInt32(Console.ReadLine());
                    if (Secim == 1)
                    {
                        ID++;
                        KupeİtemKusanma(ID);
                    }
                    else { }
                    Console.WriteLine("{0} : {1}", İtemKupe[ID].kupeİtemİsim, İtemKupe[ID].kupeİtemSayi);
                }
                else
                {
                    Console.WriteLine("{0} isimli itemi almak için paranız yetmemektedir.", İtemKupe[ID].kupeİtemİsim);
                }
            }
            else
            {
                Console.WriteLine("Böyle bir item yoktur");
            }
        }

        #endregion
        #region Template
        /*public static int Kusanma..ID { get; set; }
        public int kusanma..ID
        {
            get
            {
                return Kusanma..ID;
            }
            set
            {
                Kusanma..ID = value;
            }
        }
        public static int Kusanma.. { get; set; }
        public int kusanma..
        {
            get
            {
                return Kusanma..;
            }
            set
            {
                Kusanma.. = value;
            }
        }*/

        /*public int ..İtemID { get; set; }
          public string ..İtemİsim { get; set; }
          public bool ..İtemKullanılma { get; set; }
          public int ..İtemSayi { get; set; }
          public int ..DegisecekDeger { get; set; }
          public int ..Fiyat{ get; set; }
          */

        /*public static List<AnaBolme> İtem = new List<AnaBolme>()

        new AnaBolme(){itemID=, itemSayi=0,itemKullanılma=false,itemİsim="",DegisecekDeger= },
        */

        /*public void İtemKusanma(int ID)
        {
            ID--;
            int sinir = İtem.Count;
            if (ID <= sinir)
            {
                int sinir = İtem.Count-1;
                if (itemTablo[ID].İtemSayi > 0)
                {
                    itemTablo[kusanmaID].İtemKullanılma = false;
                    damage -= kusanmaHasar;
                    kusanmaHasar = itemTablo[ID].DegisecekDeger;
                    damage += kusanmaHasar;
                    kusanmaİsim = itemTablo[ID].İtemİsim;
                    itemTablo[ID].İtemKullanılma = true;
                    kusanmaID = ID;
                }
                else
                {
                    Console.Write("malesef sizde bu eşya bulunmadığından kuşanamasınız\n");
                }
            }
            else
            {
                Console.WriteLine("Böyle bir item yoktur");
            }
        }*/

        /* public void İtemSatınalma(int ID)
        {
            ID--;
            int sinir = İtem.Count - 1;
            if (ID < sinir)
            {
                if (İtem[ID].Fiyat < Gold)
                {
                    İtem[ID].İtemSayi++;
                    Gold -= İtem[ID].Fiyat;
                    Console.WriteLine("Kuşanmak ister misin?\n[1]Evet, kuşan\n[2]Hayır, Kuşanma\nNe yapmak istiyorsun : ");
                    int Secim = Convert.ToInt32(Console.ReadLine());
                    if (Secim == 1)
                    {
                        İtemKusanma(ID);
                    }
                    else { }
                    Console.WriteLine("{0} : {1}", İtem[ID].İtemİsim, İtem[ID].İtemSayi);
                }
                else
                {
                    Console.WriteLine("{0} isimli itemi almak için paranız yetmemektedir.", İtem[ID].İtemİsim);
                }
            }
            else
            {
                Console.WriteLine("Böyle bir item yoktur");
            }
        }
        */

        #endregion
        #endregion
    }
}
