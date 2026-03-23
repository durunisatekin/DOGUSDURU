/*
DİZİ OLUŞTURMA VE EKRANA YAZDIRMA ÖRNEKLERİ

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
*/

/*
KULLANICIDAN VERİ ALARAK DİZİ OLUŞTURMA VE EKRANA YAZDIRMA ÖRNEKLERİ
using System;

class Program
{
    static void Main()
    {
        Console.Write("oluşturmak istediğiniz dizinin eleman sayısı kaçtır? ");
        int elemanSayisi = Convert.ToInt32(Console.ReadLine());

        int[] dizi = new int[elemanSayisi];

        for(int i = 0 ; i<elemanSayisi; i++)
        {
            Console.Write($"dizinin{i + 1}. elemanını girin ");
            dizi[i] = Convert.ToInt32(Console.ReadLine());
        }

        //diziyi ekrana yazdırma 
        Console.WriteLine("\nDizi elemanları");
        for(int i= 0 ; i<elemanSayisi; i++)
        {
            Console.Write(dizi[i] + " ");
        }
    }
}
*/


/*
DİZİNİN EN BÜYÜK VE EN KÜÇÜK ELEMANINI BULMA ÖRNEKLERİ 

using System;

class Program
{
    static void Main()
    {
        int[] sayilar = { 15, 42, 7, 67, 24, 58 };

        int enKucuk = sayilar[0];
        int enBuyuk = sayilar[0];

        for (int i = 0; i < sayilar.Length; i++)
        {
            if (sayilar[i] < enKucuk)
                enKucuk = sayilar[i];

            if (sayilar[i] > enBuyuk)
                enBuyuk = sayilar[i];
        }

        Console.WriteLine($"en küçük sayı : {enKucuk}");
        Console.WriteLine($"en büyük sayı : {enBuyuk}");
    }
}


*/




