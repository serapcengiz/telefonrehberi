using System;
using System.Collections.Generic;
namespace telefonrehberi
{
    class Program
    {
        static void Main(string[] args)
        {
            Rehber rehber1=new();
            string secim = "";
            while (secim != "exit")
            {
                Console.Clear();
                Console.WriteLine("\nProgramdan Çıkış için 'exit' giriniz");
                Console.WriteLine("*******************************************");
                Console.WriteLine("(1) Yeni Numara Kaydetmek");
                Console.WriteLine("(2) Varolan Numarayı Silmek");
                Console.WriteLine("(3) Varolan Numarayı Güncelleme");
                Console.WriteLine("(4) Rehberi Listelemek");
                Console.WriteLine("(5) Rehberde Arama Yapmak");
                Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz :");
                secim = Console.ReadLine().ToLower();

                switch (secim)
                {
                    case "1":                        
                        rehber1.kisiEkleme();
                        break;
                    case "2":
                        rehber1.KisiSilme();
                        break;
                    case "3":
                        rehber1.KisiGuncelleme();
                        break;
                    case "4":
                        rehber1.RehberListele();
                        break;
                    case "5":
                        rehber1.KisiArama();
                        break;
                    case "exit": continue; 
                    default:
                        Console.WriteLine("1 ile 5 arası seçimini yapınız ya da exit ile çıkınız.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
