// Bir e ticaret uygulamasında ürün oluşturulurken ürünün bazı özellikleri var
// ürünün adı: Ürün adı minimum 2 karakterli olmalıdır
// Ürünün değeri: ürünün değeri negatif değerler alamaz
// 2-) Ürünün değerini kullnıcı girdikten sonra kdvli fiyatını müşteriye gösteriniz.

// Ürünün stok değeri: negatif değer alamaz
// ürünün satıcısı: ürün satıcısı alanı minimum 2 karakterli olmalıdır.
// ürünün kategorisi: ürün kategorisi alanı minimum 2 karakterli olmalıdır.

using Properties;

Product product = new Product()
{
    Name = "MSI GF",
    CategoryName = "Laptop",
    Owner = "MSI",
    Price = 18000,
    Stock = 150
    
};


Console.WriteLine(product);
