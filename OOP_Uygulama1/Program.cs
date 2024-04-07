// Bir Rent A Car projesi yapılması isteniyor.
// Bu projede 3 tane tablomuz olduğunu varsayalım.
// Car, Model, Brand tablolarımız var.
// Bu tablolar için bir veritabanının olduğunu varsayarak
// listeleme, ekleme, idye göre getirme, silme operasyonlarını simüle ediniz.

// Car -> Id, CreatedTime, Model, Brand, ColorName, DailyPrice
// Model -> Id, CreatedTime, Name, Year
// Brand -> Id, CreatedTime, Name

using OOP_Uygulama1.Models;

Model model = new Model()
{
    Id = 1,
    CreatedTime = DateTime.Now,
    Name = "M5",
    Year = 2022
};

Brand brand = new Brand()
{
    Id=1,
    CreatedTime= DateTime.Now,
    Name = "BMW"
};

Car car = new Car()
{
    Id=1,
    Brand = brand,
    Model = model,
    ColorName = "Kırmızı",
    CreatedTime = DateTime.Now,
    DailyPrice = 2500
};

Console.WriteLine(car);
