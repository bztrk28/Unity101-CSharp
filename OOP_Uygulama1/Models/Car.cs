namespace OOP_Uygulama1.Models;

public class Car
{
    public int Id { get; set; }

    public DateTime CreatedTime { get; set; }

    public Brand Brand { get; set; }

    public Model Model { get; set; }

    public string ColorName { get; set; }

    public double DailyPrice { get; set; }

    public override string ToString()
    {
        return $"Car [Id : {Id}, OluşturmaTarihi : {CreatedTime}, \n" +
            $" {Brand}, \n" +
            $"{Model} \n " +
            $"Renk: {ColorName}, Günlük Fiyat: {DailyPrice} ]";

    }
}
