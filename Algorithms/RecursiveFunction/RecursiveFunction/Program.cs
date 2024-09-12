using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Fonksiyon 1
        Console.WriteLine("1. Fonksiyon 1");
        int Fun1(int x, int y)
        {
            if (x == 0)
                return y;
            else
                return Fun1(x - 1, x + y);
        }
        Console.WriteLine(Fun1(7, 4));
        Console.WriteLine("-----------------------------");

        // Fonksiyon 2
        Console.WriteLine("2. Fonksiyon 2");
        int Fun2(int n)
        {
            if (n == 1)
                return 0;
            else
                return 1 + Fun2(n / 2);
        }
        Console.WriteLine(Fun2(7));
        Console.WriteLine("-----------------------------");

        // Fonksiyon 3
        Console.WriteLine("3. Fonksiyon 3");
        void Fun3(int n)
        {
            if (n == 0)
                return;
            Fun3(n / 2);
            Console.Write(n % 2);
        }
        Fun3(11);
        Console.WriteLine();
        Console.WriteLine("-----------------------------");

        // Fonksiyon 4
        Console.WriteLine("4. Fonksiyon 4");
        void Fun4(int n)
        {
            if (n > 1)
                Fun4(n - 1);
            for (int i = 0; i < n; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Fun4(11);
        Console.WriteLine("-----------------------------");

        // Fonksiyon 5
        Console.WriteLine("5. Fonksiyon 5");
        int F(int n)
        {
            if (n <= 1)
                return 1;
            if (n % 2 == 0)
                return F(n / 2);
            else
                return F(n / 2) + F(n / 2 + 1);
        }
        Console.WriteLine(F(11));
        Console.WriteLine("-----------------------------");

        // EBOB Hesaplama
        Console.WriteLine("6. EBOB Hesaplama");
        int Ebob(int x, int y)
        {
            if (y == 0)
                return x;
            else
                return Ebob(y, x % y);
        }
        Console.WriteLine(Ebob(32, 24));
        Console.WriteLine("-----------------------------");

        // Fibonacci Hesaplama
        Console.WriteLine("7. Fibonacci Hesaplama");
        int Fibo(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            return Fibo(n - 1) + Fibo(n - 2);
        }
        Console.WriteLine(Fibo(7));
        Console.WriteLine("-----------------------------");

        // Faktöriyel Hesaplama
        Console.WriteLine("8. Faktöriyel Hesaplama");
        int Fak(int n)
        {
            if (n == 1)
                return 1;
            else
                return n * Fak(n - 1);
        }
        Console.WriteLine(Fak(5));
        Console.WriteLine("-----------------------------");

        // Üs Hesaplama
        Console.WriteLine("9. Üs Hesaplama");
        int Us(int x, int y)
        {
            if (y == 0)
                return 1;
            return x * Us(x, y - 1);
        }
        Console.WriteLine(Us(4, 3));
        Console.WriteLine("-----------------------------");

        // Dizi Elemanlarının Toplamı
        Console.WriteLine("10. Dizi Elemanlarının Toplamı");
        int ElemanToplam(List<int> liste, int index)
        {
            if (index == liste.Count - 1)
                return liste[index];
            return liste[index] + ElemanToplam(liste, index + 1);
        }
        Console.WriteLine(ElemanToplam(new List<int> { 1, 2, 3, 4, 5 }, 0));
        Console.WriteLine(ElemanToplam(new List<int> { 1, 2, 3, 4, 5 }, 4));
        Console.WriteLine("-----------------------------");

        // Dizinin Elemanlarını Tersine Çevirme
        Console.WriteLine("11. Dizinin Elemanlarını Tersine Çevirme");
        void TersCevirme(List<int> liste, int index)
        {
            if (index >= (liste.Count - 1) / 2)
                return;
            int temp = liste[index];
            liste[index] = liste[liste.Count - 1 - index];
            liste[liste.Count - 1 - index] = temp;
            TersCevirme(liste, index + 1);
        }
        List<int> liste = new List<int> { 1, 2, 3, 4, 5 };
        TersCevirme(liste, 0);
        Console.WriteLine("Ters çevrilmiş dizi: " + string.Join(", ", liste));
        Console.WriteLine("-----------------------------");

        // Elemanları Çarpanlarını Bulma
        Console.WriteLine("12. Elemanları Çarpanlarını Bulma");
        List<int> carpanListe = new List<int>();
        void Carpanlar(int n, int carpan)
        {
            if (n <= 1)
                return;
            if (n % carpan == 0)
            {
                carpanListe.Add(carpan);
                Carpanlar(n / carpan, carpan);
            }
            else
            {
                Carpanlar(n, carpan + 1);
            }
        }
        Carpanlar(24, 2);
        Console.WriteLine("Çarpanlar: " + string.Join(", ", carpanListe));
        Console.WriteLine("-----------------------------");

        // String Ters Çevirme
        Console.WriteLine("13. String Ters Çevirme");
        string ReverseString(string str)
        {
            List<char> charList = new List<char>(str.ToCharArray());
            void ReverseList(List<char> list, int index)
            {
                if (index >= list.Count / 2)
                    return;
                char temp = list[index];
                list[index] = list[list.Count - 1 - index];
                list[list.Count - 1 - index] = temp;
                ReverseList(list, index + 1);
            }
            ReverseList(charList, 0);
            return new string(charList.ToArray());
        }
        Console.WriteLine(ReverseString("Merhaba"));
        Console.WriteLine("-----------------------------");

        // Listede Elemanları Çıkarma ve Çarpma
        Console.WriteLine("14. Listede Elemanları Çıkarma ve Çarpma");
        List<int> ListeCarp(List<int> liste, List<int> liste2, int index)
        {
            if (index == liste.Count)
                return liste2;
            int carpim = 1;
            for (int i = 0; i < liste.Count; i++)
            {
                if (liste[index] != liste[i])
                {
                    carpim *= liste[i];
                }
            }
            liste2.Add(carpim);
            return ListeCarp(liste, liste2, index + 1);
        }
        Console.WriteLine("Çarpım Listesi: " + string.Join(", ", ListeCarp(new List<int> { 1, 2, 3, 4, 5 }, new List<int>(), 0)));
    }
}
