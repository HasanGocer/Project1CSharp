using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oyun
{
    public class AskCesmesi : AnaBolme
    {
        public void AskCesmesiSecim1()
        {
            Random rnd = new Random();
            int askSecim, askİhtimal;
            askİhtimal = rnd.Next(1, 10);
            Console.Write("İhtimaller\n[1] Zengin olmak.\n[2] Onurun artması.\n[3] Yeni bir zırh.\n[4] Güçlenmek.\nNe dilemek istersin : ");
            askSecim = Convert.ToInt32(Console.ReadLine());
            if (askİhtimal == 1 && askSecim == 1)
            {
                Console.Write("Dileğini tuttuktan sonra yolda yürürken bir hırsızın güzel bir kadının çantasını çalarken gördün.\n[1] Peşine düş.\n[2] Umursama.\nNe dilemek istersin : ");
                askSecim = Convert.ToInt32(Console.ReadLine());
                if (askSecim == 1)
                {
                    Console.Write("Uzun bir çabadan sonra çantayı hırsızdan aldın ve hırsızı patakladın.Çantayı açtın ve o da ne!! içinde bir sürü para var.\n[1] Çantayı sahibine götür.\n[2] Çanta al ve kaç.\nNe dilemek istersin : ");
                    askSecim = Convert.ToInt32(Console.ReadLine());
                    if (askSecim == 1)
                    {
                        Console.Write("Çantayı sahibine götürdün ve kadın bunun karşılığında sana bir miktar para verdi.\n");
                        gold = gold + 200;
                        honor = honor + 20;
                        Console.Write("altınınız(+200) : {0} onurunuz(+20) : {1}\n", gold, honor);
                    }
                    else
                    {
                        gold = gold + 500;
                        honor = honor - 10;
                        Console.Write("altınınız(+500) : {0} onurunuz(-10) : {1}\n", gold, honor);
                    }
                }
            }
            else if (askİhtimal == 2 && askSecim == 2)
            {
                Console.Write("Yolda giderken bir adamın siyahi bir adamı aşağıladığını gördün.\n[1] Siyahi adama yardım et.\n[2] Umursama.\nNe dilemek istersin : ");
                askSecim = Convert.ToInt32(Console.ReadLine());
                if (askSecim == 1)
                {
                    Console.Write("Adamın yanına gittin ve yaptığının yanlış olduğunu söyledin ama o da ne!! Adam sana karşılık verdi.\n[1] Sende karşılık ver.\n[2] Uyarmaya devam et.\nNe dilemek istersin : ");
                    askSecim = Convert.ToInt32(Console.ReadLine());
                    if (askSecim == 1)
                    {
                        Console.Write("Adamı patakladın ve adam sinirli bakışlar ile kaçtı.Siyahi adam ise kısık ve korku dolu bir ses ile koşarak uzaklaştı.\n");
                        honor = honor + 50;
                        Console.WriteLine("onurunuz(+50) : {0}\n", honor);
                    }
                    else if (askSecim == 2)
                    {
                        Console.Write("Adam senin uyarı ve hoşgörüne rağmen aynı harekete devam ediyor.\n[1] Karşılık ver.\n[2] Birşey yapma ve uzaklaş\nNe dilemek istersin : ");
                        askSecim = Convert.ToInt32(Console.ReadLine());
                        if (askSecim == 1)
                        {
                            Console.Write("Adamı patakladın ve adam sinirli bakışlar ile kaçtı.Siyahi adam ise kısık ve korku dolu bir ses ile koşarak uzaklaştı.\n");
                            honor = honor + 50;
                            Console.WriteLine("onurunuz(+50) : {0}\n", honor);
                        }
                        else
                        {
                            honor = honor - 5;
                            Console.WriteLine("onurunuz(-5) : {0}\n", honor);
                        }
                    }
                }
                else if (askSecim == 2)
                {
                    honor = honor - 5;
                    Console.WriteLine("onurunuz(-5) : {0}\n", honor);
                }
            }
            else if (askİhtimal == 3 && askSecim == 3)
            {
                Console.Write("Yolda giderken bir at arabasından sandık düştüğünü gördün.Hemen gidip açtın ve o da ne!İçinde çok güzel bir zırh var.\n[1] Zırhı al.\n[2] At arabasının arkasından bağır.\nNe dilemek istersin : ");
                askSecim = Convert.ToInt32(Console.ReadLine());
                if (askSecim == 1)
                {
                    defance = defance + 50;
                    Console.Write("Zırh hoşuna gitti ve zırhı aldın.\n defansınız(+50) : {0}\n", defance);
                }
                else if (askSecim == 2)
                {
                    defance = defance + 50;
                    honor = honor + 30;
                    Console.Write("At arabsının akrasından bağırdın lakin seni duymadılar.Yeni zırh...\n defansınız(+50) : {0}\nonurunuz(+30) : {1}", AnaBolme.defance, AnaBolme.honor);
                }
            }
            else if (askİhtimal == 4 && askSecim == 4)
            {
                damage = damage + 300;
                Console.Write("Dileğini tuttun ve yolda gidiyorsun o da ne!! Tanrı HG sana ilahi bir güç bahşetti.\nhasarınız(+300) : {0}", AnaBolme.damage);
            }
        }
        public void AskCesmesiSecim2()
        {
            int askSecim;
            Console.Write("Bir kadın ile tanıştın.\nKadın : Merhabalar bana bir konuda yardımcı olur musunuz?\n[1] Yardım et.\n[2] Umursama.\n");
            askSecim = Convert.ToInt32(Console.ReadLine());
            if (askSecim == 1)
            {
                Console.Write("{0} : Tabi ki! Buyrun sizi dinliyorum!\nKadın : Şu köşede gördüğünüz adamlar bana zorbalık yapıyorlar.Bana yardım etmeniz karşılığında size çalıştığım barda bir içki verebilir ve bara girişinizin kolay olmasını sağlayabilirim.\n[1] Yabancı kadının dediğini yap.\n[2] Yapma ve uzaklaş.\n", isim);
                askSecim = Convert.ToInt32(Console.ReadLine());
                if (askSecim == 1)
                {
                    gold = gold + 50;
                    honor = honor + 20;
                    Console.Write("Yabancı kadının dediğini yaptın ve adamları patakladın.Ceblerinden bir miktar altin çıktı.\nAltınınız : {0}\nonurunuz : {1}\nYabancı Kadın:Çok teşekkür ederim efendim.Adım Lisa.Hemen şu aşağıdaki barda çalışıyorum isterseniz gidebiliriz.\n[1] Git.\n[2] Gitme\n", gold, honor);
                    askSecim = Convert.ToInt32(Console.ReadLine());
                    if (askSecim == 1)
                    {
                        Console.Write("Lisa ile beraber çalıştığı bara gittiniz ve içtiniz.Lisa sana bir işini halletmen karşılığında barın özel girişi için bir giriş kartı vereceğinin söyledi.Fakat bu iş için 3 gün sonra gelmen gerektiğini ve işi o zaman anlatacağını söyledi.\n[1] Kabul et.\n[2] Kabul etme.\n");
                        askSecim = Convert.ToInt32(Console.ReadLine());
                        if (askSecim == 1)
                        {
                            //özel alan
                            /*
                            Console.Write("Lisa : Bara akşam saatlerinde gelen bir zorba var.Zamanında benim en kıymetli eşyamı çaldı.Eğer eşyamı alıp hakettiğini ona verirsen anlaşmamız gerçekleşir.Lisa'nın dediği adamı takip ettin ve adamla yüzleşmek için uygun bir fırsat buldun.\n[1] Adamla yüzleş.\n[2] Bekle.\n");
                            askSecim = Convert.ToInt32(Console.ReadLine());
                            if(askSecim==1)
                            {
                                gold = gold + 15;
                                Console.Write("Adamdan eşyayı aldın ve adamı fena benzettin.Eşyayı aldın ve Lisaya götürdün ve bunun karşılığında bara özel giriş kartını aldın\nAltınınız(+15) : {0}\n",gold);
                            }
                            else if(askSecim==2)
                            {
                                Console.Write("Bekledin ve adam gözden kayboldu görev başarısız!!\n");
                            }
                            */
                        }
                        else if (askSecim == 2)
                        {
                            gold = gold - 20;
                            health = health - 10;
                            Console.Write("Lisa'nın dediğini yapmadın ve bu yüzden sinirlenen Lisa oyalandığını düşündü ve seni bardaki bir kaç soytarıya dövdürdü\nAltınınız(-20) : {0}\nCanınız(-10) : {1}",gold,health);
                        }
                    }
                }
                else if (askSecim == 2)
                {
                    Console.Write("Yabancı kadının dediğini yapmadın ve uzaklaştın.");
                }
            }
        }
        public void AskCesmesiSecim3()
        {
            //ticaret
        }

    }
}
