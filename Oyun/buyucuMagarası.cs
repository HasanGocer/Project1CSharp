using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oyun
{
    public class buyucuMagarası : AnaBolme
    {
        public void bMagaraSecim1()
        {
            int bMagaraSecim;
            for (int i1 = 1; i1 != 0;)
            {
                Console.Write("Büyücü: Ne hakkında tavsiye almak istersin genç adam?\n[1] İksir Tarifi\n[2]Büyü Öğrenme\n[3] Silah Efsunlama\n[4] Geri Dönmek için\nNe tavsiyesi almak istersiniz : ");
                bMagaraSecim = Convert.ToInt32(Console.ReadLine());
                if (bMagaraSecim == 1)
                {
                    for (int i2 = 1; i2 != 0;)
                    {
                        Console.Write("Ne İksirinin Tarifini istiyorsun?\n[1]Görünmezlik(500G)\n[2]Güç(250g)\n[3]Sağlık\n(100G)\n[4]Geri Dönmek için\nNe öğrenmek istersin : ");
                        bMagaraSecim = Convert.ToInt32(Console.ReadLine());
                        if (bMagaraSecim == 1)
                        {
                            if (gold > 500)
                            {
                                //gold = gold - 500;
                                Console.Write("Görünmezlik iksiri satın aldın. Daha eklemedik sonra tekrar dene.\n");
                            }
                            else
                            {
                                Console.Write("Malesef paranız yetmiyor.\n");
                            }

                        }
                        else if (bMagaraSecim == 2)
                        {
                            if (gold > 250)
                            {
                                gold = gold - 250;
                                damage = damage + 30;
                                Console.Write("güç iksirini kullandın\nAltınınız(-250) : {0}\nHasarınız(+30) : {1}", gold, damage);
                            }
                        }
                        else if (bMagaraSecim == 3)
                        {
                            gold = gold - 100;
                            health = health + 50;
                            mHealth = mHealth + 50;
                            Console.Write("can iksirini kullandınız\nAltınız(-100) : {0}\nCanınız(+50) : {1}/{2}\n", gold, health, mHealth);
                        }
                        else if (bMagaraSecim == 4)
                        {
                            i2 = 0;
                            Console.Write("çıkış yapılıyor\n");
                        }

                    }
                }
                else if (bMagaraSecim == 2)
                {
                    for (int i2 = 1; i2 != 0;)
                    {
                        Console.Write("[1] Alevtopu (1000G)\n[2] İyileştirme (700G)\n[3] Stamina Yenileme (500G)\n[4] Geri Dönmek için\nHangi büyüyü öğrenmek istiyorsun : \n");
                        bMagaraSecim = Convert.ToInt32(Console.ReadLine());
                        if (bMagaraSecim == 1)
                        {
                            if (gold > 1000)
                            {
                                Console.Write("eklenecek sonra\n");
                            }
                            else
                            {
                                Console.Write("paranız malesef yetmedi.\n");
                            }

                        }
                        else if (bMagaraSecim == 2)
                        {
                            if (gold > 700)
                            {
                                Console.Write("eklenecek sonra\n");
                            }
                            else
                            {
                                Console.Write("paranız malesef yetmedi.\n");
                            }

                        }
                        else if (bMagaraSecim == 3)
                        {
                            if (gold > 500)
                            {
                                Console.Write("eklenecek sonra\n");
                            }
                            else
                            {
                                Console.Write("paranız malesef yetmedi.\n");
                            }

                        }
                        else if (bMagaraSecim == 4)
                        {
                            i2 = 0;
                            Console.Write("çıkış yapılıyor\n");
                        }
                    }

                }
                else if (bMagaraSecim == 3)
                {
                    for (int i2 = 1; i2 != 0;)
                    {
                        Console.Write("[1] Alevleme (2000G)\n[2] Zehir (1200g)\n[3] Dayanıklılık (500G)\n[4] Geri Dönmek için\nHangi büyüyü öğrenmek istiyorsun : \n");
                        bMagaraSecim = Convert.ToInt32(Console.ReadLine());
                        if (bMagaraSecim == 1)
                        {
                            if (gold > 2000)
                            {
                                Console.Write("eklenecek sonra\n");
                            }
                            else
                            {
                                Console.Write("paranız malesef yetmedi.\n");
                            }

                        }
                        else if (bMagaraSecim == 2)
                        {
                            if (gold > 1200)
                            {
                                Console.Write("eklenecek sonra\n");
                            }
                            else
                            {
                                Console.Write("paranız malesef yetmedi.\n");
                            }

                        }
                        else if (bMagaraSecim == 3)
                        {
                            if (gold > 500)
                            {
                                Console.Write("eklenecek sonra\n");
                            }
                            else
                            {
                                Console.Write("paranız malesef yetmedi.\n");
                            }

                        }
                        else if (bMagaraSecim == 4)
                        {
                            i2 = 0;
                            Console.Write("çıkış yapılıyor\n");
                        }
                    }

                }
                else if (bMagaraSecim == 4)
                {
                    i1 = 0;
                    Console.Write("çıkış yapılıyor\n");
                }
            }


        }

        public void bMagaraSecim2()
        {
            
        }

        public void bMagaraSecim3()
        {

        }
    }
}
