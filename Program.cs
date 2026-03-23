using System;
namespace dizi_uygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[5];
            sayilar[0] = 1;
            sayilar[1] = 2;
            sayilar[2] = 3;
            sayilar[3] = 4;
            sayilar[4] = 5;

            //Diziyi yazdırmak için bir for döngüsü kullanılır.
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine($"sayilar[{i}] = {sayilar[i]}");
            }
        }
    }
}




