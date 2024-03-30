using System.Threading.Channels;

Console.WriteLine("Hello, World!");
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



