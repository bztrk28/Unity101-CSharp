﻿
// Bir rent a car projesi yapmanız beklenmektedir.
// Araba ile alakalı nesneler üretip o nesneleri ekran çıktısı olarak veriniz.


using OOP_Giris;

//Console.WriteLine("Hello, World!");

Car car = new Car()
{
    fiyat = 2500000,
    markaAdi = "Mercedes",
    modelYili = 2022,
    motorHacim = 1500,
    renk = "Siyah",
    yakitTuru = "Benzin"
};

Console.WriteLine(car);


//Console.WriteLine($"Aracın markası : {car.markaAdi}, Model : {car.modelYili}, rengi : {car.renk}, fiyat : {car.fiyat}");


// 2. Yöntem
Car car1 = new Car();

car1.fiyat = 1500000;
car1.markaAdi = "BMW";
car1.modelYili = 2018;
car1.renk = "Beyaz";
car1.motorHacim = 2000;
car1.yakitTuru = "Dizel";

//Console.WriteLine($"Aracın markası : {car1.markaAdi}, Model : {car1.modelYili}, rengi : {car1.renk}, fiyat : {car1.fiyat}");

Console.WriteLine(car1);


Car car2 = new Car(2500,"Kırmızı",3000000,"Elektrik","Tesla",2023);
Console.WriteLine(car2);

Car car3 = new Car(renk:"Yeşil", fiyat:5000000,)