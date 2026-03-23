using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bir pozitif sayı giriniz:");
        int sayi = Convert.ToInt32(Console.ReadLine());

        int kalan = sayi % 7 ;
        Console.WriteLine("girilen sayının 7 ile bölümünden kalan:" + kalan);
    }
}