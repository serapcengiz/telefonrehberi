using System;
using System.Collections.Generic;
namespace telefonrehberi
{
    public class Rehber
    {
    
        List<KisiBilgiKarti> kisiBilgiKarti=new List<KisiBilgiKarti>();

        public Rehber()
        {
            kisiBilgiKarti.Add(new KisiBilgiKarti("Serap","Cengiz","123456789"));
            kisiBilgiKarti.Add(new KisiBilgiKarti("Seher","Cengiz","23456789"));
            kisiBilgiKarti.Add(new KisiBilgiKarti("Berivan","Cengiz","3456789"));
            kisiBilgiKarti.Add(new KisiBilgiKarti("Fatma","Cengiz","456789"));
            kisiBilgiKarti.Add(new KisiBilgiKarti("Edanur","Cengiz","56789"));
        }
        public  void kisiEkleme()
        {
            KisiBilgiKarti kart1=new();
            System.Console.WriteLine("(1) Yeni Numara Kaydetmek");
            System.Console.WriteLine("Lütfen isim giriniz              : ");
            kart1.Isim = Console.ReadLine();
            System.Console.WriteLine("Lütfen soyisim giriniz           : ");
            kart1.Soyisim = Console.ReadLine();
            System.Console.WriteLine("Lütfen telefon numarası giriniz  : ");
            kart1.TelefonNumarasi = Console.ReadLine();

        
            kisiBilgiKarti.Add(kart1);
            //eklenen kartı ekrana yazdır.
            System.Console.WriteLine("Eklenen son kart bilgisi");
            System.Console.WriteLine(kisiBilgiKarti[kisiBilgiKarti.Count - 1].Isim);
            System.Console.WriteLine(kisiBilgiKarti[kisiBilgiKarti.Count - 1].Soyisim);
            System.Console.WriteLine(kisiBilgiKarti[kisiBilgiKarti.Count - 1].TelefonNumarasi);

        }
        public void KisiSilme()
        {
            string isimYadaSoyisim;
            int silmeyeDevam=2;
            System.Console.WriteLine("(2) Varolan Numarayı Silmek");
            while(silmeyeDevam==2)
            {
                Console.WriteLine("Lütfen silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                isimYadaSoyisim=Console.ReadLine();
                
                foreach(var item in kisiBilgiKarti)
                {
                    if((kisiBilgiKarti.IndexOf(item) == kisiBilgiKarti.Count - 1) &&((isimYadaSoyisim.ToLower()!=item.Isim.ToLower())||(isimYadaSoyisim.ToLower()!=item.Soyisim.ToLower())))
                    {
                        Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                        Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                        Console.WriteLine("* Yeniden denemek için      : (2)");
                        silmeyeDevam=int.Parse(Console.ReadLine());
                    }
                    else if((isimYadaSoyisim.ToLower()==item.Isim.ToLower())||(isimYadaSoyisim.ToLower()==item.Soyisim.ToLower()))
                    {
                        Console.WriteLine(item.Isim+":"+item.Soyisim+":"+item.TelefonNumarasi+":"+"kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                        if(Convert.ToChar(Console.ReadLine())=='y')
                        {
                            Console.WriteLine(item.Isim+":"+item.Soyisim+":"+item.TelefonNumarasi+":"+"kişi rehberden silindi");
                            kisiBilgiKarti.RemoveAt(kisiBilgiKarti.IndexOf(item));
                            Console.WriteLine();
                            silmeyeDevam=1;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }

                }
            }

        }
        public void KisiGuncelleme()
        {
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            string isimYadaSoyisim;
            int güncellemeyeDevam=2;
            while(güncellemeyeDevam==2)
            {
                Console.WriteLine("Lütfen güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
                isimYadaSoyisim=Console.ReadLine();
                
                foreach(var item in kisiBilgiKarti)
                {
                    if((kisiBilgiKarti.IndexOf(item) == kisiBilgiKarti.Count - 1) &&((isimYadaSoyisim.ToLower()!=item.Isim.ToLower())||(isimYadaSoyisim.ToLower()!=item.Soyisim.ToLower())))
                    {
                        Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                        Console.WriteLine("* Güncellemeyi sonlandırmak için : (1)");
                        Console.WriteLine("* Yeniden denemek için      : (2)");
                        güncellemeyeDevam=int.Parse(Console.ReadLine());
                    }
                    else if((isimYadaSoyisim.ToLower()==item.Isim.ToLower())||(isimYadaSoyisim.ToLower()==item.Soyisim.ToLower()))
                    {
                        Console.WriteLine(item.Isim+":"+item.Soyisim+":"+item.TelefonNumarasi+":"+"kişi güncellenmek üzere, onaylıyor musunuz ?(y/n)");
                        if(Convert.ToChar(Console.ReadLine())=='y')
                        {
                            System.Console.WriteLine("Lütfen güncel isim giriniz              : ");
                            item.Isim = Console.ReadLine();
                            System.Console.WriteLine("Lütfen güncel soyisim giriniz           : ");
                            item.Soyisim = Console.ReadLine();
                            System.Console.WriteLine("Lütfen güncel telefon numarası giriniz  : ");
                            item.TelefonNumarasi = Console.ReadLine();
                            Console.WriteLine(item.Isim+":"+item.Soyisim+":"+item.TelefonNumarasi+":"+"kişi güncellendi");
                            Console.WriteLine();
                            Console.ReadKey();
                            güncellemeyeDevam=1;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }

                }
            }

        }
        public void RehberListele()
        {
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("Rehberde toplam {0} kişi var.",kisiBilgiKarti.Count());
            foreach(var item in kisiBilgiKarti)
            {
                Console.WriteLine(item.Isim+":"+item.Soyisim+":"+item.TelefonNumarasi+":");
                Console.ReadKey();
            }
        }
        public void KisiArama()
        {
            System.Console.WriteLine("(5) Rehberde Arama Yapmak");
            System.Console.WriteLine(" Arama yapmak istediğiniz tipi seçiniz.:");
            System.Console.WriteLine(" ***************************************");
            System.Console.WriteLine(" İsim veya soyisime göre arama yapmak için: (1)");
            System.Console.WriteLine(" Telefon numarasına göre arama yapmak için: (2)");
            int aramaTipi = Convert.ToInt32(Console.ReadLine());
            if(aramaTipi==1)
            {
                System.Console.WriteLine(" İsim veya soyisime göre arama yapmak için isim ya da soyisim giriniz");
                string isimYadaSoyisim = Console.ReadLine();
                
                foreach(var item in kisiBilgiKarti)
                {
                    if((kisiBilgiKarti.IndexOf(item) == kisiBilgiKarti.Count - 1) &&((isimYadaSoyisim.ToLower()!=item.Isim.ToLower())||(isimYadaSoyisim.ToLower()!=item.Soyisim.ToLower())))
                    {
                         if (!kisiBilgiKarti.Contains(item))
                            System.Console.WriteLine("Rehber sonuna gelindi, aradığınız krtiterlere uygun veri rehberde bulunamadı.");
                        
                    }
                    else if((isimYadaSoyisim.ToLower()==item.Isim.ToLower())||(isimYadaSoyisim.ToLower()==item.Soyisim.ToLower()))
                    {
                        System.Console.WriteLine("İsim: " + item.Isim + "\n Soyisim: " + item.Soyisim + "\n Telefon Numarası: " + item.TelefonNumarasi);
                        Console.ReadKey();
                    }
                }
            }
            else if(aramaTipi==2)
            {
                System.Console.WriteLine(" Telefon numarasına göre arama yapmak için telefon numarası giriniz");
                string telefonNumarasi = Console.ReadLine();
                foreach(var item in kisiBilgiKarti)
                {
                    if((kisiBilgiKarti.IndexOf(item) == kisiBilgiKarti.Count - 1) &&((telefonNumarasi.ToLower()!=item.Isim.ToLower())))
                    {
                         if (!kisiBilgiKarti.Contains(item))
                            System.Console.WriteLine("Rehber sonuna gelindi, aradığınız krtiterlere uygun veri rehberde bulunamadı.");
                        else
                            System.Console.WriteLine("Rehber sonuna gelindi, aradığınız krtiterlere uygun başka veri rehberde bulunamadı.");
                    }
                    else if((telefonNumarasi.ToLower()==item.TelefonNumarasi.ToLower()))
                    {
                        System.Console.WriteLine("İsim: " + item.Isim + "\n Soyisim: " + item.Soyisim + "\n Telefon Numarası: " + item.TelefonNumarasi);
                    }
                }
            }
        }
    }
}