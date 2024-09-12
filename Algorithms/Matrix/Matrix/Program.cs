using System;

class Program
{
    static void Main()
    {
        // MxN boyutlu sıfır matris oluşturma
        Console.WriteLine("1. MxN boyutlu sıfır matris oluşturma");
        int m1 = 4;
        int n1 = 5;
        int[,] zeroMatrix = new int[m1, n1];

        for (int i = 0; i < m1; i++)
        {
            for (int j = 0; j < n1; j++)
            {
                Console.Write(zeroMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        // İki matrisin toplamını bulma
        Console.WriteLine("2. İki matrisin toplamını bulma");
        Random rand1 = new Random();
        int[,] matrixA = new int[m1, n1];
        int[,] matrixB = new int[m1, n1];

        for (int i = 0; i < m1; i++)
        {
            for (int j = 0; j < n1; j++)
            {
                matrixA[i, j] = rand1.Next(10);
                matrixB[i, j] = rand1.Next(10);
            }
        }

        int[,] sumMatrix = new int[m1, n1];
        for (int i = 0; i < m1; i++)
        {
            for (int j = 0; j < n1; j++)
            {
                sumMatrix[i, j] = matrixA[i, j] + matrixB[i, j];
            }
        }

        for (int i = 0; i < m1; i++)
        {
            for (int j = 0; j < n1; j++)
            {
                Console.Write(sumMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        // Matrisin satır ve sütun toplamlarını hesaplama
        Console.WriteLine("3. Matrisin satır ve sütun toplamlarını hesaplama");
        int[,] matrixC = new int[m1, n1];

        for (int i = 0; i < m1; i++)
        {
            for (int j = 0; j < n1; j++)
            {
                matrixC[i, j] = rand1.Next(10);
            }
        }

        // Satır toplamları
        for (int i = 0; i < m1; i++)
        {
            int rowSum = 0;
            for (int j = 0; j < n1; j++)
            {
                rowSum += matrixC[i, j];
            }
            Console.WriteLine("Satır " + i + " Toplamı: " + rowSum);
        }

        // Sütun toplamları
        for (int j = 0; j < n1; j++)
        {
            int colSum = 0;
            for (int i = 0; i < m1; i++)
            {
                colSum += matrixC[i, j];
            }
            Console.WriteLine("Sütun " + j + " Toplamı: " + colSum);
        }
        Console.WriteLine();

        // Matristeki en büyük sayıyı bulma
        Console.WriteLine("4. Matristeki en büyük sayıyı bulma");
        int[,] matrixD = new int[m1, n1];

        for (int i = 0; i < m1; i++)
        {
            for (int j = 0; j < n1; j++)
            {
                matrixD[i, j] = rand1.Next(100);
            }
        }

        int maxVal = matrixD[0, 0];
        for (int i = 0; i < m1; i++)
        {
            for (int j = 0; j < n1; j++)
            {
                if (matrixD[i, j] > maxVal)
                {
                    maxVal = matrixD[i, j];
                }
            }
        }
        Console.WriteLine("En Büyük Sayı: " + maxVal);
        Console.WriteLine();

        // Matris izini (diyagonal toplam) bulma
        Console.WriteLine("5. Matris izini (diyagonal toplam) bulma");
        int m2 = 5;
        int n2 = 5;
        int[,] matrixE = new int[m2, n2];

        for (int i = 0; i < m2; i++)
        {
            for (int j = 0; j < n2; j++)
            {
                matrixE[i, j] = rand1.Next(10);
            }
        }

        int diagonalSum = 0;
        for (int i = 0; i < m2; i++)
        {
            diagonalSum += matrixE[i, i];
        }

        for (int i = 0; i < m2; i++)
        {
            for (int j = 0; j < n2; j++)
            {
                Console.Write(matrixE[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Diyagonal Toplam: " + diagonalSum);
        Console.WriteLine();

        // Verilen sayıyı matrisin k. indeksine yerleştirme
        Console.WriteLine("6. Verilen sayıyı matrisin k. indeksine yerleştirme");
        Console.Write("Sayı: ");
        int sayi = int.Parse(Console.ReadLine());
        Console.Write("k: ");
        int k = int.Parse(Console.ReadLine());

        int[,] matrixF = new int[m1, m1];
        for (int i = 0; i < m1; i++)
        {
            for (int j = 0; j < m1; j++)
            {
                matrixF[i, j] = rand1.Next(100);
            }
        }

        int index = 0;
        for (int i = 0; i < m1; i++)
        {
            for (int j = 0; j < m1; j++)
            {
                if (index == k)
                {
                    matrixF[i, j] = sayi;
                    break;
                }
                index++;
            }
        }

        for (int i = 0; i < m1; i++)
        {
            for (int j = 0; j < m1; j++)
            {
                Console.Write(matrixF[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        // Matrisin transpozunu alma
        Console.WriteLine("7. Matrisin transpozunu alma");
        int[,] matrixG = new int[m1, n1];
        for (int i = 0; i < m1; i++)
        {
            for (int j = 0; j < n1; j++)
            {
                matrixG[i, j] = rand1.Next(10);
            }
        }

        Console.WriteLine("Orijinal Matris:");
        for (int i = 0; i < m1; i++)
        {
            for (int j = 0; j < n1; j++)
            {
                Console.Write(matrixG[i, j] + " ");
            }
            Console.WriteLine();
        }

        int[,] transposeMatrix = new int[n1, m1];
        for (int i = 0; i < m1; i++)
        {
            for (int j = 0; j < n1; j++)
            {
                transposeMatrix[j, i] = matrixG[i, j];
            }
        }

        Console.WriteLine("Transpoze Matris:");
        for (int i = 0; i < n1; i++)
        {
            for (int j = 0; j < m1; j++)
            {
                Console.Write(transposeMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        // İki matrisin çarpımını hesaplama
        Console.WriteLine("8. İki matrisin çarpımını hesaplama");
        int[,] matrixH = new int[m1, n1];
        int[,] matrixI = new int[m1, n1];

        for (int i = 0; i < m1; i++)
        {
            for (int j = 0; j < n1; j++)
            {
                matrixH[i, j] = rand1.Next(10);
                matrixI[i, j] = rand1.Next(10);
            }
        }

        int[,] productMatrix = new int[m1, n1];
        for (int i = 0; i < m1; i++)
        {
            for (int j = 0; j < n1; j++)
            {
                productMatrix[i, j] = matrixH[i, j] * matrixI[i, j];
            }
        }

        for (int i = 0; i < m1; i++)
        {
            for (int j = 0; j < n1; j++)
            {
                Console.Write(productMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();



    }
}
