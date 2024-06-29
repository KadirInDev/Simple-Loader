using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleLoader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool DöngüAyarı = true; // bu ayarı ellemeyin döngü için
            string DuyurularUrl = "https://raw.githubusercontent.com/KadirInDev/Simple-Loader/main/Duyurular";
            string versioncheckurl = "https://raw.githubusercontent.com/KadirInDev/Simple-Loader/main/versionurl";
            string LoaderName = "SimpleLoader";
            string asciiart = @"


   _____ _                 _        _                     _            
  / ____(_)               | |      | |                   | |           
 | (___  _ _ __ ___  _ __ | | ___  | |     ___   __ _  __| | ___ _ __  
  \___ \| | '_ ` _ \| '_ \| |/ _ \ | |    / _ \ / _` |/ _` |/ _ \ '__|  // github.com/KadirInDev
  ____) | | | | | | | |_) | |  __/ | |___| (_) | (_| | (_| |  __/ |    
 |_____/|_|_| |_| |_| .__/|_|\___| |______\___/ \__,_|\__,_|\___|_|    
                    | |                                                
                    |_|                                                

"; // bu yazıyı , https://patorjk.com/software/taag/#p=display&f=Graffiti&t=Type%20Something%20 gibi sitelerden elde edebilirsiniz!




            //version kontrol başlıyor
            WebClient WebClient = new WebClient();
            string versionbilgi = WebClient.DownloadString(versioncheckurl);
            if (versionbilgi != "1.1") 
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Eski Version Kullanıyorsun! Lütfen Yeni versiona geçiniz!");
                Thread.Sleep(1000);
                Environment.Exit(0x0);
            }
            //version kontrol bitiyor

            while (DöngüAyarı) // eğer hatalı bir kod girerlerse tekrardan başlangıca gelsinler 
            {            // diye döngü ekliyoruz
                Console.Clear();
                Console.Title = LoaderName;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(asciiart); // simple loader ascii artı yazdırdık!
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("\nGiriş Yap [1]\nDuyurular [2] \nÇıkış     [3]\n>");
                string secenekler = Console.ReadLine();
                int seceneklerSayi = Int32.Parse(secenekler); // string i inte çeviriyoruz!
                switch (seceneklerSayi)
                {
                    case 1:
                        // auth sistemi ekleyin



                        //auth sistemi bitsin
                        DöngüAyarı = false;
                        break;

                    case 2:
                        string duyurular = WebClient.DownloadString(DuyurularUrl);
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(asciiart + "\n********"); // simple loader ascii artı yazdırdık!
                        Console.WriteLine(duyurular + "\n********");
                        Console.WriteLine("Şuanlık Güncel Duyurular Gösteriliyor!");
                        Thread.Sleep(4500);
                        continue;

                    case 3:
                        Environment.Exit(1);
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Lütfen Varsayılan seçeneklerden birini seçiniz!");
                        Thread.Sleep(800);
                        continue;
                }
                Console.WriteLine("döngü çıkış test");
                Console.ReadLine();
            }
        }
    }
}
