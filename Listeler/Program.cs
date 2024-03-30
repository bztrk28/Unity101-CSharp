using System.Threading.Channels;

//Console.WriteLine("Hello, World!");
// Listeler dinamik bir yapıdır veri ekleyip çıkarabiliyoruz.

// Jenerik argüman
//var sayilar = new List<int>();
//List<int> sayilar = new();

List<int> sayilar = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9};
List<string> ulkeler = new List<string>() { "Türkiye", "Almanya", "İngiltere", "Amerika", "Fransa", "Kanada" };

// ülkeler listesindeki tüm elemanları ekrana yazdıran kodu yazınız.

//foreach (string ulke in ulkeler)
//{
//    Console.WriteLine(ulke);
//}

// 2. yöntem
//ulkeler.ForEach(ulke=> Console.WriteLine(ulke));

// sayılar listesine 2 tane daha eleman ekleyiniz(10,11,12,13)

sayilar.Add(10);
sayilar.Add(11);
sayilar.Add(12);
sayilar.Add(13);

//sayilar.ForEach(say => Console.WriteLine(say));

// sayilar listesinde bütün elemanları tek tek dolaşıp
// çift sayıları bir tane çift sayılar listesi oluşturup o listeye ekleyen
// tek sayıları bir tane tek sayılar listesi oluşturup o listeye ekleyen
// ve her iki listeyi listeleyen kodu yazınız.

List<int> tekSayilar = new List<int>();
List<int> ciftSayilar = new List<int>();


// 1. Yöntem

//foreach (int sayi in sayilar)
//{
//    if (sayi % 2 == 0)
//        ciftSayilar.Add(sayi);
//    else
//        tekSayilar.Add(sayi);
//}

//Console.WriteLine("Tek Sayılar:");
//foreach (int tekSayi in tekSayilar)
//{
//    Console.WriteLine(tekSayi);
//}

//Console.WriteLine("Çift Sayılar:");
//foreach (int ciftSayi in ciftSayilar)
//{
//    Console.WriteLine(ciftSayi);
//}


// 2. Yöntem ***********************

//tekSayilar = sayilar.FindAll(sayi => sayi%2!=0);
//ciftSayilar = sayilar.FindAll(sayi =>sayi%2==0);

//Console.WriteLine("Tek sayılar:");
//tekSayilar.ForEach(sayi => Console.WriteLine(sayi));

//Console.WriteLine("Çift sayılar:");
//ciftSayilar.ForEach(sayi => Console.WriteLine(sayi));


//List<int> numbers=new List<int>() {3,2,5,1,4,6,8,9,11,6 };
//ListeIslemleri(numbers);
//void ListeIslemleri(List<int> sayilar)
//{
//    Console.WriteLine($"Listedeki en büyük sayı : {sayilar.Max()}");
//    Console.WriteLine($"Listedeki en küçük sayı : {sayilar.Min()}");

//    sayilar.Sort();
//    Console.WriteLine("Artan şekilde sıralanmış liste : ");
//    sayilar.ForEach(s => Console.WriteLine(s));

//    Console.WriteLine("Azalan şekilde sıralanmış liste : ");
//    sayilar.Reverse();

//    sayilar.ForEach(s => Console.WriteLine(s));
//}




// ********************************************

// Dictionary (sözlük) key -> value *********

// Elma 25

Dictionary<string, double> manav = new Dictionary<string, double>();

//manav.Add("Elma", 25);
//manav.Add("Armut", 20);
//manav.Add("Kiraz", 55);

//Console.WriteLine(manav["Elma"]);

//foreach (var item in manav)
//{
//    Console.WriteLine($"Ürün adı : {item.Key}, Ürünün değeri : {item.Value}");
//}

// Konsoldan kullanıcıdan kaç tane ürün gireceğini alıp sonrasında
// manav sözlüğü içerisine o kadar ürün ekleyen
// ürünü ekledikten sonra her ürünün %20 kdv si eklenerek hesaplayan
// sonrasında tüm ürünleri ve kdvli fiyatı ekrana çıktı olarak veren kodu yazınız.


//Dictionary<string, double> manav = new Dictionary<string, double>();
//int urunSayisi;

//Console.Write("Kaç tane ürün gireceksiniz?: ");
//while (!int.TryParse(Console.ReadLine(), out urunSayisi) || urunSayisi <= 0)
//{
//    Console.WriteLine("Geçersiz giriş. Lütfen pozitif bir tamsayı girin.");
//    Console.Write("Kaç tane ürün gireceksiniz?: ");
//}

//for (int i = 0; i < urunSayisi; i++)
//{
//    Console.Write($"Ürün adı {i + 1}: ");
//    string urunAdi = Console.ReadLine();

//    double urunFiyati;
//    Console.Write($"Ürün fiyatı {i + 1}: ");
//    while (!double.TryParse(Console.ReadLine(), out urunFiyati) || urunFiyati <= 0)
//    {
//        Console.WriteLine("Geçersiz giriş. Lütfen pozitif bir sayı girin.");
//        Console.Write($"Ürün fiyatı {i + 1}: ");
//    }

//    manav.Add(urunAdi, urunFiyati);
//}

//Console.WriteLine("\nÜrünler ve KDV'li Fiyatları:");
//foreach (var urun in manav)
//{
//    double kdvliFiyat = urun.Value * 1.20; // %20 KDV ekleniyor
//    Console.WriteLine($"{urun.Key}: {urun.Value} TL - KDV'li Fiyat: {kdvliFiyat} TL");
//}


// Hocanın yaptığı

Console.WriteLine("Kaç adet ürün girmek istersiniz?");
int adet = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < adet; i++)
{
    Console.WriteLine($"{i+1}. ürün adını giriniz : ");
    string name = Console.ReadLine();

    Console.WriteLine($"{name} ürünün değerini giriniz : ");
    double price = Convert.ToDouble(Console.ReadLine());

    double kdvli = price * 1.20;

    manav.Add(name, kdvli);
}
foreach(var item in manav)
{
    Console.WriteLine($"Ürünün adı : {item.Key}, Ürünün değeri: {item.Value}");
}

