namespace ExamLib;

public abstract class User
{
    public virtual void LogIn()
    {
        Console.WriteLine("Giriş yapıldı.");
    }
}

public class Guest : User { }

public class Editor : User
{
    public override void LogIn()
    {
        base.LogIn();
        Console.WriteLine("editör yetkisi verildi.");
    }
}
public class Admin : User
{
    public override void LogIn()
    {
        Console.WriteLine("yönetici paneline yönlendirildi.");
    }
}