//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        int[] ededler = { 2, 4, 6, 2, 7, 9, 4, 10, 6 };
//        TekrarlananEdedleriTap(ededler);
//    }

//    static void TekrarlananEdedleriTap(int[] arr)
//    {
//        HashSet<int> gorulenler = new HashSet<int>();  
//        HashSet<int> tekrarlananlar = new HashSet<int>(); 

//        foreach (int eded in arr)
//        {
//            if (!gorulenler.Add(eded)) 
//            {
//                tekrarlananlar.Add(eded);
//            }
//        }

//        if (tekrarlananlar.Count > 0)
//        {
//            Console.WriteLine("Təkrarlanan ədədlər:");
//            foreach (int item in tekrarlananlar)
//            {
//                Console.WriteLine(item);
//            }
//        }
//        else
//        {
//            Console.WriteLine("Təkrarlanan ədəd yoxdur");
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        SaitSayiniTap();
//    }

//    static void SaitSayiniTap()
//    {
//        Console.Write("Mətn daxil edin: ");
//        string metn = Console.ReadLine().ToLower();  // Kiçik hərfə çeviririk ki, yoxlama rahat olsun

//        int saitSayi = 0;
//        string saitler = "aəeiıioöuü";

//        foreach (char herf in metn)
//        {
//            if (saitler.Contains(herf))
//            {
//                saitSayi++;
//            }
//        }

//        if (saitSayi > 0)
//        {
//            Console.WriteLine($"Mətndəki saitlərin sayı: {saitSayi}");
//        }
//        else
//        {
//            Console.WriteLine("Sait yoxdur");
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        MusbetEdedleriTopla();
//    }

//    static void MusbetEdedleriTopla()
//    {
//        int cem = 0;

//        while (true)
//        {
//            Console.Write("Eded daxil edin : ");
//            int eded = int.Parse(Console.ReadLine());

//            if (eded < 0)
//            {
//                break; 
//            }

//            cem += eded; 
//        }

//        if (cem > 0)
//        {
//            Console.WriteLine($"Musbet ededlerin cemi : {cem}");
//        }
//        else
//        {
//            Console.WriteLine("Müsbet eded daxil edilmedi.");
//        }
//    }
//}

//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        TelebeAdlariniYig();
//    }

//    static void TelebeAdlariniYig()
//    {
//        List<string> telebeAdlari = new List<string>();

//        while (true)
//        {
//            Console.Write("Teleb adi enterleyin pls : ");
//            string ad = Console.ReadLine();

//            if (ad.ToLower() == "quit")
//            {
//                break; // Daxiletmə dayanır
//            }

//            if (!string.IsNullOrWhiteSpace(ad)) // Boş string olmaz
//            {
//                telebeAdlari.Add(ad);
//            }
//        }

//        if (telebeAdlari.Count > 0)
//        {
//            Console.WriteLine("\nEnterlenmis telebe adlari :");
//            foreach (string item in telebeAdlari)
//            {
//                Console.WriteLine(item);
//            }
//        }
//        else
//        {
//            Console.WriteLine("zero telebe adi enter edilib.");
//        }
//    }
//}

