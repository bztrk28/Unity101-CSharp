Console.WriteLine("Hello, World!");

// Jenerik argüman
//var sayilar = new List<int>();
//List<int> sayilar = new();

List<int> sayilar = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9};
List<string> ulkeler = new List<string>() { "Türkiye", "Almanya", "İngiltere", "Amerika", "Fransa", "Kanada" };

// ülkeler listesindeki tüm elemanları ekrana yazdıran kodu yazınız.

foreach (string ulke in ulkeler)
{
    Console.WriteLine(ulke);
}


// Listeler dinamik bir yapıdır veri ekleyip çıkarabiliyoruz.
