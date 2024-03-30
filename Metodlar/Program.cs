Console.WriteLine("Hello, World!");

// Fonksiyon (Metod) Nedir: Yapacağımız işlemleri tekrar tekrar kullanma ihtiyacı duyduğumuz zaman
// kullandığımız soyutlama tekniğidir.

// Değer döndüren metodlar,
// Değer döndürmeyen metodlar


// Değer döndürmeyen metodlar: Herhangi bir değer bilgisi tutmayan, işi yaptıktan sonra kodu devam ettiren fonksiyonlardır.

// void fonksiyon_adı(parametre){}

// ekrana "Merhaba" yazdıran fonksiyonu yazınız.


// fonksiyon çağırıldı
//SayHello();
//SayHello();
//SayHello();
//SayHello();

//SayPersonInfo("İbrahim Birkan", "Öztürk", 22);
//SayPersonInfo(yas:22, soyad:"Öztürk", ad:"İbrahim Birkan");

//object A = SayHello();

int toplam = Topla(258, 524);
Console.WriteLine(Topla);
//Console.WriteLine(Topla(258, 524));
//Topla(258, 524);



// fonksiyon tanımlandı
void SayHello()
{
    Console.WriteLine("Merhaba");
}



// parametreli metod
// Fonksiyonda kullanıcının adı, soyadı, yaş bilgisi alındıktan
// sonra bilgilerini ekrana yazdıran kodu yazınız.

void SayPersonInfo(string ad, string soyad, int yas)
{
    Console.WriteLine($"Adınız : {ad} , Soyadınız : {soyad} , Yaşınız : {yas}");
}


// değer döndüren metodlar
// dönüş_tipi fonksiyon_adı(parametreler){
// return dönüş_tipinde_değer;
// }

// 2 sayının toplamını değer olarak döndüren fonksiyonu yazınız.

int Topla(int sayi1, int sayi2)
{
    return sayi1 + sayi2;
}

// F = m * a
double Kuvvet(double m, double a)
{
    return = m * a;
}


// Bir metod yazınız. Bu metodda kullanıcı bize vize ve final notlarını girsin
// not ortalamasını hesaplayıp döndüren kodu yazınız.
// vize = %40, final = %60



