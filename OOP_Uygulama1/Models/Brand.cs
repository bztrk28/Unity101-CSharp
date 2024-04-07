namespace OOP_Uygulama1.Models;

public class Brand
{
    public int Id { get; set; }

    public DateTime CreatedTime { get; set; }

    public string Name { get; set; }

    public override string ToString()
    {
        return $"Brand[ Id : {Id}, Oluşturma Tarihi : {CreatedTime}, Adı : {Name}]";
    }
}
