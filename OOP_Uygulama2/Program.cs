// Kütüphane otomasyonu sisteminde 
// kitap, yazar, ve kategori tablolarıyla ilişki kuran ve gerekli crud(Oluşturma, Okuma, Güncelleme, Silme) 

// Kitap -> Id, Title, AuthorId, CategoryId, Price, Stock, Renk
// Author -> Id, Name, Surname
// Category -> Id, Name

using OOP_Uygulama2.Models;

Author author = new Author(1, "Ömer", "Seyfettin");
Category category = new Category(1, "Türk Klasikleri");
Book book = new Book(1, "Kaşağı", 1, 1, 250, 300, "Siyah");

Console.WriteLine(author);
