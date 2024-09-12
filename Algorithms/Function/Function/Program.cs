using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Faktöriyel Grafiği
        Console.WriteLine("1. Faktöriyel Grafiği");
        void PrintFactorial(List<int> numbers)
        {
            foreach (int num in numbers)
            {
                int factorial = 1;
                if (num == 0 || num == 1)
                {
                    factorial = 1;
                }
                else
                {
                    for (int i = 2; i <= num; i++)
                    {
                        factorial *= i;
                    }
                }
                Console.WriteLine($"{num}! = {factorial}");
            }
        }

        List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        PrintFactorial(numbers);
        Console.WriteLine();

        // İlk N Asal Sayısını Listeleme
        Console.WriteLine("2. İlk N Asal Sayısını Listeleme");
        Console.Write("N: ");
        int n = int.Parse(Console.ReadLine());
        List<int> primeNumbers = new List<int>();
        int currentNumber = 2;

        bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        while (primeNumbers.Count < n)
        {
            if (IsPrime(currentNumber))
            {
                primeNumbers.Add(currentNumber);
            }
            currentNumber++;
        }

        Console.WriteLine(string.Join(", ", primeNumbers));
        Console.WriteLine();

        // Girilen Sayının Kaç Faktöriyel Olduğunu Bulma
        Console.WriteLine("3. Girilen Sayının Kaç Faktöriyel Olduğunu Bulma");
        Console.Write("Sayı: ");
        int numberToCheck = int.Parse(Console.ReadLine());

        void CheckFactorial(int number)
        {
            int factorial = 1;
            bool isFactorial = false;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
                if (factorial == number)
                {
                    isFactorial = true;
                    Console.WriteLine($"{number} sayısı {i} faktöriyel.");
                    break;
                }
            }
            if (!isFactorial)
            {
                Console.WriteLine("Girdiğiniz sayı faktöriyel değildir.");
            }
        }

        CheckFactorial(numberToCheck);
        Console.WriteLine();

        // Listede En Fazla Tekrar Eden Elemanı Silme
        Console.WriteLine("4. Listede En Fazla Tekrar Eden Elemanı Silme");
        List<int> list = new List<int> { 1, 9, 2, 4, 3, 8, 5, 7, 2, 4, 3, 4, 5, 6, 7, 8, 9 };

        List<int> RemoveMostFrequentElement(List<int> list)
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();
            foreach (int item in list)
            {
                if (counts.ContainsKey(item))
                {
                    counts[item]++;
                }
                else
                {
                    counts[item] = 1;
                }
            }

            int mostFrequentElement = -1;
            int maxCount = 0;
            foreach (var pair in counts)
            {
                if (pair.Value > maxCount)
                {
                    mostFrequentElement = pair.Key;
                    maxCount = pair.Value;
                }
            }

            List<int> resultList = new List<int>(list);
            resultList.RemoveAll(x => x == mostFrequentElement);
            Console.WriteLine($"En Çok Tekrar Eden Sayı: {mostFrequentElement}, Tekrarı: {maxCount}");

            return resultList;
        }

        List<int> newList = RemoveMostFrequentElement(list);
        Console.WriteLine("Güncellenmiş Liste: " + string.Join(", ", newList));
        Console.WriteLine();

        // Girilen Sayının Güçlü Olup Olmadığını Bulma
        Console.WriteLine("5. Girilen Sayının Güçlü Olup Olmadığını Bulma");
        bool IsStrongNumber(int number)
        {
            int sum = 0;
            foreach (char digit in number.ToString())
            {
                int digitValue = int.Parse(digit.ToString());
                int factorial = 1;
                for (int i = 1; i <= digitValue; i++)
                {
                    factorial *= i;
                }
                sum += factorial;
            }
            return sum == number;
        }

        Console.Write("Sayı: ");
        int strongNumberCandidate = int.Parse(Console.ReadLine());
        bool isStrong = IsStrongNumber(strongNumberCandidate);
        Console.WriteLine(isStrong ? $"{strongNumberCandidate} güçlü bir sayıdır." : $"{strongNumberCandidate} güçlü bir sayı değildir.");
    }
}
