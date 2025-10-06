namespace LinqPratik
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            // Rastgele 10 adet sayıdan oluşan liste (-20 ile 30 arasında)
            List<int> sayilar = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                sayilar.Add(rnd.Next(-20, 31));
            }

            Console.WriteLine("Rastgele Sayılar: " + string.Join(", ", sayilar));
            Console.WriteLine("--------------------------------------------------");

            // 1. Çift olan sayılar
            var ciftSayilar = sayilar.Where(x => x % 2 == 0);
            Console.WriteLine("Çift Sayılar: " + string.Join(", ", ciftSayilar));

            // 2. Tek olan sayılar
            var tekSayilar = sayilar.Where(x => x % 2 != 0);
            Console.WriteLine("Tek Sayılar: " + string.Join(", ", tekSayilar));

            // 3. Negatif sayılar
            var negatifSayilar = sayilar.Where(x => x < 0);
            Console.WriteLine("Negatif Sayılar: " + string.Join(", ", negatifSayilar));

            // 4. Pozitif sayılar
            var pozitifSayilar = sayilar.Where(x => x > 0);
            Console.WriteLine("Pozitif Sayılar: " + string.Join(", ", pozitifSayilar));

            // 5. 15'ten büyük ve 22'den küçük sayılar
            var aralikSayilar = sayilar.Where(x => x > 15 && x < 22);
            Console.WriteLine("15'ten büyük ve 22'den küçük sayılar: " + string.Join(", ", aralikSayilar));

            // 6. Listedeki her bir sayının karesi
            var kareler = sayilar.Select(x => x * x);
            Console.WriteLine("Sayıların Kareleri: " + string.Join(", ", kareler));

            Console.ReadLine();
        }
    }
}
