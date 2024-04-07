namespace OOP_Uygulama1.Models;

public class Model
{
    public int Id { get; set; }

    public DateTime CreatedTime { get; set; }

    public string Name { get; set; }

    public short Year { get; set; }

    public override string ToString()
    {
        return $"Id : {Id}, Oluşturma Tarihi : {CreatedTime}, Adı : {Name}, Yıl : {Year}";
    }
}
