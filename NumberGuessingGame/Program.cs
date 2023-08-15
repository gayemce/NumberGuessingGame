namespace NumberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen İsminizi Girin: ");
            String name = Console.ReadLine();
            Console.WriteLine("Sayı Tahmini Oyununa Hoş Geldin " + name);

            Random rastgele = new();
            int sayi = rastgele.Next(1, 10);

            int tahmin = 0;

            while (sayi != tahmin)
            {
                Console.WriteLine(" - Lütfen 1-10 arasında bir sayı tahmin edin:");
                String tahminEdilenSayi = Console.ReadLine();

                //verilen değerin integer'a dönderilip dönderilemeyeceğini kontrol eder
                if (!int.TryParse(tahminEdilenSayi, out tahmin))//tryParse başarılıysa out tahminEdilenSayi değerini tahmin değişkenine atar (convert eder)
                {
                    Console.WriteLine(" * Sadece rakam girilebilir. *");
                    continue;
                }
                if (tahmin > 10)
                {
                    Console.WriteLine(" * Sadece 1-10 arası sayı girebilir. *");
                    continue;
                }

                Console.WriteLine("Tahmininiz: " + tahminEdilenSayi);

            }
        }
    }
}