using System;

class Program
{
    static void Main()
    {
        // Kullanıcıdan ilk sayıyı al
        Console.Write("Birinci sayıyı girin: ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());

        // Kullanıcıdan ikinci sayıyı al
        Console.Write("İkinci sayıyı girin: ");
        double sayi2 = Convert.ToDouble(Console.ReadLine());

        // İki sayının toplamını hesapla
        double toplam = sayi1 + sayi2;

        // Sonucu ekrana yazdır
        Console.WriteLine("Toplam: " + toplam);
    }
}
