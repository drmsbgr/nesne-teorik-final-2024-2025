namespace ExamLib;

public interface IPerson
{
    double Percentage { get; }
}

public class Student : IPerson
{
    public double Percentage => 40;
}
public class Officer : IPerson
{
    public double Percentage => 20;
}
public class Instructor : IPerson
{
    public double Percentage => 10;
}

public class Cafeteria
{
    //metodun dönüş tipi ve gövdesi ile ilgili bilgi verilmemiş
    public void ProcessPayment(IPerson person, double baseMealCost)
    {
        var finaleCost = baseMealCost * (100 - person.Percentage) / 100.0;
        Console.WriteLine($"İndirimli fiyat: {finaleCost}");
    }
}