using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oyun
{
    public class Giris : AnaBolme
    {
        public void Gİsim()
        {
            Console.Write("Karakterinize ne isim vermek istersiniz?\nİsiminiz : ");
            isim = Console.ReadLine();
            Console.ReadKey();
            Console.Clear();
        }
        public void GYetenek()
        {
            Console.WriteLine("Hasar : {0}\nCan : {1}/{2}\nOkçuluk Yeteneği : {3}\nTahmin Yeteneği : {4}\nBüyü Yeteneği : {5}\nHız : {6}\nDayanıklılık : {7}/{8}\nHırsızlık Yeteneği : {9}\nSaklanma Yeteneği : {10}\nDefans Yeteneği : {11}\n\n", damage, health, mHealth, archer, guess, magic, speed, stamina, mStamina, steal, hide, defance);



            Console.WriteLine("yetenek dağılımını yapman lazım. Yeteneklerini seç.\n[1]Saldırı Hasarı\n[2]Can\n[3]Okçuluk Yeteneği\n[4]Tahmin Yeteneği\n[5]Büyü Yeteneği\n[6]Hız\n[7]Dayanıklılık\n[8]Hırsızlık Yeteneği\n[9]Saklanma Yeteneği\n[10]Defans Yeteneği\n");
            for (int i = 10; i > 0; i--)
            {
                Console.Write("Kalan yetenek puanınız {0}.Hangi yeteneğini geliştirmek istersin : ", i);
                int Gelistir = Convert.ToInt32(Console.ReadLine());
                if (Gelistir == 1)
                {
                    damage = damage + 10;
                    Console.WriteLine("Hasar : {0}", damage);
                }
                else if (Gelistir == 2)
                {
                    health = health + 50;
                    mHealth = health;
                    Console.WriteLine("Can : {0}/{1}", health, mHealth);
                }
                else if (Gelistir == 3)
                {
                    archer = archer + 10;
                    Console.WriteLine("Okçuluk Yeteneği : {0}", archer);
                }
                else if (Gelistir == 4)
                {
                    guess = guess + 10;
                    Console.WriteLine("Tahmin Yeteneği : {0}", guess);
                }
                else if (Gelistir == 5)
                {
                    magic = magic + 10;
                    Console.WriteLine("Büyü Yeteneği : {0}", magic);
                }
                else if (Gelistir == 6)
                {
                    speed = speed + 10;
                    Console.WriteLine("Hız : {0}", speed);
                }
                else if (Gelistir == 7)
                {
                    stamina = stamina + 50;
                    mStamina = stamina;
                    Console.WriteLine("Dayanıklılık : {0}/{1}", stamina, mStamina);
                }
                else if (Gelistir == 8)
                {
                    steal = steal + 10;
                    Console.WriteLine("Hırsızlık Yeteneği : {0}", steal);
                }
                else if (Gelistir == 9)
                {
                    hide = hide + 10;
                    Console.WriteLine("Saklanma Yeteneği : {0}", hide);
                }
                else if (Gelistir == 10)
                {
                    defance = defance + 10;
                    Console.WriteLine("Defans Yeteneği : {0}", defance);
                }

            }
            Console.WriteLine("Hasar : {0}\nCan : {1}/{2}\nOkçuluk Yeteneği : {3}\nTahmin Yeteneği : {4}\nBüyü Yeteneği : {5}\nHız : {6}\nDayanıklılık : {7}/{8}\nHırsızlık Yeteneği : {9}\nSaklanma Yeteneği : {10}\nDefans Yeteneği : {11}\n\n", damage, health, mHealth, archer, guess, magic, speed, stamina, mStamina, steal, hide, defance);

            Console.ReadKey();
            Console.Clear();
        }
        public void Gmeslek()

        {
            kusanmaSilah = 0; KusanmaSilahID = 14;
            kusanmaYay = 0; kusanmaYayID = 3;
            kusanmaOk = 0; kusanmaOkID = 2;
            kusanmaKalkan = 0; kusanmaKalkanID = 4;
            kusanmaMigfer = 0; kusanmaMigferID = 4;
            kusanmaGZirhi = 0; kusanmaGZirhiID = 4;
            KusanmaBZirhi = 0; KusanmaBZirhiID = 4;
            kusanmaKZirhi = 0; kusanmaKZirhiID = 4;
            kusanmaEldiven = 0; kusanmaEldivenID = 4;
            kusanmaBot = 0; kusanmaBotID = 4;
            kusanmaKolye = 0; kusanmaKolyeID = 3;
            kusanmaBilezik = 0; kusanmaBilezikID = 3;
            kusanmaYuzuk = 0; kusanmaYuzukID = 3;
            kusanmaKupe = 0; kusanmaKupeID = 3;

            damage = 30;
            health = 100;
            mHealth = health;
            archer = 30;
            guess = 30;
            magic = 30;
            speed = 30;
            stamina = 100;
            mStamina = stamina;
            steal = 30;
            hide = 30;
            defance = 30;
            gold = 100;
            honor = 100;
            level = 1;
            experience = 0;
            mExperience = 10;
            Console.Write("Meslek seçimi yapmalısın.\n[1]Savaşçı\n[2]Okçu\n[3]Büyücü\n[4]Dedektif\n[5]Hırsız\nHangi mesleği seçmek istersin : ");
            int İMeslek = Convert.ToInt32(Console.ReadLine());

            if (İMeslek == 1)
            {
                damage = damage + 50;
                health = health + 100;
                mHealth = health;
                meslek = "Savaşçı";
                Console.WriteLine("Mesleğiniz Savaşçı. Hasar : {0}    Can : {1}/{2}", damage, health, mHealth);
            }
            else if (İMeslek == 2)
            {
                archer = archer + 50;
                health = health + 100;
                mHealth = health;
                meslek = "Okçu";
                Console.WriteLine("Mesleğiniz Okçu. Okçuluk Yeteneği : {0}    Can : {1}/{2}", archer, health, mHealth);
            }
            else if (İMeslek == 3)
            {
                magic = magic + 50;
                meslek = "Büyücü";
                Console.WriteLine("Mesleğiniz Büyücü. Büyü Yeteneği : {0}", magic);
            }
            else if (İMeslek == 4)
            {
                guess = guess + 50;
                speed = speed + 50;
                meslek = "Dedektif";
                Console.WriteLine("Mesleğiniz Dedektif. Tahmin Yeteneği : {0}    Hız : {1}", guess, speed);
            }
            else if (İMeslek == 5)
            {
                hide = hide + 50;
                steal = steal + 50;
                meslek = "Hırsız";
                Console.WriteLine("Mesleğiniz Hırsız. Saklanma Yeteneği : {0}    Hırsızlık Yeteneği : {1}", steal, hide);
            }

            Console.ReadKey();
            Console.Clear();
        }
        public void Yetenek()
        {
            Console.Write("Yeteneğini seç.\n[1]Saldırı Hasarı\n[2]Can\n[3]Okçuluk Yeteneği\n[4]Tahmin Yeteneği\n[5]Büyü Yeteneği\n[6]Hız\n[7]Dayanıklılık\n[8]Hırsızlık Yeteneği\n[9]Saklanma Yeteneği\n[10]Defans Yeteneği\nHangi yeteneğini geliştirmek istersin : ");
            int Gelistir = Convert.ToInt32(Console.ReadLine());
            if (Gelistir == 1)
            {
                damage = damage + 10;
                Console.WriteLine("Hasar : {0}", damage);
            }
            else if (Gelistir == 2)
            {
                health = health + 50;
                mHealth = health;
                Console.WriteLine("Can : {0}/{1}", health, mHealth);
            }
            else if (Gelistir == 3)
            {
                archer = archer + 10;
                Console.WriteLine("Okçuluk Yeteneği : {0}", archer);
            }
            else if (Gelistir == 4)
            {
                guess = guess + 10;
                Console.WriteLine("Tahmin Yeteneği : {0}", guess);
            }
            else if (Gelistir == 5)
            {
                magic = magic + 10;
                Console.WriteLine("Büyü Yeteneği : {0}", magic);
            }
            else if (Gelistir == 6)
            {
                speed = speed + 10;
                Console.WriteLine("Hız : {0}", speed);
            }
            else if (Gelistir == 7)
            {
                stamina = stamina + 50;
                mStamina = stamina;
                Console.WriteLine("Dayanıklılık : {0}/{1}", stamina, mStamina);
            }
            else if (Gelistir == 8)
            {
                steal = steal + 10;
                Console.WriteLine("Hırsızlık Yeteneği : {0}", steal);
            }
            else if (Gelistir == 9)
            {
                hide = hide + 10;
                Console.WriteLine("Saklanma Yeteneği : {0}", hide);
            }
            else if (Gelistir == 10)
            {
                defance = defance + 10;
                Console.WriteLine("Defans Yeteneği : {0}", defance);
            }
        }
        public void Orman()
        {
            Arena A1 = new Arena();
            Random rnd = new Random();
            int ormanİhtimal = rnd.Next(1, 100);
            int ormanSecim;

            if (ormanİhtimal > 95)
            {
                gold = gold + 50;
                Console.Write("Yolda bir kese altın buldunuz\nAltınınız(+50) : {0}\n", gold);
            }
            else if (ormanİhtimal > 90)
            {
                magic = magic + 10;
                Console.Write("Ağaçların arasında gezerken bir büyücüye denk geldin. Kendisi size yaklaşıyor ve hareket edemiyotsunuz ama iyi niyetli olduğunu hissediyorsunuz. Sizin alnınıza dokunup kayboluyor.\nBüyü Gücünüz(+10) : {0}\n", magic);
            }
            else if (ormanİhtimal > 85)
            {
                speed = speed + 30;
                Console.Write("Ağaçların arasından geçerken ilginç bir bitkiye denk geldiniz. Sizin üstünüze bir sıvı attı.\nHızınız(+30) : {0}", speed);
            }
            else if (ormanİhtimal > 80)
            {
                Console.Write("Bir kemik yığınına denk geldin. Uzun zamandır hiç kimsenin bu kişiyi görmediği belli. Onun eşyalarını araştırmak ister misiniz?\n[1] Evet\n[2] Hayır, onu ebediyete terket\nNe yapacaksın : ");
                ormanSecim = Convert.ToInt32(Console.ReadLine());
                if (ormanSecim == 1)
                {
                    gold = gold + 75;
                    damage = damage + 30;
                    Console.Write("Şunlar Bulundu:1 kese altın(75 Altın),20 taş ok,1 demir kılıç\naltınınız : {0}\nok : Gelecek\nhasarınız(+30) : {1}", gold, damage);
                }
                else
                {
                    Console.Write("Hiçbir şey yapmadan onu sonsuz yalnızlığa bıraktın ve devam ettin\n");
                }

            }
            else if (ormanİhtimal > 75)
            {
                health = health + 50;
                mHealth = mHealth + 50;
                Console.Write("Bir peri yolunu aydınlatıyor. Kalp atışın hızlanıyor. Göğüs Kafesin daralıyor... Bir anda bayılmışsın ama kendini daha canlı hissediyorsun.\n canınız(+50) : {0}/{1}\n", health, mHealth);

            }
            else if (ormanİhtimal > 70)
            {
                Console.Write("Ormanda nam salmış Geldur'a rastladın. Seni gördüğü anda onun bölgesinde gezdiğin için seni öldğreceğini söyleyip saldırdı\n");
                int dMCan = 300, dCan = 300, dSaldiri = 30, dDefance = 30;
                A1.Savas(dMCan, dCan, dSaldiri, dDefance);
            }
            else if (ormanİhtimal > 65)
            {
                int bGold = gold / 2;
                gold = gold / 2;
                Console.Write("Bir büyücü arkandan yaklaşıp seni dondurdu cebindeki altının yarısına ulaşabildi ve çaldı. Sen çözülene kadar kaçtı.\nAltınınız(-{0}) : {1}\n", bGold, gold);
            }
            else if (ormanİhtimal > 60)
            {
                Console.Write("Bir goblin çetesine denk geldin. Seninle kumar oynamayı teklif ettiler. Minik bir fısıltı sana oynamazsan iyi sonuçları olmayacak diyor.\n[1] Kumar Oyna\n[2]reddet ve gitmek iste\nNe yapmak istersin : ");
                ormanSecim = Convert.ToInt32(Console.ReadLine());
                if (ormanSecim == 1)
                {
                    Console.Write("senin önüne 3 tane kart koydular goblini bul 50 latın kazan dediler.\nGoblin hangi kartta : ");
                    ormanSecim = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Malesef bulamadın senden 100 altın istiyorlar.\n[1] Paralarını ver ve oradan hemen uzaklaş\n[2]seni kandırdıklarını söyle ve ödemeyi reddet\nNe yapmak istersin : ");
                    ormanSecim = Convert.ToInt32(Console.ReadLine());
                    if (ormanSecim == 1)
                    {
                        gold = gold - 100;
                        Console.Write("Parayı verdin ve paçayı zor kurtardın. Canından olmaktansa biraz malından oldun.\nAltınınız(-100) : {0}", gold);
                    }
                    else
                    {
                        int bGold = gold / 2;
                        gold = gold / 2;
                        Console.Write("Sen öyle söyleyince sinirlenmeye ve büyümeye başladılar seni ayağından tutup ters çevirdiler ve tüm düşen altınları çaldılar\naltınınız(-{0}) : {1}\n", bGold, gold);
                    }
                }
                else
                {
                    int bGold = gold / 2;
                    gold = gold / 2;
                    Console.Write("Sen öyle söyleyince sinirlenmeye ve büyümeye başladılar seni ayağından tutup ters çevirdiler ve tüm düşen altınları çaldılar\naltınınız(-{0}) : {1}\n", bGold, gold);
                }

            }
            else if (ormanİhtimal > 55)
            {
                health = health - 50;
                Console.Write("ormandan birkaç maymun sana taş sopa attılar kaçtın ama hasar da aldın\ncanınız(-50) : {0}\n", health);
            }
            else if (ormanİhtimal > 50)
            {
                magic = magic - 10;
                Console.Write("Bir büyücü önüne çıktı ve bir anda yok oldu. kendinden bir şey kaybetmiş gibi hissediyorsun.\nBüyü Gücünüz(-10) : {0}", magic);

            }
            else
            {
                Console.Write("hiçbir ilginç şeye denk gelmedin\n");
            }
        }
        public void İtemDegişim()
        {
            for (int itemSayac = 1; itemSayac != 0;)
            {
                Console.Write("Hangi İtem Türünde değişim yapmak istersin?\n[1] Silah\n[2] Yay\n[3] Kalkan\n[4] Miğfer\n[5] Gövde Zırhı\n[6]Bacak Zırhı\n[7] Kol Zırhı\n[8] Eldiven\n[9] Bot\n[10] Kolye\n[11] Bilezik\n[12] Yüzük\n[13] Küpe\n[14] Setini Gör\n[15] Geri Dön\nNe yapmak istersin : ");
                int İtemSecim = Convert.ToInt32(Console.ReadLine());
                if (İtemSecim == 1)
                {
                    Console.Write("kusandığın Silah/Hasarı : {0}/{1}\nHasarınız : {2}\n", İtemSilah[kusanmaSilahID].silahİtemİsim, kusanmaSilah, damage);
                    Console.Write("[1] {0}/{1} : {2}\n", İtemSilah[0].silahİtemİsim, İtemSilah[0].silahDegisecekDeger, İtemSilah[0].silahİtemSayi);
                    Console.Write("[2] {0}/{1} : {2}\n", İtemSilah[1].silahİtemİsim, İtemSilah[1].silahDegisecekDeger, İtemSilah[1].silahİtemSayi);
                    Console.Write("[3] {0}/{1} : {2}\n", İtemSilah[2].silahİtemİsim, İtemSilah[2].silahDegisecekDeger, İtemSilah[2].silahİtemSayi);
                    Console.Write("[4] {0}/{1} : {2}\n", İtemSilah[3].silahİtemİsim, İtemSilah[3].silahDegisecekDeger, İtemSilah[3].silahİtemSayi);
                    Console.Write("[5] {0}/{1} : {2}\n", İtemSilah[4].silahİtemİsim, İtemSilah[4].silahDegisecekDeger, İtemSilah[4].silahİtemSayi);
                    Console.Write("[6] {0}/{1} : {2}\n", İtemSilah[5].silahİtemİsim, İtemSilah[5].silahDegisecekDeger, İtemSilah[5].silahİtemSayi);
                    Console.Write("[7] {0}/{1} : {2}\n", İtemSilah[6].silahİtemİsim, İtemSilah[6].silahDegisecekDeger, İtemSilah[6].silahİtemSayi);
                    Console.Write("[8] {0}/{1} : {2}\n", İtemSilah[7].silahİtemİsim, İtemSilah[7].silahDegisecekDeger, İtemSilah[7].silahİtemSayi);
                    Console.Write("[9] {0}/{1} : {2}\n", İtemSilah[8].silahİtemİsim, İtemSilah[8].silahDegisecekDeger, İtemSilah[8].silahİtemSayi);
                    Console.Write("[10] {0}/{1} : {2}\n", İtemSilah[9].silahİtemİsim, İtemSilah[9].silahDegisecekDeger, İtemSilah[9].silahİtemSayi);
                    Console.Write("[11] {0}/{1} : {2}\n", İtemSilah[10].silahİtemİsim, İtemSilah[10].silahDegisecekDeger, İtemSilah[10].silahİtemSayi);
                    Console.Write("[12] {0}/{1} : {2}\n", İtemSilah[11].silahİtemİsim, İtemSilah[11].silahDegisecekDeger, İtemSilah[11].silahİtemSayi);
                    Console.Write("[13] {0}/{1} : {2}\n", İtemSilah[12].silahİtemİsim, İtemSilah[12].silahDegisecekDeger, İtemSilah[12].silahİtemSayi);
                    Console.Write("[14] {0}/{1} : {2}\n", İtemSilah[13].silahİtemİsim, İtemSilah[13].silahDegisecekDeger, İtemSilah[13].silahİtemSayi);
                    Console.Write("[15] {0}/{1} : {2}\n\n", İtemSilah[14].silahİtemİsim, İtemSilah[14].silahDegisecekDeger, İtemSilah[14].silahİtemSayi);
                    Console.Write("Kuşanmak istediğin bir Silah var mı : ");
                    İtemSecim = Convert.ToInt32(Console.ReadLine());
                    SilahİtemKusanma(İtemSecim);
                }
                else if (İtemSecim == 2)
                {
                    Console.Write("[1] Yay\n[2] Ok\nHangisini seçmek istersin : ");
                    İtemSecim = Convert.ToInt32(Console.ReadLine());
                    if (İtemSecim == 1)
                    {
                        Console.Write("kusandığın yay/Hasarı : {0}/{1}\nHasarınız : {2}\n", İtemYay[kusanmaYayID].yayİtemİsim, kusanmaYay, Damage);
                        Console.Write("[1] {0}/{1} : {2}\n[2] {3}/{4} : {5}\n[3] {6}/{7} : {8}\nKuşanmak istediğin bir yay var mı : ", İtemYay[0].yayİtemİsim, İtemYay[0].yayDegisecekDeger, İtemYay[0].yayİtemSayi, İtemYay[1].yayİtemİsim, İtemYay[1].yayDegisecekDeger, İtemYay[1].yayİtemSayi, İtemYay[2].yayİtemİsim, İtemYay[2].yayDegisecekDeger, İtemYay[2].yayİtemSayi);
                        İtemSecim = Convert.ToInt32(Console.ReadLine());
                        YayİtemKusanma(İtemSecim);
                    }
                    else if (İtemSecim == 2)
                    {
                        Console.Write("kusandığın Ok/Hasarı : {0}/{1}\nHasarınız : {2}\n", İtemOk[kusanmaOkID].okİtemİsim, kusanmaOk, Damage);
                        Console.Write("[1] {0}/{1} : {2}\n[2] {3}/{4} : {5}\nKuşanmak istediğin bir Ok var mı : ", İtemOk[0].okİtemİsim, İtemOk[0].okDegisecekDeger, İtemOk[0].okİtemSayi, İtemOk[1].okİtemİsim, İtemOk[1].okDegisecekDeger, İtemOk[1].okİtemSayi);
                        İtemSecim = Convert.ToInt32(Console.ReadLine());
                        OkİtemKusanma(İtemSecim);
                    }
                }
                else if (İtemSecim == 3)
                {
                    Console.Write("kusandığın Kalkan/Defansı : {0}/{1}\nDefansınız : {2}\n", İtemKalkan[kusanmaKalkanID].kalkanİtemİsim, kusanmaKalkan, Defance);
                    Console.Write("[1] {0}/{1} : {2}\n[2] {3}/{4} : {5}\n[3] {6}/{7} : {8}\n[4] {9}/{10} : {11}\nKuşanmak istediğin bir Kalkan var mı : ", İtemKalkan[0].kalkanİtemİsim, İtemKalkan[0].kalkanDegisecekDeger, İtemKalkan[0].kalkanİtemSayi, İtemKalkan[1].kalkanİtemİsim, İtemKalkan[1].kalkanDegisecekDeger, İtemKalkan[1].kalkanİtemSayi, İtemKalkan[2].kalkanİtemİsim, İtemKalkan[2].kalkanDegisecekDeger, İtemKalkan[2].kalkanİtemSayi, İtemKalkan[3].kalkanİtemİsim, İtemKalkan[3].kalkanDegisecekDeger, İtemKalkan[3].kalkanİtemSayi);
                    İtemSecim = Convert.ToInt32(Console.ReadLine());
                    KalkanİtemKusanma(İtemSecim);
                }
                else if (İtemSecim == 4)
                {
                    Console.Write("kusandığın Miğfer/Defansı : {0}/{1}\nDefansınız : {2}\n", İtemMigfer[kusanmaMigferID].migferİtemİsim, kusanmaMigfer, Defance);
                    Console.Write("[1] {0}/{1} : {2}\n[2] {3}/{4} : {5}\n[3] {6}/{7} : {8}\n[4] {9}/{10} : {11}\nKuşanmak istediğin bir Miğfer var mı : ", İtemMigfer[0].migferİtemİsim, İtemMigfer[0].migferDegisecekDeger, İtemMigfer[0].migferİtemSayi, İtemMigfer[1].migferİtemİsim, İtemMigfer[1].migferDegisecekDeger, İtemMigfer[1].migferİtemSayi, İtemMigfer[2].migferİtemİsim, İtemMigfer[2].migferDegisecekDeger, İtemMigfer[2].migferİtemSayi, İtemMigfer[3].migferİtemİsim, İtemMigfer[3].migferDegisecekDeger, İtemMigfer[3].migferİtemSayi);
                    İtemSecim = Convert.ToInt32(Console.ReadLine());
                    MigferİtemKusanma(İtemSecim);
                }
                else if (İtemSecim == 5)
                {
                    Console.Write("kusandığın Gövde Zırhı/Defansı : {0}/{1}\nDefansınız : {2}\n", İtemGZirhi[kusanmaGZirhiID].gZirhiİtemİsim, kusanmaGZirhi, Defance);
                    Console.Write("[1] {0}/{1} : {2}\n[2] {3}/{4} : {5}\n[3] {6}/{7} : {8}\n[4] {9}/{10} : {11}\nKuşanmak istediğin bir Gövde Zırhı var mı : ", İtemGZirhi[0].gZirhiİtemİsim, İtemGZirhi[0].gZirhiDegisecekDeger, İtemGZirhi[0].gZirhiİtemSayi, İtemGZirhi[1].gZirhiİtemİsim, İtemGZirhi[1].gZirhiDegisecekDeger, İtemGZirhi[1].gZirhiİtemSayi, İtemGZirhi[2].gZirhiİtemİsim, İtemGZirhi[2].gZirhiDegisecekDeger, İtemGZirhi[2].gZirhiİtemSayi, İtemGZirhi[3].gZirhiİtemİsim, İtemGZirhi[3].gZirhiDegisecekDeger, İtemGZirhi[3].gZirhiİtemSayi);
                    İtemSecim = Convert.ToInt32(Console.ReadLine());
                    GZirhiİtemKusanma(İtemSecim);
                }
                else if (İtemSecim == 6)
                {
                    Console.Write("kusandığın Bacak Zırhı/Defansı : {0}/{1}\nDefansınız : {2}\n", İtemBZirhi[kusanmaBZirhiID].bZirhiİtemİsim, kusanmaBZirhi, Defance);
                    Console.Write("[1] {0}/{1} : {2}\n[2] {3}/{4} : {5}\n[3] {6}/{7} : {8}\n[4] {9}/{10} : {11}\nKuşanmak istediğin bir Bacak Zırhı var mı : ", İtemBZirhi[0].bZirhiİtemİsim, İtemBZirhi[0].bZirhiDegisecekDeger, İtemBZirhi[0].bZirhiİtemSayi, İtemBZirhi[1].bZirhiİtemİsim, İtemBZirhi[1].bZirhiDegisecekDeger, İtemBZirhi[1].bZirhiİtemSayi, İtemBZirhi[2].bZirhiİtemİsim, İtemBZirhi[2].bZirhiDegisecekDeger, İtemBZirhi[2].bZirhiİtemSayi, İtemBZirhi[3].bZirhiİtemİsim, İtemBZirhi[3].bZirhiDegisecekDeger, İtemBZirhi[3].bZirhiİtemSayi);
                    İtemSecim = Convert.ToInt32(Console.ReadLine());
                    BZirhiİtemKusanma(İtemSecim);
                }
                else if (İtemSecim == 7)
                {
                    Console.Write("kusandığın Kol Zırhı/Defansı : {0}/{1}\nDefansınız : {2}\n", İtemKZirhi[kusanmaKZirhiID].kZirhiİtemİsim, kusanmaKZirhi, Defance);
                    Console.Write("[1] {0}/{1} : {2}\n[2] {3}/{4} : {5}\n[3] {6}/{7} : {8}\n[4] {9}/{10} : {11}\nKuşanmak istediğin bir Kol Zırhı var mı : ", İtemKZirhi[0].kZirhiİtemİsim, İtemKZirhi[0].kZirhiDegisecekDeger, İtemKZirhi[0].kZirhiİtemSayi, İtemKZirhi[1].kZirhiİtemİsim, İtemKZirhi[1].kZirhiDegisecekDeger, İtemKZirhi[1].kZirhiİtemSayi, İtemKZirhi[2].kZirhiİtemİsim, İtemKZirhi[2].kZirhiDegisecekDeger, İtemKZirhi[2].kZirhiİtemSayi, İtemKZirhi[3].kZirhiİtemİsim, İtemKZirhi[3].kZirhiDegisecekDeger, İtemKZirhi[3].kZirhiİtemSayi);
                    İtemSecim = Convert.ToInt32(Console.ReadLine());
                    KZirhiİtemKusanma(İtemSecim);
                }
                else if (İtemSecim == 8)
                {
                    Console.Write("kusandığın Eldiven/Defansı : {0}/{1}\nDefansınız : {2}\n", İtemEldiven[kusanmaEldivenID].eldivenİtemİsim, kusanmaEldiven, Defance);
                    Console.Write("[1] {0}/{1} : {2}\n[2] {3}/{4} : {5}\n[3] {6}/{7} : {8}\n[4] {9}/{10} : {11}\nKuşanmak istediğin bir Eldiven var mı : ", İtemEldiven[0].eldivenİtemİsim, İtemEldiven[0].eldivenDegisecekDeger, İtemEldiven[0].eldivenİtemSayi, İtemEldiven[1].eldivenİtemİsim, İtemEldiven[1].eldivenDegisecekDeger, İtemEldiven[1].eldivenİtemSayi, İtemEldiven[2].eldivenİtemİsim, İtemEldiven[2].eldivenDegisecekDeger, İtemEldiven[2].eldivenİtemSayi, İtemEldiven[3].eldivenİtemİsim, İtemEldiven[3].eldivenDegisecekDeger, İtemEldiven[3].eldivenİtemSayi);
                    İtemSecim = Convert.ToInt32(Console.ReadLine());
                    EldivenİtemKusanma(İtemSecim);
                }
                else if (İtemSecim == 9)
                {
                    Console.Write("kusandığın Bot/Defansı : {0}/{1}\nDefansınız : {2}\n", İtemBot[kusanmaBotID].botİtemİsim, kusanmaBot, Defance);
                    Console.Write("[1] {0}/{1} : {2}\n[2] {3}/{4} : {5}\n[3] {6}/{7} : {8}\n[4] {9}/{10} : {11}\nKuşanmak istediğin bir Bot var mı : ", İtemBot[0].botİtemİsim, İtemBot[0].botDegisecekDeger, İtemBot[0].botİtemSayi, İtemBot[1].botİtemİsim, İtemBot[1].botDegisecekDeger, İtemBot[1].botİtemSayi, İtemBot[2].botİtemİsim, İtemBot[2].botDegisecekDeger, İtemBot[2].botİtemSayi, İtemBot[3].botİtemİsim, İtemBot[3].botDegisecekDeger, İtemBot[3].botİtemSayi);
                    İtemSecim = Convert.ToInt32(Console.ReadLine());
                    BotİtemKusanma(İtemSecim);
                }
                else if (İtemSecim == 10)
                {
                    Console.Write("kusandığın Kolye : {0}\n", İtemKolye[kusanmaKolyeID].kolyeİtemİsim);
                    Console.Write("[1] {0} : {1}\n[2] {2} : {3}\n[3] {4}/ : {5}\nKuşanmak istediğin bir Kolye var mı : ", İtemKolye[0].kolyeİtemİsim, İtemKolye[0].kolyeİtemSayi, İtemKolye[1].kolyeİtemİsim, İtemKolye[1].kolyeİtemSayi, İtemKolye[2].kolyeİtemİsim, İtemKolye[2].kolyeİtemSayi);
                    İtemSecim = Convert.ToInt32(Console.ReadLine());
                    KolyeİtemKusanma(İtemSecim);
                }
                else if (İtemSecim == 11)
                {
                    Console.Write("kusandığın Bilezik : {0}\n", İtemBilezik[kusanmaBilezikID].bilezikİtemİsim);
                    Console.Write("[1] {0} : {1}\n[2] {2}/ : {3}\n[3] {4} : {5}\nKuşanmak istediğin bir yay var mı : ", İtemBilezik[0].bilezikİtemİsim, İtemBilezik[0].bilezikİtemSayi, İtemBilezik[1].bilezikİtemİsim, İtemBilezik[1].bilezikİtemSayi, İtemBilezik[2].bilezikİtemİsim, İtemBilezik[2].bilezikİtemSayi);
                    İtemSecim = Convert.ToInt32(Console.ReadLine());
                    BilezikİtemKusanma(İtemSecim);
                }
                else if (İtemSecim == 12)
                {
                    Console.Write("kusandığın Yüzük/Hasarı : {0}\n", İtemYuzuk[kusanmaYuzukID].yuzukİtemİsim);
                    Console.Write("[1] {0} : {1}\n[2] {2} : {3}\n[3] {4} : {5}\nKuşanmak istediğin bir Yüzük var mı : ", İtemYuzuk[0].yuzukİtemİsim, İtemYuzuk[0].yuzukİtemSayi, İtemYuzuk[1].yuzukİtemİsim, İtemYuzuk[1].yuzukİtemSayi, İtemYuzuk[2].yuzukİtemİsim, İtemYuzuk[2].yuzukİtemSayi);
                    İtemSecim = Convert.ToInt32(Console.ReadLine());
                    YuzukİtemKusanma(İtemSecim);
                }
                else if (İtemSecim == 13)
                {
                    Console.Write("kusandığın Küpe/Hasarı : {0}\n", İtemKupe[kusanmaKupeID].kupeİtemİsim);
                    Console.Write("[1] {0} : {1}\n[2] {2} : {3}\n[3] {4} : {5}\nKuşanmak istediğin bir Küpe var mı : ", İtemKupe[0].kupeİtemİsim, İtemKupe[0].kupeİtemSayi, İtemKupe[1].kupeİtemİsim, İtemKupe[1].kupeİtemSayi, İtemKupe[2].kupeİtemİsim, İtemKupe[2].kupeİtemSayi);
                    İtemSecim = Convert.ToInt32(Console.ReadLine());
                    KupeİtemKusanma(İtemSecim);
                }
                else if (İtemSecim == 14)
                {
                    Console.Write("Silah : {0}/{1}\nYay : {2}/{3}   Ok : {4}/{5}\nKalkan : {6}/{7}\nMiğfer : {8}/{9}\nGövde Zırhı : {10}/{11}\nBacak Zırhı : {12}/{13}\nKol Zırhı : {14}/{15}\nEldiven : {16}/{17}\nBot : {18}/{19}\nKolye : {20}\nBilezik : {21}\nYüzük : {22}\nKüpe : {23}\n",İtemSilah[KusanmaSilahID].silahİtemİsim, İtemSilah[KusanmaSilahID].silahDegisecekDeger, İtemYay[KusanmaYayID].yayİtemİsim, İtemYay[KusanmaYayID].yayDegisecekDeger, İtemOk[KusanmaOkID].okİtemİsim, İtemOk[KusanmaOkID].okDegisecekDeger, İtemKalkan[KusanmaKalkanID].kalkanİtemİsim, İtemKalkan[KusanmaKalkanID].kalkanDegisecekDeger, İtemMigfer[KusanmaMigferID].migferİtemİsim, İtemMigfer[KusanmaMigferID].migferDegisecekDeger, İtemGZirhi[KusanmaGZirhiID].gZirhiİtemİsim, İtemGZirhi[KusanmaGZirhiID].gZirhiDegisecekDeger, İtemBZirhi[KusanmaBZirhiID].bZirhiİtemİsim, İtemBZirhi[KusanmaBZirhiID].bZirhiDegisecekDeger, İtemKZirhi[KusanmaKZirhiID].kZirhiİtemİsim, İtemKZirhi[KusanmaKZirhiID].kZirhiDegisecekDeger, İtemEldiven[KusanmaEldivenID].eldivenİtemİsim, İtemEldiven[KusanmaEldivenID].eldivenDegisecekDeger, İtemBot[KusanmaBotID].botİtemİsim, İtemBot[KusanmaBotID].botDegisecekDeger, İtemKolye[KusanmaKolyeID].kolyeİtemİsim, İtemBilezik[KusanmaBilezikID].bilezikİtemİsim, İtemYuzuk[KusanmaYuzukID].yuzukİtemİsim, İtemKupe[KusanmaKupeID].kupeİtemİsim);
                }
                else if (İtemSecim == 15)
                {
                    itemSayac = 0;
                }
            }
        }
        public void İtemSatinAlim()
        {
            for (int itemSayac = 1; itemSayac != 0;)
            {
                Console.Write("Hangi İtem Türünde Alım yapmak istersin?\n[1] Silah\n[2] Yay\n[3] Kalkan\n[4] Miğfer\n[5] Gövde Zırhı\n[6]Bacak Zırhı\n[7] Kol Zırhı\n[8] Eldiven\n[9] Bot\n[10] Kolye\n[11] Bilezik\n[12] Yüzük\n[13] Küpe\n[14] Setini Gör\n[15] Geri Dön\nNe yapmak istersin : ");
                int İtemSecim = Convert.ToInt32(Console.ReadLine());
                if (İtemSecim == 1)
                {
                    Console.Write("kusandığın Silah/Hasarı : {0}/{1}\nHasarınız : {2}\n", İtemSilah[kusanmaSilahID].silahİtemİsim, kusanmaSilah, damage);
                    Console.Write("[1] {0}/{1} : {2}\n", İtemSilah[0].silahİtemİsim, İtemSilah[0].silahDegisecekDeger, İtemSilah[0].silahİtemSayi);
                    Console.Write("[2] {0}/{1} : {2}\n", İtemSilah[1].silahİtemİsim, İtemSilah[1].silahDegisecekDeger, İtemSilah[1].silahİtemSayi);
                    Console.Write("[3] {0}/{1} : {2}\n", İtemSilah[2].silahİtemİsim, İtemSilah[2].silahDegisecekDeger, İtemSilah[2].silahİtemSayi);
                    Console.Write("[4] {0}/{1} : {2}\n", İtemSilah[3].silahİtemİsim, İtemSilah[3].silahDegisecekDeger, İtemSilah[3].silahİtemSayi);
                    Console.Write("[5] {0}/{1} : {2}\n", İtemSilah[4].silahİtemİsim, İtemSilah[4].silahDegisecekDeger, İtemSilah[4].silahİtemSayi);
                    Console.Write("[6] {0}/{1} : {2}\n", İtemSilah[5].silahİtemİsim, İtemSilah[5].silahDegisecekDeger, İtemSilah[5].silahİtemSayi);
                    Console.Write("[7] {0}/{1} : {2}\n", İtemSilah[6].silahİtemİsim, İtemSilah[6].silahDegisecekDeger, İtemSilah[6].silahİtemSayi);
                    Console.Write("[8] {0}/{1} : {2}\n", İtemSilah[7].silahİtemİsim, İtemSilah[7].silahDegisecekDeger, İtemSilah[7].silahİtemSayi);
                    Console.Write("[9] {0}/{1} : {2}\n", İtemSilah[8].silahİtemİsim, İtemSilah[8].silahDegisecekDeger, İtemSilah[8].silahİtemSayi);
                    Console.Write("[10] {0}/{1} : {2}\n", İtemSilah[9].silahİtemİsim, İtemSilah[9].silahDegisecekDeger, İtemSilah[9].silahİtemSayi);
                    Console.Write("[11] {0}/{1} : {2}\n", İtemSilah[10].silahİtemİsim, İtemSilah[10].silahDegisecekDeger, İtemSilah[10].silahİtemSayi);
                    Console.Write("[12] {0}/{1} : {2}\n", İtemSilah[11].silahİtemİsim, İtemSilah[11].silahDegisecekDeger, İtemSilah[11].silahİtemSayi);
                    Console.Write("[13] {0}/{1} : {2}\n", İtemSilah[12].silahİtemİsim, İtemSilah[12].silahDegisecekDeger, İtemSilah[12].silahİtemSayi);
                    Console.Write("[14] {0}/{1} : {2}\n", İtemSilah[13].silahİtemİsim, İtemSilah[13].silahDegisecekDeger, İtemSilah[13].silahİtemSayi);
                    Console.Write("[15] {0}/{1} : {2}\n\n", İtemSilah[14].silahİtemİsim, İtemSilah[14].silahDegisecekDeger, İtemSilah[14].silahİtemSayi);
                    Console.Write("Almak istediğin bir Silah var mı : ");
                    İtemSecim = Convert.ToInt32(Console.ReadLine());
                    SilahİtemSatınalma(İtemSecim);
                }
                else if (İtemSecim == 2)
                {
                    Console.Write("[1] Yay\n[2] Ok\nHangisini seçmek istersin : ");
                    İtemSecim = Convert.ToInt32(Console.ReadLine());
                    if (İtemSecim == 1)
                    {
                        Console.Write("kusandığın yay/Hasarı : {0}/{1}\nHasarınız : {2}\n", İtemYay[kusanmaYayID].yayİtemİsim, kusanmaYay, Damage);
                        Console.Write("[1] {0}/{1} : {2}\n[2] {3}/{4} : {5}\n[3] {6}/{7} : {8}\nAlmak istediğin bir yay var mı : ", İtemYay[0].yayİtemİsim, İtemYay[0].yayDegisecekDeger, İtemYay[0].yayİtemSayi, İtemYay[1].yayİtemİsim, İtemYay[1].yayDegisecekDeger, İtemYay[1].yayİtemSayi, İtemYay[2].yayİtemİsim, İtemYay[2].yayDegisecekDeger, İtemYay[2].yayİtemSayi);
                        İtemSecim = Convert.ToInt32(Console.ReadLine());
                        YayİtemSatınalma(İtemSecim);
                    }
                    else if (İtemSecim == 2)
                    {
                        Console.Write("kusandığın Ok/Hasarı : {0}/{1}\nHasarınız : {2}\n", İtemOk[kusanmaOkID].okİtemİsim, kusanmaOk, Damage);
                        Console.Write("[1] {0}/{1} : {2}\n[2] {3}/{4} : {5}\nAlmak istediğin bir Ok var mı : ", İtemOk[0].okİtemİsim, İtemOk[0].okDegisecekDeger, İtemOk[0].okİtemSayi, İtemOk[1].okİtemİsim, İtemOk[1].okDegisecekDeger, İtemOk[1].okİtemSayi);
                        İtemSecim = Convert.ToInt32(Console.ReadLine());
                        OkİtemSatınalma(İtemSecim);
                    }
                }
                else if (İtemSecim == 3)
                {
                    Console.Write("kusandığın Kalkan/Defansı : {0}/{1}\nDefansınız : {2}\n", İtemKalkan[kusanmaKalkanID].kalkanİtemİsim, kusanmaKalkan, Defance);
                    Console.Write("[1] {0}/{1} : {2}\n[2] {3}/{4} : {5}\n[3] {6}/{7} : {8}\n[4] {9}/{10} : {11}\nAlmak istediğin bir Kalkan var mı : ", İtemKalkan[0].kalkanİtemİsim, İtemKalkan[0].kalkanDegisecekDeger, İtemKalkan[0].kalkanİtemSayi, İtemKalkan[1].kalkanİtemİsim, İtemKalkan[1].kalkanDegisecekDeger, İtemKalkan[1].kalkanİtemSayi, İtemKalkan[2].kalkanİtemİsim, İtemKalkan[2].kalkanDegisecekDeger, İtemKalkan[2].kalkanİtemSayi, İtemKalkan[3].kalkanİtemİsim, İtemKalkan[3].kalkanDegisecekDeger, İtemKalkan[3].kalkanİtemSayi);
                    İtemSecim = Convert.ToInt32(Console.ReadLine());
                    KalkanİtemSatınalma(İtemSecim);
                }
                else if (İtemSecim == 4)
                {
                    Console.Write("kusandığın Miğfer/Defansı : {0}/{1}\nDefansınız : {2}\n", İtemMigfer[kusanmaMigferID].migferİtemİsim, kusanmaMigfer, Defance);
                    Console.Write("[1] {0}/{1} : {2}\n[2] {3}/{4} : {5}\n[3] {6}/{7} : {8}\n[4] {9}/{10} : {11}\nAlmak istediğin bir Miğfer var mı : ", İtemMigfer[0].migferİtemİsim, İtemMigfer[0].migferDegisecekDeger, İtemMigfer[0].migferİtemSayi, İtemMigfer[1].migferİtemİsim, İtemMigfer[1].migferDegisecekDeger, İtemMigfer[1].migferİtemSayi, İtemMigfer[2].migferİtemİsim, İtemMigfer[2].migferDegisecekDeger, İtemMigfer[2].migferİtemSayi, İtemMigfer[3].migferİtemİsim, İtemMigfer[3].migferDegisecekDeger, İtemMigfer[3].migferİtemSayi);
                    İtemSecim = Convert.ToInt32(Console.ReadLine());
                    MigferİtemSatınalma(İtemSecim);
                }
                else if (İtemSecim == 5)
                {
                    Console.Write("kusandığın Gövde Zırhı/Defansı : {0}/{1}\nDefansınız : {2}\n", İtemGZirhi[kusanmaGZirhiID].gZirhiİtemİsim, kusanmaGZirhi, Defance);
                    Console.Write("[1] {0}/{1} : {2}\n[2] {3}/{4} : {5}\n[3] {6}/{7} : {8}\n[4] {9}/{10} : {11}\nAlmak istediğin bir Gövde Zırhı var mı : ", İtemGZirhi[0].gZirhiİtemİsim, İtemGZirhi[0].gZirhiDegisecekDeger, İtemGZirhi[0].gZirhiİtemSayi, İtemGZirhi[1].gZirhiİtemİsim, İtemGZirhi[1].gZirhiDegisecekDeger, İtemGZirhi[1].gZirhiİtemSayi, İtemGZirhi[2].gZirhiİtemİsim, İtemGZirhi[2].gZirhiDegisecekDeger, İtemGZirhi[2].gZirhiİtemSayi, İtemGZirhi[3].gZirhiİtemİsim, İtemGZirhi[3].gZirhiDegisecekDeger, İtemGZirhi[3].gZirhiİtemSayi);
                    İtemSecim = Convert.ToInt32(Console.ReadLine());
                    GZirhiİtemSatınalma(İtemSecim);
                }
                else if (İtemSecim == 6)
                {
                    Console.Write("kusandığın Bacak Zırhı/Defansı : {0}/{1}\nDefansınız : {2}\n", İtemBZirhi[kusanmaBZirhiID].bZirhiİtemİsim, kusanmaBZirhi, Defance);
                    Console.Write("[1] {0}/{1} : {2}\n[2] {3}/{4} : {5}\n[3] {6}/{7} : {8}\n[4] {9}/{10} : {11}\nAlmak istediğin bir Bacak Zırhı var mı : ", İtemBZirhi[0].bZirhiİtemİsim, İtemBZirhi[0].bZirhiDegisecekDeger, İtemBZirhi[0].bZirhiİtemSayi, İtemBZirhi[1].bZirhiİtemİsim, İtemBZirhi[1].bZirhiDegisecekDeger, İtemBZirhi[1].bZirhiİtemSayi, İtemBZirhi[2].bZirhiİtemİsim, İtemBZirhi[2].bZirhiDegisecekDeger, İtemBZirhi[2].bZirhiİtemSayi, İtemBZirhi[3].bZirhiİtemİsim, İtemBZirhi[3].bZirhiDegisecekDeger, İtemBZirhi[3].bZirhiİtemSayi);
                    İtemSecim = Convert.ToInt32(Console.ReadLine());
                    BZirhiİtemSatınalma(İtemSecim);
                }
                else if (İtemSecim == 7)
                {
                    Console.Write("kusandığın Kol Zırhı/Defansı : {0}/{1}\nDefansınız : {2}\n", İtemKZirhi[kusanmaKZirhiID].kZirhiİtemİsim, kusanmaKZirhi, Defance);
                    Console.Write("[1] {0}/{1} : {2}\n[2] {3}/{4} : {5}\n[3] {6}/{7} : {8}\n[4] {9}/{10} : {11}\nAlmak istediğin bir Kol Zırhı var mı : ", İtemKZirhi[0].kZirhiİtemİsim, İtemKZirhi[0].kZirhiDegisecekDeger, İtemKZirhi[0].kZirhiİtemSayi, İtemKZirhi[1].kZirhiİtemİsim, İtemKZirhi[1].kZirhiDegisecekDeger, İtemKZirhi[1].kZirhiİtemSayi, İtemKZirhi[2].kZirhiİtemİsim, İtemKZirhi[2].kZirhiDegisecekDeger, İtemKZirhi[2].kZirhiİtemSayi, İtemKZirhi[3].kZirhiİtemİsim, İtemKZirhi[3].kZirhiDegisecekDeger, İtemKZirhi[3].kZirhiİtemSayi);
                    İtemSecim = Convert.ToInt32(Console.ReadLine());
                    KZirhiİtemSatınalma(İtemSecim);
                }
                else if (İtemSecim == 8)
                {
                    Console.Write("kusandığın Eldiven/Defansı : {0}/{1}\nDefansınız : {2}\n", İtemEldiven[kusanmaEldivenID].eldivenİtemİsim, kusanmaEldiven, Defance);
                    Console.Write("[1] {0}/{1} : {2}\n[2] {3}/{4} : {5}\n[3] {6}/{7} : {8}\n[4] {9}/{10} : {11}\nAlmak istediğin bir Eldiven var mı : ", İtemEldiven[0].eldivenİtemİsim, İtemEldiven[0].eldivenDegisecekDeger, İtemEldiven[0].eldivenİtemSayi, İtemEldiven[1].eldivenİtemİsim, İtemEldiven[1].eldivenDegisecekDeger, İtemEldiven[1].eldivenİtemSayi, İtemEldiven[2].eldivenİtemİsim, İtemEldiven[2].eldivenDegisecekDeger, İtemEldiven[2].eldivenİtemSayi, İtemEldiven[3].eldivenİtemİsim, İtemEldiven[3].eldivenDegisecekDeger, İtemEldiven[3].eldivenİtemSayi);
                    İtemSecim = Convert.ToInt32(Console.ReadLine());
                    EldivenİtemSatınalma(İtemSecim);
                }
                else if (İtemSecim == 9)
                {
                    Console.Write("kusandığın Bot/Defansı : {0}/{1}\nDefansınız : {2}\n", İtemBot[kusanmaBotID].botİtemİsim, kusanmaBot, Defance);
                    Console.Write("[1] {0}/{1} : {2}\n[2] {3}/{4} : {5}\n[3] {6}/{7} : {8}\n[4] {9}/{10} : {11}\nAlmak istediğin bir Bot var mı : ", İtemBot[0].botİtemİsim, İtemBot[0].botDegisecekDeger, İtemBot[0].botİtemSayi, İtemBot[1].botİtemİsim, İtemBot[1].botDegisecekDeger, İtemBot[1].botİtemSayi, İtemBot[2].botİtemİsim, İtemBot[2].botDegisecekDeger, İtemBot[2].botİtemSayi, İtemBot[3].botİtemİsim, İtemBot[3].botDegisecekDeger, İtemBot[3].botİtemSayi);
                    İtemSecim = Convert.ToInt32(Console.ReadLine());
                    BotİtemSatınalma(İtemSecim);
                }
                else if (İtemSecim == 10)
                {
                    Console.Write("kusandığın Kolye : {0}\n", İtemKolye[kusanmaKolyeID].kolyeİtemİsim);
                    Console.Write("[1] {0} : {1}\n[2] {2} : {3}\n[3] {4}/ : {5}\nAlmak istediğin bir Kolye var mı : ", İtemKolye[0].kolyeİtemİsim, İtemKolye[0].kolyeİtemSayi, İtemKolye[1].kolyeİtemİsim, İtemKolye[1].kolyeİtemSayi, İtemKolye[2].kolyeİtemİsim, İtemKolye[2].kolyeİtemSayi);
                    İtemSecim = Convert.ToInt32(Console.ReadLine());
                    KolyeİtemSatınalma(İtemSecim);
                }
                else if (İtemSecim == 11)
                {
                    Console.Write("kusandığın Bilezik : {0}\n", İtemBilezik[kusanmaBilezikID].bilezikİtemİsim);
                    Console.Write("[1] {0} : {1}\n[2] {2}/ : {3}\n[3] {4} : {5}\nAlmak istediğin bir yay var mı : ", İtemBilezik[0].bilezikİtemİsim, İtemBilezik[0].bilezikİtemSayi, İtemBilezik[1].bilezikİtemİsim, İtemBilezik[1].bilezikİtemSayi, İtemBilezik[2].bilezikİtemİsim, İtemBilezik[2].bilezikİtemSayi);
                    İtemSecim = Convert.ToInt32(Console.ReadLine());
                    BİlezikİtemSatınalma(İtemSecim);
                }
                else if (İtemSecim == 12)
                {
                    Console.Write("kusandığın Yüzük/Hasarı : {0}\n", İtemYuzuk[kusanmaYuzukID].yuzukİtemİsim);
                    Console.Write("[1] {0} : {1}\n[2] {2} : {3}\n[3] {4} : {5}\nAlmak istediğin bir Yüzük var mı : ", İtemYuzuk[0].yuzukİtemİsim, İtemYuzuk[0].yuzukİtemSayi, İtemYuzuk[1].yuzukİtemİsim, İtemYuzuk[1].yuzukİtemSayi, İtemYuzuk[2].yuzukİtemİsim, İtemYuzuk[2].yuzukİtemSayi);
                    İtemSecim = Convert.ToInt32(Console.ReadLine());
                    YuzukİtemSatınalma(İtemSecim);
                }
                else if (İtemSecim == 13)
                {
                    Console.Write("kusandığın Küpe/Hasarı : {0}\n", İtemKupe[kusanmaKupeID].kupeİtemİsim);
                    Console.Write("[1] {0} : {1}\n[2] {2} : {3}\n[3] {4} : {5}\nAlmak istediğin bir Küpe var mı : ", İtemKupe[0].kupeİtemİsim, İtemKupe[0].kupeİtemSayi, İtemKupe[1].kupeİtemİsim, İtemKupe[1].kupeİtemSayi, İtemKupe[2].kupeİtemİsim, İtemKupe[2].kupeİtemSayi);
                    İtemSecim = Convert.ToInt32(Console.ReadLine());
                    KupeİtemSatınalma(İtemSecim);
                }
                else if (İtemSecim == 14)
                {
                    Console.Write("Silah : {0}/{1}\nYay : {2}/{3}   Ok : {4}/{5}\nKalkan : {6}/{7}\nMiğfer : {8}/{9}\nGövde Zırhı : {10}/{11}\nBacak Zırhı : {12}/{13}\nKol Zırhı : {14}/{15}\nEldiven : {16}/{17}\nBot : {18}/{19}\nKolye : {20}\nBilezik : {21}\nYüzük : {22}\nKüpe : {23}\n", İtemSilah[KusanmaSilahID].silahİtemİsim, İtemSilah[KusanmaSilahID].silahDegisecekDeger, İtemYay[KusanmaYayID].yayİtemİsim, İtemYay[KusanmaYayID].yayDegisecekDeger, İtemOk[KusanmaOkID].okİtemİsim, İtemOk[KusanmaOkID].okDegisecekDeger, İtemKalkan[KusanmaKalkanID].kalkanİtemİsim, İtemKalkan[KusanmaKalkanID].kalkanDegisecekDeger, İtemMigfer[KusanmaMigferID].migferİtemİsim, İtemMigfer[KusanmaMigferID].migferDegisecekDeger, İtemGZirhi[KusanmaGZirhiID].gZirhiİtemİsim, İtemGZirhi[KusanmaGZirhiID].gZirhiDegisecekDeger, İtemBZirhi[KusanmaBZirhiID].bZirhiİtemİsim, İtemBZirhi[KusanmaBZirhiID].bZirhiDegisecekDeger, İtemKZirhi[KusanmaKZirhiID].kZirhiİtemİsim, İtemKZirhi[KusanmaKZirhiID].kZirhiDegisecekDeger, İtemEldiven[KusanmaEldivenID].eldivenİtemİsim, İtemEldiven[KusanmaEldivenID].eldivenDegisecekDeger, İtemBot[KusanmaBotID].botİtemİsim, İtemBot[KusanmaBotID].botDegisecekDeger, İtemKolye[KusanmaKolyeID].kolyeİtemİsim, İtemBilezik[KusanmaBilezikID].bilezikİtemİsim, İtemYuzuk[KusanmaYuzukID].yuzukİtemİsim, İtemKupe[KusanmaKupeID].kupeİtemİsim);
                }
                else if (İtemSecim == 15)
                {
                    itemSayac = 0;
                }
            }
        }




    }
}
