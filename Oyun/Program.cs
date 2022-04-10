using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oyun
{
    class Program
    {
        static void Main(string[] args)
        {
            int gidilecek;

            int arenaSecim, dMCan, dCan, dDefance, dSaldiri;

            int askSecim;

            int ormanSecim;

            int bMagaraSecim;

            double lMExperience;

            AnaBolme AnaBolme = new AnaBolme();
            Giris Giris = new Giris();
            Arena Arena = new Arena();
            AskCesmesi AskCesmesi = new AskCesmesi();
            Orman Orman = new Orman();
            buyucuMagarası buyucuMagarası = new buyucuMagarası();

            Random rnd = new Random();

            Hasen HG = new Hasen();

            //G1.Gİsim();
            //G1.Gmeslek();
            //G1.GYetenek();



            for (int day = 1; AnaBolme.Health > 0; day++)
            {
                for (int hızDay = 0; hızDay <= (AnaBolme.Speed / 100) && AnaBolme.Health > 0; hızDay++)
                {
                    Console.Write("{0}.gün\nİsim : {1}\nMeslek : {2}\nHasar : {3}\nCan : {4}/{5}\nOkçuluk Yeteneği : {6}\nTahmin Yeteneği : {7}\nBüyü Yeteneği : {8}\nHız : {9}\nDayanıklılık : {10}/{11}\nHırsızlık Yeteneği : {12}\nSaklanma Yeteneği : {13}\nAltın : {14}\nOnur : {15}\n\n[1] Arena\n[2] Aşk Çeşmesi\n[3] Bar\n[4] Orman\n[5] Büyücü İni\nNereye Gitmek istersin : ", day, AnaBolme.İsim, AnaBolme.Meslek, AnaBolme.Damage, AnaBolme.Health, AnaBolme.MHealth, AnaBolme.Archer, AnaBolme.Guess, AnaBolme.Magic, AnaBolme.Speed, AnaBolme.Stamina, AnaBolme.MStamina, AnaBolme.Steal, AnaBolme.Hide, AnaBolme.Gold, AnaBolme.Honor);
                    gidilecek = Convert.ToInt32(Console.ReadLine());
                    switch (gidilecek)
                    {
                        #region Arena
                        case 1:
                            for (int i = 1; i != 0;)
                            {
                                Console.Write("Arenaya gittin.\n[1] Savaş meydanına çık\n[2] Eşya Kuşan/Bırak\n[3] İtem satın almak\n[4] Geri Dön\nNe yapmak istersin : ");
                                arenaSecim = Convert.ToInt32(Console.ReadLine());

                                if (arenaSecim == 1)
                                {
                                    Console.Write("[1] Cher[güç 1000]\n[2] Aimer[güç 500]\n[3] Ami[güç 300]\n[4] Ordinaire[güç 100]\n[5] Cupidite[güç 50]\n[6] Haine[güç 20]\nRakibini seç : ");
                                    arenaSecim = Convert.ToInt32(Console.ReadLine());

                                    if (arenaSecim == 1)
                                    {
                                        dMCan = 1000; dCan = 1000; dSaldiri = 100; dDefance = 100;
                                        Arena.Savas(dMCan, dCan, dSaldiri, dDefance); i = 0;
                                    }
                                    else if (arenaSecim == 2)
                                    {
                                        dMCan = 500; dCan = 500; dSaldiri = 50; dDefance = 50;
                                        Arena.Savas(dMCan, dCan, dSaldiri, dDefance); i = 0;
                                    }
                                    else if (arenaSecim == 3)
                                    {
                                        dMCan = 300; dCan = 300; dSaldiri = 30; dDefance = 30;
                                        Arena.Savas(dMCan, dCan, dSaldiri, dDefance); i = 0;
                                    }
                                    else if (arenaSecim == 4)
                                    {
                                        dMCan = 100; dCan = 100; dSaldiri = 10; dDefance = 10;
                                        Arena.Savas(dMCan, dCan, dSaldiri, dDefance); i = 0;
                                    }
                                    else if (arenaSecim == 5)
                                    {
                                        dMCan = 50; dCan = 50; dSaldiri = 5; dDefance = 5;
                                        Arena.Savas(dMCan, dCan, dSaldiri, dDefance); i = 0;
                                    }
                                    else if (arenaSecim == 6)
                                    {
                                        dMCan = 20; dCan = 20; dSaldiri = 2; dDefance = 2;
                                        Arena.Savas(dMCan, dCan, dSaldiri, dDefance); i = 0;
                                    }
                                }
                                else if (arenaSecim == 2)
                                {
                                    Giris.İtemDegişim();
                                }
                                else if (arenaSecim == 3)
                                {
                                    Giris.İtemSatinAlim();
                                }
                                else if (arenaSecim == 4)
                                {
                                    
                                    i = 0;
                                }
                            }
                            #endregion 
                            break;

                        #region AskCesmesi
                        case 2:
                            Console.Write("Aşk çeşmesine geldiniz.\n[1] Dilek tutmak.\n[2] Yeni insanlar ile tanışma.\n[3] Ticaret yapmak.\nNe yapmak istersin : ");
                            askSecim = Convert.ToInt32(Console.ReadLine());
                            if (askSecim == 1)
                            {
                                AskCesmesi.AskCesmesiSecim1();
                            }
                            else if (askSecim == 2)
                            {
                                AskCesmesi.AskCesmesiSecim2();
                            }
                            else if (askSecim == 3)
                            {
                                AskCesmesi.AskCesmesiSecim3();
                            }
                            else { }
                            #endregion
                            break;
                        #region bar
                        case 3:
                            #endregion
                            break;
                        #region orman
                        case 4:
                            Console.Write("Ormana girdiniz.\n[1] Ok topla\n[2] Ormanı keşfetmek\n[3] Meyve topla\n[4] Ormanın derinliklerine gir\nNe yapmak istersiniz : ");
                            ormanSecim = Convert.ToInt32(Console.ReadLine());
                            if (ormanSecim == 1)
                            {
                                Orman.OrmanSecim1();
                            }
                            else if (ormanSecim == 2)
                            {
                                Orman.OrmanSecim2();
                            }
                            else if (ormanSecim == 3)
                            {
                                Orman.OrmanSecim3();
                            }
                            else if (ormanSecim == 4)
                            {
                                Orman.OrmanSecim4();
                            }
                            #endregion
                            break;
                        #region büyücüİni
                        case 5:
                            Console.Write("Büyücü İnine Girdiniz.\n[1] Büyücüden Tavsiye Al\n[2] Büyücüye Meydan Oku (YÜKSEK TEHLİKE)\n[3] Büyücüden Mağaranın Anahtarını İste\nNe yapmak istersiniz : ");
                            bMagaraSecim = Convert.ToInt32(Console.ReadLine());
                            if (bMagaraSecim == 1)
                            {
                                buyucuMagarası.bMagaraSecim1();
                            }
                            else if (bMagaraSecim == 2)
                            {
                                buyucuMagarası.bMagaraSecim2();
                            }
                            else if (bMagaraSecim == 3)
                            {
                                buyucuMagarası.bMagaraSecim3();
                            }


                            #endregion
                            break;
                    }


                    for (; AnaBolme.Experience >= AnaBolme.MExperience;)
                    {
                        AnaBolme.Experience = AnaBolme.Experience - AnaBolme.MExperience;
                        AnaBolme.Level += 1;
                        lMExperience = ((1 + (0.1 * AnaBolme.Level)) * AnaBolme.Experience) + AnaBolme.MExperience;

                        AnaBolme.MExperience = (int)lMExperience;
                        Console.WriteLine("\n\n-------Seviye Atladınız!!-------");
                        Giris.Yetenek();
                    }
                    Console.WriteLine("\n");
                }
            }


            Console.ReadKey();
        }
    }
}
