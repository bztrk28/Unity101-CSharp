Console.WriteLine("Hello, World!");

// diziler birden fazla veriyi tutan bir yapıdır.
// sayılar dizisi

int[] sayilar = {1, 2, 3, 4, 5 };
string[] sehirler = {"İstanbul","İzmir", "Çanakkale", "Tekirdağ"};

// sehirler dizisinden Tekirdağ verisini ekrana bastıran kodu yazınız.

//Console.WriteLine(sehirler[3]);

// sayılar listesinde 3. indexteki veriyi ekrana bastıran kodu yazınız.

//Console.WriteLine(sayilar[3]);

// her iki dizinin eleman sayısını ekrana bastıran kodu yazınız.

int sayilarCount = sayilar.Length;
int sehirlerCount = sehirler.Length;

//Console.WriteLine($"sayılar dizisinin eleman sayısı : {sayilarCount}");
//Console.WriteLine($"şehirler dizisinin eleman sayısı : {sehirlerCount}");

// şehirler dizisindeki her elemanı ekrana yazdıran kodu yazınız.
// for döngüsü

//for (int i = 0; i<sehirlerCount; i++)
//{
//    Console.WriteLine(sehirler[i]);
//}


// foreach yöntemi

//foreach (string sehir in sehirler)
//{
//    Console.WriteLine(sehir);
//}


// while yöntemi

//int i = 0;
//while (i < sehirlerCount)
//{
//    Console.WriteLine(sehirler[i]);
//    i++;
//}


// sehirler dizisindeki elemanları sıralayan kodu yazınız.

//Array.Sort(sehirler);

//foreach (string sehir in sehirler)
//{
//    Console.WriteLine(sehir);
//}



// sayılar dizisindeki en büyük ve en küçük sayıyı bulan kodları yazınız.

//int min = sayilar.Min();
//int max = sayilar.Max();

//Console.WriteLine("sayılar dizisinin en küçük değeri: "+min);
//Console.WriteLine("sayılar dizisinin en büyük değeri: " + max);



// TersYazdir(sayilar);

// Verilen diziyi tersten okuyan bir fonksiyon yazınız.

//void TersYazdir(int[] dizi)
//{
//    Array.Reverse(dizi);
//    foreach (int d in dizi)
//    {
//        Console.WriteLine(d);
//    }
//}


