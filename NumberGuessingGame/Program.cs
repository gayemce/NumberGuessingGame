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
        }
    }
}