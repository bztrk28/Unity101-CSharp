//Console.WriteLine("Hello, World!");
//Console.WriteLine(256 + 365);
//Console.WriteLine(256 * 365);
//Console.WriteLine(256 - 365);
//Console.WriteLine(256.0 / 365.0);
//// 0.7013698630136986 ondalıklı sayı (double)

//// değişken veri oluşturma    veri tipi değişken_adı = değer

//// String : Metinsel değerleri tutan veri tipidir.
//string ad = "İbrahim Birkan ";
//string soyad = "Öztürk";

//Console.WriteLine(ad);
//Console.WriteLine(soyad);

//string tum_ad1 = ad + soyad;
//Console.WriteLine(tum_ad1);

//// int: Tam sayılara karşılık gelen veri tipidir.
//int sayi1 = 15;
//int sayi2 = 25;
//Console.WriteLine(sayi1);
//Console.WriteLine(sayi2);

//int sonuc = sayi1 * sayi2;
//Console.WriteLine(sonuc);


//// İki tane değişken oluşturup bu 2 değişkenin toplamını açıklayıcı şekilde yazınız.
//int number1 = 10;
//int number2 = 20;
//int total = number1 + number2;
//// 10 + 20 = 30
//// 1. yöntem
//Console.WriteLine(number1+" + "+number2+" = "+total);

////2. yöntem String Interpolation
//Console.WriteLine($"{number1} + {number2} = {total}");


//// İki tane değişken oluşturup bu 2 değişkenle 3 işlem yapan kodları yazınız.
//int diff = number1 - number2;
//int multiply = number1 * number2;

//Console.WriteLine($"{number1} ve {number2} nin çarpımı {multiply}");
//Console.WriteLine($"{number1} ve {number2} nin farkı {diff}");
//// $ işareti değişken gömeceğimizi gösterir.


//// konsoldan girdi alma

//// kullanıcıdan isim ve söyisim alarak ekrana çıktı verelim.

//Console.WriteLine("Lütfen adınızı yazınız : ");
//string name = Console.ReadLine();

//Console.WriteLine("Lütfen soyadınızı yazınız : ");
//string surname = Console.ReadLine();

//Console.WriteLine($"İsminiz : {name}, Soyisminiz : {surname}");

//// Kullanıcıdan isim, soyisim, yaş, okuduğu bölüm bilgisini alan ve ekrana çıktı veren kod

//Console.WriteLine("İsim: ");
//string isim = Console.ReadLine();

//Console.WriteLine("Soyisim: ");
//string soyisim = Console.ReadLine();

//Console.WriteLine("Yaş: ");
//int yas = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Okuduğunuz Bölüm: ");
//string bolum = Console.ReadLine();

//Console.WriteLine($"İsminiz : {isim}, Soyisminiz : {soyisim}, Yaşınız : {yas}, Bölümünüz: {bolum}");


//// double : Ondalıklı sayıları tutan veri tipidir.
//double ondalik1 = 20.75;
//double ondalik2 = 14.65;

//Console.WriteLine($"{ondalik1} ve {ondalik2}");



//// (int) kullanıcıdan 2 tane sayı alıp toplamını ve çarpımını hesaplayınız.

//Console.WriteLine("Lütfen 1. sayıyı giriniz.");
//int num1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Lütfen 2. sayıyı giriniz.");
//int num2 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"{num1} ve {num2} nin toplamı : {num1+num2}");

//Console.WriteLine($"{num1} ve {num2} nin çarpımı : {num1 * num2}");

////------------------------------------------------------------

//// Boolean : doğruluk ifadelerinde kullanılır.

//bool dogruluk1 = true;
//bool dogruluk2 = true;

//Console.WriteLine($"{dogruluk1} ve {dogruluk2}");

//// < küçük müdür
//// > büyük müdür
//// <= küçük eşit midir
//// >= büyük eşit midir
//// == eşit midir
//// != eşit değil midir

//bool dogruluk1 = 3<5;
//bool dogruluk2 = 3>5;

//Console.WriteLine($"{dogruluk1} ve {dogruluk2}");

////----------------------------------------------------------

//// if - else blokları
//// konsoldan kullanıcının yaşını aldıktan sonra 18 yaşından büyük ve eşitse ehliyet alabilir aksi taktirde ehliyet alamaz

//Console.WriteLine("Lütfen yaşınızı giriniz : ");

//int age = Convert.ToInt32(Console.ReadLine());

//if (age >= 18)
//{
//    Console.WriteLine("Ehliyet alabilirsiniz.");
//}
//else
//{
//    Console.WriteLine("Ehliyet alamazsınız.");
//}


//// kullanıcıdan bir tam sayı değeri aldığımızda bu sayının tek mi çift mi olduğunu ekrana yazdıran program

//Console.WriteLine("Lütfen bir sayı giriniz : ");
//int input1 = Convert.ToInt32(Console.ReadLine());
//// 10  10 sayısının 2'ye bölümünden kalan 0
//// 11  11 sayısının 2'ye bölümünden kalan 0
//// % ile mod alma işlemi yapılabilir

//if (input1 % 2 ==0)
//{
//    Console.WriteLine("Girdiğiniz sayı : Çift");
//}
//else
//{
//    Console.WriteLine("Girdiğiniz sayı : Tek");
//}



//// alınan puanlara göre harf notu belirleyen sistemi tasarlayın

//int puan = 65;

//if (puan >= 90)
//{
//    Console.WriteLine("Harf notunuz: A");
//}else if(puan >= 80)
//{
//    Console.WriteLine("Harf notunuz: B");
//}else if(puan >= 70)
//{
//    Console.WriteLine("Harf notunuz: C");
//}
//else
//{
//    Console.WriteLine("Harf notunuz: F");
//}


//// kullanıcıdan 1 ile 7 arasında sayılar alarak örneğin 2. gün Salı şeklinde ekrana çıktı veren kodu yazınız.

//Console.WriteLine("Lütfen 1 ile 7 arasında bir sayı giriniz : ");
//int day = Convert.ToInt32(Console.ReadLine());

//if (day == 1)
//{
//    Console.WriteLine("1. Gün Pazartesi");
//}else if(day == 2)
//{
//    Console.WriteLine("2. Gün Salı");
//}else if (day == 3)
//{
//    Console.WriteLine("3. Gün Çarşamba");
//}else if (day == 4)
//{
//    Console.WriteLine("4. Gün Perşembe");
//}else if (day == 5)
//{
//    Console.WriteLine("5. Gün Cuma");
//}else if (day == 6)
//{
//    Console.WriteLine("6. Gün Cumartesi");
//}else if (day == 7)
//{
//    Console.WriteLine("7. Gün Cumartesi");
//}
//else
//{
//    Console.WriteLine("Seçtiğiniz sayı 1 ile 7 arasında değildir");
//}


////-------------------------------------------------

//// switch - case
//// kullanıcıdan 1 den 12 ye kadar sayılar alalım bu sayıların örneğin
//// 1 --> ocak

//Console.WriteLine("Lütfen 1 den 12 ye kadar bir sayı giriniz : ");
//int ay = Convert.ToInt32(Console.ReadLine());

//switch (ay)
//{
//    case 1: Console.WriteLine("Ocak");
//        break;
//    case 2: Console.WriteLine("Şubat");
//        break;
//    case 3: Console.WriteLine("Mart");
//        break;
//    case 4: Console.WriteLine("Nisan");
//        break;
//    case 5: Console.WriteLine("Mayıs");
//        break;
//    case 6: Console.WriteLine("Haziran");
//        break;
//    case 7: Console.WriteLine("Temmuz");
//        break;
//    case 8: Console.WriteLine("Ağutos");
//        break;
//    case 9: Console.WriteLine("Eylül");
//        break;
//    case 10: Console.WriteLine("Ekim");
//        break;
//    case 11: Console.WriteLine("Kasım");
//        break;
//    case 12: Console.WriteLine("Aralık");
//        break;
//    default: Console.WriteLine("Doğru bir sayı girmediniz.");
//        break;
//}


//// 2. yöntem
//// expression yöntemi ile switch case

//Console.WriteLine("Lütfen 1 den 12 ye kadar bir sayı giriniz : ");
//int ay = Convert.ToInt32(Console.ReadLine());

//string ayIsmi = ay switch
//{
//    1 => "Ocak",
//    2 => "Şubat",
//    3 => "Mart",
//    4 => "Nisan",
//    5 => "Mayıs",
//    6 => "Haziran",
//    7 => "Temmuz",
//    8 => "Ağustos",
//    9 => "Eylül",
//    10 => "Ekim",
//    11 => "Kasım",
//    12 => "Aralık",
//    _ => "Yanlış aralıkta bir sayı girdiniz.",
//};
//Console.WriteLine(ayIsmi);



//// mevsimleri sınıflandıran kodu yazınız. (if else)
//// sesli sessiz harf ayıran kodu yazınız (switch 1, switch 2)

//// mevsimleri sınıflandırma

//Console.Write("1 den 12 ye kadar bir sayı girin: ");
//int ay = Convert.ToInt32(Console.ReadLine());

//string mevsim;
//if (ay >= 1 && ay <= 12)
//{
//    if (ay >= 3 && ay <= 5)
//    {
//        mevsim = "İlkbahar";
//    }
//    else if (ay >= 6 && ay <= 8)
//    {
//        mevsim = "Yaz";
//    }
//    else if (ay >= 9 && ay <= 11)
//    {
//        mevsim = "Sonbahar";
//    }
//    else
//    {
//        mevsim = "Kış";
//    }

//    Console.WriteLine($"Girdiğiniz ayın mevsimi: {mevsim}");
//}
//else
//{
//    Console.WriteLine("Verilen aralıkta olmayan bir sayı girdiniz!");
//}


// sesli sessiz harf ayırma

Console.WriteLine("Bir harf girin: ");
char harf = Convert.ToChar(Console.ReadLine());

string sonuc;
switch (harf)
{
    case 'a':
    case 'e':
    case 'ı':
    case 'i':
    case 'o':
    case 'ö':
    case 'u':
    case 'ü':
        sonuc = "sesli harf";
        break;
    default:
        sonuc = "sessiz harf";
        break;
}

Console.WriteLine($"Girdiğiniz harf {sonuc}.");

// ders bitimi

//-----------------------------------------

// 2. Ders Başlangıcı


