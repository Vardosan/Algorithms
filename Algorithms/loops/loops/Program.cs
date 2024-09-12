using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Sayılar listesindeki hangi sayılar 3'ün katıdır?
        List<int> sayilar = new List<int> { 1, 3, 5, 7, 9, 12, 19, 21 };
        foreach (var sayi3 in sayilar)
        {
            if (sayi3 % 3 == 0)
            {
                Console.WriteLine(sayi3);
            }
        }

        // Sayılar listesinde sayıların toplamı kaçtır?
        int toplam = 0;
        foreach (var sayi3 in sayilar)
        {
            toplam += sayi3;
        }
        Console.WriteLine(toplam);

        // Sayılar listesindeki tek sayıların karesini alınız.
        foreach (var sayi4 in sayilar)
        {
            if (sayi4 % 2 == 1)
            {
                Console.WriteLine(sayi4 * sayi4);
            }
        }

        // Şehirlerden hangileri en fazla 5 karekterlidir?
        List<string> sehirler = new List<string> { "kocaeli", "istanbul", "ankara", "izmir", "rize" };
        foreach (var sehir in sehirler)
        {
            if (sehir.Length <= 5)
            {
                Console.WriteLine(sehir);
            }
        }

        // Ürünlerin fiyatları toplamı nedir?
        var urunler = new List<Dictionary<string, string>>
        {
            new Dictionary<string, string> { { "name", "samsung S6" }, { "price", "3000" } },
            new Dictionary<string, string> { { "name", "samsung S7" }, { "price", "4000" } },
            new Dictionary<string, string> { { "name", "samsung S8" }, { "price", "5000" } },
            new Dictionary<string, string> { { "name", "samsung S9" }, { "price", "6000" } },
            new Dictionary<string, string> { { "name", "samsung S10" }, { "price", "7000" } }
        };

        toplam = 0;
        foreach (var urun in urunler)
        {
            toplam += int.Parse(urun["price"]);
        }
        Console.WriteLine(toplam);

        // Ürünlerden fiyatı en fazla 5000 olan ürünleri gösteriniz.
        foreach (var urun in urunler)
        {
            if (int.Parse(urun["price"]) <= 5000)
            {
                Console.WriteLine(urun["name"]);
            }
        }

        // Sayılar listesini while ile ekrana yazdırın.
        int index = 0;
        while (index < sayilar.Count)
        {
            Console.WriteLine(sayilar[index]);
            index++;
        }

        // Başlangıç ve bitiş değelerini kullanıcadan alıp aradaki tüm tek sayıları ekrana yazdırın.
        Console.Write("Başlangıç Değeri: ");
        int baslangic = int.Parse(Console.ReadLine());
        Console.Write("Bitiş Değeri: ");
        int bitis = int.Parse(Console.ReadLine());

        for (int sayi6 = baslangic; sayi6 < bitis; sayi6++)
        {
            if (sayi6 % 2 == 1)
            {
                Console.WriteLine(sayi6);
            }
        }

        // 1-100 arasındaki sayıları azalan şekilde yazdırın.
        for (int i = 99; i > 0; i--)
        {
            Console.WriteLine(i);
        }

        // Kullanıcıdan alacağınız 5 sayıyı ekranda sıralı bir şekilde yazdırın.
        List<int> numbers = new List<int>();
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Sayı Giriniz: ");
            numbers.Add(int.Parse(Console.ReadLine()));
        }

        numbers.Sort();
        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }

        // 1-100 arasında rastgele üretilecek bir sayıyı aşağı yukarı ifadeleri ile buldurmaya çalışın. (hak = 5)
        Random random = new Random();
        int randomSayi = random.Next(1, 101);
        Console.Write("Kaç Hak İstiyorsunuz: ");
        int hak = int.Parse(Console.ReadLine());
        int puan = 100;

        for (int i = 0; i < hak; i++)
        {
            Console.Write("Tahmin: ");
            int tahmin = int.Parse(Console.ReadLine());

            if (randomSayi == tahmin)
            {
                Console.WriteLine("Tebrikler Bildiniz.");
                Console.WriteLine("Puanınız: " + puan);
                break;
            }
            else if (randomSayi > tahmin)
            {
                Console.WriteLine("Malesef... Biraz Daha Yukarı.");
                puan -= 20;
            }
            else
            {
                Console.WriteLine("Malesef... Biraz Daha Aşağı.");
                puan -= 20;
            }

            if (i == hak - 1)
            {
                Console.WriteLine("Hakkınız Doldu Kaybettiniz.");
                Console.WriteLine("Sayı: " + randomSayi + " Puan: " + puan);
            }
        }

        // Girilen bir sayının asal olup olmadığını bulun.
        Console.Write("Sayı: ");
        int asalSayi = int.Parse(Console.ReadLine());
        bool asalmi = true;

        if (asalSayi == 1)
        {
            asalmi = false;
        }
        else
        {
            for (int i = 2; i < asalSayi; i++)
            {
                if (asalSayi % i == 0)
                {
                    asalmi = false;
                    break;
                }
            }
        }

        Console.WriteLine(asalmi ? "Sayı Asaldır." : "Sayı Asal Değildir.");

        // Girilen 5 sayının ortalamasını bulan program.
        toplam = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Sayı: ");
            toplam += int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Ortalama: " + (toplam / 5.0));

        // Girilen 5 sayı içerisindeki minimum ve maksimum değerleri bulan program.
        List<int> list = new List<int>();
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Sayı: ");
            list.Add(int.Parse(Console.ReadLine()));
        }
        int enBuyuk = list[0];
        int enKucuk = list[0];
        foreach (var t in list)
        {
            if (enKucuk > t)
            {
                enKucuk = t;
            }
            if (enBuyuk < t)
            {
                enBuyuk = t;
            }
        }
        Console.WriteLine("En Büyük Sayı: " + enBuyuk);
        Console.WriteLine("En Küçük Sayı: " + enKucuk);

        // N’e kadar tek sayıları yazdıran program.
        Console.Write("N: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i < n; i += 2)
        {
            Console.WriteLine(i);
        }

        // Girilen sayının tam bölenlerini bulan program.
        Console.Write("Sayı: ");
        int bolenSayi = int.Parse(Console.ReadLine());
        for (int i = 1; i <= bolenSayi / 2; i++)
        {
            if (bolenSayi % i == 0)
            {
                Console.WriteLine(i);
            }
        }

        // Girilen sayının tam bölenlerinin sayısını bulan program.
        Console.Write("Sayı: ");
        bolenSayi = int.Parse(Console.ReadLine());
        int bolenlerSayi = 0;
        for (int i = 1; i <= bolenSayi / 2; i++)
        {
            if (bolenSayi % i == 0)
            {
                bolenlerSayi++;
            }
        }
        Console.WriteLine("Tam Bölenlerinin Sayısı: " + bolenlerSayi);

        // a**b yi açık hesaplayan program.
        Console.Write("a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine(Math.Pow(a, b));

        // n’e kadar ki tek sayıların toplamı, çift sayıların çarpımını hesaplayan program.
        Console.Write("N: ");
        n = int.Parse(Console.ReadLine());
        int tekToplam = 0;
        int ciftCarpim = 1;
        for (int i = 1; i < n; i++)
        {
            if (i % 2 == 1)
            {
                tekToplam += i;
            }
            else
            {
                ciftCarpim *= i;
            }
        }
        Console.WriteLine("Tek Sayıların Toplamı: " + tekToplam);
        Console.WriteLine("Çift Sayıların Toplamı: " + ciftCarpim);


        // Faktöriyel Hesaplama
        Console.WriteLine("1. Faktöriyel Hesaplama");
        Console.Write("Sayı: ");
        int sayi = int.Parse(Console.ReadLine());
        int faktoriyel = 1;
        for (int i = 1; i <= sayi; i++)
        {
            faktoriyel *= i;
        }
        Console.WriteLine("Faktoriyel: " + faktoriyel);
        Console.WriteLine();

        // Fibonacci Serisi
        Console.WriteLine("2. Fibonacci Serisi");
        Console.Write("N: ");
        int n2 = int.Parse(Console.ReadLine());
        int a2 = 0, b2 = 1, c2 = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write(c2 + " ");
            a2 = b2;
            b2 = c2;
            c2 = a2 + b2;
        }
        Console.WriteLine();
        Console.WriteLine();

        // Pozitif, Negatif ve Sıfır Sayıları Sayma
        Console.WriteLine("3. Pozitif, Negatif ve Sıfır Sayıları Sayma");
        Console.Write("Kaç Adet Sayı: ");
        int numCount = int.Parse(Console.ReadLine());
        int pozitif = 0, negatif = 0, sifir = 0;
        for (int i = 0; i < numCount; i++)
        {
            Console.Write("Sayı: ");
            int num = int.Parse(Console.ReadLine());
            if (num == 0)
            {
                sifir++;
            }
            else if (num > 0)
            {
                pozitif++;
            }
            else
            {
                negatif++;
            }
        }
        Console.WriteLine("Pozitif: " + pozitif);
        Console.WriteLine("Negatif: " + negatif);
        Console.WriteLine("Sıfır: " + sifir);
        Console.WriteLine();

        // Artış Değeri ile Seri
        Console.WriteLine("4. Artış Değeri ile Seri");
        Console.Write("Toplam Eleman: ");
        int toplamEleman = int.Parse(Console.ReadLine());
        Console.Write("İlk Eleman: ");
        int ilkEleman = int.Parse(Console.ReadLine());
        Console.Write("Artış Değeri: ");
        int artisDegeri = int.Parse(Console.ReadLine());

        int degisken = ilkEleman;
        for (int i = 0; i < toplamEleman; i++)
        {
            Console.Write(degisken + " ");
            degisken += artisDegeri;
        }
        Console.WriteLine();
        Console.WriteLine();

  
        // x^2 + 2x - 3 = 0 denkleminin köklerini hesapla
        double aCoef = 1, bCoef = 2, cCoef = -3;
        double discriminant = bCoef * bCoef - 4 * aCoef * cCoef;
        if (discriminant > 0)
        {
            Console.WriteLine("Denklemin iki gerçek kökü vardır.");
        }
        else if (discriminant == 0)
        {
            Console.WriteLine("Denklemin bir gerçek kökü vardır.");
        }
        else
        {
            Console.WriteLine("Denklemin gerçek kökü yoktur.");
        }
        Console.WriteLine();

        // Asal Sayı Kontrolü
        Console.WriteLine("6. Asal Sayı Kontrolü");
        Console.Write("Sayı: ");
        int asalSayi2 = int.Parse(Console.ReadLine());
        bool asalmi2 = true;
        if (asalSayi2 <= 1)
        {
            asalmi2 = false;
        }
        for (int i = 2; i < asalSayi2; i++)
        {
            if (asalSayi2 % i == 0)
            {
                asalmi2 = false;
                break;
            }
        }
        if (asalmi2)
        {
            Console.WriteLine("Sayı Asaldır.");
        }
        else
        {
            Console.WriteLine("Sayı Asal Değildir.");
        }
        Console.WriteLine();

        // Asal Çarpanları Bulma
        Console.WriteLine("7. Asal Çarpanları Bulma");
        Console.Write("Sayı: ");
        int asalCarpanSayi = int.Parse(Console.ReadLine());
        int bolen = 2;
        while (asalCarpanSayi > 1)
        {
            if (asalCarpanSayi % bolen == 0)
            {
                Console.Write(bolen + " ");
                asalCarpanSayi /= bolen;
            }
            else
            {
                bolen++;
            }
        }
        Console.WriteLine();
        Console.WriteLine();

        // Basamak Değerlerinin Çarpımı
        Console.WriteLine("8. Basamak Değerlerinin Çarpımı");
        Console.Write("Sayı: ");
        int carpimSayi = int.Parse(Console.ReadLine());
        int carpim = 1;
        foreach (char rakam in carpimSayi.ToString())
        {
            carpim *= int.Parse(rakam.ToString());
        }
        Console.WriteLine("Rakamların Çarpımı: " + carpim);
        Console.WriteLine();

        // Basamak Değerlerinde K Rakamı Olmayanları Listeleme
        Console.WriteLine("9. Basamak Değerlerinde K Rakamı Olmayanları Listeleme");
        Console.Write("Sayı: ");
        int kSayi = int.Parse(Console.ReadLine());
        Console.Write("K: ");
        int k = int.Parse(Console.ReadLine());
        string sonuc = "";
        foreach (char rakam in kSayi.ToString())
        {
            if (int.Parse(rakam.ToString()) != k)
            {
                sonuc += rakam;
            }
        }
        Console.WriteLine("Sonuç: " + sonuc);
        Console.WriteLine();

        // Basamak Sayısını Yazdırma
        Console.WriteLine("10. Basamak Sayısını Yazdırma");
        Console.Write("Sayı: ");
        int basamakSayi = int.Parse(Console.ReadLine());
        int basamakSayisi = 0;
        while (basamakSayi > 0)
        {
            basamakSayi /= 10;
            basamakSayisi++;
        }
        Console.WriteLine("Basamak Sayısı: " + basamakSayisi);
        Console.WriteLine();

        // Basamak Değerleri Kadar Yıldız Yazdırma
        Console.WriteLine("11. Basamak Değerleri Kadar Yıldız Yazdırma");
        Console.Write("Sayı: ");
        int yildizSayi = int.Parse(Console.ReadLine());
        foreach (char rakam in yildizSayi.ToString())
        {
            int sonRakam = int.Parse(rakam.ToString());
            Console.Write(sonRakam + " ");
            for (int i = 0; i < sonRakam; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        // TC Kimlik No Kontrolü
        Console.WriteLine("12. TC Kimlik No Kontrolü");
        Console.Write("TC Kimlik No: ");
        string tcno = Console.ReadLine();
        if (tcno.Length != 11 || !long.TryParse(tcno, out _))
        {
            Console.WriteLine("TC Kimlik Numarası 11 Haneli ve Tamamı Rakam Olmalıdır.");
        }
        else
        {
            Console.WriteLine("Başarılı");
        }
        Console.WriteLine();

        // Cümleyi Tersten Yazdırma
        Console.WriteLine("13. Cümleyi Tersten Yazdırma");
        Console.Write("Cümle: ");
        string cumle = Console.ReadLine();
        char[] cumleArray = cumle.ToCharArray();
        Array.Reverse(cumleArray);
        Console.WriteLine("Ters Cümle: " + new string(cumleArray));
        Console.WriteLine();

        // Sesli ve Sessiz Harf Sayısı
        Console.WriteLine("14. Sesli ve Sessiz Harf Sayısı");
        Console.Write("Cümle Giriniz: ");
        string sesliCumle = Console.ReadLine();
        string sesliHarfler = "aeıioöuü";
        int sesliHarfS = 0;
        foreach (char c3 in sesliCumle.ToLower())
        {
            if (sesliHarfler.Contains(c3))
            {
                sesliHarfS++;
            }
        }
        int sessizHarfS = sesliCumle.Length - sesliHarfS;
        Console.WriteLine("Sesli Harf Sayısı: " + sesliHarfS);
        Console.WriteLine("Sessiz Harf Sayısı: " + sessizHarfS);


        // 1. Harflerin Adetlerini Yazdırma
        Console.WriteLine("1. Harflerin Adetlerini Yazdırma");
        Console.Write("Cümle Giriniz: ");
        string cumle2 = Console.ReadLine();
        Dictionary<char, int> harfSayilari = new Dictionary<char, int>();
        foreach (char harf2 in cumle2)
        {
            if (harfSayilari.ContainsKey(harf2))
            {
                harfSayilari[harf2]++;
            }
            else
            {
                harfSayilari[harf2] = 1;
            }
        }
        foreach (var item in harfSayilari)
        {
            Console.WriteLine($"{item.Key} sayısı : {item.Value}");
        }
        Console.WriteLine();

        // 2. Pronic Sayı Kontrolü
        Console.WriteLine("2. Pronic Sayı Kontrolü");
        Console.Write("Sayı Giriniz: ");
        int pronicSayi = int.Parse(Console.ReadLine());
        bool pronic = false;
        for (int i = 0; i * (i + 1) <= pronicSayi; i++)
        {
            if (i * (i + 1) == pronicSayi)
            {
                pronic = true;
                break;
            }
        }
        if (pronic)
        {
            Console.WriteLine("Pronic'dir.");
        }
        else
        {
            Console.WriteLine("Pronic Değildir.");
        }
        Console.WriteLine();

        // 3. Harshad Sayıları Listeleme
        Console.WriteLine("3. Harshad Sayıları Listeleme");
        Console.Write("N: ");
        int n3 = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n3; i++)
        {
            int rakamlarToplami = 0;
            foreach (char rakam in i.ToString())
            {
                rakamlarToplami += int.Parse(rakam.ToString());
            }
            if (rakamlarToplami != 0 && i % rakamlarToplami == 0)
            {
                Console.WriteLine($"{i} Harshad Sayıdır.");
            }
        }
        Console.WriteLine();

        // 4. Jumbled Sayı Kontrolü
        Console.WriteLine("4. Jumbled Sayı Kontrolü");
        Console.Write("Sayı Giriniz: ");
        string jumbledSayiStr = Console.ReadLine();
        bool jumbled = true;
        for (int i = 0; i < jumbledSayiStr.Length - 1; i++)
        {
            if (Math.Abs(jumbledSayiStr[i] - jumbledSayiStr[i + 1]) != 1)
            {
                jumbled = false;
                break;
            }
        }
        if (jumbled)
        {
            Console.WriteLine("Jumbled Sayıdır.");
        }
        else
        {
            Console.WriteLine("Jumbled Sayı Değildir.");
        }
        Console.WriteLine();

        // 5. OKEK ve OBEB Hesaplama
        Console.WriteLine("5. OKEK ve OBEB Hesaplama");
        Console.Write("Sayı 1: ");
        int sayi1 = int.Parse(Console.ReadLine());
        Console.Write("Sayı 2: ");
        int sayi2 = int.Parse(Console.ReadLine());
        int a3 = sayi1;
        int b3 = sayi2;
        while (b != 0)
        {
            int temp = b3;
            b3 = a3 % b3;
            a3 = temp;
        }
        int ebob = a3;
        int ekok = (sayi1 * sayi2) / ebob;
        Console.WriteLine("Sayının Ekoku: " + ekok);
        Console.WriteLine("Sayının Ebobu: " + ebob);
        Console.WriteLine();

        // 6. Sayı Tahmin Oyunu
        Console.WriteLine("6. Sayı Tahmin Oyunu");
        Random rnd = new Random();
        int sayi5 = rnd.Next(0, 5);
        Console.Write("Kaç Hak İstersiniz: ");
        int hak2 = int.Parse(Console.ReadLine());
        for (int i = 0; i < hak2; i++)
        {
            Console.Write("Tahmin: ");
            int tahmin = int.Parse(Console.ReadLine());
            if (tahmin > sayi5)
            {
                Console.WriteLine("Biraz Aşağı");
            }
            else if (tahmin < sayi5)
            {
                Console.WriteLine("Biraz Yukarı");
            }
            else
            {
                Console.WriteLine("Doğru Tahmin.");
                break;
            }
            if (i == hak2 - 1)
            {
                Console.WriteLine("Hakkınız Doldu, Kaybettiniz.");
            }
        }
        Console.WriteLine();

        // 7. Harf Tahmin Oyunu
        Console.WriteLine("7. Harf Tahmin Oyunu");
        char harf = (char)rnd.Next('a', 'z' + 1);
        int harfAscii = harf;
        Console.Write("Kaç Hak İstersiniz: ");
        int hakHarf = int.Parse(Console.ReadLine());
        for (int i = 0; i < hakHarf; i++)
        {
            Console.Write("Harf Tahmin: ");
            char tahmin = Console.ReadLine()[0];
            int tahminAscii = tahmin;
            if (tahminAscii > harfAscii)
            {
                Console.WriteLine("Biraz Aşağı");
            }
            else if (tahminAscii < harfAscii)
            {
                Console.WriteLine("Biraz Yukarı");
            }
            else
            {
                Console.WriteLine("Doğru Tahmin.");
                break;
            }
            if (i == hakHarf - 1)
            {
                Console.WriteLine("Hakkınız Doldu, Kaybettiniz. Doğru Harf: " + harf);
            }
        }
        Console.WriteLine();

        // 8. Topun Sıçrama Hesaplaması
        Console.WriteLine("8. Topun Sıçrama Hesaplaması");
        Console.Write("X: ");
        double xMetre = double.Parse(Console.ReadLine());
        double toplamYol = 0;
        int sicramaSayisi = 0;
        while (xMetre > 1)
        {
            toplamYol += xMetre;
            sicramaSayisi++;
            xMetre *= 0.8;
            toplamYol += xMetre;
        }
        Console.WriteLine("Aldığı Yol: " + toplamYol);
        Console.WriteLine("Sıçrama Sayısı: " + sicramaSayisi);
        Console.WriteLine();

        // 9. Üçgen Çizme ve Hesaplama
        Console.WriteLine("9. Üçgen Çizme ve Hesaplama");
        Console.Write("Kenar 1: ");
        int a4 = int.Parse(Console.ReadLine());
        Console.Write("Kenar 2: ");
        int b4 = int.Parse(Console.ReadLine());
        Console.Write("Kenar 3: ");
        int c4 = int.Parse(Console.ReadLine());
        if ((a4 + b4 > c4) && (a4 + c4 > b4) && (b4 + c4 > a4))
        {
            Console.WriteLine("Üçgen Çizilebilir.");
            if (a4 == b4 && b4 == c4)
            {
                Console.WriteLine("Eşkenar Üçgen.");
            }
            else if (a4 == b4 || b4 == c4 || a4 == c4)
            {
                Console.WriteLine("İkiz Kenar Üçgen.");
            }
            else
            {
                Console.WriteLine("Çeşit Kenar Üçgen.");
            }
            int cevre = a4 + b4 + c4;
            double s = cevre / 2.0;
            double alan = Math.Sqrt(s * (s - a4) * (s - b4) * (s - c4));
            Console.WriteLine("Çevre: " + cevre);
            Console.WriteLine("Alan: " + alan);
        }
        else
        {
            Console.WriteLine("Üçgen Çizilemez.");
        }

    }
}
