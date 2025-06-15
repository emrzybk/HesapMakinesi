using System;

namespace HesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci sayıyı girin:");
            double sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("İkinci sayıyı girin:");
            double sayi2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("İşlemi seçin (+, -, *, /):");
            string islem = Console.ReadLine();

            double sonuc = 0;
            bool hata = false;

            switch (islem)
            {
                case "+":
                    sonuc = sayi1 + sayi2;
                    break;
                case "-":
                    sonuc = sayi1 - sayi2;
                    break;
                case "*":
                    sonuc = sayi1 * sayi2;
                    break;
                case "/":
                    if (sayi2 != 0)
                        sonuc = sayi1 / sayi2;
                    else
                    {
                        Console.WriteLine("Sıfıra bölme hatası!");
                        hata = true;
                    }
                    break;
                default:
                    Console.WriteLine("Geçersiz işlem.");
                    hata = true;
                    break;
            }

            if (!hata)
                Console.WriteLine("Sonuç: " + sonuc);

            Console.WriteLine("Program bitti. Çıkmak için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}
