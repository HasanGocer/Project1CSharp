using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oyun
{
    public  class Arena:AnaBolme
    {
          

        public int Savas(int dMCan,int dCan,int dSaldiri,int dDefance)
        {
            int dSaldiri1 = dSaldiri;
            bool teslim = false;
            for (int i1 = 1; dCan > 0 && health > 0 && teslim==false ; i1++)
            {
                int _saldiri =(int) damage/3;
                int _defans =(int) defance/3;
                dSaldiri = dSaldiri1;

                for (int i2 = 1; i2 != 0;) 
                {
                    Console.Write("{0}.Tur saldırı sırası sizde.\n[1] Saldır\n2-[2] Defans\n[3] Teslim ol\nNe yapmak istersin : ", i1);
                    int secim = Convert.ToInt32(Console.ReadLine());
                    if (secim == 1)
                    {
                        Console.Write("saldırı türünüzü seçiniz\n[1] reine(hasar : {0} dayanıklılık : 70)\n[2]beau(hasar : {1} dayanıklılık : 50)\n[3]vaillant(hasar : {2} dayanıklılık : 30)\n[4]Geri dönmek için\nHangi saldırı türüyle saldırmak istersiniz : ", (_saldiri*3), (2 * _saldiri), _saldiri);
                        int sSecim = Convert.ToInt32(Console.ReadLine());
                        if (sSecim == 1)
                        {
                            if (stamina >= 70)
                            {
                                _saldiri = _saldiri * 3;
                                if ((dDefance) / 10 > _saldiri) _saldiri = _saldiri - (dDefance / 100);
                                else _saldiri = _saldiri - (dDefance / 10);
                                dCan = dCan - _saldiri;
                                Console.WriteLine("Hasarınız : {0}",_saldiri);
                                stamina = stamina - 70;
                                i2 = 0;
                            }else 
                            {
                                Console.WriteLine("Dayanıklılığınız vuruş için yetmiyor");
                            }
                        }else if (sSecim == 2)
                        {
                            if (stamina >= 50)
                            {
                                _saldiri = _saldiri * 2;
                                if ((dDefance) / 10 > _saldiri)  _saldiri = _saldiri - (dDefance / 100);
                                else  _saldiri = _saldiri - (dDefance / 10);
                                dCan = dCan - _saldiri;
                                Console.WriteLine("Hasarınız : {0}", _saldiri);
                                stamina = stamina - 50;
                                i2 = 0;
                            }
                            else   Console.WriteLine("Dayanıklılığınız vuruş için yetmiyor");
                        }else if (sSecim == 3)
                        {
                            if (stamina >= 30)
                            {
                                if ((dDefance) / 10 > _saldiri) _saldiri = _saldiri - (dDefance / 100);
                                else  _saldiri = _saldiri - (dDefance / 10);
                                dCan = dCan - _saldiri;
                                Console.WriteLine("Hasarınız : {0}", _saldiri);
                                stamina = stamina - 30;
                                i2 = 0;
                            }
                            else Console.WriteLine("Dayanıklılığınız vuruş için yetmiyor");
                        }
                    }else if (secim == 2)
                    {
                        Console.Write("savunma türünüzü seçin.\n[1] gratuit(defansınız : {0} artacak dayanıklılığınız : 30)\n[2] loué(defansınız : {1} artacak dayanıklılığınız : 50)\n[3] de valeur(defansınız : {2} artacak dayanıklılığınız : 70)\nHangi savunma türüyle savunmak istersiniz : ", (3 * _defans), (2 * _defans), _defans);
                        int dSecim = Convert.ToInt32(Console.ReadLine());
                        if (dSecim == 1)
                        {
                            i2 = 0;
                            stamina = stamina + 30;
                            _defans = _defans * 3;
                            health =health + (mHealth / 5);
                            if (health > mHealth)    health = mHealth;
                            if (stamina > mStamina)  stamina = mStamina;

                        }else if (dSecim == 2)
                        {
                            i2 = 0;
                            stamina = stamina + 50;
                            _defans = _defans * 2;
                            health = health + (mHealth / 5);
                            if (health > mHealth)    health = mHealth;
                            if (stamina > mStamina)  stamina = mStamina;
                        }else if (dSecim == 3)
                        {
                            i2 = 0;
                            stamina = stamina + 70;
                            health = health + (mHealth / 5);
                            if (health > mHealth)   health = mHealth;
                            if (stamina > mStamina) stamina = mStamina;
                        }

                    }else if (secim == 3)
                    {
                        Console.WriteLine("onurunu arenada bırakıp teslim oluyorsun. Onur : 0");
                        honor = 0;
                        i2 = 0;
                        stamina = mStamina;
                        teslim = true;
                    }
                }
                if (dCan > 0 && teslim == false)
                {
                    if (i1 % 3 == 1 || i1 % 3 == 2)
                    {
                        if ((_defans) >= dSaldiri) { dSaldiri -=_defans / 10; }
                        else { dSaldiri -=_defans; }
                        health -= dSaldiri;
                    }else if (i1 % 3 == 0)
                    {
                        dCan +=dMCan / 10;

                    }   
                    Console.WriteLine("Aldığınız hasar : {0}\nKalan canınız : {1}/{2}\nDayanıklılığınız {3}/{4}", dSaldiri, health, mHealth, stamina, mStamina);
                }

                if (dCan<=0)
                {
                    Console.WriteLine("GALİBİYET");
                    honor += dSaldiri1;
                    gold += dSaldiri1;
                    damage += dSaldiri1;
                    stamina = mStamina;
                }
                
                
                
            }
            return 0;
        }
        
    }
}
