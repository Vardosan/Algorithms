using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Girilen sayının listede olup olmadığını bulma
        Console.WriteLine("1. Girilen sayının listede olup olmadığını bulma");
        Console.Write("Sayı: ");
        int sayi = int.Parse(Console.ReadLine());
        List<int> sList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Console.WriteLine(sList.Contains(sayi) ? "Sayı Listede" : "Sayı Listede Değil.");
        Console.WriteLine();

        // Elemanları sıralama
        Console.WriteLine("2. Elemanları sıralama");
        List<int> liste = new List<int> { 3, 5, 1, 2, 6, 4, 8, 9, 7 };
        liste.Sort();
        Console.WriteLine(string.Join(", ", liste));
        Console.WriteLine();

        // Her elemanın tekrar sayısını bulma
        Console.WriteLine("3. Her elemanın tekrar sayısını bulma");
        List<int> tekrarListe = new List<int> { 1, 2, 4, 3, 2, 4, 5, 4, 3, 1, 1, 5 };
        var tekrarSayilari = tekrarListe.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());
        foreach (var item in tekrarSayilari)
        {
            Console.WriteLine($"{item.Key} sayısından {item.Value} adet var.");
        }
        Console.WriteLine();

        // Girilen yazıdaki boşluk karakter sayısını bulma
        Console.WriteLine("4. Girilen yazıdaki boşluk karakter sayısını bulma");
        Console.Write("Yazı: ");
        string yazi = Console.ReadLine();
        int boslukSayisi = yazi.Count(c => c == ' ');
        Console.WriteLine("Boşluk Sayısı: " + boslukSayisi);
        Console.WriteLine();

        // Girilen iki yazıyı karşılaştırma
        Console.WriteLine("5. Girilen iki yazıyı karşılaştırma");
        Console.Write("Yazı1: ");
        string yazi1 = Console.ReadLine();
        Console.Write("Yazı2: ");
        string yazi2 = Console.ReadLine();
        Console.WriteLine(yazi1 == yazi2 ? "Yazılar Eşit." : "Yazılar Eşit Değil.");
        Console.WriteLine();

        // Girilen yazının büyük yazılıp yazılmadığını bulma
        Console.WriteLine("6. Girilen yazının büyük yazılıp yazılmadığını bulma");
        Console.Write("Yazı: ");
        string yazı = Console.ReadLine();
        bool buyukHarfMi = yazı.Any(c => char.IsUpper(c));
        Console.WriteLine(buyukHarfMi ? "Büyük Harf Yazılmıştır." : "Büyük Harf Yazılmamıştır.");
        Console.WriteLine();

        // Girilen yazının k. karakteriyle r. karakteri arasını kopyalama
        Console.WriteLine("7. Girilen yazının k. karakteriyle r. karakteri arasını kopyalama");
        Console.Write("Yazı: ");
        string yazi3 = Console.ReadLine();
        Console.Write("k: ");
        int k = int.Parse(Console.ReadLine());
        Console.Write("r: ");
        int r = int.Parse(Console.ReadLine());
        string sonuc = yazi3.Substring(k, r - k);
        Console.WriteLine(sonuc);
        Console.WriteLine();

        // Girilen yazıdaki kelime, rakam ve karakter sayısını bulma
        Console.WriteLine("8. Girilen yazıdaki kelime, rakam ve karakter sayısını bulma");
        Console.Write("Yazı: ");
        string yazi4 = Console.ReadLine();
        int kelimeSayisi = yazi4.Split(' ').Length;
        int rakamSayisi = yazi4.Count(c => char.IsDigit(c));
        int karakterSayisi = yazi4.Length;
        Console.WriteLine($"Kelime Sayısı: {kelimeSayisi}");
        Console.WriteLine($"Rakam Sayısı: {rakamSayisi}");
        Console.WriteLine($"Karakter Sayısı: {karakterSayisi}");
        Console.WriteLine();

        // Girilen yazıdaki aranan kelimenin önüne ve arkasına TIRNAK sembolünü ekleme
        Console.WriteLine("9. Girilen yazıdaki aranan kelimenin önüne ve arkasına TIRNAK sembolünü ekleme");
        Console.Write("Yazı: ");
        string yazi5 = Console.ReadLine();
        Console.Write("Aranan Kelime: ");
        string arananKelime = Console.ReadLine();
        string[] kelimeler = yazi5.Split(' ');
        string yazi5Sonuc = string.Join(" ", kelimeler.Select(kelime => kelime == arananKelime ? $"\"{kelime}\"" : kelime));
        Console.WriteLine(yazi5Sonuc);
        Console.WriteLine();

        // Girilen yazıdaki bir karakteri silme
        Console.WriteLine("10. Girilen yazıdaki bir karakteri silme");
        Console.Write("Yazı: ");
        string yazi6 = Console.ReadLine();
        Console.Write("Silinecek Karakter: ");
        char silinen = Console.ReadLine()[0];
        string yazi6Sonuc = yazi6.Replace(silinen.ToString(), "");
        Console.WriteLine(yazi6Sonuc);
        Console.WriteLine();

        // Girilen yazıdaki bir kelimeyi silme
        Console.WriteLine("11. Girilen yazıdaki bir kelimeyi silme");
        Console.Write("Yazı: ");
        string yazi7 = Console.ReadLine();
        Console.Write("Silinecek Kelime: ");
        string silinenKelime = Console.ReadLine();
        string yazi7Sonuc = string.Join(" ", yazi7.Split(' ').Where(kelime => kelime != silinenKelime));
        Console.WriteLine(yazi7Sonuc);
        Console.WriteLine();

        // Girilen yazıdaki noktalama işaretlerini silme
        Console.WriteLine("12. Girilen yazıdaki noktalama işaretlerini silme");
        Console.Write("Yazı: ");
        string yazi8 = Console.ReadLine();
        char[] noktalama = { '.', ',', ';', ':', '!', '?' };
        string yazi8Sonuc = new string(yazi8.Where(c => !noktalama.Contains(c)).ToArray());
        Console.WriteLine(yazi8Sonuc);
    }
}
