using System;
class Program
{
    static void Main()
    {
        //                                  İF-ELSE İF-ELSE

        // Girilen sayının pozitif ya da negatif olduğunu bulan program
        Console.Write("Girilen Sayı: ");
        int sayi = int.Parse(Console.ReadLine());

        if (sayi > 0)
        {
            Console.WriteLine("Sayı Pozitiftir.");
        }
        else if (sayi == 0)
        {
            Console.WriteLine("Sayı Sıfırdır.");
        }
        else
        {
            Console.WriteLine("Sayı Negatiftir.");
        }

        //************************************************************************************************************************************

        // Vize ve Final notu girilen öğrencinin geçip geçmediğini hesaplayan program
        Console.Write("Vize Notu: ");
        int vize = int.Parse(Console.ReadLine());
        Console.Write("Final Notu: ");
        int final = int.Parse(Console.ReadLine());

        double ortalama = vize * 0.4 + final * 0.6;

        if (ortalama >= 50)
        {
            if (final <= 60)
            {
                Console.WriteLine("Final Notunuz 60 Altında, Kaldınız.");
            }
            else
            {
                Console.WriteLine("Geçtiniz.");
            }
        }
        else
        {
            Console.WriteLine("Kaldınız.");
        }

        //************************************************************************************************************************************

        // Kullanıcının girdiği üç sayıdan büyük olanını yazdıran program
        Console.Write("1.Sayı: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("2.Sayı: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("3.Sayı: ");
        int c = int.Parse(Console.ReadLine());

        if (a > b && a > c)
        {
            Console.WriteLine(a);
        }
        else if (b > c && b > a)
        {
            Console.WriteLine(b);
        }
        else
        {
            Console.WriteLine(c);
        }

        //************************************************************************************************************************************

        // Girilen sayının 6'nın katı olduğunu bulan program
        Console.Write("Sayı: ");
        int sayi2 = int.Parse(Console.ReadLine());

        if (sayi2 % 6 == 0)
        {
            Console.WriteLine("Sayı 6'nın Katıdır.");
        }
        else
        {
            Console.WriteLine("Sayı 6'nın Katı Değildir.");
        }

        //************************************************************************************************************************************

        // Yüzlük notu harf notuna çeviren program
        Console.Write("Girilen Not: ");
        int yuzlukNot = int.Parse(Console.ReadLine());

        if (yuzlukNot >= 0 && yuzlukNot < 35)
        {
            Console.WriteLine("Harf Notunuz: FF");
        }
        else if (yuzlukNot >= 35 && yuzlukNot < 45)
        {
            Console.WriteLine("Harf Notunuz: DD");
        }
        else if (yuzlukNot >= 45 && yuzlukNot < 50)
        {
            Console.WriteLine("Harf Notunuz: DC");
        }
        else if (yuzlukNot >= 50 && yuzlukNot < 55)
        {
            Console.WriteLine("Harf Notunuz: CC");
        }
        else if (yuzlukNot >= 55 && yuzlukNot < 63)
        {
            Console.WriteLine("Harf Notunuz: CB");
        }
        else if (yuzlukNot >= 63 && yuzlukNot < 71)
        {
            Console.WriteLine("Harf Notunuz: BB");
        }
        else if (yuzlukNot >= 71 && yuzlukNot < 80)
        {
            Console.WriteLine("Harf Notunuz: BA");
        }
        else if (yuzlukNot >= 80 && yuzlukNot <= 100)
        {
            Console.WriteLine("Harf Notunuz: AA");
        }
        else
        {
            Console.WriteLine("Geçersiz bir yüzlük not girdiniz.");
        }

        //************************************************************************************************************************************

        // İşçi maaşı ve çocuk sayısına göre zam hesaplayan program
        Console.Write("İşçi Maaşı Giriniz: ");
        int isciMaas = int.Parse(Console.ReadLine());
        Console.Write("Çocuk Sayısı: ");
        int cocukSayisi = int.Parse(Console.ReadLine());

        if (cocukSayisi == 1)
        {
            double yeniMaas = isciMaas + (isciMaas * 0.05);
            Console.WriteLine("Yeni Maaş: " + yeniMaas);
        }
        else if (cocukSayisi == 2)
        {
            double yeniMaas = isciMaas + (isciMaas * 0.10);
            Console.WriteLine("Yeni Maaş: " + yeniMaas);
        }
        else if (cocukSayisi >= 3)
        {
            double yeniMaas = isciMaas + (isciMaas * 0.15);
            Console.WriteLine("Yeni Maaş: " + yeniMaas);
        }
        else
        {
            Console.WriteLine("Yanlış Bilgi Girdiniz.");
        }

        //************************************************************************************************************************************
        //************************************************************************************************************************************
        // 1- Ehliyet alma durumu kontrolü

        Console.Write("İsminiz: ");
        string isim = Console.ReadLine();
        Console.Write("Yaşınız: ");
        int yas = int.Parse(Console.ReadLine());
        Console.Write("Eğitim Durumunuz (lise/üniversite): ");
        string egitimBilgi = Console.ReadLine();

        if (yas >= 18 && (egitimBilgi == "lise" || egitimBilgi == "üniversite"))
        {
            Console.WriteLine("Ehliyet alabilirsiniz.");
        }
        else
        {
            Console.WriteLine("Ehliyet alamazsınız.");
        }

        //************************************************************************************************************************************
        // 2- Not aralığına göre öğrenci notu hesaplama

        Console.Write("1.Yazılı Notunuz: ");
        int yazili1 = int.Parse(Console.ReadLine());
        Console.Write("2.Yazılı Notunuz: ");
        int yazili2 = int.Parse(Console.ReadLine());
        Console.Write("Sözlü Notunuz: ");
        int sozlu = int.Parse(Console.ReadLine());

        double ortalama2 = (yazili1 + yazili2 + sozlu) / 3.0;

        if (ortalama2 >= 0 && ortalama2 < 25)
        {
            Console.WriteLine("Notunuz: 0");
        }
        else if (ortalama2 >= 25 && ortalama2 < 45)
        {
            Console.WriteLine("Notunuz: 1");
        }
        else if (ortalama2 >= 45 && ortalama2 < 55)
        {
            Console.WriteLine("Notunuz: 2");
        }
        else if (ortalama2 >= 55 && ortalama2 < 70)
        {
            Console.WriteLine("Notunuz: 3");
        }
        else if (ortalama2 >= 70 && ortalama2 < 85)
        {
            Console.WriteLine("Notunuz: 4");
        }
        else if (ortalama2 >= 85 && ortalama2 <= 100)
        {
            Console.WriteLine("Notunuz: 5");
        }

        //************************************************************************************************************************************
        // 3- Girilen sayının 0-100 arasında olup olmadığını kontrol etme

        Console.Write("Bir sayı giriniz: ");
        int sayi3 = int.Parse(Console.ReadLine());

        if (sayi3 >= 0 && sayi3 <= 100)
        {
            Console.WriteLine("Sayı 0-100 arasındadır.");
        }
        else
        {
            Console.WriteLine("Sayı 0-100 arasında değildir.");
        }

        //************************************************************************************************************************************
        // 4- Girilen sayının pozitif ve çift olup olmadığını kontrol etme

        Console.Write("Bir sayı giriniz: ");
        int sayi4 = int.Parse(Console.ReadLine());

        if (sayi4 > 0 && sayi4 % 2 == 0)
        {
            Console.WriteLine("Girilen sayı pozitif ve çift sayıdır.");
        }
        else
        {
            Console.WriteLine("Girilen sayı pozitif çift sayı değildir.");
        }

        //************************************************************************************************************************************
        // 5- Email ve parola kontrolü

        string email = "ahmetmert@gmail.com";
        string parola = "ahmet123";

        Console.Write("Mail Adresiniz: ");
        string girilenMail = Console.ReadLine();
        Console.Write("Parolanız: ");
        string girilenParola = Console.ReadLine();

        if (email == girilenMail && parola == girilenParola)
        {
            Console.WriteLine("Hoşgeldiniz.");
        }
        else if (email != girilenMail)
        {
            Console.WriteLine("Mail Adresi Yanlış.");
        }
        else
        {
            Console.WriteLine("Parola Yanlış.");
        }

        //************************************************************************************************************************************
        // 6- Girilen üç sayının büyüklük olarak karşılaştırılması

        Console.Write("1. Sayı: ");
        int sayi5 = int.Parse(Console.ReadLine());
        Console.Write("2. Sayı: ");
        int sayi6 = int.Parse(Console.ReadLine());
        Console.Write("3. Sayı: ");
        int sayi7 = int.Parse(Console.ReadLine());

        if (sayi5 > sayi6 && sayi5 > sayi7)
        {
            Console.WriteLine("1. Sayı en büyüktür.");
        }
        else if (sayi6 > sayi5 && sayi6 > sayi7)
        {
            Console.WriteLine("2. Sayı en büyüktür.");
        }
        else
        {
            Console.WriteLine("3. Sayı en büyüktür.");
        }

        //************************************************************************************************************************************
        // 7- Vize ve final notlarına göre geçme durumu

        Console.Write("1.Vize Notu: ");
        int vize1 = int.Parse(Console.ReadLine());
        Console.Write("2.Vize Notu: ");
        int vize2 = int.Parse(Console.ReadLine());
        Console.Write("Final Notu: ");
        int final2 = int.Parse(Console.ReadLine());

        double vizeOrtalama = (vize1 + vize2) / 2.0;
        double toplamOrtalama = (vizeOrtalama * 0.6) + (final2 * 0.4);

        if (final2 >= 70)
        {
            Console.WriteLine("Geçtiniz.");
        }
        else if (toplamOrtalama >= 50 && final2 >= 50)
        {
            Console.WriteLine("Geçtiniz.");
        }
        else
        {
            Console.WriteLine("Kaldınız.");
        }

        //************************************************************************************************************************************
        // 8- Kilo indeksi hesaplama ve sınıflandırma

        Console.Write("Adınız: ");
        string ad = Console.ReadLine();
        Console.Write("Kilonuz (kg): ");
        float kilo = float.Parse(Console.ReadLine());
        Console.Write("Boyunuz (metre): ");
        float boy = float.Parse(Console.ReadLine());

        float kiloIndeksi = kilo / (boy * boy);

        if (kiloIndeksi < 18.5)
        {
            Console.WriteLine("Kilo İndeksiniz: Zayıf");
        }
        else if (kiloIndeksi >= 18.5 && kiloIndeksi < 25)
        {
            Console.WriteLine("Kilo İndeksiniz: Normal");
        }
        else if (kiloIndeksi >= 25 && kiloIndeksi < 30)
        {
            Console.WriteLine("Kilo İndeksiniz: Fazla Kilolu");
        }
        else if (kiloIndeksi >= 30 && kiloIndeksi < 35)
        {
            Console.WriteLine("Kilo İndeksiniz: Şişman (Obez)");
        }
        else
        {
            Console.WriteLine("Yanlış bilgi girdiniz.");
        }
    }
}