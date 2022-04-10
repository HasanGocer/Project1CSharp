using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oyun
{
    public class Orman : AnaBolme
    {

        public void OrmanSecim1()
        {
            Random rnd = new Random();
            int ormanİhtimal = rnd.Next(1, 15);
            Console.Write("{0} tane çubuk buldun ve güzel oklar yaptın.\n", ormanİhtimal);
        }
        public void OrmanSecim2()
        {
            Random rnd = new Random();
            int ormanİhtimal = rnd.Next(1, 25);

            if (ormanİhtimal > 20)
            {
                Console.Write("Orman kıyılarında gezerken bir meyve sepeti buldun.İtem eklenince meyve sepeti eklensin\n");
            }
            else if (ormanİhtimal > 15)
            {
                gold = gold + 100;
                Console.Write("Ormanın kıyılarında gezerken bir kese altın buldun. Kısa günün karı.\nAltınınız(+100) : {0}", gold);
            }
            else if (ormanİhtimal > 10)
            {
                Console.Write("Ormanın kıyısında gezerken yaşlı bir dedeye rast geldin. Yardım istiyor yardım eder misin?\n[1] Yardım et\n[2] Yardım etme\n");
                int ormanSecim = Convert.ToInt32(Console.ReadLine());

                if (ormanSecim == 1)
                {
                    honor = honor + 10;
                    Console.Write("Dedenin malzemelerini dağ başındaki evine taşıyorsun. sana teşekkür ediyor\n onurunuz(+10) : {0}", honor);
                }
                else if (ormanSecim == 2)
                {
                    Console.Write("Toplum lincine uğruyorsun Hem saldırıya uğruyorsun hem de onurun azaldı\nCanınız(-15) : {0}\nOnurunuz(-10) : {1}", health, honor);
                }
            }
            else if (ormanİhtimal > 5)
            {
                Console.Write("Ormanda bir yerliye rastladın sana saldırdı.\n");
                Arena arena = new Arena();
                int dMCan = 100, dCan = 100, dSaldiri = 10, dDefance = 10;
                arena.Savas(dMCan, dCan, dSaldiri, dDefance);
            }
            else if (ormanİhtimal > 0)
            {
                Console.Write("Ne bir şey gördün ne bir şeye rastladın bomboş bir gün geçirdin\n");
            }
        }
        public void OrmanSecim3()
        {
            Console.Write("üzel ve tatlı meyveler topladın. İtemler geldiğinde meyveler eklenmeli rastgelelikle meyveler bulsun\n");
        }
        public void OrmanSecim4()
        {
            Giris giris = new Giris();
            Arena arena = new Arena();
            int dMCan = 500, dCan = 500, dSaldiri = 50, dDefance = 50, ormanSayac1 = 1, yon = 1, oX = 0, oY = 0;
            char ormanSecenek;
            int[,] ormanDizi = new int[20, 20];
            Console.Write("Ormanın derinliklerine dalıyorsun burada bir sürü pisliğin döndüğüne dair dedikodular zihnini kurcalıyor. İçeri giriyorsun şimdi vereceğin kararlar çok önemli çünkügirdiğin her alanda ya seni öldürecek risklere sahip bir yere girmiş olacaksın ya da büyük ödüllere kavuşacaksın. ilk olarak derinlere fazla gidersen bazı canavarlarla karşılaşabilirsin o yüzden fazla uzaklaşmadığından ve dönüş yolunu bildiğinden emin ol. Gittiğin yolun tam tersine giderek ormandan çıkacaksın dikkat et dönüş yolunu unutursan ormanda ölümle burun burunasın\n");

            for (ormanSayac1 = 0; ormanSayac1 < 20; ormanSayac1++)
            {
                for (int ormanSayac2 = 0; ormanSayac2 < 20; ormanSayac2++)
                {
                    ormanDizi[ormanSayac1, ormanSayac2] = 0;
                }
            }
            
            while (ormanSayac1 != 0)
            {
                Console.Write("ileri girmek için w\'ye bas\nsağa gitmek içind\'ye bas\nsola gitmek için a\'ya bas\ngeri gitmek içins\'ye bas\ngeri dönmek için g\'ye bas\nne yapmak istersin : ");
                ormanSecenek = Convert.ToChar(Console.ReadLine());

                if (yon == 1)
                {
                    if (ormanSecenek == 'w' || ormanSecenek == 'W')
                    {
                        oY++;
                        if (oY > (-1) || oY < 19)
                        {
                            if (ormanDizi[20 - oY, 10 + oX] == 1)
                            {
                                Console.Write("buraya önceden gelmişsin ya da başkası talan etmiş\n");
                            }
                            else
                            {
                                giris.Orman();
                            }
                            ormanDizi[20 - oY, 10 + oX] = 1;
                            yon = 1;
                        }
                        else
                        {
                            Console.Write("ormanın o kadar derinlerine daldın ki kendini bir canavarın ininin öünde buldun ve canavar seni çoktan görmüştü. savaşmaktan başka çaren yok\n");
                            arena.Savas(dMCan, dCan, dSaldiri, dDefance);
                            oY--;
                            ormanSayac1 = 0;
                        }
                    }

                    if (ormanSecenek == 'd' || ormanSecenek == 'D')
                    {
                        oX++;
                        if (oX < 9 || oX > (-9))
                        {
                            if (ormanDizi[20 - oY, 10 + oX] == 1)
                            {
                                Console.Write("buraya önceden gelmişsin ya da başkası talan etmiş\n");
                            }
                            else
                            {
                                giris.Orman();
                            }
                            ormanDizi[20 - oY, 10 + oX] = 1;
                            yon = 2;
                        }
                        else
                        {
                            Console.Write("ormanın o kadar derinlerine daldın ki kendini bir canavarın ininin öünde buldun ve canavar seni çoktan görmüştü. savaşmaktan başka çaren yok\n");
                            arena.Savas(dMCan, dCan, dSaldiri, dDefance);
                            oX--;
                            ormanSayac1 = 0;
                        }
                    }

                    if (ormanSecenek == 'a' || ormanSecenek == 'A')
                    {
                        oX--;
                        if (oX < 9 || oX > (-9))
                        {
                            if (ormanDizi[20 - oY, 10 + oX] == 1)
                            {
                                Console.Write("buraya önceden gelmişsin ya da başkası talan etmiş\n");
                            }
                            else
                            {
                                giris.Orman();
                            }
                            ormanDizi[20 - oY, 10 + oX] = 1;
                            yon = 3;
                        }
                        else
                        {
                            Console.Write("ormanın o kadar derinlerine daldın ki kendini bir canavarın ininin öünde buldun ve canavar seni çoktan görmüştü. savaşmaktan başka çaren yok\n");
                            arena.Savas(dMCan, dCan, dSaldiri, dDefance);
                            oX++;
                            ormanSayac1 = 0;
                        }

                    }

                    if (ormanSecenek == 's' || ormanSecenek == 'S')
                    {
                        oY--;
                        if (oY > (-1) || oY < 19)
                        {
                            if (ormanDizi[20 - oY, 10 + oX] == 1)
                            {
                                Console.Write("buraya önceden gelmişsin ya da başkası talan etmiş\n");
                            }
                            else
                            {
                                giris.Orman();
                            }
                            ormanDizi[20 - oY, 10 + oX] = 1;
                            yon = 4;
                        }
                        else
                        {
                            Console.Write("ormanın o kadar derinlerine daldın ki kendini bir canavarın ininin öünde buldun ve canavar seni çoktan görmüştü. savaşmaktan başka çaren yok\n");
                            arena.Savas(dMCan, dCan, dSaldiri, dDefance);
                            oY++;
                            ormanSayac1 = 0;
                        }
                    }
                    if (ormanSecenek == 'g' || ormanSecenek == 'G')
                    {
                        Console.Write("Çıkmak istiyorsun demek o zaman geldiğin yolu hatırlayıp geri dönmen gerekir.\n");
                        ormanSayac1 = 0;
                    }
                }

                if (yon == 2)
                {
                    if (ormanSecenek == 'w' || ormanSecenek == 'W')
                    {
                        oX++;
                        if (oX < 9 || oX > (-9))
                        {
                            if (ormanDizi[20 - oY, 10 + oX] == 1)
                            {
                                Console.Write("buraya önceden gelmişsin ya da başkası talan etmiş\n");
                            }
                            else
                            {
                                giris.Orman();
                            }
                            ormanDizi[20 - oY, 10 + oX] = 1;
                            yon = 2;
                        }
                        else
                        {
                            Console.Write("ormanın o kadar derinlerine daldın ki kendini bir canavarın ininin öünde buldun ve canavar seni çoktan görmüştü. savaşmaktan başka çaren yok\n");
                            arena.Savas(dMCan, dCan, dSaldiri, dDefance);
                            oX--;
                            ormanSayac1 = 0;
                        }
                    }
                    
                    if (ormanSecenek == 'd' || ormanSecenek == 'D')
                    {
                        oY--;
                        if (oY > (-1) || oY < 19)
                        {
                            if (ormanDizi[20 - oY, 10 + oX] == 1)
                            {
                                Console.Write("buraya önceden gelmişsin ya da başkası talan etmiş\n");
                            }
                            else
                            {
                                giris.Orman();
                            }
                            ormanDizi[20 - oY, 10 + oX] = 1;
                            yon = 4;
                        }
                        else
                        {
                            Console.Write("ormanın o kadar derinlerine daldın ki kendini bir canavarın ininin öünde buldun ve canavar seni çoktan görmüştü. savaşmaktan başka çaren yok\n");
                            arena.Savas(dMCan, dCan, dSaldiri, dDefance);
                            oY++;
                            ormanSayac1 = 0;
                        }
                    }

                    if (ormanSecenek == 'a' || ormanSecenek == 'A')
                    {
                        oY++;
                        if (oY > (-1) || oY < 19)
                        {
                            if (ormanDizi[20 - oY, 10 + oX] == 1)
                            {
                                Console.Write("buraya önceden gelmişsin ya da başkası talan etmiş\n");
                            }
                            else
                            {
                                giris.Orman();
                            }
                            ormanDizi[20 - oY, 10 + oX] = 1;
                            yon = 1;
                        }
                        else
                        {
                            Console.Write("ormanın o kadar derinlerine daldın ki kendini bir canavarın ininin öünde buldun ve canavar seni çoktan görmüştü. savaşmaktan başka çaren yok\n");
                            arena.Savas(dMCan, dCan, dSaldiri, dDefance);
                            oY--;
                            ormanSayac1 = 0;
                        }

                    }

                    if (ormanSecenek == 's' || ormanSecenek == 'S')
                    {
                        oX--;
                        if (oX < 9 || oX > (-9))
                        {
                            if (ormanDizi[20 - oY, 10 + oX] == 1)
                            {
                                Console.Write("buraya önceden gelmişsin ya da başkası talan etmiş\n");
                            }
                            else
                            {
                                giris.Orman();
                            }
                            ormanDizi[20 - oY, 10 + oX] = 1;
                            yon = 3;
                        }
                        else
                        {
                            Console.Write("ormanın o kadar derinlerine daldın ki kendini bir canavarın ininin öünde buldun ve canavar seni çoktan görmüştü. savaşmaktan başka çaren yok\n");
                            arena.Savas(dMCan, dCan, dSaldiri, dDefance);
                            oX++;
                            ormanSayac1 = 0;
                        }
                    }
                    if (ormanSecenek == 'g' || ormanSecenek == 'G')
                    {
                        Console.Write("Çıkmak istiyorsun demek o zaman geldiğin yolu hatırlayıp geri dönmen gerekir.\n");
                        ormanSayac1 = 0;
                    }
                }

                if (yon == 3)
                {
                    if (ormanSecenek == 'w' || ormanSecenek == 'W')
                    {
                        oX--;
                        if (oX < 9 || oX > (-9))
                        {
                            if (ormanDizi[20 - oY, 10 + oX] == 1)
                            {
                                Console.Write("buraya önceden gelmişsin ya da başkası talan etmiş\n");
                            }
                            else
                            {
                                giris.Orman();
                            }
                            ormanDizi[20 - oY, 10 + oX] = 1;
                            yon = 3;
                        }
                        else
                        {
                            Console.Write("ormanın o kadar derinlerine daldın ki kendini bir canavarın ininin öünde buldun ve canavar seni çoktan görmüştü. savaşmaktan başka çaren yok\n");
                            arena.Savas(dMCan, dCan, dSaldiri, dDefance);
                            oX++;
                            ormanSayac1 = 0;
                        }
                    }

                    if (ormanSecenek == 'd' || ormanSecenek == 'D')
                    {
                        oY++;
                        if (oY > (-1) || oY < 19)
                        {
                            if (ormanDizi[20 - oY, 10 + oX] == 1)
                            {
                                Console.Write("buraya önceden gelmişsin ya da başkası talan etmiş\n");
                            }
                            else
                            {
                                giris.Orman();
                            }
                            ormanDizi[20 - oY, 10 + oX] = 1;
                            yon = 1;
                        }
                        else
                        {
                            Console.Write("ormanın o kadar derinlerine daldın ki kendini bir canavarın ininin öünde buldun ve canavar seni çoktan görmüştü. savaşmaktan başka çaren yok\n");
                            arena.Savas(dMCan, dCan, dSaldiri, dDefance);
                            oY--;
                            ormanSayac1 = 0;
                        }
                    }

                    if (ormanSecenek == 'a' || ormanSecenek == 'A')
                    {
                        oY--;
                        if (oY > (-1) || oY < 19)
                        {
                            if (ormanDizi[20 - oY, 10 + oX] == 1)
                            {
                                Console.Write("buraya önceden gelmişsin ya da başkası talan etmiş\n");
                            }
                            else
                            {
                                giris.Orman();
                            }
                            ormanDizi[20 - oY, 10 + oX] = 1;
                            yon = 4;
                        }
                        else
                        {
                            Console.Write("ormanın o kadar derinlerine daldın ki kendini bir canavarın ininin öünde buldun ve canavar seni çoktan görmüştü. savaşmaktan başka çaren yok\n");
                            arena.Savas(dMCan, dCan, dSaldiri, dDefance);
                            oY++;
                            ormanSayac1 = 0;
                        }

                    }

                    if (ormanSecenek == 's' || ormanSecenek == 'S')
                    {
                        oX++;
                        if (oX < 9 || oX > (-9))
                        {
                            if (ormanDizi[20 - oY, 10 + oX] == 1)
                            {
                                Console.Write("buraya önceden gelmişsin ya da başkası talan etmiş\n");
                            }
                            else
                            {
                                giris.Orman();
                            }
                            ormanDizi[20 - oY, 10 + oX] = 1;
                            yon = 2;
                        }
                        else
                        {
                            Console.Write("ormanın o kadar derinlerine daldın ki kendini bir canavarın ininin öünde buldun ve canavar seni çoktan görmüştü. savaşmaktan başka çaren yok\n");
                            arena.Savas(dMCan, dCan, dSaldiri, dDefance);
                            oX--;
                            ormanSayac1 = 0;
                        }
                    }
                    if (ormanSecenek == 'g' || ormanSecenek == 'G')
                    {
                        Console.Write("Çıkmak istiyorsun demek o zaman geldiğin yolu hatırlayıp geri dönmen gerekir.\n");
                        ormanSayac1 = 0;
                    }

                }

                if (yon == 4)
                {
                    if (ormanSecenek == 'w' || ormanSecenek == 'W')
                    {
                        oY--;
                        if (oY > (-1) || oY < 19)
                        {
                            if (ormanDizi[20 - oY, 10 + oX] == 1)
                            {
                                Console.Write("buraya önceden gelmişsin ya da başkası talan etmiş\n");
                            }
                            else
                            {
                                giris.Orman();
                            }
                            ormanDizi[20 - oY, 10 + oX] = 1;
                            yon = 4;
                        }
                        else
                        {
                            Console.Write("ormanın o kadar derinlerine daldın ki kendini bir canavarın ininin öünde buldun ve canavar seni çoktan görmüştü. savaşmaktan başka çaren yok\n");
                            arena.Savas(dMCan, dCan, dSaldiri, dDefance);
                            oY++;
                            ormanSayac1 = 0;
                        }
                    }

                    if (ormanSecenek == 'd' || ormanSecenek == 'D')
                    {
                        oX--;
                        if (oX < 9 || oX > (-9))
                        {
                            if (ormanDizi[20 - oY, 10 + oX] == 1)
                            {
                                Console.Write("buraya önceden gelmişsin ya da başkası talan etmiş\n");
                            }
                            else
                            {
                                giris.Orman();
                            }
                            ormanDizi[20 - oY, 10 + oX] = 1;
                            yon = 3;
                        }
                        else
                        {
                            Console.Write("ormanın o kadar derinlerine daldın ki kendini bir canavarın ininin öünde buldun ve canavar seni çoktan görmüştü. savaşmaktan başka çaren yok\n");
                            arena.Savas(dMCan, dCan, dSaldiri, dDefance);
                            oX++;
                            ormanSayac1 = 0;
                        }
                    }

                    if (ormanSecenek == 'a' || ormanSecenek == 'A')
                    {
                        oX++;
                        if (oX < 9 || oX > (-9))
                        {
                            if (ormanDizi[20 - oY, 10 + oX] == 1)
                            {
                                Console.Write("buraya önceden gelmişsin ya da başkası talan etmiş\n");
                            }
                            else
                            {
                                giris.Orman();
                            }
                            ormanDizi[20 - oY, 10 + oX] = 1;
                            yon = 2;
                        }
                        else
                        {
                            Console.Write("ormanın o kadar derinlerine daldın ki kendini bir canavarın ininin öünde buldun ve canavar seni çoktan görmüştü. savaşmaktan başka çaren yok\n");
                            arena.Savas(dMCan, dCan, dSaldiri, dDefance);
                            oX--;
                            ormanSayac1 = 0;
                        }

                    }

                    if (ormanSecenek == 's' || ormanSecenek == 'S')
                    {
                        oY++;
                        if (oY > (-1) || oY < 19)
                        {
                            if (ormanDizi[20 - oY, 10 + oX] == 1)
                            {
                                Console.Write("buraya önceden gelmişsin ya da başkası talan etmiş\n");
                            }
                            else
                            {
                                giris.Orman();
                            }
                            ormanDizi[20 - oY, 10 + oX] = 1;
                            yon = 1;
                        }
                        else
                        {
                            Console.Write("ormanın o kadar derinlerine daldın ki kendini bir canavarın ininin öünde buldun ve canavar seni çoktan görmüştü. savaşmaktan başka çaren yok\n");
                            arena.Savas(dMCan, dCan, dSaldiri, dDefance);
                            oY--;
                            ormanSayac1 = 0;
                        }
                    }
                    if (ormanSecenek == 'g' || ormanSecenek == 'G')
                    {
                        Console.Write("Çıkmak istiyorsun demek o zaman geldiğin yolu hatırlayıp geri dönmen gerekir.\n");
                        ormanSayac1 = 0;
                    }
                }

                if (yon == 1)
                {
                    Console.Write(" \t\n\t/ \\\n\t |\n\t |\n\t |\n");
                }
                else if (yon == 2)
                {
                    Console.Write("<-----\n");
                }
                else if (yon == 3)
                {
                    Console.Write("        ----->\n");
                }
                else if (yon == 4)
                {
                    Console.Write(" \t |\n\t |\n\t |\n\t |\n\t\\ /\n");
                }

            }

            ormanSayac1 = 1;
            while (ormanSayac1 != 0)
            {
                Console.Write("ileri girmek için w\'ye bas\nsağa gitmek içind\'ye bas\nsola gitmek için a\'ya bas\ngeri gitmek için s\'ye bas\nne yapmak istersin : ");
                ormanSecenek = Convert.ToChar(Console.ReadLine());

                if (yon == 1)
                {
                    if (ormanSecenek == 'w' || ormanSecenek == 'W')
                    {
                        oY++;
                        if (oY > (-1) || oY < 19)
                        {
                            
                            ormanDizi[20 - oY, 10 + oX] = 2;
                            yon = 1;
                        }
                        else
                        {
                            Console.Write("ormanın o kadar derinlerine daldın ki kendini bir canavarın ininin öünde buldun ve canavar seni çoktan görmüştü. savaşmaktan başka çaren yok\n");
                            arena.Savas(dMCan, dCan, dSaldiri, dDefance);
                            oY--;
                            ormanSayac1 = 0;
                        }
                    }

                    if (ormanSecenek == 'd' || ormanSecenek == 'D')
                    {
                        oX++;
                        if (oX < 9 || oX > (-9))
                        {
                            ormanDizi[20 - oY, 10 + oX] = 2;
                            yon = 2;
                        }
                        else
                        {
                            Console.Write("ormanın o kadar derinlerine daldın ki kendini bir canavarın ininin öünde buldun ve canavar seni çoktan görmüştü. savaşmaktan başka çaren yok\n");
                            arena.Savas(dMCan, dCan, dSaldiri, dDefance);
                            oX--;
                            ormanSayac1 = 0;
                        }
                    }

                    if (ormanSecenek == 'a' || ormanSecenek == 'A')
                    {
                        oX--;
                        if (oX < 9 || oX > (-9))
                        {
                            ormanDizi[20 - oY, 10 + oX] = 2;
                            yon = 3;
                        }
                        else
                        {
                            Console.Write("ormanın o kadar derinlerine daldın ki kendini bir canavarın ininin öünde buldun ve canavar seni çoktan görmüştü. savaşmaktan başka çaren yok\n");
                            arena.Savas(dMCan, dCan, dSaldiri, dDefance);
                            oX++;
                            ormanSayac1 = 0;
                        }

                    }

                    if (ormanSecenek == 's' || ormanSecenek == 'S')
                    {
                        oY--;
                        if (oY > (-1) || oY < 19)
                        {
                            ormanDizi[20 - oY, 10 + oX] = 2;
                            yon = 4;
                        }
                        else
                        {
                            Console.Write("ormanın o kadar derinlerine daldın ki kendini bir canavarın ininin öünde buldun ve canavar seni çoktan görmüştü. savaşmaktan başka çaren yok\n");
                            arena.Savas(dMCan, dCan, dSaldiri, dDefance);
                            oY++;
                            ormanSayac1 = 0;
                        }
                    }
                }

                if (yon == 2)
                {
                    if (ormanSecenek == 'w' || ormanSecenek == 'W')
                    {
                        oX++;
                        if (oX < 9 || oX > (-9))
                        {
                            ormanDizi[20 - oY, 10 + oX] = 2;
                            yon = 2;
                        }
                        else
                        {
                            Console.Write("ormanın o kadar derinlerine daldın ki kendini bir canavarın ininin öünde buldun ve canavar seni çoktan görmüştü. savaşmaktan başka çaren yok\n");
                            arena.Savas(dMCan, dCan, dSaldiri, dDefance);
                            oX--;
                            ormanSayac1 = 0;
                        }
                    }

                    if (ormanSecenek == 'd' || ormanSecenek == 'D')
                    {
                        oY--;
                        if (oY > (-1) || oY < 19)
                        {
                            ormanDizi[20 - oY, 10 + oX] = 2;
                            yon = 4;
                        }
                        else
                        {
                            Console.Write("ormanın o kadar derinlerine daldın ki kendini bir canavarın ininin öünde buldun ve canavar seni çoktan görmüştü. savaşmaktan başka çaren yok\n");
                            arena.Savas(dMCan, dCan, dSaldiri, dDefance);
                            oY++;
                            ormanSayac1 = 0;
                        }
                    }

                    if (ormanSecenek == 'a' || ormanSecenek == 'A')
                    {
                        oY++;
                        if (oY > (-1) || oY < 19)
                        {
                            ormanDizi[20 - oY, 10 + oX] = 2;
                            yon = 1;
                        }
                        else
                        {
                            Console.Write("ormanın o kadar derinlerine daldın ki kendini bir canavarın ininin öünde buldun ve canavar seni çoktan görmüştü. savaşmaktan başka çaren yok\n");
                            arena.Savas(dMCan, dCan, dSaldiri, dDefance);
                            oY--;
                            ormanSayac1 = 0;
                        }

                    }

                    if (ormanSecenek == 's' || ormanSecenek == 'S')
                    {
                        oX--;
                        if (oX < 9 || oX > (-9))
                        {
                            ormanDizi[20 - oY, 10 + oX] = 2;
                            yon = 3;
                        }
                        else
                        {
                            Console.Write("ormanın o kadar derinlerine daldın ki kendini bir canavarın ininin öünde buldun ve canavar seni çoktan görmüştü. savaşmaktan başka çaren yok\n");
                            arena.Savas(dMCan, dCan, dSaldiri, dDefance);
                            oX++;
                            ormanSayac1 = 0;
                        }
                    }
                }

                if (yon == 3)
                {
                    if (ormanSecenek == 'w' || ormanSecenek == 'W')
                    {
                        oX--;
                        if (oX < 9 || oX > (-9))
                        {
                            ormanDizi[20 - oY, 10 + oX] = 2;
                            yon = 3;
                        }
                        else
                        {
                            Console.Write("ormanın o kadar derinlerine daldın ki kendini bir canavarın ininin öünde buldun ve canavar seni çoktan görmüştü. savaşmaktan başka çaren yok\n");
                            arena.Savas(dMCan, dCan, dSaldiri, dDefance);
                            oX++;
                            ormanSayac1 = 0;
                        }
                    }

                    if (ormanSecenek == 'd' || ormanSecenek == 'D')
                    {
                        oY++;
                        if (oY > (-1) || oY < 19)
                        {
                            ormanDizi[20 - oY, 10 + oX] = 2;
                            yon = 1;
                        }
                        else
                        {
                            Console.Write("ormanın o kadar derinlerine daldın ki kendini bir canavarın ininin öünde buldun ve canavar seni çoktan görmüştü. savaşmaktan başka çaren yok\n");
                            arena.Savas(dMCan, dCan, dSaldiri, dDefance);
                            oY--;
                            ormanSayac1 = 0;
                        }
                    }

                    if (ormanSecenek == 'a' || ormanSecenek == 'A')
                    {
                        oY--;
                        if (oY > (-1) || oY < 19)
                        {
                            ormanDizi[20 - oY, 10 + oX] = 2;
                            yon = 4;
                        }
                        else
                        {
                            Console.Write("ormanın o kadar derinlerine daldın ki kendini bir canavarın ininin öünde buldun ve canavar seni çoktan görmüştü. savaşmaktan başka çaren yok\n");
                            arena.Savas(dMCan, dCan, dSaldiri, dDefance);
                            oY++;
                            ormanSayac1 = 0;
                        }

                    }

                    if (ormanSecenek == 's' || ormanSecenek == 'S')
                    {
                        oX++;
                        if (oX < 9 || oX > (-9))
                        {
                            ormanDizi[20 - oY, 10 + oX] = 2;
                            yon = 2;
                        }
                        else
                        {
                            Console.Write("ormanın o kadar derinlerine daldın ki kendini bir canavarın ininin öünde buldun ve canavar seni çoktan görmüştü. savaşmaktan başka çaren yok\n");
                            arena.Savas(dMCan, dCan, dSaldiri, dDefance);
                            oX--;
                            ormanSayac1 = 0;
                        }
                    }

                }

                if (yon == 4)
                {
                    if (ormanSecenek == 'w' || ormanSecenek == 'W')
                    {
                        oY--;
                        if (oY > (-1) || oY < 19)
                        {
                            ormanDizi[20 - oY, 10 + oX] = 2;
                            yon = 4;
                        }
                        else
                        {
                            Console.Write("ormanın o kadar derinlerine daldın ki kendini bir canavarın ininin öünde buldun ve canavar seni çoktan görmüştü. savaşmaktan başka çaren yok\n");
                            arena.Savas(dMCan, dCan, dSaldiri, dDefance);
                            oY++;
                            ormanSayac1 = 0;
                        }
                    }

                    if (ormanSecenek == 'd' || ormanSecenek == 'D')
                    {
                        oX--;
                        if (oX < 9 || oX > (-9))
                        {
                            ormanDizi[20 - oY, 10 + oX] = 2;
                            yon = 3;
                        }
                        else
                        {
                            Console.Write("ormanın o kadar derinlerine daldın ki kendini bir canavarın ininin öünde buldun ve canavar seni çoktan görmüştü. savaşmaktan başka çaren yok\n");
                            arena.Savas(dMCan, dCan, dSaldiri, dDefance);
                            oX++;
                            ormanSayac1 = 0;
                        }
                    }

                    if (ormanSecenek == 'a' || ormanSecenek == 'A')
                    {
                        oX++;
                        if (oX < 9 || oX > (-9))
                        {
                            ormanDizi[20 - oY, 10 + oX] = 2;
                            yon = 2;
                        }
                        else
                        {
                            Console.Write("ormanın o kadar derinlerine daldın ki kendini bir canavarın ininin öünde buldun ve canavar seni çoktan görmüştü. savaşmaktan başka çaren yok\n");
                            arena.Savas(dMCan, dCan, dSaldiri, dDefance);
                            oX--;
                            ormanSayac1 = 0;
                        }

                    }

                    if (ormanSecenek == 's' || ormanSecenek == 'S')
                    {
                        oY++;
                        if (oY > (-1) || oY < 19)
                        {
                            ormanDizi[20 - oY, 10 + oX] = 2;
                            yon = 1;
                        }
                        else
                        {
                            Console.Write("ormanın o kadar derinlerine daldın ki kendini bir canavarın ininin öünde buldun ve canavar seni çoktan görmüştü. savaşmaktan başka çaren yok\n");
                            arena.Savas(dMCan, dCan, dSaldiri, dDefance);
                            oY--;
                            ormanSayac1 = 0;
                        }
                    }
                }

                if (yon == 1)
                {
                    Console.Write(" \t\n\t/ \\\n\t |\n\t |\n\t |\n");
                }
                else if (yon == 2)
                {
                    Console.Write("<-----\n");
                }
                else if (yon == 3)
                {
                    Console.Write("        ----->\n");
                }
                else if (yon == 4)
                {
                    Console.Write(" \t |\n\t |\n\t |\n\t |\n\t\\ /\n");
                }
                if (ormanDizi[20, 10] == 2)
                {
                    Console.Write("başarıyla ormandan çıktın. tebrik ederim\n");
                    ormanSayac1 = 0;
                }
            }
            if (ormanDizi[20, 10] != 2)
            {
                Console.Write("bir bekçi seni kurtardı ama o geceyi tek başına geçirmenin acısını unutamayacaksın ya seni bulmasaydı(başka ihtimaller getir)\n");
                health = health / 2;
            }

        }
    }
}
