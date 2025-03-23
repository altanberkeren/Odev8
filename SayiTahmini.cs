using System;

class Program
{
    static void Main(string[] args)
    {
        Random rastgele = new Random();
        int gizliSayi = rastgele.Next(1, 101); //1 ile 100 arasında sayı üretir
        int tahmin;
        int tahminSayisi = 0;

        Console.WriteLine("1 ile 100 arasinda bir sayi tuttum. Tahmin etmeye çaliş!");

        do
        {
            Console.Write("Tahmininiz: ");
            tahmin = Convert.ToInt32(Console.ReadLine());
            tahminSayisi++;

            if (tahmin < gizliSayi)
            {
                Console.WriteLine("Yukarı!");
            }
            else if (tahmin > gizliSayi)
            {
                Console.WriteLine("Aşağı!");
            }
            else
            {
                Console.WriteLine($"Doğru tahmin. Sayiniz : {gizliSayi}");
                Console.WriteLine($"Toplam {tahminSayisi} denemede sayinizı buldunuz.");
            }

        } while (tahmin != gizliSayi);
    }
}
